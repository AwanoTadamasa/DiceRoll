namespace DiceRoll02;

// DONE: クラス名についての解説です。
// IDice を継承しているものは、-Dice で終わるとよいです。
// インターフェースは複数継承できるので、複数ある場合は、その中でも本質を表す名前を使います。
// 今回の本質は IDice なので、抽象クラスも含めて、-Dice で終わるのが望ましいでしょう。
//
// ダイスロール(dice-roll)は和製英語？でしょうか。DiceRoleではないですよね？
// 通常は roll a dice で、roll は動詞なので混乱しそうです。
// IDiceRoll として、そのコメントで意図を説明するという手法がよさそうですが、
// 今回は プロジェクト名や namespace で DiceRoll を使っているので避けたほうが無難です。
// クラス名と被ることができないので、他の名前、今回は IDice としましょう。
// そうなってくると、RollingDice の命名も見直したほうがよいでしょう。
// Roll を動詞として捉えた場合の提案でしたので、今回は BasicDiceBase でよいと思います。
// 必ずではありませんが、基本的には継承したものは末尾に残すと一貫性が保てます。
// BasicDiceBae を継承したものは、UpperBasicDice, LowerBasicDice となります。
//
// Omikuji, ZodiacSign の命名について考えてみます。
// choice は自分で選ぶというニュアンスがあるので、サイコロには適していません。
// select や pick もそのニュアンスがあるので避けたほうがよいでしょう。
// サイコロを主体にしたいので xxxDice という名前がよさそうです。
// 確率テーブル(Probability Table)という言葉から、Table を検討してみます。
// TableDice: テーブルの上で振るためのサイコロのような名前になってしまいました。
// 表ではなく、箱の中から選ぶイメージで、Box を検討してみます。
// BoxDice: TableDice 同様、箱の中に入っているサイコロになりました。
// 難しく考えず、普通じゃない、改造されたサイコロという意味で Custom を検討してみます。
// CustomDice: BasicDice と対になりそうで、悪くありません。
// しかしカスタムだと意味が広すぎるので、もう少し考えてみます。
// FortuneCookieDice: おみくじダイス。それなら OkumijiDice そのままの方がよさそうです。
// FortuneDice: 運命のダイス。少し大げさでしょうか。
// lot は日本語のロト6の名前にもなっているようにクジという意味があります。
// 箱クジ、抽選箱は lottery box といいます。
// LotteryDice: 抽選に使うサイコロになってしまいました。間違いではありませんが違和感が残ります。
// ・・・というように、命名は非常に頭を悩ます問題です。
// プログラムの構造にも関わってくるので手は抜けません。
// さて、悩んだときは全体をぼんやりと眺めるとなにかが見えてくることがあります。
// BasicDice に対して、普通じゃないダイスを実装したいのですが、
// Omikuji も ZodiacSign も一覧から選択させたいだけの構造です。
// BasicDice の数字を他の値に変換できればよいわけです。
// 数字を他の文字に割り当てる、つまりマッピングです。
// MapDiceBase として、OmikujiMapDice, ZodiacSignMapDice としてもよいですが、
// Match という言葉を使っても良さそうです。
// あとは Random という言葉も一覧から選ばれるという意味で該当しそうです。
// 動作にフォーカスすると、上記のようになりますが、結果にフォーカスすると、
// 数字以外の何か、文字が出力されるサイコロと考えることもできます。
// BasicDiceBase に対して、TextDiceBase なんてのでもよいかもしれません。
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
