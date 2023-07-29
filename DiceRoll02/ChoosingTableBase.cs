namespace DiceRoll02;

/// <summary>
/// テーブルからサイコロで一つ取り出す
/// </summary>
internal abstract class ChoosingTableBase : IDice
{
    private readonly List<int> _results;

    public ChoosingTableBase()
    {
        _results = new List<int>
        {
            new Random().Next(this.DiceChooseTable.Length)
        };
    }
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

    public string GetRollResult()
    {
        if (this.HasError())
        {
            return "ERROR";
        }
        else
        {
            return this.DiceChooseTable[this._results.First()];
        }
    }

    public int[] GetRollResultArray()
    {
        return _results.ToArray();
    }

    public bool HasError() => this.GetErrorMessage() is not null;

    public string? GetErrorMessage()
    {
        if (this.DiceChooseTable.Length < 1)
        {
            return "テーブルが設定されていない、もしくは項目が1つしかありません。";
        }
        else
        {
            try
            {
                _ = this.DiceRollCommand;
                _ = this.DiceChooseTable[1];
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
