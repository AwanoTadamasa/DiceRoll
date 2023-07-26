namespace DiceRoll02;

class ConstellationDiceRoll : IDice
{
    public string GetDiceCommand()
    {
        return "STARS";
    }

    // DONE: constellation ���Ɛ����Ȃ̂ŁA�����Ӗ����L���ł��B
    // _numberOfZodiacSign �� ZodiacSignNum �łǂ��ł��傤���H
    private readonly int _zodiacSignNum = 12;

    public string GetRollResult()
    {
        Random r = new();
        return r.Next(0, this._zodiacSignNum) switch
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

    public string? CheckDiceCommandError()
    {
        return null;
    }
}