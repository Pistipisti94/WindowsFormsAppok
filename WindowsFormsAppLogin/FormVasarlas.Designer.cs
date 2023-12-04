namespace WindowsFormsAppLogin
{
    partial class FormVasarlas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVasarlas));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox_termekek = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_fizetesmodja = new System.Windows.Forms.GroupBox();
            this.radioButton_utanvetel = new System.Windows.Forms.RadioButton();
            this.radioButton_card = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown_mennyiseg = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button_rendeles = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.termékToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasználóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDown_termekid = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.db_label = new System.Windows.Forms.Label();
            this.textBox_termeknev = new System.Windows.Forms.TextBox();
            this.numericUpDown_termekar = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_raktaron = new System.Windows.Forms.NumericUpDown();
            this.toolStripComboBox_termekek = new System.Windows.Forms.ToolStripComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox_fizetesmodja.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mennyiseg)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_termekid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_termekar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_raktaron)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listBox_termekek, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1071, 587);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listBox_termekek
            // 
            this.listBox_termekek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_termekek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_termekek.FormattingEnabled = true;
            this.listBox_termekek.ItemHeight = 31;
            this.listBox_termekek.Location = new System.Drawing.Point(3, 3);
            this.listBox_termekek.Name = "listBox_termekek";
            this.listBox_termekek.Size = new System.Drawing.Size(529, 287);
            this.listBox_termekek.TabIndex = 0;
            this.listBox_termekek.SelectedIndexChanged += new System.EventHandler(this.listBox_termekek_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_raktaron, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(538, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(530, 287);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(2, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nev";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox_fizetesmodja, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 296);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 288F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(529, 288);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // groupBox_fizetesmodja
            // 
            this.groupBox_fizetesmodja.Controls.Add(this.radioButton_utanvetel);
            this.groupBox_fizetesmodja.Controls.Add(this.radioButton_card);
            this.groupBox_fizetesmodja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_fizetesmodja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_fizetesmodja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_fizetesmodja.Location = new System.Drawing.Point(267, 3);
            this.groupBox_fizetesmodja.Name = "groupBox_fizetesmodja";
            this.groupBox_fizetesmodja.Size = new System.Drawing.Size(259, 282);
            this.groupBox_fizetesmodja.TabIndex = 1;
            this.groupBox_fizetesmodja.TabStop = false;
            this.groupBox_fizetesmodja.Text = "Fizetés módja";
            // 
            // radioButton_utanvetel
            // 
            this.radioButton_utanvetel.AutoSize = true;
            this.radioButton_utanvetel.Location = new System.Drawing.Point(64, 165);
            this.radioButton_utanvetel.Name = "radioButton_utanvetel";
            this.radioButton_utanvetel.Size = new System.Drawing.Size(124, 20);
            this.radioButton_utanvetel.TabIndex = 1;
            this.radioButton_utanvetel.Text = "Utánvétel (KP)";
            this.radioButton_utanvetel.UseVisualStyleBackColor = true;
            // 
            // radioButton_card
            // 
            this.radioButton_card.AutoSize = true;
            this.radioButton_card.Checked = true;
            this.radioButton_card.Location = new System.Drawing.Point(64, 82);
            this.radioButton_card.Name = "radioButton_card";
            this.radioButton_card.Size = new System.Drawing.Size(126, 20);
            this.radioButton_card.TabIndex = 0;
            this.radioButton_card.TabStop = true;
            this.radioButton_card.Text = "Kártyás fizetés";
            this.radioButton_card.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.numericUpDown_termekid, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBox_termeknev, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.numericUpDown_mennyiseg, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.numericUpDown_termekar, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.db_label, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(260, 284);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // numericUpDown_mennyiseg
            // 
            this.numericUpDown_mennyiseg.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDown_mennyiseg.Location = new System.Drawing.Point(2, 144);
            this.numericUpDown_mennyiseg.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_mennyiseg.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_mennyiseg.Name = "numericUpDown_mennyiseg";
            this.numericUpDown_mennyiseg.Size = new System.Drawing.Size(126, 20);
            this.numericUpDown_mennyiseg.TabIndex = 2;
            this.numericUpDown_mennyiseg.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.button_rendeles, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(538, 296);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(530, 288);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // button_rendeles
            // 
            this.button_rendeles.BackColor = System.Drawing.Color.ForestGreen;
            this.button_rendeles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_rendeles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_rendeles.Location = new System.Drawing.Point(268, 147);
            this.button_rendeles.Name = "button_rendeles";
            this.button_rendeles.Size = new System.Drawing.Size(259, 138);
            this.button_rendeles.TabIndex = 1;
            this.button_rendeles.Text = "Rendelés";
            this.button_rendeles.UseVisualStyleBackColor = false;
            this.button_rendeles.Click += new System.EventHandler(this.button_rendeles_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.termékToolStripMenuItem,
            this.felhasználóToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // termékToolStripMenuItem
            // 
            this.termékToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.módosításToolStripMenuItem,
            this.törlésToolStripMenuItem});
            this.termékToolStripMenuItem.Name = "termékToolStripMenuItem";
            this.termékToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.termékToolStripMenuItem.Text = "Termék";
            // 
            // felhasználóToolStripMenuItem
            // 
            this.felhasználóToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.módosításToolStripMenuItem1});
            this.felhasználóToolStripMenuItem.Name = "felhasználóToolStripMenuItem";
            this.felhasználóToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.felhasználóToolStripMenuItem.Text = "Felhasználó";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.újToolStripMenuItem.Text = "Új";
            this.újToolStripMenuItem.Click += new System.EventHandler(this.újToolStripMenuItem_Click);
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_termekek});
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            this.módosításToolStripMenuItem.Click += new System.EventHandler(this.módosításToolStripMenuItem_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.törlésToolStripMenuItem.Text = "Törlés";
            this.törlésToolStripMenuItem.Click += new System.EventHandler(this.törlésToolStripMenuItem_Click);
            // 
            // módosításToolStripMenuItem1
            // 
            this.módosításToolStripMenuItem1.Name = "módosításToolStripMenuItem1";
            this.módosításToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.módosításToolStripMenuItem1.Text = "Módosítás";
            // 
            // numericUpDown_termekid
            // 
            this.numericUpDown_termekid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown_termekid.Location = new System.Drawing.Point(3, 3);
            this.numericUpDown_termekid.Name = "numericUpDown_termekid";
            this.numericUpDown_termekid.ReadOnly = true;
            this.numericUpDown_termekid.Size = new System.Drawing.Size(124, 20);
            this.numericUpDown_termekid.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(133, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id";
            // 
            // db_label
            // 
            this.db_label.AutoSize = true;
            this.db_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.db_label.Location = new System.Drawing.Point(133, 213);
            this.db_label.Name = "db_label";
            this.db_label.Size = new System.Drawing.Size(17, 13);
            this.db_label.TabIndex = 4;
            this.db_label.Text = "Ár";
            // 
            // textBox_termeknev
            // 
            this.textBox_termeknev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_termeknev.Location = new System.Drawing.Point(3, 74);
            this.textBox_termeknev.Name = "textBox_termeknev";
            this.textBox_termeknev.ReadOnly = true;
            this.textBox_termeknev.Size = new System.Drawing.Size(124, 20);
            this.textBox_termeknev.TabIndex = 6;
            // 
            // numericUpDown_termekar
            // 
            this.numericUpDown_termekar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown_termekar.Location = new System.Drawing.Point(3, 216);
            this.numericUpDown_termekar.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_termekar.Name = "numericUpDown_termekar";
            this.numericUpDown_termekar.ReadOnly = true;
            this.numericUpDown_termekar.Size = new System.Drawing.Size(124, 20);
            this.numericUpDown_termekar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(133, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Termék";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(133, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Darab";
            // 
            // numericUpDown_raktaron
            // 
            this.numericUpDown_raktaron.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDown_raktaron.Location = new System.Drawing.Point(2, 145);
            this.numericUpDown_raktaron.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_raktaron.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_raktaron.Name = "numericUpDown_raktaron";
            this.numericUpDown_raktaron.Size = new System.Drawing.Size(126, 20);
            this.numericUpDown_raktaron.TabIndex = 2;
            this.numericUpDown_raktaron.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_raktaron.Visible = false;
            // 
            // toolStripComboBox_termekek
            // 
            this.toolStripComboBox_termekek.Name = "toolStripComboBox_termekek";
            this.toolStripComboBox_termekek.Size = new System.Drawing.Size(121, 23);
            // 
            // FormVasarlas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1071, 587);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormVasarlas";
            this.Text = "Vásárlás";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVasarlas_FormClosed);
            this.Load += new System.EventHandler(this.FormVasarlas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox_fizetesmodja.ResumeLayout(false);
            this.groupBox_fizetesmodja.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mennyiseg)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_termekid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_termekar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_raktaron)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBox_termekek;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_rendeles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox_fizetesmodja;
        private System.Windows.Forms.RadioButton radioButton_utanvetel;
        private System.Windows.Forms.RadioButton radioButton_card;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.NumericUpDown numericUpDown_mennyiseg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem termékToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felhasználóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem1;
        private System.Windows.Forms.NumericUpDown numericUpDown_termekid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_termeknev;
        private System.Windows.Forms.NumericUpDown numericUpDown_termekar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label db_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_raktaron;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_termekek;
    }
}