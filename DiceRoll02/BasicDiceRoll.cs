namespace DiceRoll02
{
    class BasicDiceRoll : IDice
    {
        private readonly int _diceNumber;
        private readonly int _diceSide;

        public BasicDiceRoll(string diceNum, string diceType)
        {
            // TODO: インスタンスメソッドとクラスメソッドが混じる場合は、区別するために、インスタンスメソッドには this を、クラスメソッドにはクラス名をつけます。
            this._diceNumber = StringToInt(diceNum);
            this._diceSide = DiceTypeToSide(diceType);
        }

        public string? GetDiceCommand()
        {
            if (this._diceNumber != 0)
            {
                return $"{this._diceNumber}D{this._diceSide}";
            }
            else
            {
                return null;
            }
        }

        public string GetRollResult()
        {
            int result = 0;


            Random r = new();
            if (this._diceNumber != 0 )
            {
                for (int i = 0; i < this._diceNumber; i++)
                {
                    result += r.Next(this._diceSide)+1;
                }
            }
            return result.ToString();
        }

        private static int StringToInt(string str)
        {
            return Int32.TryParse(str, out int num) && num > 0 ? num : 0;
        }

        // TODO: 変換メソッドは、インスタンス主体で ToXxx() とするようにしましょう。
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
    }
}