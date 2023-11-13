using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsAppok
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void gombBetoltes_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt fájl (*.txt)|*.txt|csv fájl (*.csv)|*.csv|Összes fájl (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.Title = "Adatfájl neve";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;

            if (openFileDialog1.ShowDialog(this)==DialogResult.OK)
            {
                forrasfajlneveinput.Text = openFileDialog1.FileName;
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        listBoxlista.Items.Add(new Orszag(sr.ReadLine()));
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            forrasfajlneveinput.Text = "orszagok";
        }

        private void ezbetolt_Click(object sender, EventArgs e)
        {
            if (forrasfajlneveinput.Text != "") { 
                string path = Environment.CurrentDirectory + "//";
                openFileDialog1.CheckFileExists = true;
                using (StreamReader sr = new StreamReader(path + forrasfajlneveinput.Text + ".csv"))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        listBoxlista.Items.Add(new Orszag(sr.ReadLine()));
                    }
                }
            }
            else
            {

            }
        }
    }
}
