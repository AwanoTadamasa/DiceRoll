namespace DiceRoll02;

internal class LowerRoll : RollingDiceBase
{
    public LowerRoll(string diceNum, string diceType) : base(diceNum, diceType) { }

    protected override string DiceRollCommand
        => $"{this._diceNum}D{this._diceSide}L";

    protected override int DiceRollResult
    {
        get
        {
            int result = 0;
            var r = new Random();

            for (int i = 0; i < this._diceNum; i++)
            {
                int num = 1;
                for (int j = 1; j < this._diceSide && num == i; j++)
                {
                    num += r.Next(2);
                }
                result += num;
            }
            return result;
        }
    }
}
