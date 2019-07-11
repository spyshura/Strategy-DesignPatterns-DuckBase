using System;
using System.Collections.Generic;
using Strategy_DuckBase.Duck;

namespace Strategy_DuckBase
{
    class MyClass
        {
            public string indt;
        }
    class Program
    {
        static void Main(string[] args)
        {

            List<DuckBase> ducks = new List<DuckBase>();
            ducks.Add(new SimpleDuck());
            ducks.Add(new ExoticDuck());
            ducks.Add(new WoodenDuck());
            ducks.Add(new RubbenDuck());

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.Swim();
                duck.Fly();
                duck.Quack();

                Console.WriteLine();
            }

            UpdatebleDuck upduck = new UpdatebleDuck();
            upduck.Display();
            upduck.Swim();
            upduck.Fly();
            upduck.Quack();
            upduck.SetFlyBehaviour(new Fly.FlyWithWings());
            upduck.SetQuackBehaviour(new Quack.SimpleQuack());
            upduck.Fly();
            upduck.Quack();


            Console.ReadKey();
        }
       
    }

}
