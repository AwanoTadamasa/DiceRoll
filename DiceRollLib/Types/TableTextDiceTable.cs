namespace DiceRollLib.Types;

/// <summary>
/// TableTextDice roll from this table
/// </summary>
/// <param name="DiceNum">Number of dice</param>
/// <param name="DiceSide">Number of diceSide</param>
/// <param name="Command">Dice roll command</param>
/// <param name="NumberTextPairs">Rolled result sum &amp; text pair</param>
public record TableTextDiceTable(int DiceNum, int DiceSide, string Command, Dictionary<int, string> NumberTextPairs) { }
