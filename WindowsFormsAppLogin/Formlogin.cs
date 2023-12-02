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

namespace WindowsFormsAppLogin
{

    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void button_bejelentkezes_Click(object sender, EventArgs e)
        {
            string nev = textBox_nev.Text;
            string jelszo = textBox_jelszo.Text;
            //SELECT vasarlo.jelszo FROM `vasarlo` WHERE vasarlo.nev = "lajos"
            Program.command.CommandText = "SELECT vasarlo.jelszo FROM `vasarlo` WHERE vasarlo.nev = @nev";
            Program.command.Parameters.Clear();
            Program.command.Parameters.AddWithValue("@nev",nev);
            MySqlDataReader reader = Program.command.ExecuteReader();
            if (reader.Read())
            {
                string taroltjelszo = reader.GetString("jelszo");
                if (taroltjelszo.Equals(jelszo))
                {
                    reader.Close();
                    Program.formVasarlas.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hibás felhasználónév vagy jelszó","Hiba!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        private void button_regisztracio_Click(object sender, EventArgs e)
        {
            button_bejelentkezes.Visible = false;
            button_regisztracio.Visible = false;
            button_loginBack.Visible = true;
            button_regiOn.Visible = true;
            label3.Visible = true;
            textBox_jelszox.Visible = true;
        }

        private void vissza_bejelentkezes(object sender, EventArgs e)
        {
            button_bejelentkezes.Visible = true;
            button_regisztracio.Visible = true;
            button_loginBack.Visible = false;
            button_regiOn.Visible = false;
            label3.Visible = false;
            textBox_jelszox.Visible = false;
        }

        private void regisztralas(object sender, EventArgs e)
        {
            string nev = textBox_nev.Text;
            string jelszo = textBox_jelszo.Text;
            string jelszo2 = textBox_jelszox.Text;

            if (string.IsNullOrEmpty(nev))
            {
                MessageBox.Show("Nincs név", "Nope", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!jelszo.Equals(jelszo2))
            {
                MessageBox.Show("A két jelszó nem eggyezik!", "Nope", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // -- STB --
            Program.command.CommandText = "INSERT INTO `vasarlo`(`vasarloid`, `nev`, `jelszo`) VALUES (null,@nev,@jelszo)";
            Program.command.Parameters.Clear();
            Program.command.Parameters.AddWithValue("@nev", nev);
            Program.command.Parameters.AddWithValue("@jelszo", jelszo);

            try
            {
                if (Program.connection.State != ConnectionState.Open)
                    Program.connection.Open();
                Program.command.ExecuteNonQuery();
                MessageBox.Show("Sikeres rögzítés", "Hozzáadva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.formVasarlas.Show();
                this.Hide();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message,"Hibááááááááás.");
                return;
            }
        }
    }
}
