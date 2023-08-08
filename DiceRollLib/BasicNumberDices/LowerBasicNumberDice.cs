namespace DiceRollLib.BasicNumberDices;

internal class LowerBasicNumberDice : BasicNumberDiceBase
{
    /// <summary>
    /// Roll Low Unfair dice and sum roll results
    /// </summary>
    /// <param name="diceNumText">Number of dice</param>
    /// <param name="diceSideText">Number of diceSide</param>
    public LowerBasicNumberDice(string diceNumText, string diceSideText) : base(diceNumText, diceSideText) { }

    /// <inheritdoc/>
    private protected override string CreateDiceRollCommand(int diceNum, int diceSide)
    {
        return $"{diceNum}D{diceSide}L";
    }

    /// <inheritdoc/>
    private protected override List<int> CreateDiceRollResult(int diceNum, int diceSide)
    {
        var a =        Enumerable.Range(1, diceNum)
                         .Select(x => Random.Shared.Next(0, (diceSide + 1) * diceSide / 2) + 1)
                         .Select(x => (int)Math.Ceiling(Math.Pow(0.25 + x * 2, 0.5) - 0.5))
                         .Select(x => diceSide - x + 1);

        foreach(var b in a)
        {

        }
        return Enumerable.Range(1, diceNum)
            .Select(x => Random.Shared.Next(0, (diceSide + 1) * diceSide / 2) + 1)
            .Select(x => (int)Math.Ceiling(Math.Pow(0.25 + x * 2, 0.5) - 0.5))
            .Select(x => diceSide - x + 1)
            .ToList();
    }
}
