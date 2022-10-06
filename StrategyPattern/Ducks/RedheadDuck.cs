using StrategyPattern;
using System;

namespace StrategyPattern
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new DuckQuack();
            SwimBehavior = new SwimUnderwater();
        }


        public override void Display()
        {
            Console.WriteLine("I'm a Redhead Duck!!");
        }
    }
}
