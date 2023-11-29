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
            
            string semmi = listBox_rendelttermek.Text;
            if (string.IsNullOrEmpty(semmi))
            {
                MessageBox.Show("Nincs termék a listában", "Nope", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // -- STB --
            Program.command.CommandText = "INSERT INTO `vasarlas`(`vasarloid`, `termekid`, `datum`, `rendelt_db`) VALUES (null,null,null,@db)";
            Program.command.Parameters.Clear();
            Program.command.Parameters.AddWithValue("@db", semmi);
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
        }

        private void termekekBetoltese()
        {
            
                listBox_termekek.Items.Clear();
            try
            {
                if (Program.connection.State != ConnectionState.Open)
                    Program.connection.Open();
                Program.command.CommandText = "SELECT `termeknev`,`ar`,`db` FROM `termek` WHERE 1 ORDER BY termeknev";

                using (MySqlDataReader dr = Program.command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Termekek beolvasottTermek = new Termekek(dr.GetString("termeknev"), dr.GetInt32("ar"), dr.GetInt32("db"));
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
            foreach (var item in listBox_rendelttermek)
            {
                
            }
            if (listBox_rendelttermek.Items[0] ==)
            {

            }
            listBox_rendelttermek.Items.Add(listBox_termekek.SelectedItem); 
        }

        private void button_listaelemtorles_Click(object sender, EventArgs e)
        {
            listBox_rendelttermek.Items.Remove(listBox_rendelttermek.SelectedIndex); // nem jó
        }

    }
}
