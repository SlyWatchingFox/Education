namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность, завершите ввод 0");
            int counterPositive = 0;
            int counterNegative = 0;
            PosNegSeq(ref counterPositive, ref counterNegative);
            Console.WriteLine($"Кол-во отрицательных: {counterNegative}, количество положительных: {counterPositive}");
        }
        static void PosNegSeq(ref int counterPositive, ref int counterNegative)
        {

            int num;
            do
            {
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Не верный ввод. Повторите");
                }
                if (num>0 && num!=0) { counterPositive++; }
                if (num<0 && num!=0) { counterNegative++; }

            }
            while (num != 0);
        }
        
    }
}