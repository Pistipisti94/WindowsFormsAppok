namespace WindowsFormsAppLogin
{
    partial class Formlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlogin));
            this.button_bejelentkezes = new System.Windows.Forms.Button();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.textBox_jelszo = new System.Windows.Forms.TextBox();
            this.button_regisztracio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_jelszox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_regiOn = new System.Windows.Forms.Button();
            this.button_loginBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_bejelentkezes
            // 
            this.button_bejelentkezes.Location = new System.Drawing.Point(120, 169);
            this.button_bejelentkezes.Name = "button_bejelentkezes";
            this.button_bejelentkezes.Size = new System.Drawing.Size(115, 42);
            this.button_bejelentkezes.TabIndex = 3;
            this.button_bejelentkezes.Text = "Bejelentkezés";
            this.button_bejelentkezes.UseVisualStyleBackColor = true;
            this.button_bejelentkezes.Click += new System.EventHandler(this.button_bejelentkezes_Click);
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(98, 66);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(163, 20);
            this.textBox_nev.TabIndex = 1;
            // 
            // textBox_jelszo
            // 
            this.textBox_jelszo.Location = new System.Drawing.Point(98, 111);
            this.textBox_jelszo.Name = "textBox_jelszo";
            this.textBox_jelszo.Size = new System.Drawing.Size(163, 20);
            this.textBox_jelszo.TabIndex = 2;
            // 
            // button_regisztracio
            // 
            this.button_regisztracio.Location = new System.Drawing.Point(98, 359);
            this.button_regisztracio.Name = "button_regisztracio";
            this.button_regisztracio.Size = new System.Drawing.Size(158, 50);
            this.button_regisztracio.TabIndex = 4;
            this.button_regisztracio.Text = "Regisztráció";
            this.button_regisztracio.UseVisualStyleBackColor = true;
            this.button_regisztracio.Click += new System.EventHandler(this.button_regisztracio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Felhasználónév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jelszó:";
            // 
            // textBox_jelszox
            // 
            this.textBox_jelszox.Location = new System.Drawing.Point(98, 137);
            this.textBox_jelszox.Name = "textBox_jelszox";
            this.textBox_jelszox.Size = new System.Drawing.Size(163, 20);
            this.textBox_jelszox.TabIndex = 1;
            this.textBox_jelszox.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jelszó megint:";
            this.label3.Visible = false;
            // 
            // button_regiOn
            // 
            this.button_regiOn.Location = new System.Drawing.Point(120, 169);
            this.button_regiOn.Name = "button_regiOn";
            this.button_regiOn.Size = new System.Drawing.Size(115, 42);
            this.button_regiOn.TabIndex = 0;
            this.button_regiOn.Text = "Regisztráció";
            this.button_regiOn.UseVisualStyleBackColor = true;
            this.button_regiOn.Visible = false;
            this.button_regiOn.Click += new System.EventHandler(this.regisztralas);
            // 
            // button_loginBack
            // 
            this.button_loginBack.Location = new System.Drawing.Point(98, 359);
            this.button_loginBack.Name = "button_loginBack";
            this.button_loginBack.Size = new System.Drawing.Size(158, 50);
            this.button_loginBack.TabIndex = 0;
            this.button_loginBack.Text = "Bejelentkezés";
            this.button_loginBack.UseVisualStyleBackColor = true;
            this.button_loginBack.Visible = false;
            this.button_loginBack.Click += new System.EventHandler(this.vissza_bejelentkezes);
            // 
            // Formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_jelszox);
            this.Controls.Add(this.textBox_jelszo);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.button_regiOn);
            this.Controls.Add(this.button_regisztracio);
            this.Controls.Add(this.button_loginBack);
            this.Controls.Add(this.button_bejelentkezes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Formlogin";
            this.Text = "Bejelenzkezés/Regisztráció";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_bejelentkezes;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.TextBox textBox_jelszo;
        private System.Windows.Forms.Button button_regisztracio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_jelszox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_regiOn;
        private System.Windows.Forms.Button button_loginBack;
    }
}

