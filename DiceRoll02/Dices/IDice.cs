using DiceRoll02.type;

namespace DiceRoll02.Dices;

// DONE: /// でドキュメンテーションコメントを入力できます。
// それぞれのクラスやメソッドにドキュメンテーションコメントを入れてみましょう。
// エディタ上で入力するときに、その説明を読むことができます。
// 開発規模が大きくなり、複数人で開発するようになると、そのありがたみが強く感じられるようになってくるでしょう。

/// <summary>
/// サイコロを振る。生成されたコマンド、結果、振れなかった時のエラーを返す。
/// </summary>
internal interface IDice
{
    /// <summary>
    /// 生成されたコマンド。2D6、STARS など"
    /// </summary>
    /// <returns>コマンド</returns>
    public string GetRollCommand();

    #region ここから

    // DONE: GetRollResult() と GetRollResultArray() ですが、
    // サイコロの結果の取得方法が複数あるとどちらを使うか、使う方で使い分けなければいけません。
    // これらはなくして、Roll() して、結果を List<string> で返せば、
    // シンプルになるのではないでしょうか？
    // RollDices() とすると、Dice.RollDices() となるので、おかしな感じになります。
    // Roll() だけで自動詞で転がったと表現するのがよいです。

    // DONE:  List<string> を独自の型にしてみよう！！

    /// <summary>
    /// サイコロを振った結果
    /// </summary>
    /// <returns>結果</returns>
    public RollResult Roll();

    #endregion ここまで

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
