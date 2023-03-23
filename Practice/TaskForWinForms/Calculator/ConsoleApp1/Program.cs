using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = "9+99-9*8*8+1";
            Regex regexSymbol = new Regex(@"\+|\-|\*|\\|\d+");
            MatchCollection kitMath = regexSymbol.Matches(result);
            var kit = new string[kitMath.Count];
            for (int i = 0; i < kit.Length; i++)
            {
                kit[i] = kitMath[i].ToString();
            }

            double res = 0;
            if (kit.Length > 3)
            {
                for (int i = 0; i < kit.Length; i++)
                {
                    if (kit[i] == "*")
                    {
                        if (kit[i - 2] == "-")
                        {
                            res += Convert.ToDouble(kit[i - 1]) * -1 * Convert.ToDouble(kit[i + 1]);
                        }
                        else
                        {
                            res += Convert.ToDouble(kit[i - 1])* Convert.ToDouble(kit[i + 1]);
                        }
                    }
                }
            }
            Console.WriteLine(res);

            //Regex regexNumbers = new Regex(@"\d+");
            //MatchCollection numbers = regexNumbers.Matches(result);
            //var numbers1 = new string[numbers.Count];
            //for (int i = 0; i < numbers1.Length; i++)
            //{
            //    if (signs.Length > 2 && signs[i - 1] == "-")
            //    {
            //        numbers1[i] = (Convert.ToDouble(numbers[i]) * (-1)).ToString();
            //    }
            //    else
            //    {
            //        numbers1[i] = numbers[i].ToString();
            //    }
            //}
            //var kit = new string[symbol.Count+numbers.Count];



            //double resultt = Int32.Parse(numbers1[0]);
            //if (numbers1.Length > 2 && signs.Length > 1)
            //{
            //    for (int i = 0; i < signs.Length; i++)
            //    {
            //        //if (signs[i] == "*")
            //        //{
            //        //    resultt = resultt * Int32.Parse(numbers1[i + 1]);
            //        //}
            //        if (signs[i] == "+")
            //        {
            //            resultt += Int32.Parse(numbers1[i + 1]);
            //        }
            //        if (signs[i] == "-")
            //        {
            //            resultt -= Int32.Parse(numbers1[i + 1]);
            //        }
            //    }
            //}

            //Console.WriteLine(resultt);


















            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //if (numbers1.Length > 0)
            //{
            //    for (int i = 0; i < numbers1.Length; i++)
            //    {
            //        Console.WriteLine(i + " " + numbers[i]);
            //    }
            //}
            if (kit.Length > 0)
            {
                for (int i = 0; i < kit.Length; i++)
                {
                    Console.WriteLine(i + " " + kit[i]);
                }
            }
            //if (symbol.Count > 0)
            //{
            //    foreach (Match match in symbol)
            //        Console.WriteLine(match.Index + " " + match.Value);
            //}


        }
    }
}