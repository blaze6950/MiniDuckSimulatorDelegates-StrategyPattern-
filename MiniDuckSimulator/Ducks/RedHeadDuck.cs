using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator
{
    class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            FlyBehavior = FlyWithWings.Fly;
            QuackBehavior = QuackR.Quack;
        }

        public override void Display()
        {
            Console.WriteLine("Я ReadHeadDuck!");
        }
    }
}
