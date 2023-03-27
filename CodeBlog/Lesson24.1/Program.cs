namespace Lesson24._1
{
    internal class Program
    {
        private static int item;

        public string Name { get; private set; }

        public delegate int MyHandler(int i);
        static void Main(string[] args)
        {
            var lesson = new Lesson("Program C#");
            lesson.Started += (sender, date) =>
            {
                Console.WriteLine(sender);
                Console.WriteLine(date);
            };
            lesson.Start();


            var list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            var res = list.Aggregate((x, y) => x + y);
            Console.WriteLine(res);

            var result1 = Agr(list, delegate (int i)
            {
                var r = i * i;
                Console.WriteLine(r);
                return r;
            });

            var result2 = Agr(list, Method);

            var result3 = Agr(list, x => x * x * x * x);










            //delegate (тип_аргумента аргумент1, тип_аргумента аргумент2)
            //{
            //    Реализация анонимного метода
            //}
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                MyHandler handler = delegate (int i)
                {
                    var r = i * i;
                    Console.WriteLine(r);
                    return r;
                };
                //handler += Method;

                handler(result);
                handler(result);



                MyHandler lambdaHandler = (i) => // i * i;
                {
                    var r = i * i;
                    Console.WriteLine(r);
                    return r;
                };
                lambdaHandler(99);
            }
            Method(88);

        }

        public static int Agr(List<int> list, MyHandler handler)
        {
            var result = 0;
            foreach (int i in list)
            {
                result += handler(item);
            }
            return result;
        }
        public static int Method(int i)
        {
            var r = i * i * i;
            Console.WriteLine(r);
            return r;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}