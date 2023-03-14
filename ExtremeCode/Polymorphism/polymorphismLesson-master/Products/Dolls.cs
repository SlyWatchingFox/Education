namespace SexShop.Products
{
    class Dolls : Product
    {
        public string Material { get; private set; }

        public Dolls(string name, int price, string manufacturer, string material)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Material = material;
        }
        public double GetDiscountPrice(User user)
        {
            return Price / 100 * 75;
        }
    }
}
