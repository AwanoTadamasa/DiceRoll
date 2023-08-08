namespace DiceRollLib.type;

/// <summary>
/// TableTextDice roll from this table 
/// </summary>
/// <param name="DiceNum">Number of dice</param>
/// <param name="DiceSide">Number of diceside</param>
/// <param name="Command">Dice roll command</param>
/// <param name="Table">Rolled result sum & text pair</param>
public record TableTextDiceTable(int DiceNum, int DiceSide, string Command, Dictionary<int, string> NumberTextPairs) { }
