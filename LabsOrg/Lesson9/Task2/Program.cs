using System.Runtime.Intrinsics.X86;

namespace Task2
{
    //Выполнить: Создайте метод(функцию) для нахождения минимума среди целочисленной последовательности и для изменения значения найденного минимального
    //элемента в 0. Вызовите метод дважды: с тремя целыми числами и с целочисленным массивом в качестве параметров.Нельзя использовать стандартную функцию min.
    //Указание 1: Create a class named Mimimum and a function named FindMin within the class. The function returns an array, that’s why you must use the signature
    //with return type int[]:
    //public int[] FindMin(params int[] numbers)
    //Указание2: В коде метода необходимо использовать циклы foreach и for:
    //1. Цикл foreach необходимо использовать для поиска минимума(как найти минимальный элемент: здесь (lab 3), ино используйте цикл foreach).
    //2. Цикл for необходим для поиска значений, которые равны минимальному, и присваиванию им значения 0.
    //Указание3: Функция возвращает массив, поэтому при вызове функции возвращаемое значение должно быть сохранено в переменную-массив:
    //int[] result1 = minimum.FindMin(5, 3, 6);
    //foreach (var i in result1)
    //            {
    //                ...
    //            }
    internal class Program
    {
         
        static void Main(string[] args)
        {
            var mimimum = new Mimimum();
            int[] result1 = mimimum.FindMin(5, 3, 6);
            foreach (int i in result1) { Console.WriteLine(i); }
           
            
        }
    }
}