using System;
using System.Collections.Generic;
using System.Text;
using Strategy_DuckBase.Fly;

namespace Strategy_DuckBase.Duck
{
    class RubbenDuck : DuckBase
    {
        public RubbenDuck()
        {
            flyBehaviour = new NoFly();
        }
        public override void Display()
        {
            Console.WriteLine("Hi! I'm Ruuben Duck!");
        }
    }
}
