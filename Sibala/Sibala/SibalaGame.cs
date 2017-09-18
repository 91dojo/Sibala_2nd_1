using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sibala
{
    public class SibalaGame
    {
        private List<int> _dicePoints;

        public SibalaGame(List<int> dicePoints)
        {
            this._dicePoints = dicePoints;

        }

        public SibalaResult GetResult()
        {
            return new SibalaResult("",5);
        }
    }

    public class SibalaResult
    {
        public readonly string type;
        public readonly int value;

        public SibalaResult(string type,int value)
        {
            this.type = type;
            this.value = value;
        }

    }
}
