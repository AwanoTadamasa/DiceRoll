namespace DiceRoll02;

class BasicDiceRoll : IDice
{
    protected readonly int _diceNumber;
    protected readonly int _diceSide;

    public BasicDiceRoll(string diceNum, string diceType)
    {
        // TODO: out int �� out var �ƋL�q�ł��܂��B
        // TODO: num>0 �ɓK�؂ȃX�y�[�X������܂���BCtrl + K, D �������Ă݂܂��傤�B
        this._diceNumber = Int32.TryParse(diceNum, out int num) && num>0 ? num : 0;
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
        if (this._diceNumber != 0)
        {
            return $"{this._diceNumber}D{this._diceSide}";
        }
        else
        {
            return null;
        }
    }

    public string? GetRollResult()
    {
        int result = 0;
        Random r = new ();
        if (this._diceSide > 0 && this._diceNumber != 0 )
        {
            for ( int i = 0; i < this._diceNumber; i++)
            {
                result += r.Next(_diceSide) + 1;
            }
        }
        else if(this._diceSide <=  0)
        {
            return null;
        }
        return result.ToString();
    }
}