using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_DuckBase.Quack
{
    public class SimpleQuack : IQuackble
    {
        public void Quack()
        {
            Console.WriteLine("Quack! Quack!");
        }
    }
}
