
// DONE: namespace の中括弧は省略できるようになりました。無い方がインデントを減らせて見通しが良くなります。
namespace DiceRoll02;

// DONE: デフォルトのアクセス修飾子について調べてみましょう。
internal interface IDice
{
    // DONE: ここを internal にしたことで、継承先で public にしているものと合わなくなっています。
    public string? GetDiceCommand();

    public string? GetRollResult();
}