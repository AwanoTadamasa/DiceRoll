using DiceRollLib.type;
using DiceRollLib.util;
using System.Text.RegularExpressions;

namespace DiceRollLib.BasicNumberDices;

internal abstract partial class BasicNumberDiceBase : IDice
{
    private int? _diceNum;
    private int? _diceSide;

    /// <inheritdoc/>
    public int? DiceNum
    {
        get => _diceNum;
        init => _diceNum = value;
    }

    /// <inheritdoc/>
    public int? DiceSide
    {
        get => _diceSide;
        init => _diceSide = value;
    }

    /// <summary>
    /// Roll number dice and sum dice roll results
    /// </summary>
    /// <param name="diceNumText">Number of dice</param>
    /// <param name="diceSideText">Number of diceside</param>
    protected BasicNumberDiceBase(string diceNumText, string diceSideText)
    {
        var diceNumMatch = _regDiceNumMatchPattern().Match(diceNumText);
        this.DiceNum = diceNumMatch.Success && Int32.TryParse(diceNumMatch.Groups[1].Value, out var diceNum) && diceNum > 0 ? diceNum : null;

        var diceSideMatch = _regDiceSideMatchPattern().Match(diceSideText);
        if (diceSideText == "コイン")
        {
            this.DiceSide = 2;
        }
        else if (diceSideMatch.Success && Int32.TryParse(diceSideMatch.Groups[1].Value, out int diceSide) && diceSide > 1)
        {
            this.DiceSide = diceSide;
        }
        else
        {
            this.DiceSide = null;
        }
    }

    /// <inheritdoc/>
    public string? GetErrorMessage()
    {
        if (this.DiceNum is null)
        {
            return "不正なサイコロの数です。\r\n1以上の整数を入力してください。";
        }
        else if (this.DiceSide is null)
        {
            return "不明なサイコロです。";
        }
        else if (this.Roll().Command == "ERROR")
        {
            return "不明なエラーです。";
        }
        else
        {
            return null;
        }
    }

    /// <inheritdoc/>
    public RollResult Roll()
    {
        if (this.DiceNum is int num && this.DiceSide is int side)
        {
            var result = CreateDiceRollResult(num, side);
            return new RollResult(CreateDiceRollCommand(num, side), result.Sum().ToString(), result);
        }
        else
        {
            return new RollResult("ERROR", "ERROR", new List<int>());
        }
    }

    /// <summary>
    /// Return created Command
    /// </summary>
    /// <returns>Command</returns>
    private protected abstract string CreateDiceRollCommand(int diceNum, int diceSide);

    /// <summary>
    /// Roll dices and make List
    /// </summary>
    /// <returns>DiceRoll result List</returns>
    private protected abstract List<int> CreateDiceRollResult(int diceNum, int diceSide);

    [GeneratedRegex("^([0-9]+)個?$")]
    private static partial Regex _regDiceNumMatchPattern();

    [GeneratedRegex("^([0-9]+)(面体)?$")]
    private static partial Regex _regDiceSideMatchPattern();
}
