using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Calculator
{
    // Счетчик со строки
    class Counter
    {
        private readonly string str;
        public Counter(string s)
        {
            this.str = s;
        }


        // Метод подсчета
        public double CountValue()
        {
            double value = 0;
            Stack<double> st = new Stack<double>();
            string[] splitted = str.Split(' ');
            foreach (string s in splitted)
            {
                bool isNum = double.TryParse(s, out double num);
                
                // Если символ это число, то добавить в стек чисел
                if (isNum)
                {
                    st.Push(num);
                }
                // если пришла операция, то выталкивать из стека значения и считать
                else if (s == "+" || s == "-"  || s == "*" || s == "/" || s == "%")
                {
                    switch (s)
                    {
                        case "+":
                            st.Push(st.Pop() + st.Pop());
                            value = st.Peek();
                            break;
                        case "*":
                            st.Push(st.Pop() * st.Pop());
                            value = st.Peek();
                            break;
                        case "-":
                            value = st.Pop();
                            st.Push(st.Pop() - value);
                            value = st.Peek();
                            break;
                        case "/":
                            if (value != 0.0)
                            {
                                st.Push(st.Pop() / value);
                                value = st.Peek();
                            }   
                            else
                                Console.WriteLine("Ошибка. Деление на ноль");
                            break;
                        case "^":
                            Stack<double> temp = new Stack<double>();
                            temp.Push(st.Pop());
                            double v1 = temp.Peek();
                            temp.Push(st.Pop());
                            double v2 = temp.Peek();
                            value = Math.Pow(v2, v1);
                            break;
                        case "%":
                            st.Push(Math.Round((double) (st.Pop() * st.Pop()) /100));
                            value = st.Peek();
                            break;
                    }
                }
            }
            return value;
        }
    }
}
