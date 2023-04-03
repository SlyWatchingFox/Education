using System.Reflection;
using System.Windows.Forms;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var directory = new DirectoryInfo(Assembly.GetExecutingAssembly().Location);
                if (directory != null)
                {
                    Assembly asmDll;
                    FileInfo[] files = directory.GetFiles(".dll");
                    var dllList = new List<string>();
                    foreach (FileInfo file in files)
                    {
                        asmDll = Assembly.LoadFrom(file.FullName);
                        Type[] types = asmDll.GetTypes();
                        foreach (Type type in types)
                        {
                            if (type == typeof(UserControl))
                            {
                                Console.WriteLine(type);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}