using System.Drawing.Text;

namespace DiceRoll01
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
        int GetResult();
    }
    class RollDice : IDice
    {
        private int Num;
        private int Side;
        private string Option;

        public RollDice(int Num, int Side, string Option = "")
        {
            this.Num = Num;
            this.Side = Side;
            this.Option = Option;
        }

        string IDice.GetDiceCommand()
        {
            if (Option == "")
            {
                return Num.ToString()+"D"+Side.ToString();
            }
            else
            {
                return "XXX";
            }

        }
        int IDice.GetResult()
        {
            int Result = 0;

            for (int i = 0; i < Num; i++)
            {
                Random r = new Random();
                Result +=r.Next(0,Side)+1;
            }
            return Result;
        }
    }
}