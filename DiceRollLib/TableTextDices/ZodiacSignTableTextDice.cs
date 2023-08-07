using DiceRollLib.type;

namespace DiceRollLib.TableTextDices;

internal class ZodiacSignTableTextDice : TableTextDiceBase
{
    protected override TableTextDiceTable Table
    {
        get => new(1, 12, "STARS", new Dictionary<int, string>
        {
            {1, "\u2648(牡羊座)"},
            {2, "\u2649(牡牛座)"},
            {3, "\u264a(双子座)"},
            {4, "\u264b(蟹座)"  },
            {5, "\u264c(獅子座)"},
            {6, "\u264d(乙女座)"},
            {7, "\u264e(天秤座)"},
            {8, "\u264f(蠍座)"  },
            {9, "\u2650(射手座)"},
            {10,"\u2651(山羊座)"},
            {11,"\u2652(水瓶座)"},
            {12,"\u2653(魚座)"  },
        });
    }
}
