using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    // Представление входной строки ввиде польской записи
    class PolishCode
    {
        //Преобразование в польскую запись
        public string ToMachineArithmetic(string stExpression)
        {
            stExpression += " ";

            int countBracket = 0;
            ArrayList arExpression = new ArrayList();

            int a = 0;
            for (int b = 0; b < stExpression.Length; b++)
            {
                if (stExpression[b] == ' ')
                {
                    if ((string)arExpression[arExpression.Add(stExpression.Substring(a, b - a))] == "(")
                    {
                        countBracket++;
                    }
                    a = b + 1;
                }
            }

            int i = 0;
            int openBracket = 0, closeBracket = 0;
            while (true)
            {
                if (countBracket == 0)
                {
                    return SimpleTranslate(arExpression);
                }
                else if (i == arExpression.Count)
                {
                    i = 0;
                }
                else
                {
                    if ((string)arExpression[i] == "(")
                    {
                        openBracket = i;
                    }
                    else if ((string)arExpression[i] == ")")
                    {
                        closeBracket = i;

                        ArrayList arSimpleExpression = new ArrayList();

                        for (a = openBracket + 1; a < closeBracket; a++)
                        {
                            arSimpleExpression.Add(arExpression[a]);
                        }

                        arExpression[openBracket] = SimpleTranslate(arSimpleExpression);

                        // Удалим лишние элементы
                        arExpression.RemoveRange(openBracket + 1, closeBracket - openBracket);

                        countBracket--;

                        i = -1;
                    }
                }
                i++;
            }
        }

        private string SimpleTranslate(ArrayList arExpression)
        {
            int i = 0;
            // Вес операций 
            int step = 1;

            while (true)
            {
                if (arExpression.Count == 1)
                {
                    return (string)arExpression[0];
                }
                else if (i == arExpression.Count)
                {
                    i = 0;
                    step++;
                }

                switch (step)
                {
                    case 1:
                        {
                            if ((string)arExpression[i] == "^" || (string)arExpression[i] == "%")
                            {
                                arExpression[i - 1] = arExpression[i - 1] + " " + arExpression[i + 1] + " " + arExpression[i] + " ";

                                // Удалим лишние элементы
                                arExpression.RemoveRange(i, 2);
                            }
                            else i++;
                        }
                        break;

                    case 2:
                        {
                            if ((string)arExpression[i] == "*" || (string)arExpression[i] == "/")
                            {
                                arExpression[i - 1] = arExpression[i - 1] + " " + arExpression[i + 1] + " " + arExpression[i] + " ";

                                // Удалим лишние элементы
                                arExpression.RemoveRange(i, 2);
                            }
                            else i++;
                        }
                        break;
                    case 3:
                        {
                            if ((string)arExpression[i] == "+" || (string)arExpression[i] == "-")
                            {
                                arExpression[i - 1] = arExpression[i - 1] + " " + arExpression[i + 1] + " " + arExpression[i] + " ";

                                // Удалим лишние элементы
                                arExpression.RemoveRange(i, 2);
                            }
                            else i++;
                        }
                        break;
                }
            }
        }
    }
} 
