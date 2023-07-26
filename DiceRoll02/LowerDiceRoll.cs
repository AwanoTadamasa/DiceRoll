namespace DiceRoll02;

internal class LowerDiceRoll : IDice
{
    private readonly int _diceNum;
    private readonly int _diceSide;

    public LowerDiceRoll(string diceNum, string diceType)
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
                result += LowerDiceRoll.LowerDice(this._diceSide, r);
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

    private static int LowerDice(int side, Random r)
    {
        int result = 1;
        for (int i = 1; i < side; i++)
        {
            if (result == i)
            {
                result += r.Next(2);
            }
            else
            {
                break;
            }
        }
        return result;
    }

}
