
// TODO: namespace の中括弧は省略できるようになりました。無い方がインデントを減らせて見通しが良くなります。
namespace DiceRoll02
{
    // TODO: デフォルトのアクセス修飾子について調べてみましょう。
    internal interface IDice
    {
        // TODO: ここを internal にしたことで、継承先で public にしているものと合わなくなっています。
        internal string? GetDiceCommand();

        internal string GetRollResult();
    }
}