namespace PrzewodnikKalkulacyjny
{
    partial class MeasurableFunction
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ButtonResetQFBtn = new System.Windows.Forms.Button();
            this.ButtonResultMFBtn = new System.Windows.Forms.Button();
            this.ButtonCommaMFBtn = new System.Windows.Forms.Button();
            this.ButtonMinusMFBtn = new System.Windows.Forms.Button();
            this.ButtonZeroBtn = new System.Windows.Forms.Button();
            this.ButtonNineBtn = new System.Windows.Forms.Button();
            this.ButtonEightBtn = new System.Windows.Forms.Button();
            this.ButtonSevenBtn = new System.Windows.Forms.Button();
            this.ButtonSixBtn = new System.Windows.Forms.Button();
            this.ButtonFiveBtn = new System.Windows.Forms.Button();
            this.ButtonFourBtn = new System.Windows.Forms.Button();
            this.ButtonThreeBtn = new System.Windows.Forms.Button();
            this.ButtonTwoBtn = new System.Windows.Forms.Button();
            this.ButtonOneBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxMF = new System.Windows.Forms.TextBox();
            this.WykresMFChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ButtonResetDrawMFBtn = new System.Windows.Forms.Button();
            this.ButtonDrawingMFBtn = new System.Windows.Forms.Button();
            this.ButtonStartDMFBtn = new System.Windows.Forms.Button();
            this.PictureBoxMFDemonstration = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WykresMFChart)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMFDemonstration)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "THE MEASURABLE FUNCTION";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(12, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(839, 382);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage1.Controls.Add(this.ButtonResetQFBtn);
            this.tabPage1.Controls.Add(this.ButtonResultMFBtn);
            this.tabPage1.Controls.Add(this.ButtonCommaMFBtn);
            this.tabPage1.Controls.Add(this.ButtonMinusMFBtn);
            this.tabPage1.Controls.Add(this.ButtonZeroBtn);
            this.tabPage1.Controls.Add(this.ButtonNineBtn);
            this.tabPage1.Controls.Add(this.ButtonEightBtn);
            this.tabPage1.Controls.Add(this.ButtonSevenBtn);
            this.tabPage1.Controls.Add(this.ButtonSixBtn);
            this.tabPage1.Controls.Add(this.ButtonFiveBtn);
            this.tabPage1.Controls.Add(this.ButtonFourBtn);
            this.tabPage1.Controls.Add(this.ButtonThreeBtn);
            this.tabPage1.Controls.Add(this.ButtonTwoBtn);
            this.tabPage1.Controls.Add(this.ButtonOneBtn);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TextBoxMF);
            this.tabPage1.Controls.Add(this.WykresMFChart);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(831, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calculation";
            // 
            // ButtonResetQFBtn
            // 
            this.ButtonResetQFBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.ButtonResetQFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonResetQFBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonResetQFBtn.ForeColor = System.Drawing.Color.White;
            this.ButtonResetQFBtn.Location = new System.Drawing.Point(626, 237);
            this.ButtonResetQFBtn.Name = "ButtonResetQFBtn";
            this.ButtonResetQFBtn.Size = new System.Drawing.Size(115, 46);
            this.ButtonResetQFBtn.TabIndex = 55;
            this.ButtonResetQFBtn.Text = "RESET";
            this.ButtonResetQFBtn.UseVisualStyleBackColor = false;
            this.ButtonResetQFBtn.Click += new System.EventHandler(this.ButtonResetQFBtn_Click);
            // 
            // ButtonResultMFBtn
            // 
            this.ButtonResultMFBtn.BackColor = System.Drawing.Color.LightBlue;
            this.ButtonResultMFBtn.FlatAppearance.BorderSize = 3;
            this.ButtonResultMFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonResultMFBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonResultMFBtn.Location = new System.Drawing.Point(747, 236);
            this.ButtonResultMFBtn.Name = "ButtonResultMFBtn";
            this.ButtonResultMFBtn.Size = new System.Drawing.Size(55, 46);
            this.ButtonResultMFBtn.TabIndex = 54;
            this.ButtonResultMFBtn.Text = "=";
            this.ButtonResultMFBtn.UseVisualStyleBackColor = false;
            this.ButtonResultMFBtn.Click += new System.EventHandler(this.ButtonResultMFBtn_Click);
            // 
            // ButtonCommaMFBtn
            // 
            this.ButtonCommaMFBtn.BackColor = System.Drawing.Color.DarkBlue;
            this.ButtonCommaMFBtn.Enabled = false;
            this.ButtonCommaMFBtn.FlatAppearance.BorderSize = 3;
            this.ButtonCommaMFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCommaMFBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonCommaMFBtn.ForeColor = System.Drawing.Color.White;
            this.ButtonCommaMFBtn.Location = new System.Drawing.Point(686, 185);
            this.ButtonCommaMFBtn.Name = "ButtonCommaMFBtn";
            this.ButtonCommaMFBtn.Size = new System.Drawing.Size(55, 46);
            this.ButtonCommaMFBtn.TabIndex = 53;
            this.ButtonCommaMFBtn.Text = ",";
            this.ButtonCommaMFBtn.UseVisualStyleBackColor = false;
            this.ButtonCommaMFBtn.Click += new System.EventHandler(this.ButtonCommaMFBtn_Click);
            // 
            // ButtonMinusMFBtn
            // 
            this.ButtonMinusMFBtn.BackColor = System.Drawing.Color.Aqua;
            this.ButtonMinusMFBtn.Enabled = false;
            this.ButtonMinusMFBtn.FlatAppearance.BorderSize = 3;
            this.ButtonMinusMFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinusMFBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonMinusMFBtn.Location = new System.Drawing.Point(747, 184);
            this.ButtonMinusMFBtn.Name = "ButtonMinusMFBtn";
            this.ButtonMinusMFBtn.Size = new System.Drawing.Size(55, 46);
            this.ButtonMinusMFBtn.TabIndex = 52;
            this.ButtonMinusMFBtn.Text = "-";
            this.ButtonMinusMFBtn.UseVisualStyleBackColor = false;
            this.ButtonMinusMFBtn.Click += new System.EventHandler(this.ButtonMinusMFBtn_Click);
            // 
            // ButtonZeroBtn
            // 
            this.ButtonZeroBtn.BackColor = System.Drawing.Color.Yellow;
            this.ButtonZeroBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ButtonZeroBtn.FlatAppearance.BorderSize = 3;
            this.ButtonZeroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonZeroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonZeroBtn.Location = new System.Drawing.Point(625, 185);
            this.ButtonZeroBtn.Name = "ButtonZeroBtn";
            this.ButtonZeroBtn.Size = new System.Drawing.Size(55, 46);
            this.ButtonZeroBtn.TabIndex = 51;
            this.ButtonZeroBtn.Text = "0";
            this.ButtonZeroBtn.UseVisualStyleBackColor = false;
            this.ButtonZeroBtn.Click += new System.EventHandler(this.ButtonZeroBtn_Click);
            // 
            // ButtonNineBtn
            // 
            this.ButtonNineBtn.FlatAppearance.BorderSize = 3;
            this.ButtonNineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonNineBtn.ForeColor = System.Drawing.Color.White;
            this.ButtonNineBtn.Location = new System.Drawing.Point(747, 132);
            this.ButtonNineBtn.Name = "ButtonNineBtn";
            this.ButtonNineBtn.Size = new System.Drawing.Size(55, 46);
            this.ButtonNineBtn.TabIndex = 50;
            this.ButtonNineBtn.Text = "9";
            this.ButtonNineBtn.UseVisualStyleBackColor = true;
            this.ButtonNineBtn.Click += new System.EventHandler(this.ButtonNineBtn_Click);
            // 
            // ButtonEightBtn
            // 
            this.ButtonEightBtn.BackColor = System.Drawing.Color.Navy;
            this.ButtonEightBtn.FlatAppearance.BorderSize = 3;
            this.ButtonEightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonEightBtn.ForeColor = System.Drawing.Color.White;
            this.ButtonEightBtn.Location = new System.Drawing.Point(686, 132);
            this.ButtonEightBtn.Name = "ButtonEightBtn";
            this.ButtonEightBtn.Size = new System.Drawing.Size(55, 46);
            this.ButtonEightBtn.TabIndex = 49;
            this.ButtonEightBtn.Text = "8";
            this.ButtonEightBtn.UseVisualStyleBackColor = false;
            this.ButtonEightBtn.Click += new System.EventHandler(this.ButtonEightBtn_Click);
            // 
            // ButtonSevenBtn
            // 
            this.ButtonSevenBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ButtonSevenBtn.FlatAppearance.BorderSize = 3;
            this.ButtonSevenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSevenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSevenBtn.Location = new System.Drawing.Point(625, 132);
            this.ButtonSevenBtn.Name = "ButtonSevenBtn";
            this.ButtonSevenBtn.Size = new System.Drawing.Size(55, 46);
            this.ButtonSevenBtn.TabIndex = 48;
            this.ButtonSevenBtn.Text = "7";
            this.ButtonSevenBtn.UseVisualStyleBackColor = false;
            this.ButtonSevenBtn.Click += new System.EventHandler(this.ButtonSevenBtn_Click);
            // 
            // ButtonSixBtn
            // 
            this.ButtonSixBtn.BackColor = System.Drawing.Color.LightPink;
            this.ButtonSixBtn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.ButtonSixBtn.FlatAppearance.BorderSize = 3;
            this.ButtonSixBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSixBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSixBtn.Location = new System.Drawing.Point(747, 80);
            this.ButtonSixBtn.Name = "ButtonSixBtn";
            this.ButtonSixBtn.Size = new System.Drawing.Size(55, 46);
            this.ButtonSixBtn.TabIndex = 47;
            this.ButtonSixBtn.Text = "6";
            this.ButtonSixBtn.UseVisualStyleBackColor = false;
            this.ButtonSixBtn.Click += new System.EventHandler(this.ButtonSixBtn_Click);
            // 
            // ButtonFiveBtn
            // 
            this.ButtonFiveBtn.BackColor = System.Drawing.Color.Violet;
            this.ButtonFiveBtn.FlatAppearance.BorderSize = 3;
            this.ButtonFiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonFiveBtn.Location = new System.Drawing.Point(686, 80);
            this.ButtonFiveBtn.Name = "ButtonFiveBtn";
            this.ButtonFiveBtn.Size = new System.Drawing.Size(55, 46);
            this.ButtonFiveBtn.TabIndex = 46;
            this.ButtonFiveBtn.Text = "5";
            this.ButtonFiveBtn.UseVisualStyleBackColor = false;
            this.ButtonFiveBtn.Click += new System.EventHandler(this.ButtonFiveBtn_Click);
            // 
            // ButtonFourBtn
            // 
            this.ButtonFourBtn.BackColor = System.Drawing.Color.Blue;
            this.ButtonFourBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.ButtonFourBtn.FlatAppearance.BorderSize = 3;
            this.ButtonFourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonFourBtn.ForeColor = System.Drawing.Color.White;
            this.ButtonFourBtn.Location = new System.Drawing.Point(626, 80);
            this.ButtonFourBtn.Name = "ButtonFourBtn";
            this.ButtonFourBtn.Size = new System.Drawing.Size(55, 46);
            this.ButtonFourBtn.TabIndex = 45;
            this.ButtonFourBtn.Text = "4";
            this.ButtonFourBtn.UseVisualStyleBackColor = false;
            this.ButtonFourBtn.Click += new System.EventHandler(this.ButtonFourBtn_Click);
            // 
            // ButtonThreeBtn
            // 
            this.ButtonThreeBtn.BackColor = System.Drawing.Color.Olive;
            this.ButtonThreeBtn.FlatAppearance.BorderSize = 3;
            this.ButtonThreeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonThreeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonThreeBtn.ForeColor = System.Drawing.Color.White;
            this.ButtonThreeBtn.Location = new System.Drawing.Point(747, 28);
            this.ButtonThreeBtn.Name = "ButtonThreeBtn";
            this.ButtonThreeBtn.Size = new System.Drawing.Size(55, 46);
            this.ButtonThreeBtn.TabIndex = 44;
            this.ButtonThreeBtn.Text = "3";
            this.ButtonThreeBtn.UseVisualStyleBackColor = false;
            this.ButtonThreeBtn.Click += new System.EventHandler(this.ButtonThreeBtn_Click);
            // 
            // ButtonTwoBtn
            // 
            this.ButtonTwoBtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ButtonTwoBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonTwoBtn.FlatAppearance.BorderSize = 3;
            this.ButtonTwoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTwoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonTwoBtn.Location = new System.Drawing.Point(686, 28);
            this.ButtonTwoBtn.Name = "ButtonTwoBtn";
            this.ButtonTwoBtn.Size = new System.Drawing.Size(55, 46);
            this.ButtonTwoBtn.TabIndex = 43;
            this.ButtonTwoBtn.Text = "2";
            this.ButtonTwoBtn.UseVisualStyleBackColor = false;
            this.ButtonTwoBtn.Click += new System.EventHandler(this.ButtonTwoBtn_Click);
            // 
            // ButtonOneBtn
            // 
            this.ButtonOneBtn.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ButtonOneBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonOneBtn.FlatAppearance.BorderSize = 3;
            this.ButtonOneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonOneBtn.Location = new System.Drawing.Point(625, 28);
            this.ButtonOneBtn.Name = "ButtonOneBtn";
            this.ButtonOneBtn.Size = new System.Drawing.Size(55, 46);
            this.ButtonOneBtn.TabIndex = 42;
            this.ButtonOneBtn.Text = "1";
            this.ButtonOneBtn.UseVisualStyleBackColor = false;
            this.ButtonOneBtn.Click += new System.EventHandler(this.ButtonOneBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(470, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "/ X";
            // 
            // TextBoxMF
            // 
            this.TextBoxMF.BackColor = System.Drawing.Color.DarkRed;
            this.TextBoxMF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxMF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxMF.ForeColor = System.Drawing.Color.White;
            this.TextBoxMF.Location = new System.Drawing.Point(364, 48);
            this.TextBoxMF.Name = "TextBoxMF";
            this.TextBoxMF.ReadOnly = true;
            this.TextBoxMF.Size = new System.Drawing.Size(100, 38);
            this.TextBoxMF.TabIndex = 1;
            this.TextBoxMF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBoxMF_MouseDown);
            // 
            // WykresMFChart
            // 
            this.WykresMFChart.BorderlineColor = System.Drawing.Color.Black;
            this.WykresMFChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.WykresMFChart.BorderlineWidth = 5;
            chartArea1.Name = "ChartArea1";
            this.WykresMFChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.WykresMFChart.Legends.Add(legend1);
            this.WykresMFChart.Location = new System.Drawing.Point(28, 19);
            this.WykresMFChart.Name = "WykresMFChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.WykresMFChart.Series.Add(series1);
            this.WykresMFChart.Size = new System.Drawing.Size(300, 300);
            this.WykresMFChart.TabIndex = 0;
            this.WykresMFChart.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkRed;
            this.tabPage2.Controls.Add(this.ButtonResetDrawMFBtn);
            this.tabPage2.Controls.Add(this.ButtonDrawingMFBtn);
            this.tabPage2.Controls.Add(this.ButtonStartDMFBtn);
            this.tabPage2.Controls.Add(this.PictureBoxMFDemonstration);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(831, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Demonstration";
            // 
            // ButtonResetDrawMFBtn
            // 
            this.ButtonResetDrawMFBtn.BackColor = System.Drawing.Color.DimGray;
            this.ButtonResetDrawMFBtn.Enabled = false;
            this.ButtonResetDrawMFBtn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.ButtonResetDrawMFBtn.FlatAppearance.BorderSize = 3;
            this.ButtonResetDrawMFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonResetDrawMFBtn.ForeColor = System.Drawing.Color.White;
            this.ButtonResetDrawMFBtn.Location = new System.Drawing.Point(444, 202);
            this.ButtonResetDrawMFBtn.Name = "ButtonResetDrawMFBtn";
            this.ButtonResetDrawMFBtn.Size = new System.Drawing.Size(348, 52);
            this.ButtonResetDrawMFBtn.TabIndex = 7;
            this.ButtonResetDrawMFBtn.Text = "RESET DRAWING";
            this.ButtonResetDrawMFBtn.UseVisualStyleBackColor = false;
            this.ButtonResetDrawMFBtn.Click += new System.EventHandler(this.ButtonResetDrawMFBtn_Click);
            // 
            // ButtonDrawingMFBtn
            // 
            this.ButtonDrawingMFBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonDrawingMFBtn.Enabled = false;
            this.ButtonDrawingMFBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ButtonDrawingMFBtn.FlatAppearance.BorderSize = 3;
            this.ButtonDrawingMFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDrawingMFBtn.Location = new System.Drawing.Point(444, 124);
            this.ButtonDrawingMFBtn.Name = "ButtonDrawingMFBtn";
            this.ButtonDrawingMFBtn.Size = new System.Drawing.Size(348, 52);
            this.ButtonDrawingMFBtn.TabIndex = 6;
            this.ButtonDrawingMFBtn.Text = "DRAWING MEASURABLE FUNCTION";
            this.ButtonDrawingMFBtn.UseVisualStyleBackColor = false;
            this.ButtonDrawingMFBtn.Click += new System.EventHandler(this.ButtonDrawingQFBtn_Click);
            // 
            // ButtonStartDMFBtn
            // 
            this.ButtonStartDMFBtn.BackColor = System.Drawing.Color.White;
            this.ButtonStartDMFBtn.FlatAppearance.BorderSize = 3;
            this.ButtonStartDMFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStartDMFBtn.Location = new System.Drawing.Point(444, 44);
            this.ButtonStartDMFBtn.Name = "ButtonStartDMFBtn";
            this.ButtonStartDMFBtn.Size = new System.Drawing.Size(348, 52);
            this.ButtonStartDMFBtn.TabIndex = 5;
            this.ButtonStartDMFBtn.Text = "START";
            this.ButtonStartDMFBtn.UseVisualStyleBackColor = false;
            this.ButtonStartDMFBtn.Click += new System.EventHandler(this.ButtonStartDMFBtn_Click);
            // 
            // PictureBoxMFDemonstration
            // 
            this.PictureBoxMFDemonstration.BackColor = System.Drawing.Color.YellowGreen;
            this.PictureBoxMFDemonstration.Location = new System.Drawing.Point(39, 24);
            this.PictureBoxMFDemonstration.Name = "PictureBoxMFDemonstration";
            this.PictureBoxMFDemonstration.Size = new System.Drawing.Size(300, 300);
            this.PictureBoxMFDemonstration.TabIndex = 4;
            this.PictureBoxMFDemonstration.TabStop = false;
            // 
            // MeasurableFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "MeasurableFunction";
            this.Text = "MeasurableFunction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MeasurableFunction_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WykresMFChart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMFDemonstration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart WykresMFChart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TextBoxMF;
        private System.Windows.Forms.Button ButtonResetQFBtn;
        private System.Windows.Forms.Button ButtonResultMFBtn;
        public System.Windows.Forms.Button ButtonCommaMFBtn;
        public System.Windows.Forms.Button ButtonMinusMFBtn;
        public System.Windows.Forms.Button ButtonZeroBtn;
        private System.Windows.Forms.Button ButtonNineBtn;
        private System.Windows.Forms.Button ButtonEightBtn;
        private System.Windows.Forms.Button ButtonSevenBtn;
        private System.Windows.Forms.Button ButtonSixBtn;
        private System.Windows.Forms.Button ButtonFiveBtn;
        private System.Windows.Forms.Button ButtonFourBtn;
        private System.Windows.Forms.Button ButtonThreeBtn;
        private System.Windows.Forms.Button ButtonTwoBtn;
        private System.Windows.Forms.Button ButtonOneBtn;
        private System.Windows.Forms.Button ButtonResetDrawMFBtn;
        private System.Windows.Forms.Button ButtonDrawingMFBtn;
        private System.Windows.Forms.Button ButtonStartDMFBtn;
        private System.Windows.Forms.PictureBox PictureBoxMFDemonstration;
    }
}