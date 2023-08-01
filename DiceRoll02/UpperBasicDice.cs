namespace DiceRoll02;

/// <summary>
/// nを最大値として n=50%,(n-1)=25%,(n-2)=12.5%...3=(2^(2-n)),2=1=(2^(1-n))であるサイコロを振るクラス
/// </summary>
internal class UpperBasicDice : BasicDiceBase
{
    /// <summary>
    /// nを最大値として n=50%,(n-1)=25%,(n-2)=12.5%...3=(2^(2-n)),2=1=(2^(1-n))であるサイコロを振る
    /// </summary>
    /// <param name="diceNum">サイコロの数。"n"もしくは"n個"</param>
    /// <param name="diceType">サイコロの形。"コイン"もしくは"n面体"(n >= 2)</param>
    public UpperBasicDice(string diceNum, string diceType) : base(diceNum, diceType) { }

    /// <inheritdoc/>
    protected override string DiceRollCommand
        => $"{this._diceNum}D{this._diceSide}U";

    /// <inheritdoc/>
    protected override List<int> RollDices()
    {
        var results = new List<int>();
        var r = new Random();

        for (int i = 0; i < this._diceNum; i++)
        {
            int num = this._diceSide;
            for (int j = 1; j < this._diceSide && num == this._diceSide - j + 1; j++)
            {
                num -= r.Next(2);
            }
            results.Add(num);
        }
        return results;
    }
}
