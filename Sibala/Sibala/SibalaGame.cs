using System.Collections.Generic;
using System.Linq;

namespace Sibala
{
    public class SibalaGame
    {
        private List<int> _dicePoints;
        private SibalaResult _sibalaResult;

        public SibalaGame(List<int> dicePoints)
        {
            this._dicePoints = dicePoints;
            this._dicePoints.Sort();

            CalculateSibalaResult();
        }

        public SibalaResult GetResult()
        {
            return _sibalaResult;
        }

        public string GetResultString()
        {
            return _sibalaResult.ToString();
        }

        private void CalculateSibalaResult()
        {
            if (!IsOneColor())
            {
                CheckNormalPoint();
            }
        }

        private void CheckNormalPoint()
        {
            List<int> otherdices;
            for (var diceNo = 0; diceNo <= _dicePoints.Count - 2; diceNo++)
            {
                otherdices = GetOtherDices(diceNo);

                if (IsSamePoint(otherdices))
                {
                    _sibalaResult = GetNormalPoint(otherdices);
                    return;
                }
            }

            _sibalaResult = GetNoPointResult();
        }

        private static SibalaResult GetNormalPoint(List<int> otherdices)
        {
            return new SibalaResult(SibalaResultType.NormalPoint, otherdices.Sum(), otherdices.Max());
        }

        private List<int> GetOtherDices(int diceNo)
        {
            return new List<int> { _dicePoints[(diceNo + 2) % 4], _dicePoints[(diceNo + 3) % 4] };
        }

        private SibalaResult GetNoPointResult()
        {
            return new SibalaResult(SibalaResultType.NoPoint, 0, _dicePoints.Max());
        }

        private bool IsSamePoint(List<int> otherDice)
        {
            return otherDice[0] == otherDice[1];
        }

        private bool IsOneColor()
        {
            if (_dicePoints.Max() == _dicePoints.Min())
            {
                _sibalaResult = new SibalaResult(SibalaResultType.OneColor, _dicePoints[0], _dicePoints.Max());
                return true;
            }
            return false;
        }
    }
}