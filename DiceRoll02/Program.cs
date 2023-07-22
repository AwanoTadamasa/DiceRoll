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
                "4�ʑ�" => 4,
                "6�ʑ�" => 6,
                "8�ʑ�" => 8,
                "10�ʑ�" => 10,
                "12�ʑ�" => 12,
                "20�ʑ�" => 20,
                "100�ʑ�" => 100,
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
                0 => "\u2648(���r��)",
                1 => "\u2649(������)",
                2 => "\u264a(�o�q��)",
                3 => "\u264b(�I��)",
                4 => "\u264c(���q��)",
                5 => "\u264d(������)",
                6 => "\u264e(�V����)",
                7 => "\u264f(嶍�)",
                8 => "\u2650(�ˎ��)",
                9 => "\u2651(�R�r��)",
                10 => "\u2652(���r��)",
                11 => "\u2653(����)",
                _ => "�G���[�ł�",
            };
            return Result;
        }

    }
}