using System.Collections.Generic;

namespace Sibala
{
    public class Sibala
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

            if (sourceObject.type != targetObject.type)
            {
                return sourceObject.type - targetObject.type;
            }

            if (sourceObject.type == SibalaResultType.OneColor)
            {
                return _OneColorOrder[sourceObject.value] - _OneColorOrder[targetObject.value];
            }
            if (sourceObject.type == SibalaResultType.NormalPoint && sourceObject.value == targetObject.value)
            {
                return sourceObject.maxValue - targetObject.maxValue;
            }

            return sourceObject.value - targetObject.value;
        }
    }
}
