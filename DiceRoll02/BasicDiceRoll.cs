namespace DiceRoll02;

class BasicDiceRoll : IDice
{
    protected readonly int _diceNumber;
    protected readonly int _diceSide;

    public BasicDiceRoll(string diceNum, string diceType)
    {
        // TODO: out int は out var と記述できます。
        // TODO: num>0 に適切なスペースがありません。Ctrl + K, D を試してみましょう。
        this._diceNumber = Int32.TryParse(diceNum, out int num) && num>0 ? num : 0;
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