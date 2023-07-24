namespace DiceRoll02
{
    // TODO: �ʃt�@�C���ɂ��܂��傤�B
    // �p�������N���X���ʁX�̃t�@�C���ɂ��܂��傤�B
    class BasicDiceRoll : IDice
    {
        // TODO: �����K���͂��̂����肪�Q�l�ɂȂ�ł��傤�B
        // https://learn.microsoft.com/ja-jp/dotnet/standard/design-guidelines/naming-guidelines
        // private�ȃt�B�[���h�ϐ��́A�������̗��h������̂ł����A����������n�߂邩�A����� _(�A���_�[�X�R�A) �����Ă��������B
        // �����ł̓A���_�[�X�R�A�𐄂��Ă����܂��B
        private int _diceNumber;
        private int _diceSide;

        public BasicDiceRoll(string diceNum, string diceType)
        {
            // TODO: �ϐ��⃁�\�b�h�ɂ� this �����ăC���X�^���X�̂��̂ł���Ƃ����ӎ����֘A�t���܂��傤�B
            // TODO: ����ϊ�������A�R���X�g���N�^�ł�������Ƃ��ɐ��l�ɂ��Ă����Ƃ悢�ł��傤�B
            this._diceNumber = StringToInt(diceNum);
            this._diceSide = DiceTypeToSide(diceType);
        }

        public string? GetDiceCommand()
        {
            if (this._diceNumber != 0)
            {
                // TODO: String.Format() �ɂ��Ē��ׂĂ݂܂��傤�B
                // TODO: ����� $"{value}" �Ƃ����L�@�ɂ��Ē��ׂĂ݂܂��傤�B
                return $"{this._diceNumber}D{this._diceSide}";
            }
            else 
            {
                // TODO: null ��Ԃ��ꍇ�� Nullable �ɂ���K�v������܂��B
                // �Ȃ��AC# 8 �ȍ~�ł́A�f�t�H���g��null�������ɂȂ��Ă��܂��B
                // ����� null �`�F�b�N�̕��S�����炷���߂̏��u�ł��B
                return null; 
            }
        }

        public string GetRollResult()
        {
            int result = 0;
            // TODO: ���[�v�̊O�Ő錾���������悢�ł��傤�B
            // TODO: seed �ɂ��Ē��ׂĂ݂܂��傤�B
            // TODO: max �����[�v�̊O�ň�x�����錾���������悢�ł��傤�B
            Random r = new();
            if (this._diceNumber != 0 )
            {
                for (int i = 0; i < this._diceNumber; i++)
                {
                    result += r.Next(this._diceSide)+1;
                }
            }
            // TODO: {} �����ʂ͏ȗ����Ȃ��悤�ɂ��܂��傤�B
            return result.ToString();
        }

        // TODO: StringToInteger �̏����ł��ˁB�ȗ������ɋL�q���܂��傤�B
        private int StringToInt(string str)
        {            
            // DONE: int �� C# �̌^���ł��B�����CLR�̃N���X���̃G�C���A�X�ɂȂ��Ă���̂ŁA���l�Ɏg���܂��B
            // �������A�N���X�̃��\�b�h���g���ꍇ�́ACLR�̃N���X�����g�������������I�ɐ������ł��B
            // �ׂ������Ƃł����A�N���X��C���X�^���X����Ɉӎ��ł���Ƃ����ł��ˁB
            // Parse �ł͂Ȃ� TryParse ���g���Ă���Ƃ����GOOD�ł��B
            // ������ƌÂ��ł����A���L�̋L�����Q�l�ɂȂ�܂��B
            // https://dobon.net/vb/dotnet/beginner/intvsint32.html
            return Int32.TryParse(str, out int num) && num > 0 ? num : 0;
        }

        // TODO: ���\�b�h���͊�{�I�ɂ͓�������n�߂܂��B
        // �C���X�^���X(���) + ���\�b�h(����) �ŉp���Ƃ��ēǂ߂�̂����z�ł��B
        private int DiceTypeToSide(string str) 
        {
            return str switch
            {
                // TODO: �f�t�H���g��2�ʂ�Ԃ��͖̂��ł��傤�BD120���w�肳��āAD2�ɂȂ�����o�O�̌��ł��B
                // switch �����g���Ă݂��̂�GOOD�ł��B�Z���L�q�ł��ēǂ݂₷���ł��B
                "�R�C��" => 2,
                "4�ʑ�" => 4,
                "8�ʑ�" => 8,
                "10�ʑ�" => 10,
                "12�ʑ�" => 12,
                "20�ʑ�" => 20,
                "100�ʑ�" => 100,
                _ => 0,
            };
        }
    }
}