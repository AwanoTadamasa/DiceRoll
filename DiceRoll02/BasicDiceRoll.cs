namespace DiceRoll02
{
    class BasicDiceRoll : IDice
    {
        private readonly int _diceNumber;
        private readonly int _diceSide;

        public BasicDiceRoll(string diceNum, string diceType)
        {
            // TODO: �C���X�^���X���\�b�h�ƃN���X���\�b�h��������ꍇ�́A��ʂ��邽�߂ɁA�C���X�^���X���\�b�h�ɂ� this ���A�N���X���\�b�h�ɂ̓N���X�������܂��B
            this._diceNumber = StringToInt(diceNum);
            this._diceSide = DiceTypeToSide(diceType);
        }

        public string? GetDiceCommand()
        {
            if (this._diceNumber != 0)
            {
                return $"{this._diceNumber}D{this._diceSide}";
            }
            else
            {
                return null;
            }
        }

        public string GetRollResult()
        {
            int result = 0;


            Random r = new();
            if (this._diceNumber != 0 )
            {
                for (int i = 0; i < this._diceNumber; i++)
                {
                    result += r.Next(this._diceSide)+1;
                }
            }
            return result.ToString();
        }

        private static int StringToInt(string str)
        {
            return Int32.TryParse(str, out int num) && num > 0 ? num : 0;
        }

        // TODO: �ϊ����\�b�h�́A�C���X�^���X��̂� ToXxx() �Ƃ���悤�ɂ��܂��傤�B
        private static int DiceTypeToSide(string str)
        {
            return str switch
            {
                "�R�C��" => 2,
                "4�ʑ�" => 4,
                "6�ʑ�" => 6,
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