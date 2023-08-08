using DiceRollLib.BasicNumberDices;
using DiceRollLib.enums;
using DiceRollLib.TableTextDices;

namespace DiceRollLib.util;

public static class DiceSelectConteiner
{
    public static IDice LoadDice(this DiceSelectKeys key, string diceNum, string diceSide)
    {
        return key switch
        {
            DiceSelectKeys.NormalDice => new NormalBasicNumberDice(diceNum, diceSide),
            DiceSelectKeys.LowerDice => new LowerBasicNumberDice(diceNum, diceSide),
            DiceSelectKeys.UpperDice => new UpperBasicNumberDice(diceNum, diceSide),
            DiceSelectKeys.ZodiacSign => new ZodiacSignTableTextDice(),
            DiceSelectKeys.Omikuji => new OmikujiTableTextDice(),
            _ => new ErrorDice(),
        };
    }
}
