using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = FlyWithWings.Fly;
            QuackBehavior = QuackR.Quack;
        }

        public override void Display()
        {
            Console.WriteLine("Я Mallard Duck!");
        }
    }
}
