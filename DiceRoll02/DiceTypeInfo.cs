namespace DiceRoll02
{
    internal class DiceTypeInfo
    {
        private readonly bool _diceCustomable;
        private readonly string _diceType;
        internal DiceTypeInfo(string selectedDiceType, GroupBox radioButtonGroup) 
        {
            _diceCustomable = selectedDiceType switch
            {
                "星座" or "おみくじ" => false,
                _ => true
            };

            _diceType = selectedDiceType switch
            {
                "星座" => "constellation",
                "おみくじ" => "omikuji",
                _ => radioButtonGroup.Controls
                    .OfType<RadioButton>()
                    .Single(rb => rb.Checked).Name
            };
        }

        internal bool IsDiceCustomable()
        {
            return _diceCustomable;
        }

        internal string GetDiceType()
        {
            return _diceType;
        }
    }
}
