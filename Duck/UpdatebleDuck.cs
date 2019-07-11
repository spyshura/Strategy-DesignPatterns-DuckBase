using System;
using System.Collections.Generic;
using System.Text;
using Strategy_DuckBase.Quack;
using Strategy_DuckBase.Fly;

namespace Strategy_DuckBase.Duck
{
    class UpdatebleDuck : DuckBase
    {


        public UpdatebleDuck()
        {
            flyBehaviour = new NoFly();
            quackBehaviour = new NoQuack();
        }

        public void SetFlyBehaviour(IFlyble flybleBehaviour)
        {
            flyBehaviour = flybleBehaviour;
        }

        public void SetQuackBehaviour(IQuackble quackbleBehaviour)
        {
            quackBehaviour = quackbleBehaviour;
        }
        public override void Display()
        {
            Console.WriteLine("Hi! I'm updateble Duck!");
        }
    }
}
