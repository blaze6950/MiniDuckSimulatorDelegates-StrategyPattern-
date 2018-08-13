using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator
{
    class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            FlyBehavior = FlyNoWay.Fly;
            QuackBehavior = MuteQuackR.Quack;
        }

        public override void Display()
        {
            Console.WriteLine("Я DecoyDuck!");
        }
    }
}
