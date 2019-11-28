using System;

namespace duck_reunion
{
    public class GooseAdapter : Quackable
    {
        private Goose Goose;

        public GooseAdapter(Goose goose)
        {
            Goose = goose;
        }

        public void Quack()
        {
            Goose.Honk();
        }
    }
}
