using StrategyPattern;
using System;

namespace StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new DuckQuack();
            FlyBehavior = new FlyWithWings();
            SwimBehavior = new SwimFreestyle();
        }

        public override void Display()
        {
            Console.WriteLine("I am a real Mallard Duck.");
        }
              
    }
}
