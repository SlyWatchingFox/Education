using SexShop.Products;
using System;

namespace SexShop
{
    class Informer
    {
        public void Buy(User user, Product product)
        {
            double price = product.GetDiscountPrice(user);
            user.ReduceBalance(price);
            Console.WriteLine($"{user.Name} купил {product.Name} за {price}. Заказ отправлен на склад");
        }
        public void BuyAphrodisiacs(User user, Aphrodisiacs aphrodisiac)
        {
            double price = aphrodisiac.GetDiscountPrice(user);
            user.ReduceBalance(price);
            Console.WriteLine($"{user.Name} купил {aphrodisiac.Name} за {price}. Заказ отправлен на склад");
        }
        public void BuyDolls(User user, Dolls doll)
        {
            double price = doll.GetDiscountPrice(user);
            user.ReduceBalance(price);
            Console.WriteLine($"{user.Name} купил {doll.Name} за {price}. Заказ отправлен на склад");
        }
        public void BuyCondoms(User user, Condoms condom)
        {
            double price = condom.GetDiscountPrice(user);
            user.ReduceBalance(price);
            Console.WriteLine($"{user.Name} купил {condom.Name} за {price}. Заказ отправлен на склад");
        }
    }
}
