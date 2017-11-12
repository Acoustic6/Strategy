using System;

namespace Strategy.Ducks
{
    public class ReadheadDuck : DuckBase
    {
        public override void Display() 
        {
            Console.WriteLine("I'm a Readhead Duck, Greetings!");
        }
    }
}