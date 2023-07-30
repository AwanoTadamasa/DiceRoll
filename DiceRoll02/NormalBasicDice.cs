namespace DiceRoll02;

/// <summary>
/// 各面の出る確率が等しいサイコロを振るクラス
/// </summary>
internal class NormalBasicDice : BasicDiceBase
{
    /// <summary>
    /// 各面の出る確率が等しいサイコロを振る
    /// </summary>
    /// <param name="diceNum">サイコロの数。"n"もしくは"n個"</param>
    /// <param name="diceType">サイコロの形。"コイン"もしくは"n面体"(n >= 2)</param>
    public NormalBasicDice(string diceNum, string diceType) : base(diceNum, diceType) { }

    protected override string DiceRollCommand
        => $"{this._diceNum}D{this._diceSide}";

    protected override List<int> RollDices()
    {
        var results = new List<int>();
        var r = new Random();
        for (int i = 0; i < this._diceNum; i++)
        {
            results.Add(r.Next(_diceSide) + 1);
        }
        return results;
    }
}
