using StrategyPattern;
using System;

namespace StrategyPattern
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new MuteQuack();
            SwimBehavior = new SwimFast();
        }

        public override void Display()
        {
            Console.WriteLine("I am a Decoy Duck!!");
        }
    }
}
