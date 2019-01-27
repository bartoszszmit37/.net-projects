namespace bankom1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioUstawieniaLosowe = new System.Windows.Forms.RadioButton();
            this.radioSt25 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tytul = new System.Windows.Forms.Label();
            this.bs_cmbRodzajWaluty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.komunikat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wyzeruj = new System.Windows.Forms.Button();
            this.rezygnacja = new System.Windows.Forms.Button();
            this.akceptacja = new System.Windows.Forms.Button();
            this.bs_kwota_do_wyplaty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bankomat2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.bs_wyplacona_kwota_komunikat = new System.Windows.Forms.Label();
            this.bs_wyplacona_kwota_left = new System.Windows.Forms.Label();
            this.bs_komunikat_koncowy = new System.Windows.Forms.Label();
            this.bs_koniec = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bs_wyplac = new System.Windows.Forms.Button();
            this.dgwListaWyplaty = new System.Windows.Forms.DataGridView();
            this.ilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waluta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListaWyplaty)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 368);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tytul);
            this.tabPage1.Controls.Add(this.bs_cmbRodzajWaluty);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(664, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Konfigurowanie bankomatu";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Bartosz Szmit nr. albumu: 41965 ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioUstawieniaLosowe);
            this.groupBox1.Controls.Add(this.radioSt25);
            this.groupBox1.Location = new System.Drawing.Point(149, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "wybierz (kliknięciem) liczność nominałów w bankomacie";
            // 
            // radioUstawieniaLosowe
            // 
            this.radioUstawieniaLosowe.AutoSize = true;
            this.radioUstawieniaLosowe.Location = new System.Drawing.Point(238, 38);
            this.radioUstawieniaLosowe.Name = "radioUstawieniaLosowe";
            this.radioUstawieniaLosowe.Size = new System.Drawing.Size(206, 17);
            this.radioUstawieniaLosowe.TabIndex = 1;
            this.radioUstawieniaLosowe.TabStop = true;
            this.radioUstawieniaLosowe.Text = "losowe generowanie liczby nominałów";
            this.radioUstawieniaLosowe.UseVisualStyleBackColor = true;
            this.radioUstawieniaLosowe.CheckedChanged += new System.EventHandler(this.radioUstawieniaLosowe_CheckedChanged);
            // 
            // radioSt25
            // 
            this.radioSt25.AutoSize = true;
            this.radioSt25.Location = new System.Drawing.Point(29, 38);
            this.radioSt25.Name = "radioSt25";
            this.radioSt25.Size = new System.Drawing.Size(163, 17);
            this.radioSt25.TabIndex = 0;
            this.radioSt25.TabStop = true;
            this.radioSt25.Text = "liczność ustawiona domyślnie";
            this.radioSt25.UseVisualStyleBackColor = true;
            this.radioSt25.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(192, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "(zarzadzanie wypłatą gotówki bankomatu)";
            // 
            // tytul
            // 
            this.tytul.AutoSize = true;
            this.tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tytul.Location = new System.Drawing.Point(241, 13);
            this.tytul.MaximumSize = new System.Drawing.Size(300, 0);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(105, 20);
            this.tytul.TabIndex = 2;
            this.tytul.Text = "BANKOMAT";
            // 
            // bs_cmbRodzajWaluty
            // 
            this.bs_cmbRodzajWaluty.FormattingEnabled = true;
            this.bs_cmbRodzajWaluty.Items.AddRange(new object[] {
            "PLN",
            "USD"});
            this.bs_cmbRodzajWaluty.Location = new System.Drawing.Point(27, 115);
            this.bs_cmbRodzajWaluty.Name = "bs_cmbRodzajWaluty";
            this.bs_cmbRodzajWaluty.Size = new System.Drawing.Size(72, 21);
            this.bs_cmbRodzajWaluty.TabIndex = 1;
            this.bs_cmbRodzajWaluty.Text = "lista walut";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "wybierz rodzaj waluty";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.YellowGreen;
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.komunikat);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.wyzeruj);
            this.tabPage2.Controls.Add(this.rezygnacja);
            this.tabPage2.Controls.Add(this.akceptacja);
            this.tabPage2.Controls.Add(this.bs_kwota_do_wyplaty);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.bankomat2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(664, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "zlecenie wyplaty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Bartosz Szmit nr. albumu: 41965 ";
            // 
            // komunikat
            // 
            this.komunikat.AutoSize = true;
            this.komunikat.Location = new System.Drawing.Point(137, 170);
            this.komunikat.Name = "komunikat";
            this.komunikat.Size = new System.Drawing.Size(0, 13);
            this.komunikat.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "(zarządzanie wypłatą gotówki w bankowacie)";
            // 
            // wyzeruj
            // 
            this.wyzeruj.Location = new System.Drawing.Point(429, 88);
            this.wyzeruj.Name = "wyzeruj";
            this.wyzeruj.Size = new System.Drawing.Size(75, 37);
            this.wyzeruj.TabIndex = 6;
            this.wyzeruj.Text = "wyzeruj";
            this.wyzeruj.UseVisualStyleBackColor = true;
            this.wyzeruj.Click += new System.EventHandler(this.wyzeruj_Click);
            // 
            // rezygnacja
            // 
            this.rezygnacja.Location = new System.Drawing.Point(521, 88);
            this.rezygnacja.Name = "rezygnacja";
            this.rezygnacja.Size = new System.Drawing.Size(75, 37);
            this.rezygnacja.TabIndex = 5;
            this.rezygnacja.Text = "rezygnacja";
            this.rezygnacja.UseVisualStyleBackColor = true;
            this.rezygnacja.Click += new System.EventHandler(this.rezygnacja_Click);
            // 
            // akceptacja
            // 
            this.akceptacja.Location = new System.Drawing.Point(328, 88);
            this.akceptacja.Name = "akceptacja";
            this.akceptacja.Size = new System.Drawing.Size(83, 37);
            this.akceptacja.TabIndex = 3;
            this.akceptacja.Text = "akceptacja";
            this.akceptacja.UseVisualStyleBackColor = true;
            this.akceptacja.Click += new System.EventHandler(this.akceptacja_Click);
            // 
            // bs_kwota_do_wyplaty
            // 
            this.bs_kwota_do_wyplaty.Location = new System.Drawing.Point(210, 92);
            this.bs_kwota_do_wyplaty.Name = "bs_kwota_do_wyplaty";
            this.bs_kwota_do_wyplaty.Size = new System.Drawing.Size(100, 20);
            this.bs_kwota_do_wyplaty.TabIndex = 2;
            this.bs_kwota_do_wyplaty.TextChanged += new System.EventHandler(this.kwota_do_wyplaty_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(59, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Wpisz kwotę do wypłaty";
            // 
            // bankomat2
            // 
            this.bankomat2.AutoSize = true;
            this.bankomat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bankomat2.Location = new System.Drawing.Point(241, 13);
            this.bankomat2.Name = "bankomat2";
            this.bankomat2.Size = new System.Drawing.Size(105, 20);
            this.bankomat2.TabIndex = 0;
            this.bankomat2.Text = "BANKOMAT";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Chocolate;
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.bs_wyplacona_kwota_komunikat);
            this.tabPage3.Controls.Add(this.bs_wyplacona_kwota_left);
            this.tabPage3.Controls.Add(this.bs_komunikat_koncowy);
            this.tabPage3.Controls.Add(this.bs_koniec);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.bs_wyplac);
            this.tabPage3.Controls.Add(this.dgwListaWyplaty);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(664, 342);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "wyplata nominałów";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Bartosz Szmit nr. albumu: 41965 ";
            // 
            // bs_wyplacona_kwota_komunikat
            // 
            this.bs_wyplacona_kwota_komunikat.AutoSize = true;
            this.bs_wyplacona_kwota_komunikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bs_wyplacona_kwota_komunikat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bs_wyplacona_kwota_komunikat.Location = new System.Drawing.Point(291, 73);
            this.bs_wyplacona_kwota_komunikat.Name = "bs_wyplacona_kwota_komunikat";
            this.bs_wyplacona_kwota_komunikat.Size = new System.Drawing.Size(0, 20);
            this.bs_wyplacona_kwota_komunikat.TabIndex = 7;
            this.bs_wyplacona_kwota_komunikat.Visible = false;
            // 
            // bs_wyplacona_kwota_left
            // 
            this.bs_wyplacona_kwota_left.AutoSize = true;
            this.bs_wyplacona_kwota_left.Location = new System.Drawing.Point(177, 73);
            this.bs_wyplacona_kwota_left.Name = "bs_wyplacona_kwota_left";
            this.bs_wyplacona_kwota_left.Size = new System.Drawing.Size(96, 13);
            this.bs_wyplacona_kwota_left.TabIndex = 6;
            this.bs_wyplacona_kwota_left.Text = "Wyplacona kwota:";
            this.bs_wyplacona_kwota_left.Visible = false;
            // 
            // bs_komunikat_koncowy
            // 
            this.bs_komunikat_koncowy.AutoSize = true;
            this.bs_komunikat_koncowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bs_komunikat_koncowy.Location = new System.Drawing.Point(173, 103);
            this.bs_komunikat_koncowy.Name = "bs_komunikat_koncowy";
            this.bs_komunikat_koncowy.Size = new System.Drawing.Size(244, 20);
            this.bs_komunikat_koncowy.TabIndex = 5;
            this.bs_komunikat_koncowy.Text = "Lista wypłaconych nominałów";
            this.bs_komunikat_koncowy.Visible = false;
            // 
            // bs_koniec
            // 
            this.bs_koniec.Location = new System.Drawing.Point(556, 179);
            this.bs_koniec.Name = "bs_koniec";
            this.bs_koniec.Size = new System.Drawing.Size(75, 23);
            this.bs_koniec.TabIndex = 4;
            this.bs_koniec.Text = "koniec";
            this.bs_koniec.UseVisualStyleBackColor = true;
            this.bs_koniec.Visible = false;
            this.bs_koniec.Click += new System.EventHandler(this.bs_koniec_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "(zarządzanie wypłatą gotówki bankomatu)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(241, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "BANKOMAT";
            // 
            // bs_wyplac
            // 
            this.bs_wyplac.Location = new System.Drawing.Point(556, 141);
            this.bs_wyplac.Name = "bs_wyplac";
            this.bs_wyplac.Size = new System.Drawing.Size(75, 23);
            this.bs_wyplac.TabIndex = 1;
            this.bs_wyplac.Text = "wypłać";
            this.bs_wyplac.UseVisualStyleBackColor = true;
            this.bs_wyplac.Click += new System.EventHandler(this.resetuj_Click);
            // 
            // dgwListaWyplaty
            // 
            this.dgwListaWyplaty.AllowUserToOrderColumns = true;
            this.dgwListaWyplaty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListaWyplaty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ilosc,
            this.nominal,
            this.rodzaj,
            this.waluta});
            this.dgwListaWyplaty.Location = new System.Drawing.Point(78, 141);
            this.dgwListaWyplaty.Name = "dgwListaWyplaty";
            this.dgwListaWyplaty.ReadOnly = true;
            this.dgwListaWyplaty.Size = new System.Drawing.Size(446, 169);
            this.dgwListaWyplaty.TabIndex = 0;
            // 
            // ilosc
            // 
            this.ilosc.HeaderText = "ilosc";
            this.ilosc.Name = "ilosc";
            this.ilosc.ReadOnly = true;
            // 
            // nominal
            // 
            this.nominal.HeaderText = "nominal";
            this.nominal.Name = "nominal";
            this.nominal.ReadOnly = true;
            // 
            // rodzaj
            // 
            this.rodzaj.HeaderText = "rodzaj";
            this.rodzaj.Name = "rodzaj";
            this.rodzaj.ReadOnly = true;
            // 
            // waluta
            // 
            this.waluta.HeaderText = "waluta";
            this.waluta.Name = "waluta";
            this.waluta.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 372);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Bankomat formularzowy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListaWyplaty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bs_cmbRodzajWaluty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tytul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSt25;
        private System.Windows.Forms.RadioButton radioUstawieniaLosowe;
        private System.Windows.Forms.DataGridView dgwListaWyplaty;
        private System.Windows.Forms.Label bankomat2;
        private System.Windows.Forms.Button rezygnacja;
        private System.Windows.Forms.Button akceptacja;
        private System.Windows.Forms.TextBox bs_kwota_do_wyplaty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bs_wyplac;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodzaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn waluta;
        private System.Windows.Forms.Button wyzeruj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label komunikat;
        private System.Windows.Forms.Button bs_koniec;
        private System.Windows.Forms.Label bs_komunikat_koncowy;
        private System.Windows.Forms.Label bs_wyplacona_kwota_komunikat;
        private System.Windows.Forms.Label bs_wyplacona_kwota_left;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

