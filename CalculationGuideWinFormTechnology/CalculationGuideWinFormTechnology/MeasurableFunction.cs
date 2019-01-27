using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzewodnikKalkulacyjny
{
    public partial class MeasurableFunction : Form
    {
        private CharChecker _charChecker;
        private Graphics g;
        private int[] xmeasurtab = new int[20];
        private float[] ymeasurtab = new float[20];
        private int x_na_osi;
        private float y_na_osi;
        
        public MeasurableFunction()
        {
            InitializeComponent();
            _charChecker = new CharChecker(this);

            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Size = new Size(879, 488);
            //AmountElements._measure_results.Add(-10.0F);

        }

        private void ButtonOneBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

            //_valueString = ValueToAbsTxb.Text;
            //_isComma = _valueString.Contains(CommaSymbol);
            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, "1");
                _MFSS++;
                //_a += Convert.ToDouble(TextBoxLinFunA.Text);
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
                // _charChecker.IsCommaCheckerFunLinAMethod();
                //_charChecker.IsMinusCheckerFunLinAMethod();
                // _charChecker.IsMinusCheckerMethod();

            }
        }

        private void TextBoxMF_MouseDown(object sender, MouseEventArgs e)
        {
            Checked._checkedTextBoxMFA = true;
            _charChecker.IsCommaChecherMFMethod();
            _charChecker.IsMinusCheckedMFMethod();
        }

        private void ButtonTwoBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

            //_valueString = ValueToAbsTxb.Text;
            //_isComma = _valueString.Contains(CommaSymbol);
            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, "2");
                _MFSS++;
                //_a += Convert.ToDouble(TextBoxLinFunA.Text);
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
                // _charChecker.IsCommaCheckerFunLinAMethod();
                //_charChecker.IsMinusCheckerFunLinAMethod();
                // _charChecker.IsMinusCheckerMethod();

            }
        }

        private void ButtonThreeBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

            //_valueString = ValueToAbsTxb.Text;
            //_isComma = _valueString.Contains(CommaSymbol);
            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, "3");
                _MFSS++;
                //_a += Convert.ToDouble(TextBoxLinFunA.Text);
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
                // _charChecker.IsCommaCheckerFunLinAMethod();
                //_charChecker.IsMinusCheckerFunLinAMethod();
                // _charChecker.IsMinusCheckerMethod();

            }
        }

        private void ButtonFourBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

            //_valueString = ValueToAbsTxb.Text;
            //_isComma = _valueString.Contains(CommaSymbol);
            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, "4");
                _MFSS++;
                //_a += Convert.ToDouble(TextBoxLinFunA.Text);
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
                // _charChecker.IsCommaCheckerFunLinAMethod();
                //_charChecker.IsMinusCheckerFunLinAMethod();
                // _charChecker.IsMinusCheckerMethod();

            }
        }

        private void ButtonFiveBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

            //_valueString = ValueToAbsTxb.Text;
            //_isComma = _valueString.Contains(CommaSymbol);
            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, "5");
                _MFSS++;
                //_a += Convert.ToDouble(TextBoxLinFunA.Text);
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
                // _charChecker.IsCommaCheckerFunLinAMethod();
                //_charChecker.IsMinusCheckerFunLinAMethod();
                // _charChecker.IsMinusCheckerMethod();

            }
        }

        private void ButtonSixBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

            //_valueString = ValueToAbsTxb.Text;
            //_isComma = _valueString.Contains(CommaSymbol);
            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, "6");
                _MFSS++;
                //_a += Convert.ToDouble(TextBoxLinFunA.Text);
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
                // _charChecker.IsCommaCheckerFunLinAMethod();
                //_charChecker.IsMinusCheckerFunLinAMethod();
                // _charChecker.IsMinusCheckerMethod();

            }
        }

        private void ButtonSevenBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

            //_valueString = ValueToAbsTxb.Text;
            //_isComma = _valueString.Contains(CommaSymbol);
            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, "7");
                _MFSS++;
                //_a += Convert.ToDouble(TextBoxLinFunA.Text);
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
                // _charChecker.IsCommaCheckerFunLinAMethod();
                //_charChecker.IsMinusCheckerFunLinAMethod();
                // _charChecker.IsMinusCheckerMethod();

            }
        }

        private void ButtonEightBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

            //_valueString = ValueToAbsTxb.Text;
            //_isComma = _valueString.Contains(CommaSymbol);
            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, "8");
                _MFSS++;
                //_a += Convert.ToDouble(TextBoxLinFunA.Text);
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
                // _charChecker.IsCommaCheckerFunLinAMethod();
                //_charChecker.IsMinusCheckerFunLinAMethod();
                // _charChecker.IsMinusCheckerMethod();

            }
        }

        private void ButtonNineBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

            //_valueString = ValueToAbsTxb.Text;
            //_isComma = _valueString.Contains(CommaSymbol);
            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, "9");
                _MFSS++;
                //_a += Convert.ToDouble(TextBoxLinFunA.Text);
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
                // _charChecker.IsCommaCheckerFunLinAMethod();
                //_charChecker.IsMinusCheckerFunLinAMethod();
                // _charChecker.IsMinusCheckerMethod();

            }
        }

        private void ButtonZeroBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

            //_valueString = ValueToAbsTxb.Text;
            //_isComma = _valueString.Contains(CommaSymbol);
            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, "0");
                _MFSS++;
                //_a += Convert.ToDouble(TextBoxLinFunA.Text);
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
                // _charChecker.IsCommaCheckerFunLinAMethod();
                //_charChecker.IsMinusCheckerFunLinAMethod();
                // _charChecker.IsMinusCheckerMethod();

            }
        }

        private void ButtonCommaMFBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

            //_valueString = ValueToAbsTxb.Text;
            //_isComma = _valueString.Contains(CommaSymbol);
            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, ",");
                _MFSS++;
                //_a += Convert.ToDouble(TextBoxLinFunA.Text);
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
                // _charChecker.IsCommaCheckerFunLinAMethod();
                //_charChecker.IsMinusCheckerFunLinAMethod();
                // _charChecker.IsMinusCheckerMethod();

            }
        }

        private void ButtonMinusMFBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

            //_valueString = ValueToAbsTxb.Text;
            //_isComma = _valueString.Contains(CommaSymbol);
            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, "-");
                _MFSS++;
                //_a += Convert.ToDouble(TextBoxLinFunA.Text);
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
                // _charChecker.IsCommaCheckerFunLinAMethod();
                //_charChecker.IsMinusCheckerFunLinAMethod();
                // _charChecker.IsMinusCheckerMethod();

            }
        }

        private void MeasurableFunction_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.Parent = null;
        }

        private void ButtonResultMFBtn_Click(object sender, EventArgs e)
        {
            String MFStr = TextBoxMF.Text;
            //ResultsValue._yMF = 0;
            double MFdouble = Convert.ToDouble(MFStr);
            
            for (int i = -20; i < 0; i++)
            {
                /*if (i == 0)
                {
                    i++;
                }*/
                ResultsValue._yMF = MFdouble / i;
                WykresMFChart.Series["Series1"].Points.AddXY(i,ResultsValue._yMF);
            }
            for (int i = 1; i < 20; i++)
            {
                ResultsValue._yMF = MFdouble / i;
                WykresMFChart.Series["Series1"].Points.AddXY(i, ResultsValue._yMF);
            }
        }

        private void ButtonDrawingQFBtn_Click(object sender, EventArgs e)
        {
            Pen _penCurve = new Pen(Color.Red,2);
            Pen _penNameFunction = new Pen(Color.Red, 3);
            g = PictureBoxMFDemonstration.CreateGraphics();
            ButtonDrawingMFBtn.Enabled = false;
            int step = 1;
            //AmountElements._measure_step = 0.1F;
            //AmountElements._measure_x_mes=-10.0F;
            AmountElements._measure_x_mes = -140.0F;
            while (AmountElements._measure_x_mes<0.0F)
           //for (int x = -10;x<0;x++)
            {
                AmountElements._measure_y_mes = -1300 / AmountElements._measure_x_mes;
                //-1/10
                //float result_step = 5.0F;
                x_na_osi = (int)AmountElements._measure_x_mes + 150;
                y_na_osi = AmountElements._measure_y_mes + 151.0F;
                //AmountElements._measure_results.Add(AmountElements._measure_y_mes);
                PointF _pc1 = new PointF((float)x_na_osi,y_na_osi);
                //AmountElements._measure_x_mes += AmountElements._measure_step;
                
                //x++;
                AmountElements._measure_x_mes = AmountElements._measure_x_mes+10;
                
                AmountElements._measure_y_mes = -1300 / AmountElements._measure_x_mes;
                x_na_osi = x_na_osi + 10;
                //result_step += 10;
                y_na_osi = AmountElements._measure_y_mes + 151.0F;
                PointF _pc2 = new PointF((float)x_na_osi,y_na_osi);
                if (AmountElements._measure_x_mes == 0) break;
                g.DrawLine(_penCurve, _pc1, _pc2);
             }
            AmountElements._measure_x_mes = 1.0F;
            while (AmountElements._measure_x_mes < 140.0F)
            {
                AmountElements._measure_y_mes = -1300 / AmountElements._measure_x_mes;
                x_na_osi = (int)AmountElements._measure_x_mes + 150;
                y_na_osi = AmountElements._measure_y_mes + 151.0F;

                PointF _pc1 = new PointF((float)x_na_osi, y_na_osi);
                AmountElements._measure_x_mes = AmountElements._measure_x_mes + 10;

                AmountElements._measure_y_mes = -1300 / AmountElements._measure_x_mes;
                x_na_osi = x_na_osi + 10;
                //result_step += 10;
                y_na_osi = AmountElements._measure_y_mes + 151.0F;
                PointF _pc2 = new PointF((float)x_na_osi, y_na_osi);
                if (AmountElements._measure_x_mes == 140.0F) break;
                g.DrawLine(_penCurve, _pc1, _pc2);


            }
            Font _leftSide = new Font("Arial", 14);
            g.DrawString("y=", _leftSide, Brushes.Red, new Point(2, 50));
            Font _upName = new Font("Arial", 14);
            g.DrawString("3", _upName, Brushes.Red, new Point(40, 30));

            Font _lineDivide = new Font("Arial", 14);
            g.DrawString("___", _lineDivide, Brushes.Red, new Point(30, 40));

            Font _downName = new Font("Arial", 14);
            g.DrawString("x", _downName, Brushes.Red, new Point(40, 60));
           // Point _pc1 = new Point(290,140);
            //Point _pc2 = new Point(280,139);
           /* Point _pc3 = new Point(270, 138);
            Point _pc4 = new Point(265, 137);
            Point _pc5 = new Point(262,136);
            Point _pc6 = new Point(259,135);
            Point _pc7 = new Point(245,134);
            Point _pc8 = new Point(240,133);
            Point _pc9 = new Point(230,132);
            Point _pc10 = new Point(220, 131);
            Point _pc11 = new Point(210, 130);
            Point _pc12 = new Point(205, 129);
            Point _pc13 = new Point(200, 128);
            Point _pc14 = new Point(195, 127);
            Point _pc15 = new Point(185, 126);
            Point _pc16 = new Point(175, 124);
            Point _pc17 = new Point(174, 123);
            Point _pc18 = new Point(173, 122);
            Point _pc19 = new Point(172, 121);
            Point _pc20 = new Point(171, 115);
            Point _pc21 = new Point(170, 110);
            Point _pc22 = new Point(169, 105);
            Point _pc23 = new Point(168, 100);
            Point _pc24 = new Point(167, 95);
            Point _pc25 = new Point(166, 90);
            Point _pc26 = new Point(165, 85);
            Point _pc27 = new Point(164, 80);
            Point _pc28 = new Point(163, 75);
            Point _pc29 = new Point(162, 70);
            Point _pc30 = new Point(161, 65);
            Point _pc31 = new Point(160, 60);
            Point _pc32 = new Point(159, 55);
            Point _pc33 = new Point(158, 50);
            Point _pc34 = new Point(157, 45);*/
            //prawa
            //lewa
           /* Point _pcl1 = new Point(140,290);
            Point _pcl2 = new Point(139, 285);
            Point _pcl3 = new Point(138, 280);
            Point _pcl4 = new Point(137, 275);
            Point _pcl5 = new Point(136, 270);
            Point _pcl6 = new Point(135, 265);
            Point _pcl7 = new Point(134, 260);
            Point _pcl8 = new Point(133, 255);
            Point _pcl9 = new Point(132, 250);
            Point _pcl10 = new Point(131, 245);
            Point _pcl11 = new Point(130, 240);
            Point _pcl12 = new Point(129, 235);
            Point _pcl13 = new Point(128, 230);
            Point _pcl14 = new Point(127, 225);
            Point _pcl15 = new Point(126,220);
            Point _pcl16 = new Point(125, 215);
            Point _pcl17 = new Point(124, 210);
            Point _pcl18 = new Point(123, 205);
            Point _pcl19 = new Point(122, 200);
            Point _pcl20 = new Point(121, 195);
            Point _pcl21 = new Point(115, 187);
            Point _pcl22 = new Point(114, 186);
            Point _pcl23 = new Point(113, 185);
            Point _pcl24 = new Point(112, 184);
            Point _pcl25 = new Point(111, 183);
            Point _pcl26 = new Point(110, 182);
            Point _pcl27 = new Point(109, 181);

            Point _pcl28 = new Point(108, 180);
            Point _pcl29 = new Point(105, 179);
            Point _pcl30 = new Point(100, 178);
            Point _pcl31 = new Point(95, 177);
            Point _pcl32 = new Point(90, 176);
            Point _pcl33 = new Point(85, 175);
            Point _pcl34 = new Point(80, 174);
            Point _pcl35 = new Point(75, 173);
            Point _pcl36 = new Point(70,172);
            Point _pcl37 = new Point(65, 171);
            Point _pcl38 = new Point(60, 170);
            Point _pcl39 = new Point(55, 169);
            Point _pcl40 = new Point(50, 168);
            Point _pcl41 = new Point(45, 167);
            Point _pcl42 = new Point(40, 166);
            Point _pcl43 = new Point(35, 165);
            Point _pcl44 = new Point(30, 164);
            Point _pcl45 = new Point(25, 163);*/
            //Point _pcl42 = new Point(40, 166);







            //right curve
            
            //g.DrawLine(_penCurve, _pc1, _pc2);
           // g.DrawLine(_penCurve, _pc2, _pc3);
           /* g.DrawLine(_penCurve, _pc3, _pc4);
            g.DrawLine(_penCurve, _pc4, _pc5);
            g.DrawLine(_penCurve, _pc5, _pc6);
            g.DrawLine(_penCurve, _pc6, _pc7);
            g.DrawLine(_penCurve, _pc7, _pc8);
            g.DrawLine(_penCurve, _pc8, _pc9);
            g.DrawLine(_penCurve, _pc9, _pc10);
            g.DrawLine(_penCurve, _pc10, _pc11);
            g.DrawLine(_penCurve, _pc11, _pc12);
            g.DrawLine(_penCurve, _pc12, _pc13);
            g.DrawLine(_penCurve, _pc13, _pc14);
            g.DrawLine(_penCurve, _pc14, _pc15);
            g.DrawLine(_penCurve, _pc15, _pc16);
            g.DrawLine(_penCurve, _pc16, _pc17);
            g.DrawLine(_penCurve, _pc17, _pc18);
            g.DrawLine(_penCurve, _pc18, _pc19);
            g.DrawLine(_penCurve, _pc19, _pc20);
            g.DrawLine(_penCurve, _pc20, _pc21);
            g.DrawLine(_penCurve, _pc21, _pc22);
            g.DrawLine(_penCurve, _pc22, _pc23);
            g.DrawLine(_penCurve, _pc23, _pc24);
            g.DrawLine(_penCurve, _pc24, _pc25);
            g.DrawLine(_penCurve, _pc25, _pc26);
            g.DrawLine(_penCurve, _pc26, _pc27);
            g.DrawLine(_penCurve, _pc27, _pc28);
            g.DrawLine(_penCurve, _pc28, _pc29);
            g.DrawLine(_penCurve, _pc29, _pc30);
            g.DrawLine(_penCurve, _pc30, _pc31);
            g.DrawLine(_penCurve, _pc31, _pc32);
            g.DrawLine(_penCurve, _pc32, _pc33);
            g.DrawLine(_penCurve, _pc33, _pc34);*/
            //measure curve
           /* g.DrawLine(_penCurve,_pcl1,_pcl2);
            g.DrawLine(_penCurve, _pcl2, _pcl3);
            g.DrawLine(_penCurve, _pcl3, _pcl4);
            g.DrawLine(_penCurve, _pcl4, _pcl5);
            g.DrawLine(_penCurve, _pcl5, _pcl6);
            g.DrawLine(_penCurve, _pcl6, _pcl7);
            g.DrawLine(_penCurve, _pcl7, _pcl8);
            g.DrawLine(_penCurve, _pcl8, _pcl9);
            g.DrawLine(_penCurve, _pcl9, _pcl10);
            g.DrawLine(_penCurve, _pcl10, _pcl11);
            g.DrawLine(_penCurve, _pcl11, _pcl12);
            g.DrawLine(_penCurve, _pcl12, _pcl13);
            g.DrawLine(_penCurve, _pcl13, _pcl14);
            g.DrawLine(_penCurve, _pcl14, _pcl15);
            g.DrawLine(_penCurve, _pcl15, _pcl16);
            g.DrawLine(_penCurve, _pcl16, _pcl17);
            g.DrawLine(_penCurve, _pcl17, _pcl18);
            g.DrawLine(_penCurve, _pcl18, _pcl19);
            g.DrawLine(_penCurve, _pcl19, _pcl20);
            g.DrawLine(_penCurve, _pcl20, _pcl21);
            g.DrawLine(_penCurve, _pcl21, _pcl22);
            g.DrawLine(_penCurve, _pcl22, _pcl23);
            g.DrawLine(_penCurve, _pcl23, _pcl24);
            g.DrawLine(_penCurve, _pcl24, _pcl25);
            g.DrawLine(_penCurve, _pcl25, _pcl26);
            g.DrawLine(_penCurve, _pcl26, _pcl27);
            g.DrawLine(_penCurve, _pcl27, _pcl28);
            g.DrawLine(_penCurve, _pcl28, _pcl29);
            g.DrawLine(_penCurve, _pcl29, _pcl30);
            g.DrawLine(_penCurve, _pcl30, _pcl31);
            g.DrawLine(_penCurve, _pcl31, _pcl32);
            g.DrawLine(_penCurve, _pcl32, _pcl33);
            g.DrawLine(_penCurve, _pcl33, _pcl34);
            g.DrawLine(_penCurve, _pcl34, _pcl35);
            g.DrawLine(_penCurve, _pcl35, _pcl36);
            g.DrawLine(_penCurve, _pcl36, _pcl37);
            g.DrawLine(_penCurve, _pcl37, _pcl38);
            g.DrawLine(_penCurve, _pcl38, _pcl39);
            g.DrawLine(_penCurve, _pcl39, _pcl40);
            g.DrawLine(_penCurve, _pcl40, _pcl41);

            g.DrawLine(_penCurve, _pcl41, _pcl42);
            g.DrawLine(_penCurve, _pcl42, _pcl43);
            g.DrawLine(_penCurve, _pcl43, _pcl44);
            g.DrawLine(_penCurve, _pcl44, _pcl45);*/
            // g.DrawLine(_penCurve, _pcl45, _pcl46);
            //g.DrawLine(_penCurve, _pcl42, _pcl42);
            ButtonResetDrawMFBtn.Enabled = true;



            g.Dispose();

        }

        private void ButtonResetDrawMFBtn_Click(object sender, EventArgs e)
        {
            ButtonResetDrawMFBtn.Enabled = false;
            g = PictureBoxMFDemonstration.CreateGraphics();
            g.Clear(Color.YellowGreen);
            ButtonResetDrawMFBtn.Enabled = false;
            ButtonStartDMFBtn.Enabled = true;
            
        }

        private void ButtonStartDMFBtn_Click(object sender, EventArgs e)
        {
            ButtonStartDMFBtn.Enabled = false;
            ButtonDrawingMFBtn.Enabled = true;
            int overScale = 10;
            int _x = 1;
            int _y = 1;
            int i = 0;
            int j = 0;

            int _startPoint = 0;

            int _xsclale = _startPoint + 150;
            int _yscale = _startPoint + 150;

            Pen _pen = new Pen(Color.White);
            Point _p1v = new Point(150, 0);
            Point _p2v = new Point(150, 300);
            Point _p1h = new Point(0, 150);
            Point _p2h = new Point(300, 150);
            g = PictureBoxMFDemonstration.CreateGraphics();
            g.DrawLine(_pen, _p1v, _p2v);
            g.DrawLine(_pen, _p1h, _p2h);
            for (i += _xsclale + _x * overScale; i <= 300; i = i + 10)
            {
                Point _xsc = new Point(i, _yscale);
                Point _xsc2 = new Point(i, _yscale - 5);
                g.DrawLine(_pen, _xsc, _xsc2);

            }
            for (i += _xsclale - _x * overScale; i >= 0; i = i - 10)
            {
                Point _xsc = new Point(i, _yscale);
                Point _xsc2 = new Point(i, _yscale - 5);
                g.DrawLine(_pen, _xsc, _xsc2);

            }
            for (i += _yscale - _y * overScale; i >= 0; i = i - 10)
            {
                Point _ysc = new Point(_xsclale, i);
                Point _ysc2 = new Point(_xsclale + 5, i);
                g.DrawLine(_pen, _ysc, _ysc2);
            }
            for (i += _yscale + _y * overScale; i <= 300; i = i + 10)
            {
                Point _ysc = new Point(_xsclale, i);
                Point _ysc2 = new Point(_xsclale + 5, i);
                g.DrawLine(_pen, _ysc, _ysc2);
            }
            Font _xfont = new Font("Arial", 14);
            g.DrawString("X", _xfont, Brushes.White, new Point(280, 130));
            Font _yfont = new Font("Arial", 14);
            g.DrawString("Y", _yfont, Brushes.White, new Point(170, 20));
            Font _zero = new Font("Arial", 14);
            g.DrawString("0", _zero, Brushes.White, new Point(160, 120));
            g.Dispose();
        }

        private void ButtonResetQFBtn_Click(object sender, EventArgs e)
        {
            WykresMFChart.Series["Series1"].Points.Clear();
            TextBoxMF.Text = "";
            this.ButtonCommaMFBtn.Text = ",";
            this.ButtonMinusMFBtn.Text = "-";
            
        }
    }
}
