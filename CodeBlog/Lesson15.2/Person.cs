﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15._2
{
    internal class Person
    {
        public event Action GoToSleep;
        public event EventHandler DoWork;

        public string Name { get; set; }     

        public void TakeTime(DateTime now)
        {
            if (now.Hour <= 8)
            {
                GoToSleep?.Invoke();
            }
            else
            {
                var args = new EventArgs();
                DoWork?.Invoke(this, args);
            }
        }
    }
}
