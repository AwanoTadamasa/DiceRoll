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

    // DONE: プロパティを使うときは、何度呼び出しても結果が変わらないようにします。
    // 何か動きがあって結果が変わる場合はメソッドにしましょう。
    // プロパティはそのクラスが持つ特性や属性を表すのに適しています。
    // 中に処理を書くこともありますが、基本的には単純に値を返すだけです。
    protected override List<int> RollDices()
    {
        // DONE: これだと加算結果だけ返しているので、ゾロ目の判定が出来ません。
        // 指定された数分の結果を返すようにしてみましょう。
        var results = new List<int>();
        var r = new Random();
        for (int i = 0; i < this._diceNum; i++)
        {
            results.Add(r.Next(_diceSide) + 1);
        }
        return results;
    }
}
