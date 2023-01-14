using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Calculator.Controllers;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly CalController calcController = new CalController();
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Проверка на нецифровые значения
            if (calcController.IsValid(inputText.Text))
            {
                polishLabel.Text = calcController.SetPolishText(inputText.Text);
                answeLabel.Text = calcController.CalculateResult(polishLabel.Text).ToString();
            }
        }
    }
}
