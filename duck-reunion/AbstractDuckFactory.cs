using System;

namespace duck_reunion
{
    // Abstract factory pattern
    public abstract class AbstractDuckFactory
    {
        public abstract Quackable CreateMallardDuck();
        public abstract Quackable CreateReadheadDuck();
        public abstract Quackable CreateDuckCall();
        public abstract Quackable CreateRubberDuck();
    }
}
