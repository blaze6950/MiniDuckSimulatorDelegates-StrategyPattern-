using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck rubber = new RubberDuck();
            rubber.Display();
            rubber.PerformFly();
            rubber.FlyBehavior = FlyRocketPowered.Fly;
            rubber.PerformFly();
            rubber.PerformQuack();
            rubber.QuackBehavior = MuteQuackR.Quack;
            rubber.PerformQuack();
        }
    }
}
