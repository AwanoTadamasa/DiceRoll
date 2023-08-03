using DiceRoll02.type;

namespace DiceRoll02.Dices;

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
    /// サイコロを振った結果
    /// </summary>
    /// <returns>結果</returns>
    public RollResult Roll();

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
