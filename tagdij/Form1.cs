using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;

namespace tagdij
{
    public partial class formTag : Form
    {
        MySqlConnection connection = null;
        MySqlCommand command = null;
        public formTag()
        {
            InitializeComponent();
        }

        private void Tag_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Clear();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "tagdij";
            sb.CharacterSet = "utf8";
            connection = new MySqlConnection(sb.ConnectionString);
            command = connection.CreateCommand();

            tagokBetoltese();
            numericUpDown_szulev.Maximum = DateTime.Now.Year;
            numericUpDown_szulev.Minimum = DateTime.Now.Year - 100;
            textBox_orsz.Text = "H";
            numericUpDown_szulev.Value = 2000;

        }

        private void tagokBetoltese()
        {
            listBoxTagok.Items.Clear();
            try
            {
                if (connection.State != ConnectionState.Open)                
                connection.Open();                           
                command.CommandText = "SELECT `azon`,`nev`,`szulev`,`irszam`,`orsz` FROM `ugyfel` WHERE 1 ORDER BY nev";
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Tag beolvasottTag = new Tag(dr.GetInt32("azon"),dr.GetString("nev"),dr.GetInt32("szulev"),dr.GetInt32("irszam"),dr.GetString("orsz"));
                        listBoxTagok.Items.Add(beolvasottTag);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        private void listBoxTagok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTagok.SelectedIndex<0)
            {
                return;
            }
            Tag kivalasztottTag = (Tag)listBoxTagok.SelectedItem; 
            textBox_azon.Text = kivalasztottTag.azon.ToString();
            textBox_nev.Text = kivalasztottTag.nev.ToString();
            numericUpDown_irszam.Value = (decimal)kivalasztottTag.irszam;
            numericUpDown_szulev.Value = (decimal)kivalasztottTag.szulev;
            textBox_orsz.Text = kivalasztottTag.orsz.ToString();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            int mostaniev = DateTime.Now.Year; ;
            //A beviteli mezőkben lévő adatok ellenörzése
            if (string.IsNullOrEmpty(textBox_nev.Text))
            {
                MessageBox.Show("Nincs név","Nope", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(textBox_orsz.Text))
            {
                MessageBox.Show("Nincs ország", "Nope", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (mostaniev - numericUpDown_szulev.Value < 18)
            {
                MessageBox.Show("18 év alatti nem regisztrálható!", "Nope", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // -- STB --
            string nev = textBox_nev.Text;
            decimal szulev = numericUpDown_szulev.Value;
            decimal irszam = numericUpDown_irszam.Value;
            string orsz = textBox_orsz.Text;
            command.CommandText = "INSERT INTO `ugyfel`(`azon`, `nev`, `szulev`, `irszam`, `orsz`) VALUES (null,@nev,@szulev,@irszam,@orsz)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev",nev);
            command.Parameters.AddWithValue("@szulev",szulev);
            command.Parameters.AddWithValue("@irszam",irszam);
            command.Parameters.AddWithValue("@orsz",orsz);
            try
            {
                if (connection.State != ConnectionState.Open)                
                connection.Open();                
                command.ExecuteNonQuery();
                MessageBox.Show("Sikeres rögzítés","Hozzáadva",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            textBox_nev.Text = "";
            numericUpDown_szulev.Value = numericUpDown_szulev.Minimum;
            numericUpDown_irszam.Value = numericUpDown_irszam.Minimum;
            textBox_orsz.Text = "H";
            tagokBetoltese();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string azon = textBox_azon.Text;
            string nev = textBox_nev.Text;
            decimal szulev = numericUpDown_szulev.Value;
            decimal irszam = numericUpDown_irszam.Value;
            string orsz = textBox_orsz.Text;
            command.CommandText = "UPDATE `ugyfel` SET `nev`=@nev,`szulev`=@szulev,`irszam`=@irszam,`orsz`=@orsz WHERE `azon`= @azon";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", nev);
            command.Parameters.AddWithValue("@szulev", szulev);
            command.Parameters.AddWithValue("@irszam", irszam);
            command.Parameters.AddWithValue("@orsz", orsz);
            command.Parameters.AddWithValue("@azon", azon);
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Sikeres módosítás", "Módosítva", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            tagokBetoltese();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string azon = textBox_azon.Text;
            string nev = textBox_nev.Text;
            decimal szulev = numericUpDown_szulev.Value;
            decimal irszam = numericUpDown_irszam.Value;
            string orsz = textBox_orsz.Text;
            command.CommandText = "DELETE FROM `ugyfel` WHERE `azon`= @azon";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@azon", azon);
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Sikeres törlés", "Törölve", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            tagokBetoltese();
        }

        private void textBox_nev_Click(object sender, EventArgs e)
        {
            textBox_nev.BackColor = Color.Silver;
        }

        private void textBox_nev_Leave(object sender, EventArgs e)
        {
            textBox_nev.BackColor= DefaultBackColor;
        }

        private void textBox_orsz_Leave(object sender, EventArgs e)
        {
            textBox_orsz.BackColor = DefaultBackColor;
        }

        private void textBox_orsz_Click(object sender, EventArgs e)
        {
            textBox_orsz.BackColor = Color.Silver;
        }

        private void numericUpDown_irszam_Click(object sender, EventArgs e)
        {
            numericUpDown_irszam.BackColor = Color.Silver;
        }

        private void numericUpDown_szulev_Click(object sender, EventArgs e)
        {
            numericUpDown_szulev.BackColor = Color.Silver;
        }

        private void numericUpDown_szulev_Leave(object sender, EventArgs e)
        {
            numericUpDown_szulev.BackColor = DefaultBackColor;
        }

        private void numericUpDown_irszam_Leave(object sender, EventArgs e)
        {
            numericUpDown_irszam.BackColor = DefaultBackColor;
        }
    }
}
