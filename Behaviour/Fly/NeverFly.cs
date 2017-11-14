using System;

namespace Strategy.Behaviour.Fly
{
    public class NeverFly : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Sorry, I never fly");
        }
    }
}