namespace DiceRollLib.type;

/// <summary>
/// Has rolled dices result
/// </summary>
/// <param name="Command">DicreollCommand</param>
/// <param name="Result">FinalyDiceRollResult</param>
/// <param name="Dices">EachDiceNumbersList</param>
public record RollResult(string Command, string Result, List<int> Dices) { }
