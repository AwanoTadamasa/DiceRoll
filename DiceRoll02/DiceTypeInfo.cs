namespace DiceRoll02
{
    internal static class DiceTypeInfo
    {
        internal static bool IsCustomDice(string selectedDiceType)
        {
            return selectedDiceType switch
            {
                "星座" or "おみくじ" => true,
                _ => false
            };
        }

        internal static string GetDiceType(string selectedDiceType, GroupBox radioButtonGroup)
        {
            IEnumerable<RadioButton> radioButtons = radioButtonGroup.Controls.OfType<RadioButton>();

            return selectedDiceType switch
            {
                "星座" => "constellation",
                "おみくじ" => "omikuji",
                _ => radioButtons.FirstOrDefault(rb => rb.Checked, radioButtons.First()).Name
            };
        }
    }
}
