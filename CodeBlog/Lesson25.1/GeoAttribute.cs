﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson25._1
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Constructor)]
    public class GeoAttribute : Attribute
    {
        public int X { get; set; }
        public int Y { get; set; }

        public GeoAttribute() { }

        public GeoAttribute(int x, int y)
        {
            //Проверка входных данных
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"[{X};{Y}]";
        }
    }
}
