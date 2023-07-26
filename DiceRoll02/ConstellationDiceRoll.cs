namespace DiceRoll02
{
    class ConstellationDiceRoll : IDice
    {
        public string GetDiceCommand()
        {
            return "STARS";
        }

        private readonly int _numberConstellation = 12;

        public string GetRollResult()
        {
            // DONE: 11 �̃��e�����͕ϐ��ɂ��܂��傤�B
            // UTF�Ő����������Ă݂��̂�GOOD�ł��B
            Random r = new();
            return r.Next(0, _numberConstellation) switch
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
        }
    }
}