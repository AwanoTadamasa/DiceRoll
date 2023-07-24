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

    // TODO: �ʃt�@�C���ɂ��܂��傤�B
    // �p�������N���X���ʁX�̃t�@�C���ɂ��܂��傤�B
    interface IDice
    {
        string GetDiceCommand();
        string GetRollResult();
    }

    class RollBasicDice : IDice
    {
        // TODO: �����K���͂��̂����肪�Q�l�ɂȂ�ł��傤�B
        // https://learn.microsoft.com/ja-jp/dotnet/standard/design-guidelines/naming-guidelines
        // private�ȃt�B�[���h�ϐ��́A�������̗��h������̂ł����A����������n�߂邩�A����� _(�A���_�[�X�R�A) �����Ă��������B
        // �����ł̓A���_�[�X�R�A�𐄂��Ă����܂��B
        private string DiceNum;
        private string DiceType;

        public RollBasicDice(string num, string type)
        {
            // TODO: �ϐ��⃁�\�b�h�ɂ� this �����ăC���X�^���X�̂��̂ł���Ƃ����ӎ����֘A�t���܂��傤�B
            DiceNum = num;
            DiceType = type;
        }

        public string GetDiceCommand()
        {
            // TODO: ����ϊ�������A�R���X�g���N�^�ł�������Ƃ��ɐ��l�ɂ��Ă����Ƃ悢�ł��傤�B
            int DNum = StoI(DiceNum);
            if (DNum == 0)
            {
                // TODO: null ��Ԃ��ꍇ�� Nullable �ɂ���K�v������܂��B
                // �Ȃ��AC# 8 �ȍ~�ł́A�f�t�H���g��null�������ɂȂ��Ă��܂��B
                // ����� null �`�F�b�N�̕��S�����炷���߂̏��u�ł��B
                return null;
            }
            else
            {
                // TODO: String.Format() �ɂ��Ē��ׂĂ݂܂��傤�B
                // TODO: ����� $"{value}" �Ƃ����L�@�ɂ��Ē��ׂĂ݂܂��傤�B
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
                    // TODO: ���[�v�̊O�Ő錾���������悢�ł��傤�B
                    // TODO: seed �ɂ��Ē��ׂĂ݂܂��傤�B
                    Random r = new();
                    // TODO: max �����[�v�̊O�ň�x�����錾���������悢�ł��傤�B
                    Result += r.Next(DSide(DiceType)) + 1;
                }
            }
            // TODO: {} �����ʂ͏ȗ����Ȃ��悤�ɂ��܂��傤�B
            else Result = 0;

            return Result.ToString();
        }

        // TODO: StringToInteger �̏����ł��ˁB�ȗ������ɋL�q���܂��傤�B
        static int StoI(string s)
        {
            // DONE: int �� C# �̌^���ł��B�����CLR�̃N���X���̃G�C���A�X�ɂȂ��Ă���̂ŁA���l�Ɏg���܂��B
            // �������A�N���X�̃��\�b�h���g���ꍇ�́ACLR�̃N���X�����g�������������I�ɐ������ł��B
            // �ׂ������Ƃł����A�N���X��C���X�^���X����Ɉӎ��ł���Ƃ����ł��ˁB
            // Parse �ł͂Ȃ� TryParse ���g���Ă���Ƃ����GOOD�ł��B
            // ������ƌÂ��ł����A���L�̋L�����Q�l�ɂȂ�܂��B
            // https://dobon.net/vb/dotnet/beginner/intvsint32.html
            return Int32.TryParse(s, out var i) && i > 0 ? i : 0;
        }

        // TODO: ���\�b�h���͊�{�I�ɂ͓�������n�߂܂��B
        // �C���X�^���X(���) + ���\�b�h(����) �ŉp���Ƃ��ēǂ߂�̂����z�ł��B
        static int DSide(string s)
        {
            // TODO: �f�t�H���g��2�ʂ�Ԃ��͖̂��ł��傤�BD120���w�肳��āAD2�ɂȂ�����o�O�̌��ł��B
            // switch �����g���Ă݂��̂�GOOD�ł��B�Z���L�q�ł��ēǂ݂₷���ł��B
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
            // TODO: 11 �̃��e�����͕ϐ��ɂ��܂��傤�B
            // UTF�Ő����������Ă݂��̂�GOOD�ł��B
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