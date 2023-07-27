namespace DiceRoll02;

// TODO: C#では慣例的に abstract クラスの名前には -Base のサフィックスをつけます。
// BasicDice の共通部分という意味で BasicDiceBase でよいと思います。
// RollDice という名前だと、転がるサイコロ という意味になってます。
// 転がる以外の何かを実装するならRollingDiceもありだと思いますが・・・。
internal abstract class RollDice : IDice
{
    protected readonly int _diceNum;
    protected readonly int _diceSide;

    public RollDice(string diceNum, string diceType)
    {
        _diceNum = Int32.TryParse(diceNum, out var num) && num > 0 ? num : 0;
        _diceSide = diceType switch
        {
            "コイン" => 2,
            "4面体" => 4,
            "6面体" => 6,
            "8面体" => 8,
            "10面体" => 10,
            "12面体" => 12,
            "20面体" => 20,
            "100面体" => 100,
            _ => 0,
        };
    }

    public string GetRollCommand()
    {
        if (this.CommandError is null)
        {
            return this.DiceRollCommand;
        }
        else
        {
            return "ERROR";
        }
    }

    public string GetRollResult()
    {
        if (this.CommandError is null)
        {
            return this.DiceRollResult.ToString();
        }
        else
        {
            return "ERROR";
        }
    }

    public string? CommandError
    {
        get
        {
            if (this._diceNum == 0) { return "HaveNoDice"; }
            else if (this._diceSide <= 0) { return "HaveUnknownSide"; }
            else { return null; }
        }
    }

    protected abstract string DiceRollCommand { get; }

    protected abstract int DiceRollResult { get; }
}
