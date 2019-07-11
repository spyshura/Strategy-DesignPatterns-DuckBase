using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_DuckBase.Duck
{
    class SimpleDuck : DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("Hi! I'm Simple Duck!");
        }
    }
}
