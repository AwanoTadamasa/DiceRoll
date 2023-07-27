namespace DiceRoll02;

internal class OmikujiRoll : IDice
{
    private readonly int _numberOfOmikuji = 7;

    public string GetDiceCommand()
    {
        return "OMKJ";
    }

    public string GetRollResult()
    {
        Random r = new();

        return r.Next(this._numberOfOmikuji) switch
        {
            0 => "大吉",
            1 => "中吉",
            2 => "吉",
            3 => "小吉",
            4 => "末吉",
            5 => "凶",
            6 => "大凶",
            _ => "エラーです"
        };
    }

    public string? HasError()
    {
        return null;
    }
}
