namespace DiceRoll02;

internal class BasicDiceRoll : IDice
{
    private readonly int _diceNum;
    private readonly int _diceSide;

    public BasicDiceRoll(string diceNum, string diceType)
    {
        // DONE: out int �� out var �ƋL�q�ł��܂��B
        // DONE: num>0 �ɓK�؂ȃX�y�[�X������܂���BCtrl + K, D �������Ă݂܂��傤�B
        this._diceNum = Int32.TryParse(diceNum, out var num) && num > 0 ? num : 0;
        this._diceSide = diceType switch
        {
            "�R�C��" => 2,
            "4�ʑ�" => 4,
            "6�ʑ�" => 6,
            "8�ʑ�" => 8,
            "10�ʑ�" => 10,
            "12�ʑ�" => 12,
            "20�ʑ�" => 20,
            "100�ʑ�" => 100,
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