using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            base.Display();
            Console.WriteLine("我的頭是黃色的");
        }
    }
}