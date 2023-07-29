namespace DiceRoll02;

/// <summary>
/// 黄道12星座を返すクラス
/// </summary>
internal class ZodiacSignTableChoose : ChoosingTableBase
{
    protected override string DiceRollCommand => "STARS";

    // DONE: インデントするときはスペース4つとします。
    // あとは、開始カッコの位置に合わせて閉じカッコのインデントを揃えるとよいです。
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

    // 閉じカッコを揃えないパターンもよくありますが、インデント8つに見えてしまうので、あまりおすすめしません。
    // プロジェクトを通して一貫した書き方をすることが大切です。
    // 途中から参加するプロジェクトの場合は、そのプロジェクトの書き方に合わせます。
    protected string[] DiceChooseTable2 => new[] {
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
