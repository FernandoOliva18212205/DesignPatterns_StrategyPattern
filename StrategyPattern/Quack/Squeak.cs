using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
