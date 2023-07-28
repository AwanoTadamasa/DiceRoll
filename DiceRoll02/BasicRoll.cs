﻿namespace DiceRoll02;

// TODO: サイコロを振るという意味でRollと使いたいと思うので、Diceという名詞がないと困ります。
// Baseクラスの名前を変えたので、それに合わせて変更していきましょう。
internal class BasicRoll : RollingDiceBase
{
    public BasicRoll(string diceNum, string diceType) : base(diceNum, diceType) { }

    protected override string DiceRollCommand
        => $"{this._diceNum}D{this._diceSide}";

    // TODO: プロパティを使うときは、何度呼び出しても結果が変わらないようにします。
    // 何か動きがあって結果が変わる場合はメソッドにしましょう。
    // プロパティはそのクラスが持つ特性や属性を表すのに適しています。
    // 中に処理を書くこともありますが、基本的には単純に値を返すだけです。
    protected override int DiceRollResult
    {
        get
        {
            int result = 0;
            var r = new Random();

            for (int i = 0; i < this._diceNum; i++)
            {
                // TODO: これだと加算結果だけ返しているので、ゾロ目の判定が出来ません。
                // 指定された数分の結果を返すようにしてみましょう。
                result += r.Next(this._diceSide) + 1;
            }

            return result;
        }
    }
}
