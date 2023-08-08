using DiceRollLib.BasicNumberDices;
using DiceRollLib.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollLib.type
{
    internal class DiceRollDI
    {
        public Dictionary<DiceSelectKeys, Func<BasicNumberDiceBase>> DICO;

        void init()
        {
            DICO.Add("Dice", () =>
            {
                File.ReadAllText("");
                retrun new LowerBasicNumberDice("", "")
            });

            DICO[typeof(DiceSelectKeys)].
        }
    }
}
