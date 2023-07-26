namespace DiceRoll02
{
    internal static class DiceTypeInfo
    {
        // TODO: Canを使う場合は動詞と組み合わせます。
        // bool を返すメソッド名の定形はいくつかあって、
        // Is + 状態名詞
        // Is + 過去分詞
        // Has + 過去分詞
        // Can + 現在形動詞
        // Exists や Contains など三単現s付き
        // などのパターンがあります。
        // この場合は IsCustomDice くらいがよさそうです。そうなってくると、 true/false の意味が逆になってるようです。
        internal static bool CanDiceCustom(string selectedDiceType)
        {
            return selectedDiceType switch
            {
                "星座" or "おみくじ" => false,
                _ => true
            };
        }

        internal static string GetDiceType(string selectedDiceType, GroupBox radioButtonGroup)
        {
            // TODO: = の次にスペースがありません。
            // Ctrl + K, D で現在のドキュメントをフォーマットできます。
            IEnumerable<RadioButton> radioButtons =radioButtonGroup.Controls.OfType<RadioButton>();

            return selectedDiceType switch
            {
                "星座" => "constellation",
                "おみくじ" => "omikuji",
                _ => radioButtons.FirstOrDefault(rb => rb.Checked, radioButtons.First()).Name
            };
        }
    }
}
