using System;

namespace Strategy.Ducks
{
    public abstract class DuckBase
    {
        public abstract void Display();
        public void Quack() 
        {
            Console.WriteLine("Quack!");
        }  
        public void Swim() 
        {
            Console.WriteLine("I swim");
        }
        public void Fly() 
        {
            Console.WriteLine("Wow! I fly!");
        }
    }
}