using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_DuckBase.Fly
{
    public class FlyWithWings : IFlyble
    {
        public void Fly()
        {
            Console.WriteLine("I flying with wings!!!");
        }
    }
}
