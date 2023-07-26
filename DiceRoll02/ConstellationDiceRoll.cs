namespace DiceRoll02;

class ConstellationDiceRoll : IDice
{
    public string GetDiceCommand()
    {
        return "STARS";
    }

    // DONE: constellation だと星座なので、少し意味が広いです。
    // _numberOfZodiacSign か ZodiacSignNum でどうでしょうか？
    private readonly int _zodiacSignNum = 12;

    public string GetRollResult()
    {
        Random r = new();
        return r.Next(0, this._zodiacSignNum) switch
        {
            0 => "\u2648(牡羊座)",
            1 => "\u2649(牡牛座)",
            2 => "\u264a(双子座)",
            3 => "\u264b(蟹座)",
            4 => "\u264c(獅子座)",
            5 => "\u264d(乙女座)",
            6 => "\u264e(天秤座)",
            7 => "\u264f(蠍座)",
            8 => "\u2650(射手座)",
            9 => "\u2651(山羊座)",
            10 => "\u2652(水瓶座)",
            11 => "\u2653(魚座)",
            _ => "エラーです",
        };
    }

    public string? CheckDiceCommandError()
    {
        return null;
    }
}