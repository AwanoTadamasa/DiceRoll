namespace DiceRoll02.Dices;

internal class OmikujiTextDice : TextDiceBase
{
    /// <inheritdoc/>
    protected override string DiceRollCommand => "OMKJI";

    /// <inheritdoc/>
    protected override string[] DiceChooseTable => new[] {
        "大吉",
        "中吉",
        "吉",
        "小吉",
        "末吉",
        "凶",
        "大凶"
    };
}
