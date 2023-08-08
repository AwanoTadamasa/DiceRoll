namespace DiceRollLib.BasicNumberDices;

internal class NormalBasicNumberDice : BasicNumberDiceBase
{
    /// <summary>
    /// Roll fair number dice and sum roll results
    /// </summary>
    /// <param name="diceNumText">Number of dice</param>
    /// <param name="diceSideText">Number of diceSide</param>
    public NormalBasicNumberDice(string diceNumText, string diceSideText) : base(diceNumText, diceSideText) { }

    /// <inheritdoc/>
    private protected override string CreateDiceRollCommand(int diceNum, int diceSide)
    {
        return $"{diceNum}D{diceSide}";
    }

    /// <inheritdoc/>
    private protected override List<int> CreateDiceRollResult(int diceNum, int diceSide)
    {
        return Enumerable.Range(0, diceNum)
            .Select(i => Random.Shared.Next(0, diceSide) + 1)
            .ToList();
    }
}
