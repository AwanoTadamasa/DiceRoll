namespace DiceRoll02;

// TODO: /// でドキュメンテーションコメントを入力できます。
// それぞれのクラスやメソッドにドキュメンテーションコメントを入れてみましょう。
// エディタ上で入力するときに、その説明を読むことができます。
// 開発規模が大きくなり、複数人で開発するようになると、そのありがたみが強く感じられるようになってくるでしょう。
internal interface IDice
{
    public string? GetDiceCommand();

    public string? GetRollResult();

    // TODO: Checkという英語は、何をチェックしているか中身を見るまでわかりません。具体的な名前を考えてみましょう。
    // 今後の使い方次第だとは思いますが BasicDiceRoll でしか使わないなら、インターフェースにする必要はあまりないでしょう。
    public string? CheckDiceCommandError();
}