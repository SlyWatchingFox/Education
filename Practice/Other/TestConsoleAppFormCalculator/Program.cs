using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string result = Console.ReadLine();
            string result = "5-(5/2-7+35)-9*7+2*8+1*2/2";
            Regex regexSymbol = new Regex(@"\)|\(|\%|\+|\-|\*|\/|\d+,?\d+|\d+");
            MatchCollection kitMath = regexSymbol.Matches(result);
            var kit = new string[kitMath.Count];
            for (int i = 0; i < kit.Length; i++)
            {
                kit[i] = kitMath[i].ToString();
            }

            if (kit.Length > 3)
            {
                for (int k = 0; k < kit.Length; k++)
                {
                    //while (kit[i] == ")" || kit[i] == "(")
                    var inskobb = new string[kit.Length];
                    for (int i = 0; i < kit.Length; i++)
                    {
                        int first = 0;
                        int second = 0;
                        if (kit[i] == "(")
                        {
                            first = i;
                            kit[i] = null;
                        }
                        if (kit[i] == ")")
                        {
                            second = i;
                            kit[i] = null;
                        }
                        for (int j = 0; j < second - first; j++)
                        {
                            inskobb[j] += kit[i];
                        }
                    }


                    Interest(inskobb);

                    Division(inskobb);
                    Multiplication1(inskobb);
                    Summ(inskobb);
                    Console.WriteLine(inskobb[0]);
                }

            }
            Interest(kit);

            Division(kit);
            Multiplication1(kit);
            Summ(kit);

            listCW(kit);
        }

        private static void Interest(string[] kit)
        {
            if (kit.Length > 1)
            {
                for (int k = 0; k < kit.Length; k++)
                {
                    for (int i = 0; i < kit.Length; i++)
                    {
                        if (kit[i] == "%")
                        {
                            double res = 0;
                            if (i > 2 && kit[i - 2] == "-")
                            {
                                res = Convert.ToDouble(kit[i - 1]) / 100 * -1;
                                kit[i - 2] = "+";
                            }
                            else
                            {
                                res = Convert.ToDouble(kit[i - 1]) / 100;
                            }
                            kit[i - 1] = res.ToString();
                            for (int j = 0; j < kit.Length - i - 2; j++)
                            {
                                kit[i + j] = kit[i + j + 2];
                            }
                            kit[kit.Length - 1] = null;
                        }
                    }
                }
            }
        }

        private static void Summ(string[] kit)
        {
            if (kit.Length > 3)
            {

                double resul = Convert.ToDouble(kit[0]);
                for (int k = 0; k < kit.Length; k++)
                {
                    if (kit[k] == "+")
                    {
                        resul += Convert.ToDouble(kit[k + 1]);
                    }
                    if (kit[k] == "-")
                    {
                        resul -= Convert.ToDouble(kit[k + 1]);
                    }
                }
                kit[0] = (resul).ToString();
            }
        }

        private static void Multiplication(string[] kit)
        {
            if (kit.Length > 3)
            {
                for (int k = 0; k < kit.Length; k++)
                {
                    for (int i = 0; i < kit.Length; i++)
                    {
                        if (kit[i] == "*")
                        {
                            double res = 0;
                            if (i > 2 && kit[i - 2] == "-")
                            {
                                res = Convert.ToDouble(kit[i - 1]) * -1 * Convert.ToDouble(kit[i + 1]);
                                kit[i - 2] = "+";
                            }
                            else
                            {
                                res = Convert.ToDouble(kit[i - 1]) * Convert.ToDouble(kit[i + 1]);
                            }
                            kit[i - 1] = res.ToString();
                            for (int j = 0; j < kit.Length - i - 2; j++)
                            {
                                kit[i + j] = kit[i + j + 2];
                            }
                            kit[kit.Length - 1] = null;
                            kit[kit.Length - 2] = null;
                        }

                    }
                }
            }
        }
        private static void Multiplication1(string[] kit)
        {
            if (kit.Length > 3)
            {

                for (int i = 0; i < kit.Length; i++)
                {
                    while (kit[i] == "*")
                    {
                        double res = 0;
                        if (i > 2 && kit[i - 2] == "-")
                        {
                            res = Convert.ToDouble(kit[i - 1]) * -1 * Convert.ToDouble(kit[i + 1]);
                            kit[i - 2] = "+";
                        }
                        else
                        {
                            res = Convert.ToDouble(kit[i - 1]) * Convert.ToDouble(kit[i + 1]);
                        }
                        kit[i - 1] = res.ToString();
                        for (int j = 0; j < kit.Length - i - 2; j++)
                        {
                            kit[i + j] = kit[i + j + 2];
                        }
                        kit[kit.Length - 1] = null;
                        kit[kit.Length - 2] = null;
                    }

                }

            }
        }

        private static void Division(string[] kit)
        {
            if (kit.Length > 3)
            {
                for (int k = 0; k < kit.Length; k++)
                {
                    for (int i = 0; i < kit.Length; i++)
                    {
                        if (kit[i] == "/")
                        {
                            double res = 0;
                            if (i > 2 && kit[i - 2] == "-")
                            {
                                res = Convert.ToDouble(kit[i - 1]) / Convert.ToDouble(kit[i + 1]) * -1;
                                kit[i - 2] = "+";
                            }
                            else
                            {
                                res = Convert.ToDouble(kit[i - 1]) / Convert.ToDouble(kit[i + 1]);
                            }
                            kit[i - 1] = res.ToString();
                            for (int j = 0; j < kit.Length - i - 2; j++)
                            {
                                kit[i + j] = kit[i + j + 2];
                            }
                            kit[kit.Length - 1] = null;
                            kit[kit.Length - 2] = null;
                        }

                    }
                }
            }
        }

        private static void listCW(string[] kit)
        {

            Console.WriteLine("______________");
            Console.WriteLine();
            if (kit.Length > 0)
            {
                for (int i = 0; i < kit.Length; i++)
                {
                    Console.WriteLine(i + " " + kit[i]);
                }
            }
        }

    }

}
