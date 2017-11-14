using System;
using Strategy.Behaviour.Quack;
using Strategy.Behaviour.Fly;

namespace Strategy.Ducks
{
    public abstract class DuckBase
    {
        protected IFlyBehaviour flyBehaviour;
        protected IQuackBehaviour quackBehaviour;

        public abstract void Display();

        public virtual void Quack() 
        {
            quackBehaviour.Quack();
        }  
        public void Swim() 
        {
            Console.WriteLine("I swim");
        }
        public virtual void Fly() 
        {
            flyBehaviour.Fly();
        }

        public void setFlyBehaviour(IFlyBehaviour newFlyBehaviour) {
            flyBehaviour = newFlyBehaviour;
        }

        public void setQuackBehaviour(IQuackBehaviour newQuackBehaviour) {
            quackBehaviour = newQuackBehaviour;
        }
    }
}