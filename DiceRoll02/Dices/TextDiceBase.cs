using DiceRoll02.type;

namespace DiceRoll02.Dices;

/// <summary>
/// テーブルからサイコロで一つ取り出す
/// </summary>
internal abstract class TextDiceBase : IDice
{
    private readonly List<int> _results;

    public TextDiceBase()
    {
        _results = new List<int>
        {
            new Random().Next(DiceChooseTable.Length)
        };
    }

    /// <inheritdoc/>
    public string GetRollCommand()
    {
        if (HasError())
        {
            return "ERROR";
        }
        else
        {
            return DiceRollCommand;
        }
    }

    /// <inheritdoc/>
    public RollResult Roll()
    {
        if (HasError())
        {
            return new RollResult("ERROR", new List<int>());
        }
        else
        {
            return new RollResult(DiceChooseTable[_results.First()], _results);
        }
    }

    /// <inheritdoc/>
    public bool HasError() => GetErrorMessage() is not null;

    public string? GetErrorMessage()
    {
        if (DiceChooseTable.Length < 1)
        {
            return "テーブルが設定されていない、もしくは項目が1つしかありません。";
        }
        else
        {
            try
            {
                _ = DiceRollCommand;
                _ = DiceChooseTable[1];
                return null;
            }
            catch
            {
                return "不明なエラーが発生しました。";
            }
        }
    }

    /// <summary>
    /// 生成したコマンドを入れるフィールド
    /// </summary>
    abstract protected string DiceRollCommand { get; }

    /// <summary>
    /// テーブルを配列で入れておくフィールド。ここから1つが結果として出てくる
    /// 項目は2つ以上必要
    /// </summary>
    abstract protected string[] DiceChooseTable { get; }
}
