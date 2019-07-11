using System;
using System.Collections.Generic;
using System.Text;
using Strategy_DuckBase.Quack;
using Strategy_DuckBase.Fly;

namespace Strategy_DuckBase.Duck
{
    class WoodenDuck : DuckBase
    {
        public WoodenDuck()
        {
            quackBehaviour = new NoQuack();
            flyBehaviour = new NoFly();
        }

        public override void Display()
        {
            Console.WriteLine("Hi! I'm Wooden Duck!");
        }
    }
}
