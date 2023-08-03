using System.Text.RegularExpressions;
using DiceRoll02.type;

namespace DiceRoll02.Dices;

/// <summary>
/// サイコロを振り、結果を返す
/// </summary>
internal abstract partial class BasicDiceBase : IDice
{
    protected readonly int _diceNum;
    protected readonly int _diceSide;
    protected readonly List<int> _results;

    /// <summary>
    /// コンストラクタ。内部で整数型にする。
    /// </summary>
    /// <param name="diceNumText">サイコロの数。"n"もしくは"n個"</param>
    /// <param name="diceTypeText">サイコロの形。"コイン"もしくは"n面体"(n >= 2)</param>
    public BasicDiceBase(string diceNumText, string diceTypeText)
    {
        var diceNum = _regDiceNumMatchPattern().Match(diceNumText);
        this._diceNum = diceNum.Success && Int32.TryParse(diceNum.Groups[1].Value, out var num) && num > 0 ? num : 0;

        var diceType = _regDiceSideMatchPattern().Match(diceTypeText);
        if (diceTypeText == "コイン")
        {
            this._diceSide = 2;
        }
        else if (diceType.Success)
        {
            this._diceSide = Int32.TryParse(diceType.Groups[1].Value, out var side) && side > 1 ? side : 0;
        }
        else
        {
            this._diceSide = 0;
        }

        this._results = this.RollDices();
    }

    /// <inheritdoc/>
    public string GetRollCommand()
    {
        if (this.HasError())
        {
            return "ERROR";
        }
        else
        {
            return this.DiceRollCommand;
        }
    }

    /// <inheritdoc/>
    public RollResult Roll()
    {
        if (this.HasError())
        {
            return new RollResult("ERROR", new List<int>());
        }
        else
        {
            return new RollResult(this._results.Sum().ToString(), this._results);
        }
    }

    /// <inheritdoc/>
    public bool HasError() => this.GetErrorMessage() is not null;

    /// <inheritdoc/>
    public string? GetErrorMessage()
    {
        if (this._diceNum == 0)
        {
            return "不正な数字です。\r\n1以上の整数を入力してください。";
        }
        else if (this._diceSide <= 0)
        {
            return "不明なサイコロです。";
        }
        else
        {
            return null;
        }
    }

    /// <summary>
    /// GetRollCommand()で返すコマンドを作成する
    /// </summary>
    protected abstract string DiceRollCommand { get; }

    /// <summary>
    /// サイコロを指定個数振り、その数値のリストを返す
    /// </summary>
    protected abstract List<int> RollDices();

    [GeneratedRegex("^([0-9]+)個?$")]
    private static partial Regex _regDiceNumMatchPattern();

    [GeneratedRegex("^([0-9]+)(面体)?$")]
    private static partial Regex _regDiceSideMatchPattern();
}
