using System;

namespace Strategy.Behaviour.Quack
{
    public class NeverQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("...");
        }
    }
}