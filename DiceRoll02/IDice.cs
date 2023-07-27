namespace DiceRoll02;

// TODO: /// でドキュメンテーションコメントを入力できます。
// それぞれのクラスやメソッドにドキュメンテーションコメントを入れてみましょう。
// エディタ上で入力するときに、その説明を読むことができます。
// 開発規模が大きくなり、複数人で開発するようになると、そのありがたみが強く感じられるようになってくるでしょう。
internal interface IDice
{
    public string GetRollCommand();

    public string GetRollResult();

    // TODO: bool HasError() という名前のメソッドを用意するとともに、
    // string? GetErrorMessage() という名前のメソッドを用意するのがよさそうです。
    // 上記を使うことで呼び出し元でエラーメッセージの内容を考えなくてよくなります。
    public string? CommandError { get; }
}