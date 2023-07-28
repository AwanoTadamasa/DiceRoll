namespace DiceRoll02;

internal class UpperRoll : RollingDiceBase
{
    public UpperRoll(string diceNum, string diceType) : base(diceNum, diceType) { }

    protected override string DiceRollCommand
        => $"{this._diceNum}D{this._diceSide}U";

    protected override int DiceRollResult
    {
        get
        {
            int result = 0;
            var r = new Random();

            for (int i = 0; i < this._diceNum; i++)
            {
                int num = this._diceSide;

                for (int j = 1; j < this._diceSide && num == this._diceSide - j + 1; j++)
                {
                    num -= r.Next(2);
                }
                result += num;
            }
            return result;
        }
    }
}
