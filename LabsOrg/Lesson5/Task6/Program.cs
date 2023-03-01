namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два двузначных числа:");
            int num1, num2;

            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Не верный ввод. Повторите");
            }
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Не верный ввод. Повторите");
            }
            int bitwiseSum = BitwiseSum(num1, num2);
            Console.WriteLine($"Побитовая сумма чисел {num1} и {num2} = {bitwiseSum}");
        }
        static int BitwiseSum(int num1, int num2)
        {
            int digit1num1 = num1 / 10; 
            int digit2num1 = num1 % 10;
            int digit1num2 = num2 / 10;
            int digit2num2 = num2 % 10;
            int bitwiseSum1 = digit1num1 + digit1num2;
            int bitwiseSum2 = digit2num1 + digit2num2;
            if (bitwiseSum1 > 9)
            {
                bitwiseSum1 = bitwiseSum1 % 10;
            }
            if (bitwiseSum2 > 9)
            {
                bitwiseSum2 = bitwiseSum2 % 10;
            }
            int bitwiseSum = bitwiseSum1 * 10 + bitwiseSum2;
            
            return bitwiseSum;

        }
    }
}
