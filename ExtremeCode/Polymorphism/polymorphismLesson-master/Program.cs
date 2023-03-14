using System;
using SexShop.Products;

namespace SexShop
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(
                "Artem",
                "Улица Пушкина, дом Колотушкина",
                100000,
                550
                );

            Console.WriteLine("Список товаров:");

            Dolls gusDolls = new Dolls(
                "Гусь",
                200,
                "Гусыня",
                "резина"
                );

            Console.WriteLine("Кукла:");
            Console.WriteLine("Название: " + gusDolls.Name);
            Console.WriteLine("Цена: " + gusDolls.Price);
            Console.WriteLine("Производитель: " + gusDolls.Manufacturer);
            Console.WriteLine("Материал: " + gusDolls.Material);
            Console.WriteLine(new String('-', 25));

            Condoms DirtyJoes = new Condoms(
                "Грязный Джо",
                400,
                "Хэнд Мейд",
                25
                );

            Console.WriteLine("Контрацептив:");
            Console.WriteLine("Название: " + DirtyJoes.Name);
            Console.WriteLine("Цена: " + DirtyJoes.Price);
            Console.WriteLine("Производитель: " + DirtyJoes.Manufacturer);
            Console.WriteLine("Размер: " + DirtyJoes.Size);
            Console.WriteLine(new String('-', 25));

            Aphrodisiacs HorsesAphrodisiacs = new Aphrodisiacs(
                "Конский возбудитель",
                500,
                "Ферма Дяди Васи",
                "Любовь"
                );

            Console.WriteLine("Афродизиак:");
            Console.WriteLine("Название: " + HorsesAphrodisiacs.Name);
            Console.WriteLine("Цена: " + HorsesAphrodisiacs.Price);
            Console.WriteLine("Производитель: " + HorsesAphrodisiacs.Manufacturer);
            Console.WriteLine("Состав: " + HorsesAphrodisiacs.Composition);
            Console.WriteLine(new String('-', 25));

            Aphrodisiacs FriendAphrodisiacs = new Aphrodisiacs("" +
                "Завали Подругу",
                700,
                "Мачо Индастриз",
                "Клофелин, Спиртяга"
                );

            Console.WriteLine("Афродизиак:");
            Console.WriteLine("Название: " + FriendAphrodisiacs.Name);
            Console.WriteLine("Цена: " + FriendAphrodisiacs.Price);
            Console.WriteLine("Производитель: " + FriendAphrodisiacs.Manufacturer);
            Console.WriteLine("Состав: " + FriendAphrodisiacs.Composition);
            Console.WriteLine(new String('-', 25));

            AnalLube vasilin = new AnalLube(
                "Вазилин",
                500,
                "Вазилинодельня #1"
                );

            Console.WriteLine("Афродизиак:");
            Console.WriteLine("Название: " + vasilin.Name);
            Console.WriteLine("Цена: " + vasilin.Price);
            Console.WriteLine("Производитель: " + vasilin.Manufacturer);
            Console.WriteLine(new String('-', 25));


            Product[] products = new Product[]
            {


                vasilin
            };
            Aphrodisiacs[] aphrodisiacs = new Aphrodisiacs[]
            {
                HorsesAphrodisiacs,
                FriendAphrodisiacs,
            };
            Dolls[] dolls = new Dolls[]
            {
                gusDolls,
            };
            Condoms[] condoms = new Condoms[]
            {
                DirtyJoes,
            };

            Informer informer = new Informer();
            //Console.WriteLine(aphrodisiacs[3 - products.Length].Name);

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Здравствуйте {user.Name} ваш баланс {user.Balance}");

                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Товар {i} {products[i].Name} по цене {products[i].Price}");
                }
                for (int i = 0; i < aphrodisiacs.Length; i++)
                {
                    Console.WriteLine($"Товар {i + products.Length} {aphrodisiacs[i].Name} по цене {aphrodisiacs[i].Price}");
                }
                for (int i = 0; i < dolls.Length; i++)
                {
                    Console.WriteLine($"Товар {i + products.Length + aphrodisiacs.Length} {dolls[i].Name} по цене {dolls[i].Price}");
                }
                for (int i = 0; i < condoms.Length; i++)
                {
                    Console.WriteLine($"Товар {i + products.Length + aphrodisiacs.Length + dolls.Length} {condoms[i].Name} по цене {condoms[i].Price}");
                }
                Console.WriteLine("Выберете номер товара и нажмите Enter:");

                string str = Console.ReadLine();
                int productNumber = Convert.ToInt32(str);
                int LenghtDolls = products.Length + aphrodisiacs.Length;
                int LenghtCondoms = products.Length + aphrodisiacs.Length + dolls.Length;

                if (productNumber >= 0 && productNumber < products.Length)
                {

                    if (products[productNumber].Price < user.Balance)
                    {
                        informer.Buy(user, products[productNumber]);
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }

                }
                if (productNumber >= products.Length && productNumber < aphrodisiacs.Length + products.Length)
                {

                    if (aphrodisiacs[productNumber - products.Length].Price < user.Balance)
                    {
                        informer.BuyAphrodisiacs(user, aphrodisiacs[productNumber - products.Length]);
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }

                }
                if (productNumber >= LenghtDolls && productNumber < LenghtDolls + dolls.Length)
                {

                    if (dolls[productNumber - LenghtDolls].Price < user.Balance)
                    {
                        informer.BuyDolls(user, dolls[productNumber - LenghtDolls]);
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }

                }
                if (productNumber >= LenghtCondoms && productNumber < LenghtCondoms + condoms.Length)
                {
                    
                    if (condoms[productNumber - LenghtCondoms].Price < user.Balance)
                    {
                        informer.BuyCondoms(user, condoms[productNumber - LenghtCondoms]);
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }

                }
                else
                {
                    Console.WriteLine("Таких товаров нет");
                }
            }
        }
    }
}
