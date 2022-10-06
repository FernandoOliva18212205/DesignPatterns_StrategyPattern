using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class DuckQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
