
// TODO: namespace �̒����ʂ͏ȗ��ł���悤�ɂȂ�܂����B���������C���f���g�����点�Č��ʂ����ǂ��Ȃ�܂��B
namespace DiceRoll02
{
    // TODO: �f�t�H���g�̃A�N�Z�X�C���q�ɂ��Ē��ׂĂ݂܂��傤�B
    internal interface IDice
    {
        // TODO: ������ internal �ɂ������ƂŁA�p����� public �ɂ��Ă�����̂ƍ���Ȃ��Ȃ��Ă��܂��B
        internal string? GetDiceCommand();

        internal string GetRollResult();
    }
}