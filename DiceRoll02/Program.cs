namespace DiceRoll02
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    interface IDice
    {
        string GetDiceCommand();
        string GetRollResult();
    }

    class RollBasicDice : IDice
    {
        private string DiceNum;
        private string DiceType;
        public RollBasicDice(string num, string type)
        {
            DiceNum = num;
            DiceType = type;
        }

        public string GetDiceCommand()
        {
            int DNum = StoI(DiceNum);
            if (DNum == 0)
            {
                return null;
            }
            else
            {
                return DNum.ToString() + "D" + DSide(DiceType).ToString();
            }
        }
        public string GetRollResult()
        {
            int DNum = StoI(DiceNum);
            int Result = 0;
            if(DNum != 0)
            {
                for (int i = 0; i < DNum; i++)
                {
                    Random r = new();
                    Result += r.Next(DSide(DiceType)) + 1;
                }
            }
            else Result = 0;
            return Result.ToString();
        }
        static int StoI(string s)
        {
            return int.TryParse(s, out int i) && i > 0 ? i : 0;
        }
        static int DSide(string s)
        {
            int i = s switch
            {
                "4面体" => 4,
                "6面体" => 6,
                "8面体" => 8,
                "10面体" => 10,
                "12面体" => 12,
                "20面体" => 20,
                "100面体" => 100,
                _ => 2,
            };
            return i;
        }
    }
    class ConstellationDice : IDice
    {
        public string GetDiceCommand()
        {
            return "STARS";
        }
        public string GetRollResult()
        {
            Random r = new();
            string Result = r.Next(11) switch
            {
                0 => "\u2648(牡羊座)",
                1 => "\u2649(牡牛座)",
                2 => "\u264a(双子座)",
                3 => "\u264b(蟹座)",
                4 => "\u264c(獅子座)",
                5 => "\u264d(乙女座)",
                6 => "\u264e(天秤座)",
                7 => "\u264f(蠍座)",
                8 => "\u2650(射手座)",
                9 => "\u2651(山羊座)",
                10 => "\u2652(水瓶座)",
                11 => "\u2653(魚座)",
                _ => "エラーです",
            };
            return Result;
        }

    }
}