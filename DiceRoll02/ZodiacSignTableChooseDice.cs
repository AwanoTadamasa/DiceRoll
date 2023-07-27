namespace DiceRoll02;

internal class ZodiacSignTableChooseDice : TableChooseDice
{
    protected override string DiceRollCommand => "STARS";

    protected override string[] DiceChooseTable => new string[] {
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
