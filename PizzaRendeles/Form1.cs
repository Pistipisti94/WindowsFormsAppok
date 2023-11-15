using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaRendeles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string file = Directory.GetCurrentDirectory() + "//pizza.csv";
            using (StreamReader sr = new StreamReader(file))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    pizzaListaBox.Items.Add(new Pizza(sr.ReadLine()));
                }
            }
        }

        private void pizzaAtlagArGomb_Click(object sender, EventArgs e)
        {
            atlagSzamitas();
        }

        private void atlagSzamitas()
        {
            double atlag = 0;
            foreach (Pizza item in pizzaListaBox.Items)
            {
                atlag += item.PizzaAra;
            }
            atlag = atlag / pizzaListaBox.Items.Count;
            MessageBox.Show($"A Pizzák árának átlaga: {atlag.ToString()} forint.", "Átlagár", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pizzaListaBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {           
            MessageBox.Show($"Tétel:  Végösszeg:", "Véglegesítés",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
        }

        private void pizzaValasztas_Click(object sender, EventArgs e)
        {
            rendelesHozzaadas();
            int db = rendelesLista.Items.Count;
            pizzamennyiseg.Text = $"Rendelni kívánt pizzák száma: {db.ToString()}";

        }

        private void rendelesHozzaadas()
        {
                rendelesLista.Items.Add((Pizza)pizzaListaBox.SelectedItem);
        }

        private void szamlaIgeny_CheckedChanged(object sender, EventArgs e)
        {
            if (szamlaIgeny.Checked)
            {
                labelSzamla.Text = "Számlaigény: Van";
            }
            else
            {
                labelSzamla.Text = "Számlaigény: Nincs";
            }
        }

        private void kezpenz_MouseClick(object sender, MouseEventArgs e)
        {
            labelFizetes.Text = "Fizetés: Kézpénzzel";
        }

        private void kartya_Click(object sender, EventArgs e)
        {
            labelFizetes.Text = "Fizetés: Kártyával";
        }
    }
}
