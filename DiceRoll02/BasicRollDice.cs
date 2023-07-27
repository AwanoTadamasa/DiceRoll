namespace DiceRoll02;

internal class BasicRollDice : RollDice
{
    public BasicRollDice(string diceNum, string diceType) : base(diceNum, diceType) { }

    override protected string CreatDiceCommand
    {
        get
        {
            return $"{_diceNum}D{_diceSide}";
        }
    }

    override protected int CreatRollResult
    {
        get
        {
            int result = 0;
            var r = new Random();

            for (int i = 0; i < this._diceNum; i++)
            {
                result += r.Next(_diceSide) + 1;
            }
            return result;
        }
    }
}
