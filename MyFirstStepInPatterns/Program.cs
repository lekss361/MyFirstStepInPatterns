using System;
using System.Collections.Generic;
using MyFirstStepInPatterns.Ducks;
using MyFirstStepInPatterns.Arrow.CapTypes;
using MyFirstStepInPatterns.Arrow.LineTypes;

namespace MyFirstStepInPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<AbstractDuck> ducks = new List<AbstractDuck>();
            List<AbstractArrow> arrows = new List<AbstractArrow>();
            //IFabric fabric = new WellFlyFabric();
            arrows.Add(new ConcretArrow("ss", new AgregationCap(), new SolidLine()));
            //ducks.Add(fabric.GetDuck("Q"));
            //ducks.Add(fabric.GetDuck("Q"));
            //ducks.Add(fabric.GetDuck("Q"));
            //ducks.Add(fabric.GetDuck("Q"));

            //fabric = new BadFlyFabric();
            //ducks.Add(fabric.GetDuck("Q"));
            //ducks.Add(fabric.GetDuck("Q"));
            //ducks.Add(fabric.GetDuck("Q"));
            //ducks.Add(fabric.GetDuck("Q"));

            //foreach (AbstractDuck duck in ducks)
            //{
            //    duck.Eat();
            //    duck.Fly();
            //}


            Lake lake;
            lake = Lake.GetLake();
            lake.QQQ();
        }
    }
}
