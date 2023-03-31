using System;
using System.Text.RegularExpressions;

namespace FormCalculator
{
    public static class MathOperations
    {
        public static string Main1(string s)
        {
            string result = s;
            Regex regexSymbol = new Regex(@"\%|\+|\-|\*|\/|\d+,?\d+|\d+");
            MatchCollection kitMath = regexSymbol.Matches(result);
            var kit = new string[kitMath.Count];
            for (int i = 0; i < kit.Length; i++)
            {
                kit[i] = kitMath[i].ToString();
            }
            Interest(kit);
            Division(kit);
            Multiplication(kit);
            Summ(kit);
            if (kit.Length > 0)
            {
                return kit[0];
            }
            return null;
        }
        private static void Interest(string[] kit)
        {
            if (kit.Length > 1)
            {
                for (int i = 0; i < kit.Length; i++)
                {
                    while (kit[i] == "%")
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
        private static void Summ(string[] kit)
        {
            if (kit.Length >= 3)
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
            if (kit.Length >= 3)
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
            if (kit.Length >= 3)
            {
                for (int i = 0; i < kit.Length; i++)
                {
                    while (kit[i] == "/")
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
}
