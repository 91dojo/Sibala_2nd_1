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
        private SibalaResult _sibalaResult;

        public SibalaGame(List<int> dicePoints)
        {
            this._dicePoints = dicePoints;
            this._dicePoints.Sort();

            Calculate();
        }

        public SibalaResult GetResult()
        {
            return _sibalaResult;
        }

        public string GetResultString()
        {
            return _sibalaResult.ToString();
        }

        private void Calculate()
        {
            if (!CheckSamePoint())
            {
                CheckNormalPoint();
            }

        }

        private void CheckNormalPoint()
        {

            for (int i = 0; i < _dicePoints.Count - 2; i++)
            {
                if (_dicePoints[i] == _dicePoints[i + 1])
                {
                    _sibalaResult = new SibalaResult((SibalaResultType)1, _dicePoints[ (i + 2) % 4] + _dicePoints[(i + 3)%4], _dicePoints.Max());
                    return;
                }
            }

            
            _sibalaResult = new SibalaResult((SibalaResultType)0, 0, _dicePoints.Max());
            
        }

        private bool CheckSamePoint()
        {
            if (_dicePoints[0] == _dicePoints[3])
            {
                _sibalaResult = new SibalaResult((SibalaResultType)2, _dicePoints[0], _dicePoints.Max());
                return true;
            }
            return false;
        }
    }


    public class SibalaResult
    {
        public readonly SibalaResultType type;
        public readonly int value;
        public readonly int maxValue;

        public SibalaResult(SibalaResultType type, int value, int maxValue)
        {
            this.type = type;
            this.value = value;
            this.maxValue = maxValue;
        }

        public override string ToString()
        {
            switch (type)
            {
                case (SibalaResultType)2: return "一色";
                case (SibalaResultType)1:
                    if (value == 3)
                        return "BG";
                    else if (value == 12)
                        return "十八啦";
                    return value+"點";
                default: return "沒點";
            }

        }
    }
}
