using MyFirstStepInPatterns.Ducks;
using MyFirstStepInPatterns.Ducks.FlyTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstStepInPatterns
{
    public interface IFabric
    {
        AbstractArrow GetDuck(string name);
    }

    public class WellFlyFabric : IFabric
    {
        public AbstractArrow GetDuck(string name)
        {
            return new ConcretArrow(name, new Inheritance());
        }
    }

    public class BadFlyFabric : IFabric
    {
        public AbstractArrow GetDuck(string name)
        {
            return new ConcretArrow(name, new BadFlyType());
        }
    }
}
