using System;
using System.Collections.Generic;
using System.Text;
using MyFirstStepInPatterns.Arrow.LineTypes;
using MyFirstStepInPatterns.Ducks.FlyTypes;

namespace MyFirstStepInPatterns.Ducks
{
   public class ConcretArrow:AbstractArrow
   {
        public ConcretArrow(string name, ICapType capType,ILineType lineType)
        {
            Name = name;
            _capType = capType;
            _lineType = lineType;
        }
   }
}
