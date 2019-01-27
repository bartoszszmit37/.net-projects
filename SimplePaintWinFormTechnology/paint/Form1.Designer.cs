namespace paint
{
    partial class bs_pulpit_paint
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
            this.bs_wspolrzedne = new System.Windows.Forms.Label();
            this.bs_wspolrzedna_x = new System.Windows.Forms.Label();
            this.bs_wspolrzedna_y = new System.Windows.Forms.Label();
            this.bs_rysownica = new System.Windows.Forms.PictureBox();
            this.bs_suwak_grubosci = new System.Windows.Forms.TrackBar();
            this.bs_numeric_grubosci = new System.Windows.Forms.NumericUpDown();
            this.bs_wziernik = new System.Windows.Forms.Panel();
            this.bs_olowek = new System.Windows.Forms.RadioButton();
            this.bs_okrag = new System.Windows.Forms.RadioButton();
            this.bs_prostokat = new System.Windows.Forms.RadioButton();
            this.bs_color_linii = new System.Windows.Forms.Button();
            this.bs_zapisz_rysunek = new System.Windows.Forms.Button();
            this.bs_otworz_rysunek = new System.Windows.Forms.Button();
            this.bs_kolor_tla = new System.Windows.Forms.Button();
            this.bs_style_linii = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bs_rysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_suwak_grubosci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_numeric_grubosci)).BeginInit();
            this.SuspendLayout();
            // 
            // bs_wspolrzedne
            // 
            this.bs_wspolrzedne.AutoSize = true;
            this.bs_wspolrzedne.Location = new System.Drawing.Point(28, 18);
            this.bs_wspolrzedne.Name = "bs_wspolrzedne";
            this.bs_wspolrzedne.Size = new System.Drawing.Size(152, 13);
            this.bs_wspolrzedne.TabIndex = 0;
            this.bs_wspolrzedne.Text = "Współrzędne położenia myszy";
            // 
            // bs_wspolrzedna_x
            // 
            this.bs_wspolrzedna_x.AutoSize = true;
            this.bs_wspolrzedna_x.Location = new System.Drawing.Point(214, 18);
            this.bs_wspolrzedna_x.Name = "bs_wspolrzedna_x";
            this.bs_wspolrzedna_x.Size = new System.Drawing.Size(0, 13);
            this.bs_wspolrzedna_x.TabIndex = 1;
            // 
            // bs_wspolrzedna_y
            // 
            this.bs_wspolrzedna_y.AutoSize = true;
            this.bs_wspolrzedna_y.Location = new System.Drawing.Point(271, 18);
            this.bs_wspolrzedna_y.Name = "bs_wspolrzedna_y";
            this.bs_wspolrzedna_y.Size = new System.Drawing.Size(0, 13);
            this.bs_wspolrzedna_y.TabIndex = 2;
            // 
            // bs_rysownica
            // 
            this.bs_rysownica.BackColor = System.Drawing.Color.Transparent;
            this.bs_rysownica.Location = new System.Drawing.Point(31, 65);
            this.bs_rysownica.Name = "bs_rysownica";
            this.bs_rysownica.Size = new System.Drawing.Size(377, 221);
            this.bs_rysownica.TabIndex = 3;
            this.bs_rysownica.TabStop = false;
            this.bs_rysownica.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bs_rysownica_MouseDown);
            this.bs_rysownica.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bs_rysownica_MouseMove);
            this.bs_rysownica.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bs_rysownica_MouseUp);
            // 
            // bs_suwak_grubosci
            // 
            this.bs_suwak_grubosci.Location = new System.Drawing.Point(437, 160);
            this.bs_suwak_grubosci.Maximum = 20;
            this.bs_suwak_grubosci.Minimum = 1;
            this.bs_suwak_grubosci.Name = "bs_suwak_grubosci";
            this.bs_suwak_grubosci.Size = new System.Drawing.Size(120, 45);
            this.bs_suwak_grubosci.TabIndex = 4;
            this.bs_suwak_grubosci.Value = 1;
            this.bs_suwak_grubosci.Scroll += new System.EventHandler(this.bs_suwak_grubosci_Scroll);
            // 
            // bs_numeric_grubosci
            // 
            this.bs_numeric_grubosci.Location = new System.Drawing.Point(437, 225);
            this.bs_numeric_grubosci.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.bs_numeric_grubosci.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bs_numeric_grubosci.Name = "bs_numeric_grubosci";
            this.bs_numeric_grubosci.Size = new System.Drawing.Size(120, 20);
            this.bs_numeric_grubosci.TabIndex = 5;
            this.bs_numeric_grubosci.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bs_numeric_grubosci.ValueChanged += new System.EventHandler(this.bs_numeric_grubosci_ValueChanged);
            // 
            // bs_wziernik
            // 
            this.bs_wziernik.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bs_wziernik.Location = new System.Drawing.Point(437, 114);
            this.bs_wziernik.Name = "bs_wziernik";
            this.bs_wziernik.Size = new System.Drawing.Size(120, 20);
            this.bs_wziernik.TabIndex = 6;
            this.bs_wziernik.Paint += new System.Windows.Forms.PaintEventHandler(this.bs_wziernik_Paint);
            // 
            // bs_olowek
            // 
            this.bs_olowek.AutoSize = true;
            this.bs_olowek.Location = new System.Drawing.Point(31, 298);
            this.bs_olowek.Name = "bs_olowek";
            this.bs_olowek.Size = new System.Drawing.Size(59, 17);
            this.bs_olowek.TabIndex = 7;
            this.bs_olowek.TabStop = true;
            this.bs_olowek.Text = "olówek";
            this.bs_olowek.UseVisualStyleBackColor = true;
            // 
            // bs_okrag
            // 
            this.bs_okrag.AutoSize = true;
            this.bs_okrag.Location = new System.Drawing.Point(118, 298);
            this.bs_okrag.Name = "bs_okrag";
            this.bs_okrag.Size = new System.Drawing.Size(52, 17);
            this.bs_okrag.TabIndex = 8;
            this.bs_okrag.TabStop = true;
            this.bs_okrag.Text = "okrąg";
            this.bs_okrag.UseVisualStyleBackColor = true;
            // 
            // bs_prostokat
            // 
            this.bs_prostokat.AutoSize = true;
            this.bs_prostokat.Location = new System.Drawing.Point(191, 298);
            this.bs_prostokat.Name = "bs_prostokat";
            this.bs_prostokat.Size = new System.Drawing.Size(69, 17);
            this.bs_prostokat.TabIndex = 9;
            this.bs_prostokat.TabStop = true;
            this.bs_prostokat.Text = "prostokąt";
            this.bs_prostokat.UseVisualStyleBackColor = true;
            // 
            // bs_color_linii
            // 
            this.bs_color_linii.Location = new System.Drawing.Point(437, 263);
            this.bs_color_linii.Name = "bs_color_linii";
            this.bs_color_linii.Size = new System.Drawing.Size(120, 23);
            this.bs_color_linii.TabIndex = 10;
            this.bs_color_linii.Text = "color linii";
            this.bs_color_linii.UseVisualStyleBackColor = true;
            this.bs_color_linii.Click += new System.EventHandler(this.bs_color_linii_Click);
            // 
            // bs_zapisz_rysunek
            // 
            this.bs_zapisz_rysunek.Location = new System.Drawing.Point(437, 8);
            this.bs_zapisz_rysunek.Name = "bs_zapisz_rysunek";
            this.bs_zapisz_rysunek.Size = new System.Drawing.Size(99, 23);
            this.bs_zapisz_rysunek.TabIndex = 11;
            this.bs_zapisz_rysunek.Text = "zapisz rysunek";
            this.bs_zapisz_rysunek.UseVisualStyleBackColor = true;
            this.bs_zapisz_rysunek.Click += new System.EventHandler(this.bs_zapisz_rysunek_Click);
            // 
            // bs_otworz_rysunek
            // 
            this.bs_otworz_rysunek.Location = new System.Drawing.Point(437, 37);
            this.bs_otworz_rysunek.Name = "bs_otworz_rysunek";
            this.bs_otworz_rysunek.Size = new System.Drawing.Size(99, 23);
            this.bs_otworz_rysunek.TabIndex = 12;
            this.bs_otworz_rysunek.Text = "otwórz rysunek";
            this.bs_otworz_rysunek.UseVisualStyleBackColor = true;
            this.bs_otworz_rysunek.Click += new System.EventHandler(this.bs_otworz_rysunek_Click);
            // 
            // bs_kolor_tla
            // 
            this.bs_kolor_tla.Location = new System.Drawing.Point(437, 292);
            this.bs_kolor_tla.Name = "bs_kolor_tla";
            this.bs_kolor_tla.Size = new System.Drawing.Size(120, 23);
            this.bs_kolor_tla.TabIndex = 13;
            this.bs_kolor_tla.Text = "kolor tła rysownicy";
            this.bs_kolor_tla.UseVisualStyleBackColor = true;
            this.bs_kolor_tla.Click += new System.EventHandler(this.bs_kolor_tla_Click);
            // 
            // bs_style_linii
            // 
            this.bs_style_linii.FormattingEnabled = true;
            this.bs_style_linii.Items.AddRange(new object[] {
            "Dash",
            "DashDot",
            "DashDotDot",
            "Dot",
            "Solid"});
            this.bs_style_linii.Location = new System.Drawing.Point(437, 67);
            this.bs_style_linii.Name = "bs_style_linii";
            this.bs_style_linii.Size = new System.Drawing.Size(121, 21);
            this.bs_style_linii.TabIndex = 14;
            this.bs_style_linii.SelectedIndexChanged += new System.EventHandler(this.bs_style_linii_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "x:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "y:";
            // 
            // bs_pulpit_paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 327);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bs_style_linii);
            this.Controls.Add(this.bs_kolor_tla);
            this.Controls.Add(this.bs_otworz_rysunek);
            this.Controls.Add(this.bs_zapisz_rysunek);
            this.Controls.Add(this.bs_color_linii);
            this.Controls.Add(this.bs_prostokat);
            this.Controls.Add(this.bs_okrag);
            this.Controls.Add(this.bs_olowek);
            this.Controls.Add(this.bs_wziernik);
            this.Controls.Add(this.bs_numeric_grubosci);
            this.Controls.Add(this.bs_suwak_grubosci);
            this.Controls.Add(this.bs_rysownica);
            this.Controls.Add(this.bs_wspolrzedna_y);
            this.Controls.Add(this.bs_wspolrzedna_x);
            this.Controls.Add(this.bs_wspolrzedne);
            this.Name = "bs_pulpit_paint";
            this.Text = "Program Paint";
            ((System.ComponentModel.ISupportInitialize)(this.bs_rysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_suwak_grubosci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_numeric_grubosci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bs_wspolrzedne;
        private System.Windows.Forms.Label bs_wspolrzedna_x;
        private System.Windows.Forms.Label bs_wspolrzedna_y;
        private System.Windows.Forms.PictureBox bs_rysownica;
        private System.Windows.Forms.TrackBar bs_suwak_grubosci;
        private System.Windows.Forms.NumericUpDown bs_numeric_grubosci;
        private System.Windows.Forms.Panel bs_wziernik;
        private System.Windows.Forms.RadioButton bs_olowek;
        private System.Windows.Forms.RadioButton bs_okrag;
        private System.Windows.Forms.RadioButton bs_prostokat;
        private System.Windows.Forms.Button bs_color_linii;
        private System.Windows.Forms.Button bs_zapisz_rysunek;
        private System.Windows.Forms.Button bs_otworz_rysunek;
        private System.Windows.Forms.Button bs_kolor_tla;
        private System.Windows.Forms.ComboBox bs_style_linii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

