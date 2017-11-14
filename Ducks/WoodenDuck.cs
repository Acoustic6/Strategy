using System;
using Strategy.Behaviour.Fly;
using Strategy.Behaviour.Quack;

namespace Strategy.Ducks
{
    public class WoodenDuck : DuckBase
    {
        public WoodenDuck() 
        {
            setFlyBehaviour(new NeverFly());
            setQuackBehaviour(new NeverQuack());
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Wooden Duck, Greetings!");
        }

        public override void Fly()
        {

        }

        public override void Quack()
        {
            
        }
    }
}