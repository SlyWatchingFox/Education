namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Введите координаты двух точек (четыре целых числа: x1, y1, x2, y2):");
                double x1, x2, y1, y2;
                while (!double.TryParse(Console.ReadLine(), out x1))
                {
                    Console.WriteLine("Не верный ввод. Повторите");
                }
                while (!double.TryParse(Console.ReadLine(), out y1))
                {
                    Console.WriteLine("Не верный ввод. Повторите");
                }
                while (!double.TryParse(Console.ReadLine(), out x2))
                {
                    Console.WriteLine("Не верный ввод. Повторите");
                }
                while (!double.TryParse(Console.ReadLine(), out y2))
                {
                    Console.WriteLine("Не верный ввод. Повторите");
                }
                double result = Distance(x1, x2, y1, y2);
                Console.WriteLine($"Расстояние: {result}");
            }
            static double Distance(double x1, double x2, double y1, double y2)
            {
                double x = Math.Pow(x2 - x1, 2);
                double y = Math.Pow(y2 - y1, 2);
                double distance = Math.Sqrt(x + y);
                return distance;
            }
            //        Выполнить: Создайте метод Distance который вычисляет расстояние между двумя точками на плоскости.Координаты точек вводятся(переменные x1, y1 — для первой точки, и x2, y2 — для второй).
            //Указание 1: Метод Distance() принимает 4 аргумента(координаты точек).
            //Указание 2: Метод не должен возвращать значение, поэтому следует использовать ключевой слово void в сигнатуре:
            //            static void Distance(...);
            //Указание 3: Для подсчета расстояния между двумя точками на плоскости используйте формулу:
        }
    }
}