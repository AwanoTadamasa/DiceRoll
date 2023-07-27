namespace DiceRoll02;

// TODO: BasicRoll
internal class BasicRollDice : RollDice
{
    public BasicRollDice(string diceNum, string diceType) : base(diceNum, diceType) { }

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
