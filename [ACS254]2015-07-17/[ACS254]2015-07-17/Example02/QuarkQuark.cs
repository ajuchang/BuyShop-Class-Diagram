using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public class QuarkQuark : IQuarkBehavior
    {
        public void Quark()
        {
            Console.WriteLine("我在呱呱叫");
        }
    }
}