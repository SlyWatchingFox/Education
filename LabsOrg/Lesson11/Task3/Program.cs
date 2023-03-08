namespace Task3
//Задание 3:
//Выполнить: Создайте программу подсчитывающую количество сочетаний букв «ma» в тексте.
//Не разрешается использовать стандартные методы, выполните программу, используя цикл для перебора символов в строке.
//Указание 1: Создайте функцию CountInText с двумя параметрами: строка с текстом и строка с сочетанием букв,
//которое необходимо искать в тексте.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            string let = "ma";
            CountInText(str, let);

        }
        public static void CountInText(string str, string let)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'm')
                {
                    if (str[i+1] == 'a')
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Строка {str} содержит {count} вхождений '{let}'");
        }
    }
}
