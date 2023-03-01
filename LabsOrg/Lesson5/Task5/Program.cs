namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двузначное число:");
            int digit;

            while (!int.TryParse(Console.ReadLine(), out digit))
            {
                Console.WriteLine("Не верный ввод. Повторите");
            }

            ChangeDigits(digit);
        }
        static void ChangeDigits(int digit)
        {
            int digit1 = digit / 10;
            int digit2 = digit % 10;
            int changeDigit = digit2 * 10 + digit1;
            Console.WriteLine($"Результат:{changeDigit}");
        }
        //        Задание 5:
        //Выполнить: Вводится двузначное целое число.Создайте метод ChangeDigits(), который принимает введенный аргумент по ссылке и изменяет его значение так, чтобы первая цифра нового числа была второй цифрой введенного числа и, наоборот, вторая цифра нового числа была первой цифрой введенного числа.Например, если ввести 45, то результирующее число будет равно 54.
        //Указание 1: Метод ChangeDigits() принимает аргумент с модификатором ref.
        //Указание 2: Метод не возвращает значения:
        //static void ChangeDigits(...);
        //Указание 3: Сначала необходимо получить цифры из числа.Затем, поменяв местами цифры, сделать новое число.Пример создания нового числа из двух цифр:
    }
}