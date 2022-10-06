using StrategyPattern;
using System;

namespace StrategyPattern
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Squeak();
            SwimBehavior = new SwimFreestyle();
        }

        public override void Display()
        {
            Console.WriteLine("I am a Rubber Duck!!");
        }
    }
}
