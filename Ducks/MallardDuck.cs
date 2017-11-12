using System;

namespace Strategy.Ducks
{
    public class MallardDuck : DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck, Greetings!");
        }
    }
}