namespace DiceRoll02
{
    internal class LowerDiceRoll : IDice
    {
        private readonly int _diceNum;
        private readonly int _diceSide;
        public LowerDiceRoll(string diceNum, string diceType)
        {
            this._diceNum = StringToInt(diceNum);
            this._diceSide = DiceTypeToSide(diceType);
        }

        public string? GetDiceCommand()
        {
            if (this._diceNum != 0)
            {
                return $"{this._diceNum}D{this._diceSide}L";
            }
            else 
            {
                return null ; 
            }
        }

        public string GetRollResult()
        {
            int result = 0 ;
            for (int i = 0; i < this._diceNum; i++)
            {
                result += LowerDice(this._diceSide);
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

        private static int LowerDice(int side)
        {
            int result = 1;
            Random r = new();
            for (int i = 1; i < side; i++) 
            {
                if (result == i)
                {
                    result += r.Next(2);
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
