﻿using System;
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
    public partial class Form1 : Form
    {
        private Label modalWindowNameOfProgramLbl = new Label();
        public AbsoluteValueCalculationForm absValueCalculationForm;
        public FunctionAndHerFeatures linfuncAndHerFeatures;
        public QuadraticFunctionAndHejDemonstration qFuncAndDemonstation;
        public MeasurableFunction measureFunction;
        public ExponentialFunction _expFun;
        //private Label modalWindowDescOfAbsValLbl = new Label();
        public Form1()
        {
            InitializeComponent();
            modalWindowNameOfProgramLblMethod();
            absValueCalculationForm = new AbsoluteValueCalculationForm();
            linfuncAndHerFeatures = new FunctionAndHerFeatures();
            qFuncAndDemonstation = new QuadraticFunctionAndHejDemonstration();
            measureFunction = new MeasurableFunction();
            _expFun = new ExponentialFunction();
            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Size = new Size(915,300);
            //this.Width = 915;
            //this.Height = 300;

           // modalWindowDescOfAbsValBtnMethod();
            
        }
        private void modalWindowNameOfProgramLblMethod()
        {
            modalWindowNameOfProgramLbl.Name = "modalWindowNameOfProgramLbl";
            modalWindowNameOfProgramLbl.Text = "This program enables mathematic calculations and prezentations them by animations";
            modalWindowNameOfProgramLbl.Font = new Font("Arial", 20);
            modalWindowNameOfProgramLbl.ForeColor = Color.Red;
            modalWindowNameOfProgramLbl.BackColor = Color.White;
            modalWindowNameOfProgramLbl.Size = new Size(260, 200);
            modalWindowNameOfProgramLbl.BorderStyle = BorderStyle.FixedSingle;

            modalWindowNameOfProgramLbl.Location = new Point(600, 10);
            this.Controls.Add(this.modalWindowNameOfProgramLbl);
            this.modalWindowNameOfProgramLbl.Visible = false;
        }
        private void modalWindowDescOfAbsValBtnMethod()
        {
            /*modalWindowDescOfAbsValLbl.Name = "modalWindowDescOfAbsValLbl";
            modalWindowDescOfAbsValLbl.Text = "The absolute value calculation chapter";
            modalWindowDescOfAbsValLbl.Font = new Font("Arial", 20);
            modalWindowDescOfAbsValLbl.ForeColor = Color.Red;
            modalWindowDescOfAbsValLbl.BackColor = Color.White;
            modalWindowDescOfAbsValLbl.Size = new Size(180, 160);
            modalWindowDescOfAbsValLbl.BorderStyle = BorderStyle.FixedSingle;
            modalWindowDescOfAbsValLbl.Location = new Point(206, 74);

            this.Controls.Add(this.modalWindowDescOfAbsValLbl);
            this.modalWindowDescOfAbsValLbl.Visible = false;*/

        }
        private void NameOfProgramLbl_MouseHover(object sender, EventArgs e)
        {
            this.modalWindowNameOfProgramLbl.Visible = true;
            

        }

        private void NameOfProgramLbl_MouseLeave(object sender, EventArgs e)
        {
            this.modalWindowNameOfProgramLbl.Visible = false;
        }

        private void AbsoluteValueBtn_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void AbsoluteValueBtn_MouseHover(object sender, EventArgs e)
        {
           // modalWindowDescOfAbsValLbl.Visible = true;
        }

        private void AbsoluteValueBtn_MouseLeave(object sender, EventArgs e)
        {
            //modalWindowDescOfAbsValLbl.Visible = false;
        }

        private void AbsoluteValueBtn_Click(object sender, EventArgs e)
        {
            absValueCalculationForm.Show();

           
        }

        private void ButtonFuncBtn_Click(object sender, EventArgs e)
        {
            linfuncAndHerFeatures.Show();
        }

        private void ButtonQuadraticFuncBtn_Click(object sender, EventArgs e)
        {
            qFuncAndDemonstation.Show();
        }

        private void MeasurmentFunctionBtn_Click(object sender, EventArgs e)
        {
            measureFunction.Show();
        }

        private void ButtonExpFunBtn_Click(object sender, EventArgs e)
        {
            _expFun.Show();
        }
    }
}
