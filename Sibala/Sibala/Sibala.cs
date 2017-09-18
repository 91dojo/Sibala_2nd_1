using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sibala
{
    public  class Sibala
    {
        public static int Compare(SibalaGame source, SibalaGame target)
        {
            var sourceObject = source.GetResult();
            var targetObject = target.GetResult();

            if (sourceObject.type > targetObject.type)
            {
                return 1;
            }
            else if (sourceObject.type < targetObject.type)
            {
                return -1;
            }
            else
            {
                return sourceObject.value - targetObject.value;
            }
        }
    }
}
