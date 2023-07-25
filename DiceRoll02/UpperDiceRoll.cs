namespace DiceRoll02
{
    internal class UpperDiceRoll : IDice
    {
        private readonly int _diceNum;
        private readonly int _diceSide;

        public UpperDiceRoll(string diceNum, string diceType)
        {
            this._diceNum = StringToInt(diceNum);
            this._diceSide = DiceTypeToSide(diceType);
        }

        public string? GetDiceCommand()
        {
            if (this._diceNum != 0)
            {
                return $"{this._diceNum}D{this._diceSide}U";
            }
            else
            {
                return null;
            }
        }

        public string GetRollResult()
        {
            int result = 0;
            for (int i = 0; i < this._diceNum; i++)
            {
                result += UpperDice(this._diceSide);
            }
            return result.ToString();
        }

        private static int StringToInt(string str)
        {
            return Int32.TryParse(str, out int num) && num > 0 ? num : 0;
        }

        private static int DiceTypeToSide(string str)
        {
            return str switch
            {
                "コイン" => 2,
                "4面体" => 4,
                "6面体" => 6,
                "8面体" => 8,
                "10面体" => 10,
                "12面体" => 12,
                "20面体" => 20,
                "100面体" => 100,
                _ => 0,
            };
        }

        private static int UpperDice(int side)
        {
            int result = side;
            Random r = new();
            for (int i = 0; i < side - 1; i++)
            {
                if (result == side - i)
                {
                    result -= r.Next(2);
                }
                else
                {
                    break;
                }
            }
            return result;
        }

    }
}
