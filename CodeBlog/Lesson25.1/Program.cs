namespace Lesson25._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var photo = new Photo("hello.png")
            {
                Path = @"E:\hello.png"
            };

            var type = typeof(Photo);
            var attributes = type.GetCustomAttributes(false);
            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute);
            }

            var properties = type.GetProperties();
            foreach (var prop in properties)
            {
                var attrs = prop.GetCustomAttributes(false);

                if(attrs.Any(a=>a.GetType() == typeof(GeoAttribute)))
                {
                    Console.WriteLine(prop.PropertyType + " " + prop.Name + " " + prop.Attributes);
                }

                //foreach(var attr in attrs)
                //{
                //    Console.WriteLine(attr); 
                //}
            }


        }
    }
}