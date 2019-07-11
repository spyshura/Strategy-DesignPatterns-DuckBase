using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_DuckBase.Quack
{
    class NoQuack : IQuackble
    {
        public void Quack()
        {
            Console.WriteLine("...");
        }
    }
}
