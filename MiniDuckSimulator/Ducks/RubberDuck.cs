using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator
{
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehavior = FlyNoWay.Fly;
            QuackBehavior = SqueakR.Quack;
        }

        public override void Display()
        {
            Console.WriteLine("Я RubberDuck!");
        }
    }
}
