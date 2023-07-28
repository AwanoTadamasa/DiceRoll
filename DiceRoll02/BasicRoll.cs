namespace DiceRoll02;

// DONE: BasicRoll
internal class BasicRoll : RollingDiceBase
{
    public BasicRoll(string diceNum, string diceType) : base(diceNum, diceType) { }

    protected override string DiceRollCommand
        => $"{this._diceNum}D{this._diceSide}";

    protected override int DiceRollResult
    {
        get
        {
            int result = 0;
            var r = new Random();

            for (int i = 0; i < this._diceNum; i++)
            {
                result += r.Next(this._diceSide) + 1;
            }
            return result;
        }
    }
}
