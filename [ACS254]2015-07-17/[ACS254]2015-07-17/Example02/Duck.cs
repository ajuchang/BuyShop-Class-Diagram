using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public abstract class Duck
    {
        public string Name { get; set; }

        public IFlyBehavior flybehavior;
        public IQuarkBehavior quarkbehavior;

        public void Swim()
        {
            Console.WriteLine("我在游泳");
        }

        public virtual void Display()
        {
            Console.WriteLine("{0}", this.Name);
            this.Quark();
            this.Swim();
            this.Fly();
        }

        public void Quark()
        {
            if (quarkbehavior != null)
                quarkbehavior.Quark();
        }

        public void Fly()
        {
            if (flybehavior != null)
                flybehavior.Fly();
        }
    }
}