namespace DiceRoll02.type;

/// <summary>
/// サイコロを振った結果を返す型
/// </summary>
/// <param name="Text">サイコロを振った最終的な結果</param>
/// <param name="Ints">それぞれのサイコロの結果</param>
internal record RollResult(string Text, List<int> Ints)
{


}
