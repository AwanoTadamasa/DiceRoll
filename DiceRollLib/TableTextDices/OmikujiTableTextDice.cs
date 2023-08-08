using DiceRollLib.type;

namespace DiceRollLib.TableTextDices;

internal class OmikujiTableTextDice : TableTextDiceBase
{
    protected override TableTextDiceTable Table =>
        new(1, 7, "OMKJI", new Dictionary<int, string>
        {
            {1, "大吉" },
            {2, "中吉" },
            {3, "吉"   },
            {4, "小吉" },
            {5, "末吉" },
            {6, "凶"   },
            {7 ,"大凶" }
        });
}
