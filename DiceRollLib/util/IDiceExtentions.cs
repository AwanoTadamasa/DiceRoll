namespace DiceRollLib.util;

// TODO: 小さい細々したものは IDice.cs 内に記述してしまってよい。
public static class IDiceExtentions
{
    public static bool HasError(this IDice dice)
    {
        return dice.DiceNum is null
            || dice.DiceSide is null
            || dice.Roll().Command == "ERROR";
    }
}
