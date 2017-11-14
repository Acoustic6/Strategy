using System;

namespace Strategy.Behaviour.Fly
{
    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I fly with my wings!");
        }
    }
}