using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sibala
{
    public  class Sibala
    {
        private static Dictionary<int, int> _OneColorOrder = new Dictionary<int, int>
        {
            {1, 6},
            {4, 5},
            {6, 4},
            {5, 3},
            {3, 2},
            {2, 1}
        };

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
                if (sourceObject.type == SibalaResultType.OneColor)
                {
                    // 1 4 6 5 3 2 
                    var sourceOrder = _OneColorOrder[sourceObject.value];
                    var targetOrder = _OneColorOrder[targetObject.value];

                    return sourceOrder - targetOrder;
                }
                else if (sourceObject.type == SibalaResultType.NormalPoint)
                {
                    if (sourceObject.value == targetObject.value)
                    {
                        return sourceObject.maxValue - targetObject.maxValue;
                    }
                }
                return sourceObject.value - targetObject.value;
            }
        }
    }
}
