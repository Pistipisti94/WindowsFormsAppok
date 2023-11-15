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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.szamlaIgeny = new System.Windows.Forms.CheckBox();
            this.fizetesLehetoseg = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pizzaAtlagArGomb = new System.Windows.Forms.Button();
            this.pizzaListaBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.fizetesLehetoseg.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(338, 156);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(427, 240);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(338, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(427, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            // 
            // fizetesLehetoseg
            // 
            this.fizetesLehetoseg.Controls.Add(this.radioButton2);
            this.fizetesLehetoseg.Controls.Add(this.radioButton1);
            this.fizetesLehetoseg.Location = new System.Drawing.Point(203, 3);
            this.fizetesLehetoseg.Name = "fizetesLehetoseg";
            this.fizetesLehetoseg.Size = new System.Drawing.Size(114, 73);
            this.fizetesLehetoseg.TabIndex = 2;
            this.fizetesLehetoseg.TabStop = false;
            this.fizetesLehetoseg.Text = "Fizetés:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "Kártya";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kézpénz";
            this.radioButton1.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzaRendeles.Properties.Resources.pizza;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 430);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox pizzaListaBox;
        private System.Windows.Forms.Button pizzaAtlagArGomb;
        private System.Windows.Forms.CheckBox szamlaIgeny;
        private System.Windows.Forms.GroupBox fizetesLehetoseg;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

