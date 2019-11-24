using System;

namespace virtualandoverridemodifiers
{
    public class Lion : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("I'm eating meat...");
        }
    }
}