using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppLogin
{
    public partial class FormVasarlas : Form
    {
        public Formlogin login;
        public FormVasarlas()
        {
            InitializeComponent();             
        }

        private void button_rendeles_Click(object sender, EventArgs e)
        {
            if (numericUpDown_mennyiseg.Value == 0)
            {
                MessageBox.Show("Elfogyott");
                return;
            }
            string szoveg = $"Valóban megszeretné vásárolni a {numericUpDown_mennyiseg.Value} darab {textBox_termeknev.Text} terméket, {(numericUpDown_mennyiseg.Value * numericUpDown_termekar.Value).ToString("#,##0")} forint értékben?";
            if (MessageBox.Show(szoveg,"Megerősítés",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                termekRendelesLeadasa();
                listBox_termekek.Items.Clear();
                termekekBetoltese();
            }
            else
            {
                return;
            }
           
            

        }
        private void termekRendelesLeadasa()
        {
            
            
            if (listBox_termekek.SelectedItem == null)
            {
                MessageBox.Show("Nincs termék kiválasztva", "Nope", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string fizetesmod = "";
            if (radioButton_card.Checked)
            {
                 fizetesmod = "kártya";
            }
            else
            {
                fizetesmod = "készpénz";
            }

            // -- STB --
            MySqlTransaction tr = null;
            try
            {
                tr = Program.connection.BeginTransaction();
                Program.command.Transaction = tr;
            Program.command.CommandText = "INSERT INTO `vasarlas` (`vasarloId`, `termekid`, `datum`, `vasaroltdb`, `osszeg`, `fizetesmod`) VALUES (@vasarolta, @termeket, current_timestamp(), @mennyit, @termekszorar, @mivel)";
            Program.command.Parameters.Clear();
            Program.command.Parameters.AddWithValue("@vasarolta", Program.userId);
            Program.command.Parameters.AddWithValue("@termeket",numericUpDown_termekid.Value);
            Program.command.Parameters.AddWithValue("@mennyit", numericUpDown_mennyiseg.Value);
            Program.command.Parameters.AddWithValue("@termekszorar", numericUpDown_mennyiseg.Value * numericUpDown_termekar.Value);
            Program.command.Parameters.AddWithValue("@mivel", fizetesmod);
            Program.command.ExecuteNonQuery();
            Program.command.CommandText = $"UPDATE `termek` SET `db`= ({numericUpDown_raktaron.Value- numericUpDown_mennyiseg.Value}) WHERE `termekid`= {numericUpDown_termekid.Value};";
                
                MessageBox.Show(Program.command.CommandText);
            
                Program.command.ExecuteNonQuery();
            tr.Commit();
            MessageBox.Show("Sikeres vásárlás!");
            }
            catch (MySqlException ex)
            {

                tr.Rollback();
                MessageBox.Show(ex.Message,"Tranzakció probléma");
            }
            try
            {
                if (Program.connection.State != ConnectionState.Open)
                    Program.connection.Open();
                Program.command.ExecuteNonQuery();
                MessageBox.Show("Sikeres rögzítés", "Hozzáadva", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Hibááááááááás.");
                MessageBox.Show(Program.command.CommandText);
                return;
            }

        }

        private void FormVasarlas_Load(object sender, EventArgs e)
        {
            termekekBetoltese();

            label1.Text = Program.userId.ToString();            
        }

        private void termekekBetoltese()
        {
            
                listBox_termekek.Items.Clear();
            try
            {
                if (Program.connection.State != ConnectionState.Open)
                    Program.connection.Open();
                Program.command.CommandText = "SELECT `termekid`,`termeknev`,`ar`,`db` FROM `termek` WHERE 1 ORDER BY termeknev";

                using (MySqlDataReader dr = Program.command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Termekek beolvasottTermek = new Termekek(dr.GetInt32("termekid"), dr.GetString("termeknev"), dr.GetInt32("ar"), dr.GetInt32("db"));
                        listBox_termekek.Items.Add(beolvasottTermek);
                        Termekek beolvasottTermek2 = new Termekek(dr.GetInt32("termekid"), dr.GetString("termeknev"), dr.GetInt32("ar"), dr.GetInt32("db"));
                        toolStripComboBox_termekek.Items.Add(beolvasottTermek2);
                        toolStripComboBox_termekek.SelectedIndex = 0;
                    }
                    dr.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        private void FormVasarlas_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Kilépés", "Kilépés", MessageBoxButtons.OK, MessageBoxIcon.Question)==DialogResult.OK)
            {
                Environment.Exit(1);
            }
        }

        private void button_hozzaad_Click(object sender, EventArgs e)
        {
        }

        private void button_listaelemtorles_Click(object sender, EventArgs e)
        {
        }

        private void listBox_termekek_SelectedIndexChanged(object sender, EventArgs e)
        {
            Termekek term = (Termekek)listBox_termekek.SelectedItem;
            textBox_termeknev.Text = term.termeknev;
            numericUpDown_termekid.Value = term.termekid;
            numericUpDown_termekar.Value = term.ar;
            numericUpDown_mennyiseg.Maximum = term.db;
            if (term.db > 0)
            {
                numericUpDown_raktaron.Value = term.db;
            }
            else
            {
                numericUpDown_raktaron.Value = 1;
                numericUpDown_mennyiseg.ReadOnly = true;
                numericUpDown_mennyiseg.Value = numericUpDown_mennyiseg.Minimum;
            }
            
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTermek formTermekUj = new FormTermek("Új");
            formTermekUj.ShowDialog();


        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTermek formTermekModosit = new FormTermek("Módosítás");
            formTermekModosit.ShowDialog();
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTermek formTermekTorol = new FormTermek("Törlés");
            formTermekTorol.ShowDialog();
        }
    }
}
