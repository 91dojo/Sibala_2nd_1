using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sibala
{
    public enum SibalaResultType
    {
        OneColor = 2,
        NormalPoint = 1, 
        NoPoint = 0
    }
    public class SibalaGame
    {
        private List<int> _dicePoints;

        public SibalaGame(List<int> dicePoints)
        {
            this._dicePoints = dicePoints;

        }

        public SibalaResult GetResult()
        {
            return new SibalaResult(SibalaResultType.NoPoint, 5);
        }
    }


    public class SibalaResult
    {
        public readonly SibalaResultType type;
        public readonly int value;

        public SibalaResult(SibalaResultType type,int value)
        {
            this.type = type;
            this.value = value;
        }

    }
}
