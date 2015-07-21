using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public class MallarDuck : Duck, IQuarkBehavior, IFlyBehavior
    {
        public override void Display()
        {
            base.Display();
            Console.WriteLine("我的頭是綠色的");
        }
    }
}