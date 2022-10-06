using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class SwimFast : ISwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("I'm swimming so fast!!");
        }
    }
}
