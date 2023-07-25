namespace DiceRoll02
{
    internal class OmikujiRoll : IDice
    {
        public string GetDiceCommand()
        {
            return "OMKJ";
        }

        public string GetRollResult()
        {
            Random r = new();
            int numberOmikuji = 7;

            return r.Next(numberOmikuji) switch 
            {
                0 => "大吉",
                1 => "中吉",
                2 => "吉",
                3 => "小吉",
                4 => "末吉",
                5 => "凶",
                6 => "大凶",
                _ => "エラーです"
            };
        }
    }
}
