namespace Sibala
{
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