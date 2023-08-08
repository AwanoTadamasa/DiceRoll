using DiceRollLib.type;
using DiceRollLib.util;

namespace DiceRollLib.TableTextDices;

internal abstract class TableTextDiceBase : IDice
{
    private readonly int? _diceNum;
    private readonly int? _diceSide;

    protected TableTextDiceBase()
    {
        this.DiceNum = this.Table.DiceNum;
        this.DiceSide = this.Table.DiceSide;
    }

    /// <inheritdoc/>
    public int? DiceNum
    {
        get => this._diceNum;
        init => this._diceNum = value > 0 ? value : null;
    }

    /// <inheritdoc/>
    public int? DiceSide
    {
        get => this._diceSide;
        init => this._diceSide = value > 1 ? value : null;
    }

    /// <inheritdoc/>
    public string? GetErrorMessage()
    {
        // TODO: this.HasError() 使えば？
        if (this.DiceNum is null || this.DiceSide is null)
        {
            return "不正なテーブルです。";
        }
        else if (this.Roll().Command == "ERROR")
        {
            return "不明なエラーです。";
        }
        return null;
    }

    /// <inheritdoc/>
    public RollResult Roll()
    {
        if (this.DiceNum is int num && this.DiceSide is int side)
        {
            var result = Enumerable.Range(1, num)
                                   .Select(x => Random.Shared.Next(0, side) + 1);

            return new RollResult(Table.Command,
                                  Table.NumberTextPairs[result.Sum()],
                                  result.ToList());
        }
        else
        {
            return new RollResult("ERROR", "ERROR", new List<int>());
        }
    }

    /// <summary>
    /// Dice roll from this table
    /// </summary>
    protected abstract TableTextDiceTable Table { get; }
}
