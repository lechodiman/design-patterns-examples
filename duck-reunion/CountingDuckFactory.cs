using System;

namespace duck_reunion
{
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override Quackable CreateDuckCall()
        {
            return new QuackCounter(new MallardDuck());
        }

        public override Quackable CreateMallardDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }

        public override Quackable CreateReadheadDuck()
        {
            return new QuackCounter(new DuckCall());
        }

        public override Quackable CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}
