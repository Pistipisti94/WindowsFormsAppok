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
    public partial class FormVasarlas : Form
    {
        public FormVasarlas()
        {
            InitializeComponent();             
        }

        private void button_rendeles_Click(object sender, EventArgs e)
        {

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
                }
            }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    Environment.Exit(0);
                
            }
        }
    }
}
