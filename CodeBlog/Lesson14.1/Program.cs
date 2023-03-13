namespace Lesson14._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 6;
            try
            {
                throw new DivideByZeroException("афываывпвывпыв");
                var k = 5;
                var j = k / 0; // trow new DivideByZeroException();
                Console.WriteLine(j);
                int a = 200000000;
                int b = 200000000;
                int c = checked(a * b);
                Console.WriteLine(c);
            }
            catch(MyOwnExpection ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex) when (i == 5)
            {
                Console.WriteLine("Деление на ноль (i = 5)");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) /*(тип_исключения, исключение)*/
            {
                Console.WriteLine("Какое-то исключение");
                throw;
            }
            finally
            {
                Console.WriteLine("Работа завершена");
                Console.ReadLine();
            }

        }
    }
}