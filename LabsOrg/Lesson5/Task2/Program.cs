namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение для трёх сторон треугольника:");
            int a, b, c;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Не верный ввод. Повторите");
            }
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Не верный ввод. Повторите");
            }
            while (!int.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Не верный ввод. Повторите");
            }
            int result = Perimeter(a, b, c);
            Console.WriteLine($"Периметр: {result}");
        }
        static int Perimeter(int a, int b, int c)
        {
         int perimeter = a + b + c;
         return perimeter;
        }
        //Выполнить: Необходимо переделать предыдущую задачу, теперь функция периметр должна возвращать целое значение.
    }
}