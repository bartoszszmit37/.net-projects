namespace konwersja_liczb
{
    partial class NumbersConverter
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lewa_lista = new System.Windows.Forms.ComboBox();
            this.prawa_lista = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wynik_po_konwersji = new System.Windows.Forms.Label();
            this.wpisz_liczbe = new System.Windows.Forms.TextBox();
            this.btnResetuj = new System.Windows.Forms.Button();
            this.konwertuj = new System.Windows.Forms.Button();
            this.koniec_programu = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.etykieta_prawa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(54, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Konwerter liczb przy różnej podstawie systemu liczbowego";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "wybierz system";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "wybierz system";
            // 
            // lewa_lista
            // 
            this.lewa_lista.FormattingEnabled = true;
            this.lewa_lista.Items.AddRange(new object[] {
            "dziesiętny",
            "oktalny (8)",
            "szesnastkowy",
            "binarny"});
            this.lewa_lista.Location = new System.Drawing.Point(46, 122);
            this.lewa_lista.Name = "lewa_lista";
            this.lewa_lista.Size = new System.Drawing.Size(167, 21);
            this.lewa_lista.TabIndex = 3;
            this.lewa_lista.Text = "Podstawa systemu liczbowego";
            // 
            // prawa_lista
            // 
            this.prawa_lista.FormattingEnabled = true;
            this.prawa_lista.Items.AddRange(new object[] {
            "dziesiętny",
            "oktalny (8)",
            "szesnastkowy",
            "binarny"});
            this.prawa_lista.Location = new System.Drawing.Point(351, 122);
            this.prawa_lista.Name = "prawa_lista";
            this.prawa_lista.Size = new System.Drawing.Size(167, 21);
            this.prawa_lista.TabIndex = 4;
            this.prawa_lista.Text = "Podstawa systemu liczbowego";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "wprowadz liczbe";
            // 
            // wynik_po_konwersji
            // 
            this.wynik_po_konwersji.AutoSize = true;
            this.wynik_po_konwersji.BackColor = System.Drawing.SystemColors.Highlight;
            this.wynik_po_konwersji.Location = new System.Drawing.Point(378, 201);
            this.wynik_po_konwersji.MinimumSize = new System.Drawing.Size(100, 0);
            this.wynik_po_konwersji.Name = "wynik_po_konwersji";
            this.wynik_po_konwersji.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.wynik_po_konwersji.Size = new System.Drawing.Size(100, 23);
            this.wynik_po_konwersji.TabIndex = 6;
            // 
            // wpisz_liczbe
            // 
            this.wpisz_liczbe.Location = new System.Drawing.Point(78, 201);
            this.wpisz_liczbe.Name = "wpisz_liczbe";
            this.wpisz_liczbe.Size = new System.Drawing.Size(100, 20);
            this.wpisz_liczbe.TabIndex = 7;
            // 
            // btnResetuj
            // 
            this.btnResetuj.Location = new System.Drawing.Point(137, 239);
            this.btnResetuj.Name = "btnResetuj";
            this.btnResetuj.Size = new System.Drawing.Size(75, 23);
            this.btnResetuj.TabIndex = 8;
            this.btnResetuj.Text = "resetuj";
            this.btnResetuj.UseVisualStyleBackColor = true;
            this.btnResetuj.Click += new System.EventHandler(this.btnResetuj_Click);
            // 
            // konwertuj
            // 
            this.konwertuj.Location = new System.Drawing.Point(281, 239);
            this.konwertuj.Name = "konwertuj";
            this.konwertuj.Size = new System.Drawing.Size(75, 23);
            this.konwertuj.TabIndex = 9;
            this.konwertuj.Text = "konwertuj";
            this.konwertuj.UseVisualStyleBackColor = true;
            this.konwertuj.Click += new System.EventHandler(this.konwertuj_Click);
            // 
            // koniec_programu
            // 
            this.koniec_programu.Location = new System.Drawing.Point(418, 239);
            this.koniec_programu.Name = "koniec_programu";
            this.koniec_programu.Size = new System.Drawing.Size(100, 23);
            this.koniec_programu.TabIndex = 10;
            this.koniec_programu.Text = "koniec programu";
            this.koniec_programu.UseVisualStyleBackColor = true;
            this.koniec_programu.Click += new System.EventHandler(this.koniec_programu_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // etykieta_prawa
            // 
            this.etykieta_prawa.AutoSize = true;
            this.etykieta_prawa.Location = new System.Drawing.Point(381, 165);
            this.etykieta_prawa.Name = "etykieta_prawa";
            this.etykieta_prawa.Size = new System.Drawing.Size(96, 13);
            this.etykieta_prawa.TabIndex = 11;
            this.etykieta_prawa.Text = "liczba po konwersji";
            // 
            // konwerter_liczb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 318);
            this.Controls.Add(this.etykieta_prawa);
            this.Controls.Add(this.koniec_programu);
            this.Controls.Add(this.konwertuj);
            this.Controls.Add(this.btnResetuj);
            this.Controls.Add(this.wpisz_liczbe);
            this.Controls.Add(this.wynik_po_konwersji);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prawa_lista);
            this.Controls.Add(this.lewa_lista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "konwerter_liczb";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.konwerter_liczb_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lewa_lista;
        private System.Windows.Forms.ComboBox prawa_lista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label wynik_po_konwersji;
        private System.Windows.Forms.TextBox wpisz_liczbe;
        private System.Windows.Forms.Button btnResetuj;
        private System.Windows.Forms.Button konwertuj;
        private System.Windows.Forms.Button koniec_programu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label etykieta_prawa;
    }
}

