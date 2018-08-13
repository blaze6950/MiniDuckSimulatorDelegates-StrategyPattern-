using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator
{
    public delegate void FlyBehaviour();

    public delegate void QuackBehavior();
    abstract class Duck
    {
        public FlyBehaviour FlyBehavior { get; set; }
        public QuackBehavior QuackBehavior { get; set; }

        public Duck()
        {
        }
        public void Swim()
        {
            Console.WriteLine("Я плаваю");
        }
        public virtual void Display()
        {
            Console.WriteLine("Я утка!");
        }
        public void PerformQuack()
        {
            QuackBehavior();
        }
        public void PerformFly()
        {
            FlyBehavior();
        }
    }
}
