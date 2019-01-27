namespace projekt_wykresow_funkcji
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pole_wykresu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.naglowek_wykresu_funkcji = new System.Windows.Forms.Label();
            this.etykieta_funkcji_liniowej = new System.Windows.Forms.Label();
            this.etykieta_y_liniowej = new System.Windows.Forms.Label();
            this.liniowy_wspolczynnik_a = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.liniowy_wspolczynnik_b = new System.Windows.Forms.TextBox();
            this.polecenie_zaznaczenia_funkcji = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wspolczynnik_kwadratowy_a = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wspolczynnik_kwadratowy_b = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.wspolczynnik_kwadratowy_c = new System.Windows.Forms.TextBox();
            this.aktywuj_funkcje_liniowa = new System.Windows.Forms.Button();
            this.aktywuj_funkcje_kwadratowa = new System.Windows.Forms.Button();
            this.etykieta_funkcji_wielomianowej = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.wspolczynnik_wielomianowy_a = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.wspolczynnik_wielomianowy_b = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.wspolczynnik_wielomianowy_c = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.wspolczynnik_wielomianowy_d = new System.Windows.Forms.TextBox();
            this.aktywuj_funkcje_wielomianowa = new System.Windows.Forms.Button();
            this.resetuj = new System.Windows.Forms.Button();
            this.rysuj_funkcje_liniowa = new System.Windows.Forms.Button();
            this.rysuj_funkcje_kwadratowa = new System.Windows.Forms.Button();
            this.rysuj_funkcje_wielomianowa = new System.Windows.Forms.Button();
            this.tresc_bledu = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.etykieta_potegi_kwadratowej = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pole_wykresu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // pole_wykresu
            // 
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "pozycja_osi";
            this.pole_wykresu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pole_wykresu.Legends.Add(legend1);
            this.pole_wykresu.Location = new System.Drawing.Point(406, 60);
            this.pole_wykresu.Name = "pole_wykresu";
            series1.ChartArea = "pozycja_osi";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "wykres";
            this.pole_wykresu.Series.Add(series1);
            this.pole_wykresu.Size = new System.Drawing.Size(300, 300);
            this.pole_wykresu.TabIndex = 0;
            this.pole_wykresu.Text = "chart1";
            // 
            // naglowek_wykresu_funkcji
            // 
            this.naglowek_wykresu_funkcji.AutoSize = true;
            this.naglowek_wykresu_funkcji.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naglowek_wykresu_funkcji.Location = new System.Drawing.Point(416, 19);
            this.naglowek_wykresu_funkcji.Name = "naglowek_wykresu_funkcji";
            this.naglowek_wykresu_funkcji.Size = new System.Drawing.Size(281, 24);
            this.naglowek_wykresu_funkcji.TabIndex = 1;
            this.naglowek_wykresu_funkcji.Text = "WYKRES WYBRANEJ FUNKCJI";
            // 
            // etykieta_funkcji_liniowej
            // 
            this.etykieta_funkcji_liniowej.AutoSize = true;
            this.etykieta_funkcji_liniowej.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.etykieta_funkcji_liniowej.Location = new System.Drawing.Point(33, 71);
            this.etykieta_funkcji_liniowej.Name = "etykieta_funkcji_liniowej";
            this.etykieta_funkcji_liniowej.Size = new System.Drawing.Size(124, 20);
            this.etykieta_funkcji_liniowej.TabIndex = 2;
            this.etykieta_funkcji_liniowej.Text = "Funkcja liniowa: ";
            // 
            // etykieta_y_liniowej
            // 
            this.etykieta_y_liniowej.AutoSize = true;
            this.etykieta_y_liniowej.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.etykieta_y_liniowej.Location = new System.Drawing.Point(12, 105);
            this.etykieta_y_liniowej.Name = "etykieta_y_liniowej";
            this.etykieta_y_liniowej.Size = new System.Drawing.Size(33, 20);
            this.etykieta_y_liniowej.TabIndex = 3;
            this.etykieta_y_liniowej.Text = "Y =";
            // 
            // liniowy_wspolczynnik_a
            // 
            this.liniowy_wspolczynnik_a.Enabled = false;
            this.liniowy_wspolczynnik_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.liniowy_wspolczynnik_a.Location = new System.Drawing.Point(52, 104);
            this.liniowy_wspolczynnik_a.Name = "liniowy_wspolczynnik_a";
            this.liniowy_wspolczynnik_a.Size = new System.Drawing.Size(23, 23);
            this.liniowy_wspolczynnik_a.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(81, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "* X +";
            // 
            // liniowy_wspolczynnik_b
            // 
            this.liniowy_wspolczynnik_b.Enabled = false;
            this.liniowy_wspolczynnik_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.liniowy_wspolczynnik_b.Location = new System.Drawing.Point(130, 105);
            this.liniowy_wspolczynnik_b.Name = "liniowy_wspolczynnik_b";
            this.liniowy_wspolczynnik_b.Size = new System.Drawing.Size(26, 23);
            this.liniowy_wspolczynnik_b.TabIndex = 6;
            // 
            // polecenie_zaznaczenia_funkcji
            // 
            this.polecenie_zaznaczenia_funkcji.AutoSize = true;
            this.polecenie_zaznaczenia_funkcji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.polecenie_zaznaczenia_funkcji.Location = new System.Drawing.Point(253, 71);
            this.polecenie_zaznaczenia_funkcji.Name = "polecenie_zaznaczenia_funkcji";
            this.polecenie_zaznaczenia_funkcji.Size = new System.Drawing.Size(104, 17);
            this.polecenie_zaznaczenia_funkcji.TabIndex = 7;
            this.polecenie_zaznaczenia_funkcji.Text = "Aktywuj funkcję";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(32, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Funkcja kwadratowa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(11, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Y =";
            // 
            // wspolczynnik_kwadratowy_a
            // 
            this.wspolczynnik_kwadratowy_a.Enabled = false;
            this.wspolczynnik_kwadratowy_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wspolczynnik_kwadratowy_a.Location = new System.Drawing.Point(52, 171);
            this.wspolczynnik_kwadratowy_a.Name = "wspolczynnik_kwadratowy_a";
            this.wspolczynnik_kwadratowy_a.Size = new System.Drawing.Size(23, 23);
            this.wspolczynnik_kwadratowy_a.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(81, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "* X+";
            // 
            // wspolczynnik_kwadratowy_b
            // 
            this.wspolczynnik_kwadratowy_b.Enabled = false;
            this.wspolczynnik_kwadratowy_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wspolczynnik_kwadratowy_b.Location = new System.Drawing.Point(134, 171);
            this.wspolczynnik_kwadratowy_b.Name = "wspolczynnik_kwadratowy_b";
            this.wspolczynnik_kwadratowy_b.Size = new System.Drawing.Size(23, 23);
            this.wspolczynnik_kwadratowy_b.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(163, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "* X +";
            // 
            // wspolczynnik_kwadratowy_c
            // 
            this.wspolczynnik_kwadratowy_c.Enabled = false;
            this.wspolczynnik_kwadratowy_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wspolczynnik_kwadratowy_c.Location = new System.Drawing.Point(212, 171);
            this.wspolczynnik_kwadratowy_c.Name = "wspolczynnik_kwadratowy_c";
            this.wspolczynnik_kwadratowy_c.Size = new System.Drawing.Size(23, 23);
            this.wspolczynnik_kwadratowy_c.TabIndex = 15;
            // 
            // aktywuj_funkcje_liniowa
            // 
            this.aktywuj_funkcje_liniowa.Location = new System.Drawing.Point(268, 105);
            this.aktywuj_funkcje_liniowa.Name = "aktywuj_funkcje_liniowa";
            this.aktywuj_funkcje_liniowa.Size = new System.Drawing.Size(75, 23);
            this.aktywuj_funkcje_liniowa.TabIndex = 16;
            this.aktywuj_funkcje_liniowa.Text = "aktywuj";
            this.aktywuj_funkcje_liniowa.UseVisualStyleBackColor = true;
            this.aktywuj_funkcje_liniowa.Click += new System.EventHandler(this.aktywuj_funkcje_liniowa_Click);
            // 
            // aktywuj_funkcje_kwadratowa
            // 
            this.aktywuj_funkcje_kwadratowa.Location = new System.Drawing.Point(268, 171);
            this.aktywuj_funkcje_kwadratowa.Name = "aktywuj_funkcje_kwadratowa";
            this.aktywuj_funkcje_kwadratowa.Size = new System.Drawing.Size(75, 23);
            this.aktywuj_funkcje_kwadratowa.TabIndex = 17;
            this.aktywuj_funkcje_kwadratowa.Text = "aktywuj";
            this.aktywuj_funkcje_kwadratowa.UseVisualStyleBackColor = true;
            this.aktywuj_funkcje_kwadratowa.Click += new System.EventHandler(this.aktywuj_funkcje_kwadratowa_Click);
            // 
            // etykieta_funkcji_wielomianowej
            // 
            this.etykieta_funkcji_wielomianowej.AutoSize = true;
            this.etykieta_funkcji_wielomianowej.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.etykieta_funkcji_wielomianowej.Location = new System.Drawing.Point(32, 206);
            this.etykieta_funkcji_wielomianowej.Name = "etykieta_funkcji_wielomianowej";
            this.etykieta_funkcji_wielomianowej.Size = new System.Drawing.Size(167, 20);
            this.etykieta_funkcji_wielomianowej.TabIndex = 18;
            this.etykieta_funkcji_wielomianowej.Text = "Funkcja wielomianowa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(11, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Y =";
            // 
            // wspolczynnik_wielomianowy_a
            // 
            this.wspolczynnik_wielomianowy_a.Enabled = false;
            this.wspolczynnik_wielomianowy_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wspolczynnik_wielomianowy_a.Location = new System.Drawing.Point(50, 237);
            this.wspolczynnik_wielomianowy_a.Name = "wspolczynnik_wielomianowy_a";
            this.wspolczynnik_wielomianowy_a.Size = new System.Drawing.Size(23, 23);
            this.wspolczynnik_wielomianowy_a.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(81, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "* X +";
            // 
            // wspolczynnik_wielomianowy_b
            // 
            this.wspolczynnik_wielomianowy_b.Enabled = false;
            this.wspolczynnik_wielomianowy_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wspolczynnik_wielomianowy_b.Location = new System.Drawing.Point(146, 237);
            this.wspolczynnik_wielomianowy_b.Name = "wspolczynnik_wielomianowy_b";
            this.wspolczynnik_wielomianowy_b.Size = new System.Drawing.Size(23, 23);
            this.wspolczynnik_wielomianowy_b.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(175, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "* X +";
            // 
            // wspolczynnik_wielomianowy_c
            // 
            this.wspolczynnik_wielomianowy_c.Enabled = false;
            this.wspolczynnik_wielomianowy_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wspolczynnik_wielomianowy_c.Location = new System.Drawing.Point(117, 283);
            this.wspolczynnik_wielomianowy_c.Name = "wspolczynnik_wielomianowy_c";
            this.wspolczynnik_wielomianowy_c.Size = new System.Drawing.Size(23, 23);
            this.wspolczynnik_wielomianowy_c.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(146, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "* X +";
            // 
            // wspolczynnik_wielomianowy_d
            // 
            this.wspolczynnik_wielomianowy_d.Enabled = false;
            this.wspolczynnik_wielomianowy_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wspolczynnik_wielomianowy_d.Location = new System.Drawing.Point(195, 283);
            this.wspolczynnik_wielomianowy_d.Name = "wspolczynnik_wielomianowy_d";
            this.wspolczynnik_wielomianowy_d.Size = new System.Drawing.Size(23, 23);
            this.wspolczynnik_wielomianowy_d.TabIndex = 26;
            // 
            // aktywuj_funkcje_wielomianowa
            // 
            this.aktywuj_funkcje_wielomianowa.Location = new System.Drawing.Point(268, 240);
            this.aktywuj_funkcje_wielomianowa.Name = "aktywuj_funkcje_wielomianowa";
            this.aktywuj_funkcje_wielomianowa.Size = new System.Drawing.Size(75, 23);
            this.aktywuj_funkcje_wielomianowa.TabIndex = 27;
            this.aktywuj_funkcje_wielomianowa.Text = "aktywuj";
            this.aktywuj_funkcje_wielomianowa.UseVisualStyleBackColor = true;
            this.aktywuj_funkcje_wielomianowa.Click += new System.EventHandler(this.aktywuj_funkcje_wielomianowa_Click);
            // 
            // resetuj
            // 
            this.resetuj.Location = new System.Drawing.Point(268, 295);
            this.resetuj.Name = "resetuj";
            this.resetuj.Size = new System.Drawing.Size(75, 23);
            this.resetuj.TabIndex = 28;
            this.resetuj.Text = "resetuj";
            this.resetuj.UseVisualStyleBackColor = true;
            this.resetuj.Click += new System.EventHandler(this.resetuj_Click);
            // 
            // rysuj_funkcje_liniowa
            // 
            this.rysuj_funkcje_liniowa.Enabled = false;
            this.rysuj_funkcje_liniowa.Location = new System.Drawing.Point(352, 105);
            this.rysuj_funkcje_liniowa.Name = "rysuj_funkcje_liniowa";
            this.rysuj_funkcje_liniowa.Size = new System.Drawing.Size(37, 23);
            this.rysuj_funkcje_liniowa.TabIndex = 29;
            this.rysuj_funkcje_liniowa.Text = "rysuj";
            this.rysuj_funkcje_liniowa.UseVisualStyleBackColor = true;
            this.rysuj_funkcje_liniowa.Click += new System.EventHandler(this.rysuj_funkcje_liniowa_Click);
            // 
            // rysuj_funkcje_kwadratowa
            // 
            this.rysuj_funkcje_kwadratowa.Enabled = false;
            this.rysuj_funkcje_kwadratowa.Location = new System.Drawing.Point(352, 171);
            this.rysuj_funkcje_kwadratowa.Name = "rysuj_funkcje_kwadratowa";
            this.rysuj_funkcje_kwadratowa.Size = new System.Drawing.Size(37, 23);
            this.rysuj_funkcje_kwadratowa.TabIndex = 30;
            this.rysuj_funkcje_kwadratowa.Text = "rysuj";
            this.rysuj_funkcje_kwadratowa.UseVisualStyleBackColor = true;
            this.rysuj_funkcje_kwadratowa.Click += new System.EventHandler(this.rysuj_funkcje_kwadratowa_Click);
            // 
            // rysuj_funkcje_wielomianowa
            // 
            this.rysuj_funkcje_wielomianowa.Enabled = false;
            this.rysuj_funkcje_wielomianowa.Location = new System.Drawing.Point(352, 240);
            this.rysuj_funkcje_wielomianowa.Name = "rysuj_funkcje_wielomianowa";
            this.rysuj_funkcje_wielomianowa.Size = new System.Drawing.Size(37, 23);
            this.rysuj_funkcje_wielomianowa.TabIndex = 31;
            this.rysuj_funkcje_wielomianowa.Text = "rysuj";
            this.rysuj_funkcje_wielomianowa.UseVisualStyleBackColor = true;
            this.rysuj_funkcje_wielomianowa.Click += new System.EventHandler(this.rysuj_funkcje_wielomianowa_Click);
            // 
            // tresc_bledu
            // 
            this.tresc_bledu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tresc_bledu.Location = new System.Drawing.Point(37, 12);
            this.tresc_bledu.Name = "tresc_bledu";
            this.tresc_bledu.Size = new System.Drawing.Size(100, 26);
            this.tresc_bledu.TabIndex = 32;
            this.tresc_bledu.Text = "tresc blędu";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // etykieta_potegi_kwadratowej
            // 
            this.etykieta_potegi_kwadratowej.AutoSize = true;
            this.etykieta_potegi_kwadratowej.Location = new System.Drawing.Point(107, 161);
            this.etykieta_potegi_kwadratowej.Name = "etykieta_potegi_kwadratowej";
            this.etykieta_potegi_kwadratowej.Size = new System.Drawing.Size(13, 13);
            this.etykieta_potegi_kwadratowej.TabIndex = 33;
            this.etykieta_potegi_kwadratowej.Text = "2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(107, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(205, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 383);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.etykieta_potegi_kwadratowej);
            this.Controls.Add(this.tresc_bledu);
            this.Controls.Add(this.rysuj_funkcje_wielomianowa);
            this.Controls.Add(this.rysuj_funkcje_kwadratowa);
            this.Controls.Add(this.rysuj_funkcje_liniowa);
            this.Controls.Add(this.resetuj);
            this.Controls.Add(this.aktywuj_funkcje_wielomianowa);
            this.Controls.Add(this.wspolczynnik_wielomianowy_d);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.wspolczynnik_wielomianowy_c);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.wspolczynnik_wielomianowy_b);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.wspolczynnik_wielomianowy_a);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.etykieta_funkcji_wielomianowej);
            this.Controls.Add(this.aktywuj_funkcje_kwadratowa);
            this.Controls.Add(this.aktywuj_funkcje_liniowa);
            this.Controls.Add(this.wspolczynnik_kwadratowy_c);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wspolczynnik_kwadratowy_b);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wspolczynnik_kwadratowy_a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.polecenie_zaznaczenia_funkcji);
            this.Controls.Add(this.liniowy_wspolczynnik_b);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.liniowy_wspolczynnik_a);
            this.Controls.Add(this.etykieta_y_liniowej);
            this.Controls.Add(this.etykieta_funkcji_liniowej);
            this.Controls.Add(this.naglowek_wykresu_funkcji);
            this.Controls.Add(this.pole_wykresu);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pole_wykresu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart pole_wykresu;
        private System.Windows.Forms.Label naglowek_wykresu_funkcji;
        private System.Windows.Forms.Label etykieta_funkcji_liniowej;
        private System.Windows.Forms.Label etykieta_y_liniowej;
        private System.Windows.Forms.TextBox liniowy_wspolczynnik_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox liniowy_wspolczynnik_b;
        private System.Windows.Forms.Label polecenie_zaznaczenia_funkcji;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox wspolczynnik_kwadratowy_a;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox wspolczynnik_kwadratowy_b;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox wspolczynnik_kwadratowy_c;
        private System.Windows.Forms.Button aktywuj_funkcje_liniowa;
        private System.Windows.Forms.Button aktywuj_funkcje_kwadratowa;
        private System.Windows.Forms.Label etykieta_funkcji_wielomianowej;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox wspolczynnik_wielomianowy_a;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox wspolczynnik_wielomianowy_b;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox wspolczynnik_wielomianowy_c;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox wspolczynnik_wielomianowy_d;
        private System.Windows.Forms.Button aktywuj_funkcje_wielomianowa;
        private System.Windows.Forms.Button resetuj;
        private System.Windows.Forms.Button rysuj_funkcje_liniowa;
        private System.Windows.Forms.Button rysuj_funkcje_kwadratowa;
        private System.Windows.Forms.Button rysuj_funkcje_wielomianowa;
        private System.Windows.Forms.TextBox tresc_bledu;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label etykieta_potegi_kwadratowej;
    }
}

