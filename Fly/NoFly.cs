using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_DuckBase.Fly
{
    class NoFly : IFlyble
    {
        public void Fly()
        {
            Console.WriteLine("---");
        }
    }
}
