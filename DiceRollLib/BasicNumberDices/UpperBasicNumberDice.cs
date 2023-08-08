namespace DiceRollLib.BasicNumberDices;

internal class UpperBasicNumberDice : BasicNumberDiceBase
{
    /// <summary>
    /// Roll Low Unfair dice and sum roll results
    /// </summary>
    /// <param name="diceNumText">Number of dice</param>
    /// <param name="diceSideText">Number of diceside</param>
    public UpperBasicNumberDice(string diceNumText, string diceSideText) : base(diceNumText, diceSideText) { }

    /// <inheritdoc/>
    private protected override string CreateDiceRollCommand(int diceNum, int diceSide)
    {
        return $"{diceNum}D{diceSide}U";
    }

    /// <inheritdoc/>
    private protected override List<int> CreateDiceRollResult(int diceNum, int diceSide)
    {
        return Enumerable.Range(0, diceNum)
                         .Select(x => Random.Shared.Next(0, (diceSide + 1) * diceSide / 2) + 1)
                         .Select(x => (int)Math.Ceiling(Math.Pow(0.25 + x * 2, 0.5) - 0.5))
                         .ToList();
    }
}
