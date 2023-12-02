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
        int vid = 1;
        int tid = 1;
        public Formlogin login;
        public FormVasarlas()
        {
            InitializeComponent();             
        }

        private void button_rendeles_Click(object sender, EventArgs e)
        {
            termekRendelesLeadasa();
            //termekDarabFrissitese();
            termekekBetoltese();
            

        }

        private void termekDarabFrissitese()
        {
            throw new NotImplementedException();
        }

        private void termekRendelesLeadasa()
        {
            
            
            if (listBox_termekek.SelectedItem == null)
            {
                MessageBox.Show("Nincs termék kiválasztva", "Nope", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            int vasaroltaid = vid;
            int termekid = tid;
            string mennyiseg = numericUpDown_mennyiseg.Text;
            int ar = int.Parse(mennyiseg);
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
            Program.command.CommandText = "INSERT INTO `vasarlas` (`vasarloId`, `termekid`, `datum`, `vasaroltdb`, `osszeg`, `fizetesmod`) VALUES (@vasarolta, @termeket, current_timestamp(), @mennyit, @termekszorar, @mivel);";
            Program.command.Parameters.Clear();
            Program.command.Parameters.AddWithValue("@vasarolta",vasaroltaid );
            Program.command.Parameters.AddWithValue("@termeket",termekid );
            Program.command.Parameters.AddWithValue("@mennyit",mennyiseg );
            Program.command.Parameters.AddWithValue("@termekszorar", ar);
            Program.command.Parameters.AddWithValue("@mivel", fizetesmod);
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
                return;
            }
        }

        private void FormVasarlas_Load(object sender, EventArgs e)
        {
            termekekBetoltese();

            label1.Text = "Lajos";
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

    }
}
