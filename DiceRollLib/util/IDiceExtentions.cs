namespace DiceRollLib.util;

public static class IDiceExtentions
{
    public static bool HasError(this IDice dice)
    {
        return dice.DiceNum is null || dice.DiceSide is null || dice.Roll().Command == "ERROR";
    }
}
