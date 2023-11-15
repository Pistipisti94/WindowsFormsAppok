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
            comboBoxvalasztas.SelectedIndex = 0;
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

        private void gombTeruletekAtlaga_Click(object sender, EventArgs e)
        {
            atlagszamitas();
        }

        private void atlagszamitas()
        {
            double atlag = 0;
            foreach (Orszag item in listBoxlista.Items)
            {
                atlag += item.Terulet;
            }
            atlag = atlag / listBoxlista.Items.Count;
            MessageBox.Show($"Az országok területének átlaga: {atlag.ToString("#,##0.00")}", "Az országok területének átlaga:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gombMegszamolas_Click(object sender, EventArgs e)
        {
            if (kevesebbmintszazezer.Checked)
            {
                szamolLegfeljebbSzazezer();
            }
            else
            {
                szamolSzazezernelNagyobb();
            }
        }

        private void szamolSzazezernelNagyobb()
        {
            
            int db = 0;
            foreach (Orszag item in listBoxlista.Items)
            {
                if (item.Terulet >= 100000)
                {
                    db++;
                }
            }
            MessageBox.Show($"Több mint 100.000 = {db}", "100.000-nél nagyobb területű országok száma:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            foreach (Orszag item in listBoxlista.Items)
            {
                if (item.Terulet <= 100000)
                {
                    listBoxlista.Items.Remove(item);
                }
            }

        }

        private void szamolLegfeljebbSzazezer()
        {
            int db = 0;
            foreach (Orszag item in listBoxlista.Items)
            {
                if (item.Terulet<=100000)
                {
                    db++;
                }
            }
            MessageBox.Show($"Maximum 100.000 = {db}","100.000-nél kisebb területű országok száma:",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
        }

        private void gombKiiras_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = ".txt típus|*.txt";
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.FileName = "eredmeny.txt";

            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                string eredmenyFile = saveFileDialog.FileName;
                eredmenyfajlneveinput.Text = Path.GetFileName(eredmenyFile);
                try
                {
                    using (StreamWriter sw = new StreamWriter(eredmenyFile))
                    {
                        sw.WriteLine("Ez az eredmény.");
                    }
                }
                catch (IOException ex)
                {

                    MessageBox.Show("Valami nem jó! " + Environment.NewLine + ex.Message,"Hiba!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void gombMinMaxKivalasztas_Click(object sender, EventArgs e)
        {
            //Listboxban vagy a legnagyobb vagy a legkisebb területű országot választja ki
            if (comboBoxvalasztas.SelectedIndex == 0)
            {
                Orszag keresettOrszag = null;
                double keresettErtek = ((Orszag)listBoxlista.Items[0]).Terulet;
                foreach (Orszag item in listBoxlista.Items)
                {
                    if (keresettErtek > item.Terulet)
                    {
                        keresettErtek = item.Terulet;
                        keresettOrszag = item;
                    }
                }
                MessageBox.Show($"A legkisebb területű ország neve: {keresettOrszag}, területe: {keresettErtek}");
            }
            else
            {
                Orszag keresettOrszag = null;
                double keresettErtek = ((Orszag)listBoxlista.Items[0]).Terulet;
                foreach (Orszag item in listBoxlista.Items)
                {
                    if (keresettErtek < item.Terulet)
                    {
                        keresettErtek = item.Terulet;
                        keresettOrszag = item;
                    }
                }
                MessageBox.Show($"A legnagyobb területű ország neve: {keresettOrszag}, területe: {keresettErtek}");
            }
        }

        private void gombKereses_Click(object sender, EventArgs e)
        {
            string keres = keresesInput.Text;
            string talalat = "";
            if (keresesInput.Text != "")
            {
                foreach (Orszag item in listBoxlista.Items)
                {
                    if (keres.Equals(item.OrszagNev))
                    {
                        talalat = item.OrszagNev;
                        break;
                    }
                    else
                    {
                        talalat = "Nincs ilyen ország";
                    }
                }
                MessageBox.Show(talalat, "Keresés szövege:", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Nincs keresésnek megadott szöveg!","Keresés szövege:",MessageBoxButtons.OK);
            }
            
        }

        private void betunkent(object sender, KeyEventArgs e)
        {
            MessageBox.Show(keresesInput.Text);
        }

        private void szinvaltoztatas(object sender, EventArgs e)
        {
            listBoxlista.BackColor = Color.Bisque;
        }

        private void szinvissza(object sender, MouseEventArgs e)
        {
        }

        private void listBoxlista_MouseLeave(object sender, EventArgs e)
        {
            listBoxlista.BackColor = DefaultBackColor;
        }
    }
}
