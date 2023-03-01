namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа: число и степень");
            double baseNum, powNum;
            while (!double.TryParse(Console.ReadLine(), out baseNum))
            {
                Console.WriteLine("Не верный ввод. Повторите");
            }
            while (!double.TryParse(Console.ReadLine(), out powNum))
            {
                Console.WriteLine("Не верный ввод. Повторите");
            }
            double result = GetPow(baseNum, powNum);
            Console.WriteLine($"Число {baseNum} возведённое в степень {powNum} ровно {result}");
        }
        static double GetPow(double baseNum, double powNum)
        {
            double getPow = Math.Pow(baseNum, powNum);
            return getPow;

        }
        //        Лабораторная работа 2. Построение экспоненциальной функции
        //Выполнить: Создайте метод GetPow(), который принимает два целочисленных аргумента — число и степень.Метод возвращает результат возведения числа в степень.
        //Указание 1: Необходимо использовать служебное слово static, потому что основная функция статичная(static), а мы не можем вызвать нестатический метод из статического метода.
        //Указание 2: Функция возвращает целочисленное значение, поэтому необходимо использовать int в сигнатуре функции:
        //static int GetPow(int baseNum, int powNum) {…}
    }
}