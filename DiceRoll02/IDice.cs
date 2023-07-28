namespace DiceRoll02;

// TODO(WIP): /// でドキュメンテーションコメントを入力できます。
// それぞれのクラスやメソッドにドキュメンテーションコメントを入れてみましょう。
// エディタ上で入力するときに、その説明を読むことができます。
// 開発規模が大きくなり、複数人で開発するようになると、そのありがたみが強く感じられるようになってくるでしょう。

/// <summary>
/// サイコロを振る。生成されたコマンド、結果、振れなかった時のエラーを返す。
/// </summary>
internal interface IDice
{
    /// <summary>
    /// 生成されたコマンド。2D6、STARS　など
    /// </summary>
    /// <returns>コマンド(string)</returns>
    public string GetRollCommand();

    /// <summary>
    /// 生成された結果の文字列
    /// </summary>
    /// <returns>結果(string)</returns>
    public string GetRollResult();

    // DONE: bool HasError() という名前のメソッドを用意するとともに、
    // string? GetErrorMessage() という名前のメソッドを用意するのがよさそうです。
    // 上記を使うことで呼び出し元でエラーメッセージの内容を考えなくてよくなります。
    /// <summary>
    /// エラーで結果が出なかった時true
    /// </summary>
    /// <returns>true/false(bool)</returns>
    public bool HasError();

    /// <summary>
    /// エラー時のメッセージ、結果が出た時にはnull
    /// </summary>
    /// <returns>メッセージ(string)/null</returns>
    public string? GetErrorMessage();
}