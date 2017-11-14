using System;

namespace Strategy.Behaviour.Quack
{
    public class CommonQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}