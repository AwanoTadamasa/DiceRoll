namespace DiceRoll02;

/// <summary>
/// 1=50%,2=25%,3=12.5%...(n-2)=(2^(2-n)),(n-1)=n=(2^(1-n))であるサイコロを振るクラス
/// </summary>
internal class LowerDiceRoll : RollingDiceBase
{
    /// <summary>
    /// 1=50%,2=25%,3=12.5%...(n-2)=(2^(2-n)),(n-1)=n=(2^(1-n))であるサイコロを振る
    /// </summary>
    /// <param name="diceNum">サイコロの数。"n"もしくは"n個"</param>
    /// <param name="diceType">サイコロの形。"コイン"もしくは"n面体"(n >= 2)</param>
    public LowerDiceRoll(string diceNum, string diceType) : base(diceNum, diceType) { }

    protected override string DiceRollCommand
        => $"{this._diceNum}D{this._diceSide}L";

    protected override List<int> RollDices()
    {
        var results = new List<int>();
        var r = new Random();

        for (int i = 0; i < this._diceNum; i++)
        {
            int num = 1;
            for (int j = 1; j < this._diceSide && num == j; j++)
            {
                num += r.Next(2);
            }
            results.Add(num);
        }
        return results;
    }
}
