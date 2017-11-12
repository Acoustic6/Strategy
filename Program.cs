using System;
using Strategy.Ducks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var mallard = new MallardDuck();
            var readhead = new ReadheadDuck();
            mallard.Display();
            readhead.Display();
            mallard.Quack();
            readhead.Swim();
        }
    }
}
