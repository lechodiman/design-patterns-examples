using System;

namespace duck_reunion
{
    // Quack Counter acts as a Decorator
    public class QuackCounter : Quackable
    {
        private Quackable Duck;
        static int NumberOfQuacks;

        public QuackCounter(Quackable duck)
        {
            Duck = duck;
        }

        public void Quack()
        {
            Duck.Quack();
            NumberOfQuacks += 1;
        }

        public static int GetQuacks()
        {
            return NumberOfQuacks;
        }
    }
}
