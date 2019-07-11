using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_DuckBase.Duck
{
    public class ExoticDuck : DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("Hi! I'm exotic Duck!");
        }

       
    }
}
