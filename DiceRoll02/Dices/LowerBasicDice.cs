namespace DiceRoll02.Dices;

/// <summary>
/// 1=50%,2=25%,3=12.5%...(n-2)=(2^(2-n)),(n-1)=n=(2^(1-n))であるサイコロを振るクラス
/// </summary>
internal class LowerBasicDice : BasicDiceBase
{
    /// <summary>
    /// 1=50%,2=25%,3=12.5%...(n-2)=(2^(2-n)),(n-1)=n=(2^(1-n))であるサイコロを振る
    /// </summary>
    /// <param name="diceNum">サイコロの数。"n"もしくは"n個"</param>
    /// <param name="diceType">サイコロの形。"コイン"もしくは"n面体"(n >= 2)</param>
    public LowerBasicDice(string diceNum, string diceType) : base(diceNum, diceType) { }

    /// <inheritdoc/>
    protected override string DiceRollCommand
        => $"{_diceNum}D{_diceSide}L";

    /// <inheritdoc/>
    protected override List<int> RollDices()
    {
        var results = new List<int>();
        var r = new Random();

        for (int i = 0; i < _diceNum; i++)
        {
            int num = 1;
            for (int j = 1; j < _diceSide && num == j; j++)
            {
                num += r.Next(2);
            }
            results.Add(num);
        }
        return results;
    }
}
