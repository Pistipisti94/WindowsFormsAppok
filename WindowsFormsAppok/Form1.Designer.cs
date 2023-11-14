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
            this.comboBoxvalasztas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxlista = new System.Windows.Forms.ListBox();
            this.forrasfajlneveinput = new System.Windows.Forms.TextBox();
            this.szazezernelnagyobb = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kevesebbmintszazezer = new System.Windows.Forms.RadioButton();
            this.gombTeruletekAtlaga = new System.Windows.Forms.Button();
            this.gombMegszamolas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.eredmenyfajlneveinput = new System.Windows.Forms.TextBox();
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
            this.ezbetolt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ezbetolt.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.ezbetolt.FlatAppearance.BorderSize = 2;
            this.ezbetolt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ezbetolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ezbetolt.Location = new System.Drawing.Point(12, 48);
            this.ezbetolt.Name = "ezbetolt";
            this.ezbetolt.Size = new System.Drawing.Size(94, 23);
            this.ezbetolt.TabIndex = 0;
            this.ezbetolt.Text = "Betöltés";
            this.ezbetolt.UseVisualStyleBackColor = true;
            this.ezbetolt.Click += new System.EventHandler(this.ezbetolt_Click);
            // 
            // comboBoxvalasztas
            // 
            this.comboBoxvalasztas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxvalasztas.FormattingEnabled = true;
            this.comboBoxvalasztas.Items.AddRange(new object[] {
            "Minimum",
            "Maximum"});
            this.comboBoxvalasztas.Location = new System.Drawing.Point(208, 200);
            this.comboBoxvalasztas.Name = "comboBoxvalasztas";
            this.comboBoxvalasztas.Size = new System.Drawing.Size(190, 21);
            this.comboBoxvalasztas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Forrásfájl neve:";
            // 
            // listBoxlista
            // 
            this.listBoxlista.FormattingEnabled = true;
            this.listBoxlista.Location = new System.Drawing.Point(12, 77);
            this.listBoxlista.Name = "listBoxlista";
            this.listBoxlista.Size = new System.Drawing.Size(190, 251);
            this.listBoxlista.TabIndex = 3;
            // 
            // forrasfajlneveinput
            // 
            this.forrasfajlneveinput.Location = new System.Drawing.Point(12, 26);
            this.forrasfajlneveinput.Name = "forrasfajlneveinput";
            this.forrasfajlneveinput.Size = new System.Drawing.Size(190, 20);
            this.forrasfajlneveinput.TabIndex = 4;
            // 
            // szazezernelnagyobb
            // 
            this.szazezernelnagyobb.AutoSize = true;
            this.szazezernelnagyobb.Checked = true;
            this.szazezernelnagyobb.Location = new System.Drawing.Point(3, 17);
            this.szazezernelnagyobb.Name = "szazezernelnagyobb";
            this.szazezernelnagyobb.Size = new System.Drawing.Size(163, 17);
            this.szazezernelnagyobb.TabIndex = 5;
            this.szazezernelnagyobb.TabStop = true;
            this.szazezernelnagyobb.Text = "100.000-nél nagyobb területű";
            this.szazezernelnagyobb.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(208, 308);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Találatok kijelölése a listában";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kevesebbmintszazezer);
            this.groupBox1.Controls.Add(this.szazezernelnagyobb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(208, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 62);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mit számoljunk?";
            // 
            // kevesebbmintszazezer
            // 
            this.kevesebbmintszazezer.AutoSize = true;
            this.kevesebbmintszazezer.Location = new System.Drawing.Point(3, 39);
            this.kevesebbmintszazezer.Name = "kevesebbmintszazezer";
            this.kevesebbmintszazezer.Size = new System.Drawing.Size(150, 17);
            this.kevesebbmintszazezer.TabIndex = 5;
            this.kevesebbmintszazezer.Text = "legfeljebb 100.000 területű";
            this.kevesebbmintszazezer.UseVisualStyleBackColor = true;
            // 
            // gombTeruletekAtlaga
            // 
            this.gombTeruletekAtlaga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gombTeruletekAtlaga.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.gombTeruletekAtlaga.FlatAppearance.BorderSize = 2;
            this.gombTeruletekAtlaga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gombTeruletekAtlaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gombTeruletekAtlaga.Location = new System.Drawing.Point(12, 334);
            this.gombTeruletekAtlaga.Name = "gombTeruletekAtlaga";
            this.gombTeruletekAtlaga.Size = new System.Drawing.Size(190, 23);
            this.gombTeruletekAtlaga.TabIndex = 0;
            this.gombTeruletekAtlaga.Text = "Területek átlaga";
            this.gombTeruletekAtlaga.UseVisualStyleBackColor = true;
            this.gombTeruletekAtlaga.Click += new System.EventHandler(this.gombTeruletekAtlaga_Click);
            // 
            // gombMegszamolas
            // 
            this.gombMegszamolas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gombMegszamolas.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.gombMegszamolas.FlatAppearance.BorderSize = 2;
            this.gombMegszamolas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gombMegszamolas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gombMegszamolas.Location = new System.Drawing.Point(208, 77);
            this.gombMegszamolas.Name = "gombMegszamolas";
            this.gombMegszamolas.Size = new System.Drawing.Size(190, 23);
            this.gombMegszamolas.TabIndex = 0;
            this.gombMegszamolas.Text = "Megszámolás";
            this.gombMegszamolas.UseVisualStyleBackColor = true;
            this.gombMegszamolas.Click += new System.EventHandler(this.gombMegszamolas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(208, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eredményfájl neve:";
            // 
            // eredmenyfajlneveinput
            // 
            this.eredmenyfajlneveinput.Location = new System.Drawing.Point(208, 119);
            this.eredmenyfajlneveinput.Name = "eredmenyfajlneveinput";
            this.eredmenyfajlneveinput.Size = new System.Drawing.Size(190, 20);
            this.eredmenyfajlneveinput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(208, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Minimum vagy maximum?";
            // 
            // gombKiiras
            // 
            this.gombKiiras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gombKiiras.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.gombKiiras.FlatAppearance.BorderSize = 2;
            this.gombKiiras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gombKiiras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gombKiiras.Location = new System.Drawing.Point(208, 145);
            this.gombKiiras.Name = "gombKiiras";
            this.gombKiiras.Size = new System.Drawing.Size(190, 23);
            this.gombKiiras.TabIndex = 0;
            this.gombKiiras.Text = "Kiírás";
            this.gombKiiras.UseVisualStyleBackColor = true;
            this.gombKiiras.Click += new System.EventHandler(this.gombKiiras_Click);
            // 
            // gombMinMaxKivalasztas
            // 
            this.gombMinMaxKivalasztas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gombMinMaxKivalasztas.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.gombMinMaxKivalasztas.FlatAppearance.BorderSize = 2;
            this.gombMinMaxKivalasztas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gombMinMaxKivalasztas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gombMinMaxKivalasztas.Location = new System.Drawing.Point(208, 227);
            this.gombMinMaxKivalasztas.Name = "gombMinMaxKivalasztas";
            this.gombMinMaxKivalasztas.Size = new System.Drawing.Size(190, 23);
            this.gombMinMaxKivalasztas.TabIndex = 0;
            this.gombMinMaxKivalasztas.Text = "Minimum / Maximum kiválasztása";
            this.gombMinMaxKivalasztas.UseVisualStyleBackColor = true;
            this.gombMinMaxKivalasztas.Click += new System.EventHandler(this.gombMinMaxKivalasztas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(208, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ország keresése:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(208, 282);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 20);
            this.textBox3.TabIndex = 4;
            // 
            // gombKereses
            // 
            this.gombKereses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gombKereses.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.gombKereses.FlatAppearance.BorderSize = 2;
            this.gombKereses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gombKereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gombKereses.Location = new System.Drawing.Point(208, 334);
            this.gombKereses.Name = "gombKereses";
            this.gombKereses.Size = new System.Drawing.Size(190, 23);
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
            this.gombBetoltes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gombBetoltes.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.gombBetoltes.FlatAppearance.BorderSize = 2;
            this.gombBetoltes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gombBetoltes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gombBetoltes.Location = new System.Drawing.Point(107, 48);
            this.gombBetoltes.Name = "gombBetoltes";
            this.gombBetoltes.Size = new System.Drawing.Size(94, 23);
            this.gombBetoltes.TabIndex = 0;
            this.gombBetoltes.Text = "Tallózás";
            this.gombBetoltes.UseVisualStyleBackColor = true;
            this.gombBetoltes.Click += new System.EventHandler(this.gombBetoltes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 373);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.eredmenyfajlneveinput);
            this.Controls.Add(this.forrasfajlneveinput);
            this.Controls.Add(this.listBoxlista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxvalasztas);
            this.Controls.Add(this.gombKereses);
            this.Controls.Add(this.gombMinMaxKivalasztas);
            this.Controls.Add(this.gombKiiras);
            this.Controls.Add(this.gombMegszamolas);
            this.Controls.Add(this.gombTeruletekAtlaga);
            this.Controls.Add(this.gombBetoltes);
            this.Controls.Add(this.ezbetolt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ComboBox comboBoxvalasztas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxlista;
        private System.Windows.Forms.TextBox forrasfajlneveinput;
        private System.Windows.Forms.RadioButton szazezernelnagyobb;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton kevesebbmintszazezer;
        private System.Windows.Forms.Button gombTeruletekAtlaga;
        private System.Windows.Forms.Button gombMegszamolas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eredmenyfajlneveinput;
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

