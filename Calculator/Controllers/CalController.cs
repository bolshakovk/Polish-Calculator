using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Calculator.Controllers
{
    class CalController
    {
        private readonly PolishCode polishCode = new PolishCode();
        

        public CalController()
        {
        }

        public bool IsValid(string text)
        {
            if (Regex.IsMatch(text, @"^[a-zA-Z]+$"))
            {
                return false;
            }
            return true;
        }
        public string SetPolishText(string text)
        {
            return polishCode.ToMachineArithmetic(text);
        }
        public double CalculateResult(string t)
        {
            Counter counter = new Counter(t);
            
            return counter.CountValue();
        }
    }
}
