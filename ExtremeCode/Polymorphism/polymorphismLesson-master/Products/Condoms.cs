namespace SexShop.Products
{
    class Condoms : Product
    {
        public int Size { get; set; }

        public Condoms(string name, int price, string manufacturer, int size)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Size = size;
        }
        public double GetDiscountPrice(User user)
        {
            string name = user.Name;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[0] == 'З')
                {
                    return Price / 100 * 73;
                }
            }
           
            return Price;
        }
    }
}
