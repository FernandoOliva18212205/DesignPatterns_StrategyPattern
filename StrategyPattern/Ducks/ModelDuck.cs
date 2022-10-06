using StrategyPattern;
using System;

namespace StrategyPattern
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new DuckQuack();
            SwimBehavior = new SwimFast();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Model Duck! ");
        }
    }
}
