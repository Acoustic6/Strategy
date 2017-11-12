using System;

namespace Strategy.Ducks
{
    public class RubberDuck : DuckBase
    {
        public override void Display() 
        {
            Console.WriteLine("I'm a Rubber Duck, Greetings!");
        }
    }
}