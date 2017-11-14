using System;
using Strategy.Behaviour.Fly;
using Strategy.Behaviour.Quack;

namespace Strategy.Ducks
{
    public class RubberDuck : DuckBase
    {
        public RubberDuck() 
        {
            setFlyBehaviour(new NeverFly());
            setQuackBehaviour(new NeverQuack());
        }
        
        public override void Display() 
        {
            Console.WriteLine("I'm a Rubber Duck, Greetings!");
        }

        public override void Fly() 
        {
            
        }
    }
}