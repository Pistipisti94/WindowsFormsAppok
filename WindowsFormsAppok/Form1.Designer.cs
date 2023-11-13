namespace WindowsFormsAppok
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
            this.ezbetolt = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxlista = new System.Windows.Forms.ListBox();
            this.forrasfajlneveinput = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.gombTeruletekAtlaga = new System.Windows.Forms.Button();
            this.gombMegszamolas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gombKiiras = new System.Windows.Forms.Button();
            this.gombMinMaxKivalasztas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.gombKereses = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gombBetoltes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ezbetolt
            // 
            this.ezbetolt.Location = new System.Drawing.Point(16, 59);
            this.ezbetolt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ezbetolt.Name = "ezbetolt";
            this.ezbetolt.Size = new System.Drawing.Size(125, 28);
            this.ezbetolt.TabIndex = 0;
            this.ezbetolt.Text = "Betöltés";
            this.ezbetolt.UseVisualStyleBackColor = true;
            this.ezbetolt.Click += new System.EventHandler(this.ezbetolt_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Minimum",
            "Maximum"});
            this.comboBox1.Location = new System.Drawing.Point(277, 246);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Forrásfájl neve:";
            // 
            // listBoxlista
            // 
            this.listBoxlista.FormattingEnabled = true;
            this.listBoxlista.ItemHeight = 16;
            this.listBoxlista.Location = new System.Drawing.Point(16, 95);
            this.listBoxlista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxlista.Name = "listBoxlista";
            this.listBoxlista.Size = new System.Drawing.Size(252, 308);
            this.listBoxlista.TabIndex = 3;
            // 
            // forrasfajlneveinput
            // 
            this.forrasfajlneveinput.Location = new System.Drawing.Point(16, 32);
            this.forrasfajlneveinput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.forrasfajlneveinput.Name = "forrasfajlneveinput";
            this.forrasfajlneveinput.Size = new System.Drawing.Size(252, 22);
            this.forrasfajlneveinput.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 21);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(198, 20);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "100.000-nél nagyobb területű";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(277, 379);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(208, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Találatok kijelölése a listában";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(277, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(253, 76);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mit számoljunk?";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(4, 48);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(182, 20);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "legfeljebb 100.000 területű";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // gombTeruletekAtlaga
            // 
            this.gombTeruletekAtlaga.Location = new System.Drawing.Point(16, 411);
            this.gombTeruletekAtlaga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gombTeruletekAtlaga.Name = "gombTeruletekAtlaga";
            this.gombTeruletekAtlaga.Size = new System.Drawing.Size(253, 28);
            this.gombTeruletekAtlaga.TabIndex = 0;
            this.gombTeruletekAtlaga.Text = "Területek átlaga";
            this.gombTeruletekAtlaga.UseVisualStyleBackColor = true;
            // 
            // gombMegszamolas
            // 
            this.gombMegszamolas.Location = new System.Drawing.Point(277, 95);
            this.gombMegszamolas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gombMegszamolas.Name = "gombMegszamolas";
            this.gombMegszamolas.Size = new System.Drawing.Size(253, 28);
            this.gombMegszamolas.TabIndex = 0;
            this.gombMegszamolas.Text = "Megszámolás";
            this.gombMegszamolas.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eredményfájl neve:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(277, 146);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 22);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Minimum vagy maximum?";
            // 
            // gombKiiras
            // 
            this.gombKiiras.Location = new System.Drawing.Point(277, 178);
            this.gombKiiras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gombKiiras.Name = "gombKiiras";
            this.gombKiiras.Size = new System.Drawing.Size(253, 28);
            this.gombKiiras.TabIndex = 0;
            this.gombKiiras.Text = "Kiírás";
            this.gombKiiras.UseVisualStyleBackColor = true;
            // 
            // gombMinMaxKivalasztas
            // 
            this.gombMinMaxKivalasztas.Location = new System.Drawing.Point(277, 279);
            this.gombMinMaxKivalasztas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gombMinMaxKivalasztas.Name = "gombMinMaxKivalasztas";
            this.gombMinMaxKivalasztas.Size = new System.Drawing.Size(253, 28);
            this.gombMinMaxKivalasztas.TabIndex = 0;
            this.gombMinMaxKivalasztas.Text = "Minimum / Maximum kiválasztása";
            this.gombMinMaxKivalasztas.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 327);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ország keresése:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(277, 347);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(252, 22);
            this.textBox3.TabIndex = 4;
            // 
            // gombKereses
            // 
            this.gombKereses.Location = new System.Drawing.Point(277, 411);
            this.gombKereses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gombKereses.Name = "gombKereses";
            this.gombKereses.Size = new System.Drawing.Size(253, 28);
            this.gombKereses.TabIndex = 0;
            this.gombKereses.Text = "Keresés";
            this.gombKereses.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gombBetoltes
            // 
            this.gombBetoltes.Location = new System.Drawing.Point(143, 59);
            this.gombBetoltes.Margin = new System.Windows.Forms.Padding(4);
            this.gombBetoltes.Name = "gombBetoltes";
            this.gombBetoltes.Size = new System.Drawing.Size(125, 28);
            this.gombBetoltes.TabIndex = 0;
            this.gombBetoltes.Text = "Tallózás";
            this.gombBetoltes.UseVisualStyleBackColor = true;
            this.gombBetoltes.Click += new System.EventHandler(this.gombBetoltes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 459);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.forrasfajlneveinput);
            this.Controls.Add(this.listBoxlista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gombKereses);
            this.Controls.Add(this.gombMinMaxKivalasztas);
            this.Controls.Add(this.gombKiiras);
            this.Controls.Add(this.gombMegszamolas);
            this.Controls.Add(this.gombTeruletekAtlaga);
            this.Controls.Add(this.gombBetoltes);
            this.Controls.Add(this.ezbetolt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Példa Windows Form alkalmazás";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ezbetolt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxlista;
        private System.Windows.Forms.TextBox forrasfajlneveinput;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button gombTeruletekAtlaga;
        private System.Windows.Forms.Button gombMegszamolas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button gombKiiras;
        private System.Windows.Forms.Button gombMinMaxKivalasztas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button gombKereses;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button gombBetoltes;
    }
}

