using System;

namespace duck_reunion
{
    public class DuckFactory : AbstractDuckFactory
    {
        public override Quackable CreateDuckCall()
        {
            return new MallardDuck();
        }

        public override Quackable CreateMallardDuck()
        {
            return new RedheadDuck();
        }

        public override Quackable CreateReadheadDuck()
        {
            return new DuckCall();
        }

        public override Quackable CreateRubberDuck()
        {
            return new RubberDuck();
        }
    }
}
