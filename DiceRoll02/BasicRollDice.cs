namespace DiceRoll02;
// DONE: IDice を継承したクラスの場合は、Dice で終わるクラス名の方がわかりやすいです。
// サイコロを振る動作を含むクラスだから Roll をつけたくなりますが、
// その名前を活かすなら、IDiceRollable で、Roll() メソッドをもたせると具体的になります。
//      => 抽象クラスの作成により名前が変わりました
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
