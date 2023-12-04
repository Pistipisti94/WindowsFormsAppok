namespace WindowsFormsAppLogin
{
    partial class FormTermek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTermek));
            this.numericUpDown_cruddb = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_crudar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_crudid = new System.Windows.Forms.NumericUpDown();
            this.textBox_crudnev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_gomb = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cruddb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_crudar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_crudid)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_cruddb
            // 
            this.numericUpDown_cruddb.Location = new System.Drawing.Point(132, 164);
            this.numericUpDown_cruddb.Name = "numericUpDown_cruddb";
            this.numericUpDown_cruddb.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_cruddb.TabIndex = 0;
            // 
            // numericUpDown_crudar
            // 
            this.numericUpDown_crudar.Location = new System.Drawing.Point(132, 138);
            this.numericUpDown_crudar.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_crudar.Name = "numericUpDown_crudar";
            this.numericUpDown_crudar.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_crudar.TabIndex = 0;
            // 
            // numericUpDown_crudid
            // 
            this.numericUpDown_crudid.Location = new System.Drawing.Point(132, 86);
            this.numericUpDown_crudid.Name = "numericUpDown_crudid";
            this.numericUpDown_crudid.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_crudid.TabIndex = 0;
            // 
            // textBox_crudnev
            // 
            this.textBox_crudnev.Location = new System.Drawing.Point(132, 112);
            this.textBox_crudnev.Name = "textBox_crudnev";
            this.textBox_crudnev.Size = new System.Drawing.Size(120, 20);
            this.textBox_crudnev.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Termék név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ÁR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Darab:";
            // 
            // button_gomb
            // 
            this.button_gomb.Location = new System.Drawing.Point(100, 200);
            this.button_gomb.Name = "button_gomb";
            this.button_gomb.Size = new System.Drawing.Size(75, 23);
            this.button_gomb.TabIndex = 3;
            this.button_gomb.Text = "Gomb";
            this.button_gomb.UseVisualStyleBackColor = true;
            this.button_gomb.Click += new System.EventHandler(this.button_gomb_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormTermek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 232);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_gomb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_crudnev);
            this.Controls.Add(this.numericUpDown_crudid);
            this.Controls.Add(this.numericUpDown_crudar);
            this.Controls.Add(this.numericUpDown_cruddb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTermek";
            this.Text = "FormTermek";
            this.Load += new System.EventHandler(this.FormTermek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cruddb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_crudar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_crudid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_cruddb;
        private System.Windows.Forms.NumericUpDown numericUpDown_crudar;
        private System.Windows.Forms.NumericUpDown numericUpDown_crudid;
        private System.Windows.Forms.TextBox textBox_crudnev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_gomb;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}