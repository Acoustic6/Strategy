using System;

namespace Strategy.Ducks
{
    public abstract class DuckBase
    {
        public abstract void Display();
        public virtual void Quack() 
        {
            Console.WriteLine("Quack!");
        }  
        public void Swim() 
        {
            Console.WriteLine("I swim");
        }
        public virtual void Fly() 
        {
            Console.WriteLine("Wow! I fly!");
        }
    }
}