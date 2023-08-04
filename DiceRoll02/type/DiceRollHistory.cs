using Newtonsoft.Json;

namespace DiceRoll02.type;

//[JsonConverter(typeof(forma), Formatting.None)]
internal record DiceRollHistory(string Command, string Result) { }
