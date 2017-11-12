using System;
using Strategy.Ducks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var rubber = new RubberDuck();
            rubber.Fly();//not expected behaviour!

            var wooden = new WoodenDuck();
            wooden.Quack();//not expected behaviour!
        }
    }
}
