using System;
using System.Collections.Generic;
using System.Text;
using Strategy_DuckBase.Fly;
using Strategy_DuckBase.Quack;

namespace Strategy_DuckBase.Duck
{
    public abstract class DuckBase
    {
        public IFlyble flyBehaviour;
        public IQuackble quackBehaviour;

        public DuckBase()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new SimpleQuack();
        }

    

        public virtual void Fly()
        {
            flyBehaviour.Fly();
        }

        public virtual void Quack()
        {
            quackBehaviour.Quack();
        }
        public abstract void Display();

        public void Swim()
        {
            Console.WriteLine("I swimming!");
        }
    }
}
