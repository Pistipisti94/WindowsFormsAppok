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
    public partial class FormTermek : Form
    {
        string muvelet = "";
        string uzenet = "";
        string mod = null;
        public FormTermek(string mod)
        {
            InitializeComponent();
            this.mod = mod;
        }

        private void FormTermek_Load(object sender, EventArgs e)
        {
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
                        comboBox1.Items.Add(beolvasottTermek);
                        comboBox1.SelectedIndex = 0;
                    }
                    dr.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }

            numericUpDown_crudid.ReadOnly = true;
            if (mod == "Új") 
            {
                comboBox1.Visible = false;
                button_gomb.Text = "Hozzáadás";
                numericUpDown_crudid.Visible = false;
                numericUpDown_crudar.Value = 0;
                textBox_crudnev.Text = "";
                numericUpDown_cruddb.Value = 1;
                numericUpDown_cruddb.Minimum = 1;
            }
            else if (mod == "Módosítás")
            {
                button_gomb.Text = "Módosítás";
            }
            else if (mod == "Törlés")
            {
                button_gomb.Text = "Törlés";
                numericUpDown_cruddb.ReadOnly = true;
                numericUpDown_crudar.ReadOnly = true;
                textBox_crudnev.ReadOnly = true;
            }
        }

        private void button_gomb_Click(object sender, EventArgs e)
        {
                if (numericUpDown_cruddb.Value == 0)
                {
                    MessageBox.Show("A darabszám nem lehet nulla", "Nope", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (textBox_crudnev.Text == "")
                {
                    MessageBox.Show("A terméknek kell egy név", "Nope", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (numericUpDown_crudar.Value == 0)
                {
                    MessageBox.Show("Ingyen semmit sem adunk hé! :O", "Nope", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }                
            try
            {
            if (button_gomb.Text == "Hozzáadás")
            {
                muvelet = $"INSERT INTO `termek`(`termekid`, `termeknev`, `ar`, `db`) VALUES (null,'{textBox_crudnev.Text}',{numericUpDown_crudar.Value},{numericUpDown_cruddb.Value})";
                uzenet = "Hozzáadva";
            }
            else if (button_gomb.Text == "Módosítás")
            {
                muvelet = $"UPDATE `termek` SET `termeknev`='{textBox_crudnev.Text}',`ar`={numericUpDown_crudar.Value},`db`={numericUpDown_cruddb.Value} WHERE `termekid` = {numericUpDown_crudid.Value}";
                    uzenet = "Módosítva";
            }
            else if (button_gomb.Text == "Törlés")
            {
                muvelet = $"DELETE FROM `termek` WHERE `termekid` = {numericUpDown_crudid.Value}";
                    uzenet = "Törölve";
            }
            Program.command.CommandText = muvelet;
            Program.command.Parameters.Clear();
            if (button_gomb.Text == "Hozzáadás")
            {
                MessageBox.Show("Hozzáadva");
            }
            else if (button_gomb.Text == "Módosítás")
            {
                MessageBox.Show("Módosítva");
            }
            else if (button_gomb.Text == "Törlés")
            {
                MessageBox.Show("Törölve");
            }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, uzenet+" Hiba");
                return;
            }

            try
            {
                if (Program.connection.State != ConnectionState.Open)
                    Program.connection.Open();
                Program.command.ExecuteNonQuery();
                MessageBox.Show("Sikeres rögzítés", uzenet, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.formVasarlas.Show();
                this.Hide();
                Program.formVasarlas.termekekBetoltese();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, uzenet+" Hiba");
                return;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Termekek term = (Termekek)comboBox1.SelectedItem;
            numericUpDown_crudid.Value = term.termekid;
            textBox_crudnev.Text = term.termeknev;
            numericUpDown_crudar.Value = term.ar;
            numericUpDown_cruddb.Value = term.db;
        }
    }
}
