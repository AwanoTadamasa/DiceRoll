namespace DiceRoll02;

// TODO: IDice を継承したクラスの場合は、Dice で終わるクラス名の方がわかりやすいです。
// サイコロを振る動作を含むクラスだから Roll をつけたくなりますが、
// その名前を活かすなら、IDiceRollable で、Roll() メソッドをもたせると具体的になります。
internal class BasicDiceRoll : IDice
{
    private readonly int _diceNum;
    private readonly int _diceSide;

    public BasicDiceRoll(string diceNum, string diceType)
    {
        this._diceNum = Int32.TryParse(diceNum, out var num) && num > 0 ? num : 0;
        this._diceSide = diceType switch
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

    public string? GetDiceCommand()
    {
        return this.CheckDiceCommandError() is null ? $"{this._diceNum}D{this._diceSide}" : null;
    }

    public string? GetRollResult()
    {
        if (this.CheckDiceCommandError() is null)
        {
            int result = 0;
            Random r = new();
            for (int i = 0; i < this._diceNum; i++)
            {
                result += r.Next(this._diceSide) + 1;
            }
            return result.ToString();
        }
        else
        {
            return null;
        }
    }

    public string? CheckDiceCommandError()
    {
        if (this._diceNum == 0)
        {
            return "HaveNoDice";
        }
        else if (this._diceSide <= 0)
        {
            return "HaveUnknownSide";
        }
        else
        {
            return null;
        }
    }
}