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
    /// 生成されたコマンド。2D6、STARS など"
    /// </summary>
    /// <returns>コマンド</returns>
    public string GetRollCommand();

    /// <summary>
    /// サイコロを振った結果の合計を文字列にしたもの 
    /// </summary>
    /// <returns>結果</returns>
    public string GetRollResult();

    /// <summary>
    /// サイコロを振った結果のリスト
    /// </summary>
    /// <returns></returns>
    public int[] GetRollResultArray();

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