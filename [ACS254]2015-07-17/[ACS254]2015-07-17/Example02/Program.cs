using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Duck> duckList = new List<Duck>();
            duckList.Add(new RedheadDuck() { Name = "紅色小鴨" });
            duckList.Add(new MallarDuck() { Name = "綠色小鴨" });
            duckList.Add(new RubberDuck() { Name = "黃色小鴨" });
            duckList[1].flybehavior = new FlyWidthWings();
            duckList[2].flybehavior = new FlyNoWay();
            foreach (Duck duck in duckList)
            {
                duck.Display();
            }
        }
    }
}