using DiceRollLib.Types;
using DiceRollLib.util;

namespace DiceRollLib.TableTextDices;

internal abstract class TableTextDiceBase : IDice
{

    public int? DiceNum { get; init; }
    public int? DiceSide { get; init; }

    protected TableTextDiceBase()
    {
        this.DiceNum = this.Table.DiceNum;
        this.DiceSide = this.Table.DiceSide;
    }

    /// <inheritdoc/>
    public string? GetErrorMessage()
    {
        // DONE: 三項演算子?を使うのがよさそうです。
        return this.HasError() ? "不正なテーブルです" : null;
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
