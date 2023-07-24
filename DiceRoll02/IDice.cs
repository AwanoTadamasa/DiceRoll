namespace DiceRoll02
{
    // TODO: 別ファイルにしましょう。
    // 継承したクラスも別々のファイルにしましょう。
    internal interface IDice
    {
        internal string? GetDiceCommand();
        internal string GetRollResult();
    }
}