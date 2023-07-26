namespace DiceRoll02
{
    internal static class DiceTypeInfo
    {
        // DONE: able は可能な動作を表します。そのためインターフェース名によく使われます。
        // IDisposable、ICloneable、など
        // IDisposable は Dispose できるという意味なので、Dispose メソッドを持ちます。
        //      => 変更しました
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
