namespace DiceRoll02;

class ConstellationDiceRoll : IDice
{
    public string GetDiceCommand()
    {
        return "STARS";
    }

    private readonly int _zodiacSignNum = 12;

    public string GetRollResult()
    {
        Random r = new();
        return r.Next(0, this._zodiacSignNum) switch
        {
            0 => "\u2648(‰²—rÀ)",
            1 => "\u2649(‰²‹À)",
            2 => "\u264a(‘oqÀ)",
            3 => "\u264b(ŠIÀ)",
            4 => "\u264c(‚qÀ)",
            5 => "\u264d(‰³—À)",
            6 => "\u264e(“V”‰À)",
            7 => "\u264f(å¶À)",
            8 => "\u2650(ËèÀ)",
            9 => "\u2651(R—rÀ)",
            10 => "\u2652(…•rÀ)",
            11 => "\u2653(‹›À)",
            _ => "ƒGƒ‰[‚Å‚·",
        };
    }

    public string? HasError()
    {
        return null;
    }
}