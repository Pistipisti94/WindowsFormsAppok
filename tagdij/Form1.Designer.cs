namespace tagdij
{
    partial class formTag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTag));
            this.listBoxTagok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_azon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_orsz = new System.Windows.Forms.TextBox();
            this.numericUpDown_irszam = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_szulev = new System.Windows.Forms.NumericUpDown();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_irszam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_szulev)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxTagok
            // 
            this.listBoxTagok.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.listBoxTagok, "listBoxTagok");
            this.listBoxTagok.FormattingEnabled = true;
            this.listBoxTagok.Name = "listBoxTagok";
            this.listBoxTagok.SelectedIndexChanged += new System.EventHandler(this.listBoxTagok_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_szulev);
            this.groupBox1.Controls.Add(this.numericUpDown_irszam);
            this.groupBox1.Controls.Add(this.textBox_orsz);
            this.groupBox1.Controls.Add(this.textBox_nev);
            this.groupBox1.Controls.Add(this.textBox_azon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_delete);
            this.groupBox2.Controls.Add(this.button_update);
            this.groupBox2.Controls.Add(this.button_insert);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox_azon
            // 
            resources.ApplyResources(this.textBox_azon, "textBox_azon");
            this.textBox_azon.Name = "textBox_azon";
            this.textBox_azon.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBox_nev
            // 
            this.textBox_nev.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.textBox_nev, "textBox_nev");
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Click += new System.EventHandler(this.textBox_nev_Click);
            this.textBox_nev.Leave += new System.EventHandler(this.textBox_nev_Leave);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // textBox_orsz
            // 
            resources.ApplyResources(this.textBox_orsz, "textBox_orsz");
            this.textBox_orsz.Name = "textBox_orsz";
            this.textBox_orsz.Click += new System.EventHandler(this.textBox_orsz_Click);
            this.textBox_orsz.Leave += new System.EventHandler(this.textBox_orsz_Leave);
            // 
            // numericUpDown_irszam
            // 
            this.numericUpDown_irszam.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            resources.ApplyResources(this.numericUpDown_irszam, "numericUpDown_irszam");
            this.numericUpDown_irszam.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_irszam.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_irszam.Name = "numericUpDown_irszam";
            this.numericUpDown_irszam.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_irszam.Click += new System.EventHandler(this.numericUpDown_irszam_Click);
            this.numericUpDown_irszam.Leave += new System.EventHandler(this.numericUpDown_irszam_Leave);
            // 
            // numericUpDown_szulev
            // 
            this.numericUpDown_szulev.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            resources.ApplyResources(this.numericUpDown_szulev, "numericUpDown_szulev");
            this.numericUpDown_szulev.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDown_szulev.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDown_szulev.Name = "numericUpDown_szulev";
            this.numericUpDown_szulev.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numericUpDown_szulev.Click += new System.EventHandler(this.numericUpDown_szulev_Click);
            this.numericUpDown_szulev.Leave += new System.EventHandler(this.numericUpDown_szulev_Leave);
            // 
            // button_insert
            // 
            this.button_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.button_insert, "button_insert");
            this.button_insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_insert.Name = "button_insert";
            this.button_insert.UseVisualStyleBackColor = false;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_update.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button_update, "button_update");
            this.button_update.Name = "button_update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button_delete, "button_delete");
            this.button_delete.Name = "button_delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // formTag
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxTagok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formTag";
            this.Load += new System.EventHandler(this.Tag_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_irszam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_szulev)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTagok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_orsz;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.TextBox textBox_azon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown_irszam;
        private System.Windows.Forms.NumericUpDown numericUpDown_szulev;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
    }
}

