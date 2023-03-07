using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11._1
{
    public class Apple : Product
    {
        public Apple(string name, int caloria, int volume) : base(name, caloria, volume)
        {

        }
        public static Apple Add(Apple apple1, Apple apple2)
        {
            int calories = (int)Math.Round(((apple1.Caloria + apple2.Caloria) / 2.0));
            var volume = apple1.Volume + apple2.Volume;
            var apple = new Apple("Яблоко", calories, volume);
            return apple;
        }
        public static Apple operator +(Apple apple1, Apple apple2)
        {
            int calories = (int)Math.Round(((apple1.Caloria + apple2.Caloria) / 2.0));
            var volume = apple1.Volume + apple2.Volume;
            var apple = new Apple("Яблоко", calories, volume);
            return apple;

        }
        public static Apple operator +(Apple apple1, int volume)
        {
            var apple = new Apple(apple1.Name, apple1.Caloria, apple1.Caloria + volume);
            return apple;
        }
        public static bool operator ==(Apple apple1, Apple apple2)
        {
            return apple1.Name == apple2.Name;
        }
        public static bool operator !=(Apple apple1, Apple apple2)
        {
            return apple1.Name == apple2.Name;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
