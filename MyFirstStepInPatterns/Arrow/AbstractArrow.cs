using System;
using System.Collections.Generic;
using System.Text;
using MyFirstStepInPatterns.Ducks.FlyTypes;
using MyFirstStepInPatterns.Arrow.LineTypes;

namespace MyFirstStepInPatterns.Ducks
{
    public abstract class AbstractArrow
    {
        public string Name { get; set; }

        protected ICapType _capType;
        protected ILineType _lineType;
        protected AbstractArrow(string name, ICapType capType, ILineType lineType)
        {
            Name = name;
            _capType = capType;
            _lineType = lineType;
        }


        public void Eat()
        {
            Console.WriteLine($"{Name} поела");
        }

        public void Fly()
        {
            _capType.Cap();
        }
    }
}
