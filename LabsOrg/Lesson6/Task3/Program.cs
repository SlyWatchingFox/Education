namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральные числа N и a:");
            int N, w;
            while (!int.TryParse(Console.ReadLine(), out N))
            {
                Console.WriteLine("Не верный ввод. Повторите");
            } while (!int.TryParse(Console.ReadLine(), out w))
            {
                Console.WriteLine("Не верный ввод. Повторите");
            }
            IEnumerable<int> seq;
            seq = System.Linq.Enumerable.Range(N, w).Select((a, b) => (a + b));
            foreach (var x in seq)
                Console.Write($"{x} ");
        }
        //Выполнить: Создайте последовательность из 9 целых чисел, начиная с 1 с шагом = 2.
        //Указание: чтобы получить шаг, вы можете использовать лямбда-выражение... .Select((a, b)=> ...);. Подумайте, что нужно вставить вместо....
    }
}