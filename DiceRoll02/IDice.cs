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
    // DONE: returns には型名は含めない方がよいでしょう。
    // 型名はIDEでコードを記述するときに見えるので、コメントに書くと冗長です。
    // あと、型を変更したらコメントまで直さないといけないのでめんどくさいと思います。
    /// <summary>
    /// 生成されたコマンド。2D6、STARS　など
    /// </summary>
    /// <returns>コマンド</returns>
    public string GetRollCommand();

    /// <summary>
    /// 生成された結果の文字列
    /// </summary>
    /// <returns>結果</returns>
    public string GetRollResult();

    /// <summary>
    /// エラーで結果が出なかった時true
    /// </summary>
    /// <returns>true/false</returns>
    public bool HasError();

    /// <summary>
    /// エラー時のメッセージ、結果が出た時にはnull
    /// </summary>
    /// <returns>メッセージ/null</returns>
    public string? GetErrorMessage();
}