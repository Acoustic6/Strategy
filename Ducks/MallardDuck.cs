using System;
using Strategy.Behaviour.Fly;
using Strategy.Behaviour.Quack;

namespace Strategy.Ducks
{
    public class MallardDuck : DuckBase
    {
        public MallardDuck()
        {
            setFlyBehaviour(new FlyWithWings());
            setQuackBehaviour(new CommonQuack());
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck, Greetings!");
        }
    }
}