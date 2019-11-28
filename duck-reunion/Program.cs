using System;

namespace duck_reunion
{
    class Program
    {
        static void Main(string[] args)
        {
            var duckFactory = new CountingDuckFactory();
            Simulate(duckFactory);
        }

        static void Simulate(AbstractDuckFactory duckFactory)
        {
            var mallardDuck = duckFactory.CreateMallardDuck();
            var redheadDuck = duckFactory.CreateReadheadDuck();
            var duckCall = duckFactory.CreateDuckCall();
            var rubberDuck = duckFactory.CreateRubberDuck();
            var gooseDuck = new GooseAdapter(new Goose());

            System.Console.WriteLine("Duck Simulator: With Abstract Factory");

            var flockOfDucks = new Flock();

            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);

            var flockOfMallards = new Flock();

            var mallardOne = duckFactory.CreateMallardDuck();
            var mallardTwo = duckFactory.CreateMallardDuck();
            var mallardThree = duckFactory.CreateMallardDuck();
            var mallardFour = duckFactory.CreateMallardDuck();

            flockOfMallards.Add(mallardOne);
            flockOfMallards.Add(mallardTwo);
            flockOfMallards.Add(mallardThree);
            flockOfMallards.Add(mallardFour);

            flockOfDucks.Add(flockOfMallards);

            System.Console.WriteLine("\nDuck Simulator: Whole Flock Simulation");
            SimulateQuack(flockOfDucks);

            System.Console.WriteLine("\nDuck Simulator: Mallard Flock Simulation");
            SimulateQuack(flockOfMallards);

            System.Console.WriteLine("The ducks quacked {0} times", QuackCounter.GetQuacks());
        }

        static void SimulateQuack(Quackable duck)
        {
            duck.Quack();
        }
    }
}
