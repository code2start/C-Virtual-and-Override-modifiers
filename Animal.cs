using System;
namespace virtualandoverridemodifiers
{
    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("this will be chage implementation");
        }
    }
}