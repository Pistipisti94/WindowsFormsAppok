namespace PizzaRendeles
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.szamlaIgeny = new System.Windows.Forms.CheckBox();
            this.fizetesLehetoseg = new System.Windows.Forms.GroupBox();
            this.kartya = new System.Windows.Forms.RadioButton();
            this.kezpenz = new System.Windows.Forms.RadioButton();
            this.pizzaAtlagArGomb = new System.Windows.Forms.Button();
            this.pizzaListaBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.rendelesLista = new System.Windows.Forms.ListBox();
            this.pizzaValasztas = new System.Windows.Forms.Button();
            this.pizzamennyiseg = new System.Windows.Forms.Label();
            this.labelFizetes = new System.Windows.Forms.Label();
            this.labelSzamla = new System.Windows.Forms.Label();
            this.mennyisegKivalasztasa = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.fizetesLehetoseg.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegKivalasztasa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.mennyisegKivalasztasa);
            this.panel1.Controls.Add(this.pizzaValasztas);
            this.panel1.Controls.Add(this.szamlaIgeny);
            this.panel1.Controls.Add(this.fizetesLehetoseg);
            this.panel1.Controls.Add(this.pizzaAtlagArGomb);
            this.panel1.Controls.Add(this.pizzaListaBox);
            this.panel1.Location = new System.Drawing.Point(12, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 240);
            this.panel1.TabIndex = 2;
            // 
            // szamlaIgeny
            // 
            this.szamlaIgeny.AutoSize = true;
            this.szamlaIgeny.Location = new System.Drawing.Point(204, 83);
            this.szamlaIgeny.Name = "szamlaIgeny";
            this.szamlaIgeny.Size = new System.Drawing.Size(93, 17);
            this.szamlaIgeny.TabIndex = 3;
            this.szamlaIgeny.Text = "Számlát kérek";
            this.szamlaIgeny.UseVisualStyleBackColor = true;
            this.szamlaIgeny.CheckedChanged += new System.EventHandler(this.szamlaIgeny_CheckedChanged);
            // 
            // fizetesLehetoseg
            // 
            this.fizetesLehetoseg.Controls.Add(this.kartya);
            this.fizetesLehetoseg.Controls.Add(this.kezpenz);
            this.fizetesLehetoseg.Location = new System.Drawing.Point(203, 3);
            this.fizetesLehetoseg.Name = "fizetesLehetoseg";
            this.fizetesLehetoseg.Size = new System.Drawing.Size(114, 73);
            this.fizetesLehetoseg.TabIndex = 2;
            this.fizetesLehetoseg.TabStop = false;
            this.fizetesLehetoseg.Text = "Fizetés:";
            // 
            // kartya
            // 
            this.kartya.AutoSize = true;
            this.kartya.Location = new System.Drawing.Point(7, 43);
            this.kartya.Name = "kartya";
            this.kartya.Size = new System.Drawing.Size(55, 17);
            this.kartya.TabIndex = 0;
            this.kartya.Text = "Kártya";
            this.kartya.UseVisualStyleBackColor = true;
            this.kartya.Click += new System.EventHandler(this.kartya_Click);
            // 
            // kezpenz
            // 
            this.kezpenz.AutoSize = true;
            this.kezpenz.Checked = true;
            this.kezpenz.Location = new System.Drawing.Point(7, 20);
            this.kezpenz.Name = "kezpenz";
            this.kezpenz.Size = new System.Drawing.Size(66, 17);
            this.kezpenz.TabIndex = 0;
            this.kezpenz.TabStop = true;
            this.kezpenz.Text = "Kézpénz";
            this.kezpenz.UseVisualStyleBackColor = true;
            this.kezpenz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kezpenz_MouseClick);
            // 
            // pizzaAtlagArGomb
            // 
            this.pizzaAtlagArGomb.Location = new System.Drawing.Point(203, 205);
            this.pizzaAtlagArGomb.Name = "pizzaAtlagArGomb";
            this.pizzaAtlagArGomb.Size = new System.Drawing.Size(114, 23);
            this.pizzaAtlagArGomb.TabIndex = 1;
            this.pizzaAtlagArGomb.Text = "Pizzák átlagára";
            this.pizzaAtlagArGomb.UseVisualStyleBackColor = true;
            this.pizzaAtlagArGomb.Click += new System.EventHandler(this.pizzaAtlagArGomb_Click);
            // 
            // pizzaListaBox
            // 
            this.pizzaListaBox.FormattingEnabled = true;
            this.pizzaListaBox.Location = new System.Drawing.Point(15, 3);
            this.pizzaListaBox.Name = "pizzaListaBox";
            this.pizzaListaBox.Size = new System.Drawing.Size(182, 225);
            this.pizzaListaBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(338, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 104);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.labelSzamla);
            this.panel3.Controls.Add(this.labelFizetes);
            this.panel3.Controls.Add(this.pizzamennyiseg);
            this.panel3.Controls.Add(this.rendelesLista);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(338, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 240);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rendelés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rendelesLista
            // 
            this.rendelesLista.Location = new System.Drawing.Point(3, 5);
            this.rendelesLista.Name = "rendelesLista";
            this.rendelesLista.Size = new System.Drawing.Size(273, 95);
            this.rendelesLista.TabIndex = 1;
            // 
            // pizzaValasztas
            // 
            this.pizzaValasztas.Location = new System.Drawing.Point(203, 134);
            this.pizzaValasztas.Name = "pizzaValasztas";
            this.pizzaValasztas.Size = new System.Drawing.Size(110, 23);
            this.pizzaValasztas.TabIndex = 4;
            this.pizzaValasztas.Text = "Hozzáadás";
            this.pizzaValasztas.UseVisualStyleBackColor = true;
            this.pizzaValasztas.Click += new System.EventHandler(this.pizzaValasztas_Click);
            // 
            // pizzamennyiseg
            // 
            this.pizzamennyiseg.AutoSize = true;
            this.pizzamennyiseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pizzamennyiseg.Location = new System.Drawing.Point(3, 103);
            this.pizzamennyiseg.Name = "pizzamennyiseg";
            this.pizzamennyiseg.Size = new System.Drawing.Size(265, 20);
            this.pizzamennyiseg.TabIndex = 2;
            this.pizzamennyiseg.Text = "Rendelni kívánt pizzák száma: 0";
            // 
            // labelFizetes
            // 
            this.labelFizetes.AutoSize = true;
            this.labelFizetes.Location = new System.Drawing.Point(283, 5);
            this.labelFizetes.Name = "labelFizetes";
            this.labelFizetes.Size = new System.Drawing.Size(87, 13);
            this.labelFizetes.TabIndex = 3;
            this.labelFizetes.Text = "Fizetés: Kézpénz";
            // 
            // labelSzamla
            // 
            this.labelSzamla.AutoSize = true;
            this.labelSzamla.Location = new System.Drawing.Point(283, 25);
            this.labelSzamla.Name = "labelSzamla";
            this.labelSzamla.Size = new System.Drawing.Size(99, 13);
            this.labelSzamla.TabIndex = 4;
            this.labelSzamla.Text = "Számlaigény: Nincs";
            // 
            // mennyisegKivalasztasa
            // 
            this.mennyisegKivalasztasa.Location = new System.Drawing.Point(204, 163);
            this.mennyisegKivalasztasa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mennyisegKivalasztasa.Name = "mennyisegKivalasztasa";
            this.mennyisegKivalasztasa.Size = new System.Drawing.Size(53, 20);
            this.mennyisegKivalasztasa.TabIndex = 5;
            this.mennyisegKivalasztasa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Összeg:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzaRendeles.Properties.Resources.pizza;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 430);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pizza rendelés";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.fizetesLehetoseg.ResumeLayout(false);
            this.fizetesLehetoseg.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegKivalasztasa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox pizzaListaBox;
        private System.Windows.Forms.Button pizzaAtlagArGomb;
        private System.Windows.Forms.CheckBox szamlaIgeny;
        private System.Windows.Forms.GroupBox fizetesLehetoseg;
        private System.Windows.Forms.RadioButton kartya;
        private System.Windows.Forms.RadioButton kezpenz;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox rendelesLista;
        private System.Windows.Forms.Button pizzaValasztas;
        private System.Windows.Forms.Label pizzamennyiseg;
        private System.Windows.Forms.Label labelFizetes;
        private System.Windows.Forms.Label labelSzamla;
        private System.Windows.Forms.NumericUpDown mennyisegKivalasztasa;
        private System.Windows.Forms.Label label1;
    }
}

