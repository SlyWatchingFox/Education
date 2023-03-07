using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11._1
{
    public abstract class Product
    {
        public string Name { get; }
        /// <summary>
        /// Калорийность на 100 гр продукта
        /// </summary>
        public int Caloria { get; }
        /// <summary>
        /// Объем в граммах
        /// </summary>
        public int Volume { get; set; }
        public double Energy
        {
            get
            {
                return Volume * Caloria / 100.0;
            }

        }
        public Product(string name, int caloria, int volume)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(nameof(name));
            }
            if (caloria <= 0)
            {
                throw new ArgumentException(nameof(caloria));
            }
            if (volume < 0)
            {
                throw new ArgumentException(nameof(volume));
            }
            Name = name;
            Caloria = caloria;
            Volume = volume;
        }

        public override string ToString()
        {
            return $"{Name}.Kалорийность={Caloria}, Объём:{Volume}";
        }
    }
}
