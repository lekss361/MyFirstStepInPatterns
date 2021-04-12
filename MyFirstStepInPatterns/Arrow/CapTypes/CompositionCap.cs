using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstStepInPatterns.Ducks.FlyTypes
{
    public class Inheritance : ICapType
    {
        public void Cap()
        {
            Console.WriteLine("Ой как хорошо летаю");
        }
    }

    public class BadFlyType : ICapType
    {
        public void Cap()
        {
            Console.WriteLine("Не хорошо летаю");
        }
    }

    public class NoFlyType : ICapType
    {
        public void Cap()
        {
        }
    }
}
