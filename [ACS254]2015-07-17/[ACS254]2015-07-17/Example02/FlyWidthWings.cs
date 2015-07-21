using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public class FlyWidthWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("振翅高飛");
        }
    }
}