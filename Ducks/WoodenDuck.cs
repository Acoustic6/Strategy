using System;

namespace Strategy.Ducks
{
    public class WoodenDuck : DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("I'm a Wooden Duck, Greetings!");
        }
    }
}