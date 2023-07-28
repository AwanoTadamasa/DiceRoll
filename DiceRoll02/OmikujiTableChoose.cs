namespace DiceRoll02;

internal class OmikujiTableChoose : TableChoosingDiceBase
{
    protected override string DiceRollCommand => "OMKJI";

    // TODO: インデントがほしいです。
    // TODO: new string[] → new[] と省略できます。
    protected override string[] DiceChooseTable => new string[] {
    "大吉",
    "中吉",
    "吉",
    "小吉",
    "末吉",
    "凶",
    "大凶"
    };
}
