using System;
using Strategy.Behaviour.Fly;
using Strategy.Behaviour.Quack;

namespace Strategy.Ducks
{
    public class ReadheadDuck : DuckBase
    {
        public ReadheadDuck() {
            setFlyBehaviour(new FlyWithWings());
            setQuackBehaviour(new CommonQuack());
        }
        public override void Display() 
        {
            Console.WriteLine("I'm a Readhead Duck, Greetings!");
        }
    }
}