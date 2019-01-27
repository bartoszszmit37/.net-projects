namespace bs_project_4_liczby_zespolone
{
    partial class bs_cala_formatka
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.bs_re = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bs_im = new System.Windows.Forms.TextBox();
            this.bs_rysuj_Z1 = new System.Windows.Forms.Button();
            this.bs_plotno_dla_Z1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bs2_re = new System.Windows.Forms.TextBox();
            this.bs_rysuj_Z2 = new System.Windows.Forms.Button();
            this.bs2_im = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bs_plotno_dla_Z2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bs_Z_wynik = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bs_modul_Z2 = new System.Windows.Forms.Button();
            this.bs_modul_Z1 = new System.Windows.Forms.Button();
            this.bs_resetowanie_errorow = new System.Windows.Forms.Button();
            this.bs_czesc_urojona_z1 = new System.Windows.Forms.Button();
            this.bs_re_z1 = new System.Windows.Forms.Button();
            this.bs_wyczysc_wykresy = new System.Windows.Forms.Button();
            this.bs_odwrotnoscZ2 = new System.Windows.Forms.Button();
            this.bs_odwrotnoscZ1 = new System.Windows.Forms.Button();
            this.bs_dzielenieZ1Z2 = new System.Windows.Forms.Button();
            this.bs_mnozenie = new System.Windows.Forms.Button();
            this.bs_odejmijZ1Z2 = new System.Windows.Forms.Button();
            this.bs_dodajZ1Z2 = new System.Windows.Forms.Button();
            this.bs_error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bs_plotno_dla_Z1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_plotno_dla_Z2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Z_wynik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liczba zespolona: Z1";
            // 
            // bs_re
            // 
            this.bs_re.Location = new System.Drawing.Point(126, 17);
            this.bs_re.Name = "bs_re";
            this.bs_re.Size = new System.Drawing.Size(26, 20);
            this.bs_re.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "+ i * ";
            // 
            // bs_im
            // 
            this.bs_im.Location = new System.Drawing.Point(192, 17);
            this.bs_im.Name = "bs_im";
            this.bs_im.Size = new System.Drawing.Size(31, 20);
            this.bs_im.TabIndex = 4;
            // 
            // bs_rysuj_Z1
            // 
            this.bs_rysuj_Z1.Location = new System.Drawing.Point(257, 17);
            this.bs_rysuj_Z1.Name = "bs_rysuj_Z1";
            this.bs_rysuj_Z1.Size = new System.Drawing.Size(75, 23);
            this.bs_rysuj_Z1.TabIndex = 6;
            this.bs_rysuj_Z1.Text = "rysuj Z1";
            this.bs_rysuj_Z1.UseVisualStyleBackColor = true;
            this.bs_rysuj_Z1.Click += new System.EventHandler(this.bs_rysuj_Z1_Click);
            // 
            // bs_plotno_dla_Z1
            // 
            this.bs_plotno_dla_Z1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bs_plotno_dla_Z1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bs_plotno_dla_Z1.Location = new System.Drawing.Point(12, 46);
            this.bs_plotno_dla_Z1.Name = "bs_plotno_dla_Z1";
            this.bs_plotno_dla_Z1.Size = new System.Drawing.Size(320, 320);
            this.bs_plotno_dla_Z1.TabIndex = 7;
            this.bs_plotno_dla_Z1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Liczba zespolona: Z2";
            // 
            // bs2_re
            // 
            this.bs2_re.Location = new System.Drawing.Point(452, 17);
            this.bs2_re.Name = "bs2_re";
            this.bs2_re.Size = new System.Drawing.Size(26, 20);
            this.bs2_re.TabIndex = 9;
            // 
            // bs_rysuj_Z2
            // 
            this.bs_rysuj_Z2.Location = new System.Drawing.Point(569, 15);
            this.bs_rysuj_Z2.Name = "bs_rysuj_Z2";
            this.bs_rysuj_Z2.Size = new System.Drawing.Size(75, 23);
            this.bs_rysuj_Z2.TabIndex = 13;
            this.bs_rysuj_Z2.Text = "rysuj_Z2";
            this.bs_rysuj_Z2.UseVisualStyleBackColor = true;
            this.bs_rysuj_Z2.Click += new System.EventHandler(this.bs_rysuj_Z2_Click);
            // 
            // bs2_im
            // 
            this.bs2_im.Location = new System.Drawing.Point(521, 17);
            this.bs2_im.Name = "bs2_im";
            this.bs2_im.Size = new System.Drawing.Size(31, 20);
            this.bs2_im.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "+ i *";
            // 
            // bs_plotno_dla_Z2
            // 
            this.bs_plotno_dla_Z2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bs_plotno_dla_Z2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bs_plotno_dla_Z2.Location = new System.Drawing.Point(338, 46);
            this.bs_plotno_dla_Z2.Name = "bs_plotno_dla_Z2";
            this.bs_plotno_dla_Z2.Size = new System.Drawing.Size(320, 320);
            this.bs_plotno_dla_Z2.TabIndex = 14;
            this.bs_plotno_dla_Z2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(105, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "ostateczny wynik ";
            // 
            // bs_Z_wynik
            // 
            this.bs_Z_wynik.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bs_Z_wynik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bs_Z_wynik.Location = new System.Drawing.Point(15, 389);
            this.bs_Z_wynik.Name = "bs_Z_wynik";
            this.bs_Z_wynik.Size = new System.Drawing.Size(320, 320);
            this.bs_Z_wynik.TabIndex = 16;
            this.bs_Z_wynik.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(380, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "dzialania na liczbach zespolonych";
            // 
            // bs_modul_Z2
            // 
            this.bs_modul_Z2.Location = new System.Drawing.Point(435, 482);
            this.bs_modul_Z2.Name = "bs_modul_Z2";
            this.bs_modul_Z2.Size = new System.Drawing.Size(75, 37);
            this.bs_modul_Z2.TabIndex = 38;
            this.bs_modul_Z2.Text = "modul Z2";
            this.bs_modul_Z2.UseVisualStyleBackColor = true;
            this.bs_modul_Z2.Click += new System.EventHandler(this.bs_modul_Z2_Click);
            // 
            // bs_modul_Z1
            // 
            this.bs_modul_Z1.Location = new System.Drawing.Point(354, 482);
            this.bs_modul_Z1.Name = "bs_modul_Z1";
            this.bs_modul_Z1.Size = new System.Drawing.Size(75, 37);
            this.bs_modul_Z1.TabIndex = 37;
            this.bs_modul_Z1.Text = "modul Z1";
            this.bs_modul_Z1.UseVisualStyleBackColor = true;
            this.bs_modul_Z1.Click += new System.EventHandler(this.bs_modul_Z1_Click);
            // 
            // bs_resetowanie_errorow
            // 
            this.bs_resetowanie_errorow.Location = new System.Drawing.Point(435, 525);
            this.bs_resetowanie_errorow.Name = "bs_resetowanie_errorow";
            this.bs_resetowanie_errorow.Size = new System.Drawing.Size(129, 48);
            this.bs_resetowanie_errorow.TabIndex = 36;
            this.bs_resetowanie_errorow.Text = "resetowanie errorów";
            this.bs_resetowanie_errorow.UseVisualStyleBackColor = true;
            this.bs_resetowanie_errorow.Click += new System.EventHandler(this.bs_resetowanie_errorow_Click);
            // 
            // bs_czesc_urojona_z1
            // 
            this.bs_czesc_urojona_z1.Location = new System.Drawing.Point(599, 437);
            this.bs_czesc_urojona_z1.Name = "bs_czesc_urojona_z1";
            this.bs_czesc_urojona_z1.Size = new System.Drawing.Size(75, 39);
            this.bs_czesc_urojona_z1.TabIndex = 35;
            this.bs_czesc_urojona_z1.Text = "im Z1";
            this.bs_czesc_urojona_z1.UseVisualStyleBackColor = true;
            this.bs_czesc_urojona_z1.Click += new System.EventHandler(this.bs_czesc_urojona_z1_Click);
            // 
            // bs_re_z1
            // 
            this.bs_re_z1.Location = new System.Drawing.Point(516, 437);
            this.bs_re_z1.Name = "bs_re_z1";
            this.bs_re_z1.Size = new System.Drawing.Size(75, 39);
            this.bs_re_z1.TabIndex = 34;
            this.bs_re_z1.Text = "re Z1";
            this.bs_re_z1.UseVisualStyleBackColor = true;
            this.bs_re_z1.Click += new System.EventHandler(this.bs_re_z1_Click);
            // 
            // bs_wyczysc_wykresy
            // 
            this.bs_wyczysc_wykresy.Location = new System.Drawing.Point(516, 482);
            this.bs_wyczysc_wykresy.Name = "bs_wyczysc_wykresy";
            this.bs_wyczysc_wykresy.Size = new System.Drawing.Size(75, 37);
            this.bs_wyczysc_wykresy.TabIndex = 33;
            this.bs_wyczysc_wykresy.Text = "wyszczysc wykresy";
            this.bs_wyczysc_wykresy.UseVisualStyleBackColor = true;
            this.bs_wyczysc_wykresy.Click += new System.EventHandler(this.bs_wyczysc_wykresy_Click);
            // 
            // bs_odwrotnoscZ2
            // 
            this.bs_odwrotnoscZ2.Location = new System.Drawing.Point(435, 437);
            this.bs_odwrotnoscZ2.Name = "bs_odwrotnoscZ2";
            this.bs_odwrotnoscZ2.Size = new System.Drawing.Size(75, 39);
            this.bs_odwrotnoscZ2.TabIndex = 32;
            this.bs_odwrotnoscZ2.Text = "odwrotnosc Z2";
            this.bs_odwrotnoscZ2.UseVisualStyleBackColor = true;
            this.bs_odwrotnoscZ2.Click += new System.EventHandler(this.bs_odwrotnoscZ2_Click);
            // 
            // bs_odwrotnoscZ1
            // 
            this.bs_odwrotnoscZ1.Location = new System.Drawing.Point(354, 437);
            this.bs_odwrotnoscZ1.Name = "bs_odwrotnoscZ1";
            this.bs_odwrotnoscZ1.Size = new System.Drawing.Size(75, 39);
            this.bs_odwrotnoscZ1.TabIndex = 31;
            this.bs_odwrotnoscZ1.Text = "odwrotnosc Z1";
            this.bs_odwrotnoscZ1.UseVisualStyleBackColor = true;
            this.bs_odwrotnoscZ1.Click += new System.EventHandler(this.bs_odwrotnoscZ1_Click);
            // 
            // bs_dzielenieZ1Z2
            // 
            this.bs_dzielenieZ1Z2.Location = new System.Drawing.Point(597, 407);
            this.bs_dzielenieZ1Z2.Name = "bs_dzielenieZ1Z2";
            this.bs_dzielenieZ1Z2.Size = new System.Drawing.Size(75, 23);
            this.bs_dzielenieZ1Z2.TabIndex = 30;
            this.bs_dzielenieZ1Z2.Text = "dzielenie";
            this.bs_dzielenieZ1Z2.UseVisualStyleBackColor = true;
            this.bs_dzielenieZ1Z2.Click += new System.EventHandler(this.bs_dzielenieZ1Z2_Click);
            // 
            // bs_mnozenie
            // 
            this.bs_mnozenie.Location = new System.Drawing.Point(516, 407);
            this.bs_mnozenie.Name = "bs_mnozenie";
            this.bs_mnozenie.Size = new System.Drawing.Size(75, 23);
            this.bs_mnozenie.TabIndex = 29;
            this.bs_mnozenie.Text = "mnożenie";
            this.bs_mnozenie.UseVisualStyleBackColor = true;
            this.bs_mnozenie.Click += new System.EventHandler(this.bs_mnozenie_Click);
            // 
            // bs_odejmijZ1Z2
            // 
            this.bs_odejmijZ1Z2.Location = new System.Drawing.Point(435, 407);
            this.bs_odejmijZ1Z2.Name = "bs_odejmijZ1Z2";
            this.bs_odejmijZ1Z2.Size = new System.Drawing.Size(75, 23);
            this.bs_odejmijZ1Z2.TabIndex = 28;
            this.bs_odejmijZ1Z2.Text = "Z1 - Z2";
            this.bs_odejmijZ1Z2.UseVisualStyleBackColor = true;
            this.bs_odejmijZ1Z2.Click += new System.EventHandler(this.bs_odejmijZ1Z2_Click);
            // 
            // bs_dodajZ1Z2
            // 
            this.bs_dodajZ1Z2.Location = new System.Drawing.Point(354, 407);
            this.bs_dodajZ1Z2.Name = "bs_dodajZ1Z2";
            this.bs_dodajZ1Z2.Size = new System.Drawing.Size(75, 23);
            this.bs_dodajZ1Z2.TabIndex = 27;
            this.bs_dodajZ1Z2.Text = "Z1 + Z2";
            this.bs_dodajZ1Z2.UseVisualStyleBackColor = true;
            this.bs_dodajZ1Z2.Click += new System.EventHandler(this.bs_dodajZ1Z2_Click);
            // 
            // bs_error
            // 
            this.bs_error.ContainerControl = this;
            // 
            // bs_cala_formatka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 720);
            this.Controls.Add(this.bs_modul_Z2);
            this.Controls.Add(this.bs_modul_Z1);
            this.Controls.Add(this.bs_resetowanie_errorow);
            this.Controls.Add(this.bs_czesc_urojona_z1);
            this.Controls.Add(this.bs_re_z1);
            this.Controls.Add(this.bs_wyczysc_wykresy);
            this.Controls.Add(this.bs_odwrotnoscZ2);
            this.Controls.Add(this.bs_odwrotnoscZ1);
            this.Controls.Add(this.bs_dzielenieZ1Z2);
            this.Controls.Add(this.bs_mnozenie);
            this.Controls.Add(this.bs_odejmijZ1Z2);
            this.Controls.Add(this.bs_dodajZ1Z2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bs_Z_wynik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bs_plotno_dla_Z2);
            this.Controls.Add(this.bs_rysuj_Z2);
            this.Controls.Add(this.bs2_im);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bs2_re);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bs_plotno_dla_Z1);
            this.Controls.Add(this.bs_rysuj_Z1);
            this.Controls.Add(this.bs_im);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bs_re);
            this.Controls.Add(this.label1);
            this.Name = "bs_cala_formatka";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bs_plotno_dla_Z1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_plotno_dla_Z2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Z_wynik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bs_re;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bs_im;
        private System.Windows.Forms.Button bs_rysuj_Z1;
        private System.Windows.Forms.PictureBox bs_plotno_dla_Z1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bs2_re;
        private System.Windows.Forms.Button bs_rysuj_Z2;
        private System.Windows.Forms.TextBox bs2_im;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox bs_plotno_dla_Z2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox bs_Z_wynik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bs_modul_Z2;
        private System.Windows.Forms.Button bs_modul_Z1;
        private System.Windows.Forms.Button bs_resetowanie_errorow;
        private System.Windows.Forms.Button bs_czesc_urojona_z1;
        private System.Windows.Forms.Button bs_re_z1;
        private System.Windows.Forms.Button bs_wyczysc_wykresy;
        private System.Windows.Forms.Button bs_odwrotnoscZ2;
        private System.Windows.Forms.Button bs_odwrotnoscZ1;
        private System.Windows.Forms.Button bs_dzielenieZ1Z2;
        private System.Windows.Forms.Button bs_mnozenie;
        private System.Windows.Forms.Button bs_odejmijZ1Z2;
        private System.Windows.Forms.Button bs_dodajZ1Z2;
        private System.Windows.Forms.ErrorProvider bs_error;
    }
}

