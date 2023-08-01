namespace DiceRoll02;

/// <summary>
/// 黄道12星座を返すクラス
/// </summary>
internal class ZodiacSignTextDice : TextDiceBase
{
    /// <inheritdoc/>
    protected override string DiceRollCommand => "STARS";

    /// <inheritdoc/>
    protected override string[] DiceChooseTable => new[] {
        "\u2648(牡羊座)",
        "\u2649(牡牛座)",
        "\u264a(双子座)",
        "\u264b(蟹座)",
        "\u264c(獅子座)",
        "\u264d(乙女座)",
        "\u264e(天秤座)",
        "\u264f(蠍座)",
        "\u2650(射手座)",
        "\u2651(山羊座)",
        "\u2652(水瓶座)",
        "\u2653(魚座)",
    };
}
