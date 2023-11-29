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
            this.button_hozzaad = new System.Windows.Forms.Button();
            this.button_listaelemtorles = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox_rendelttermek = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button_rendeles = new System.Windows.Forms.Button();
            this.groupBox_fizetesmodja = new System.Windows.Forms.GroupBox();
            this.radioButton_card = new System.Windows.Forms.RadioButton();
            this.radioButton_utanvetel = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox_fizetesmodja.SuspendLayout();
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
            this.listBox_termekek.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_termekek.FormattingEnabled = true;
            this.listBox_termekek.ItemHeight = 37;
            this.listBox_termekek.Location = new System.Drawing.Point(3, 3);
            this.listBox_termekek.Name = "listBox_termekek";
            this.listBox_termekek.Size = new System.Drawing.Size(529, 287);
            this.listBox_termekek.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.button_hozzaad, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_listaelemtorles, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(538, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(530, 287);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button_hozzaad
            // 
            this.button_hozzaad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_hozzaad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_hozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_hozzaad.Location = new System.Drawing.Point(3, 3);
            this.button_hozzaad.Name = "button_hozzaad";
            this.button_hozzaad.Size = new System.Drawing.Size(524, 137);
            this.button_hozzaad.TabIndex = 0;
            this.button_hozzaad.Text = "Kosárhoz adás";
            this.button_hozzaad.UseVisualStyleBackColor = false;
            this.button_hozzaad.Click += new System.EventHandler(this.button_hozzaad_Click);
            // 
            // button_listaelemtorles
            // 
            this.button_listaelemtorles.BackColor = System.Drawing.Color.Red;
            this.button_listaelemtorles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_listaelemtorles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_listaelemtorles.Location = new System.Drawing.Point(3, 146);
            this.button_listaelemtorles.Name = "button_listaelemtorles";
            this.button_listaelemtorles.Size = new System.Drawing.Size(524, 138);
            this.button_listaelemtorles.TabIndex = 1;
            this.button_listaelemtorles.Text = "Töröl";
            this.button_listaelemtorles.UseVisualStyleBackColor = false;
            this.button_listaelemtorles.Click += new System.EventHandler(this.button_listaelemtorles_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.listBox_rendelttermek, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox_fizetesmodja, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 296);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 288F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(529, 288);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // listBox_rendelttermek
            // 
            this.listBox_rendelttermek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_rendelttermek.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_rendelttermek.FormattingEnabled = true;
            this.listBox_rendelttermek.ItemHeight = 37;
            this.listBox_rendelttermek.Location = new System.Drawing.Point(3, 3);
            this.listBox_rendelttermek.Name = "listBox_rendelttermek";
            this.listBox_rendelttermek.Size = new System.Drawing.Size(258, 282);
            this.listBox_rendelttermek.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.button_rendeles, 1, 1);
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
            // FormVasarlas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1071, 587);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVasarlas";
            this.Text = "Vásárlás";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVasarlas_FormClosed);
            this.Load += new System.EventHandler(this.FormVasarlas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox_fizetesmodja.ResumeLayout(false);
            this.groupBox_fizetesmodja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBox_termekek;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_hozzaad;
        private System.Windows.Forms.Button button_rendeles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button_listaelemtorles;
        private System.Windows.Forms.ListBox listBox_rendelttermek;
        private System.Windows.Forms.GroupBox groupBox_fizetesmodja;
        private System.Windows.Forms.RadioButton radioButton_utanvetel;
        private System.Windows.Forms.RadioButton radioButton_card;
    }
}