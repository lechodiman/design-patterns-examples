using System;

namespace duck_reunion
{
    public interface Quackable
    {
        void Quack();
    }

    public class MallardDuck : Quackable
    {
        public void Quack()
        {
            System.Console.WriteLine("Quack");
        }
    }

    public class RedheadDuck : Quackable
    {
        public void Quack()
        {
            System.Console.WriteLine("Quack");
        }
    }

    public class DuckCall : Quackable
    {
        public void Quack()
        {
            System.Console.WriteLine("Kwak");
        }
    }

    public class RubberDuck : Quackable
    {
        public void Quack()
        {
            System.Console.WriteLine("Squeak");
        }
    }
}
