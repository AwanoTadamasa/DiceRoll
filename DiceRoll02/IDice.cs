namespace DiceRoll02;

// TODO: /// �Ńh�L�������e�[�V�����R�����g����͂ł��܂��B
// ���ꂼ��̃N���X�⃁�\�b�h�Ƀh�L�������e�[�V�����R�����g�����Ă݂܂��傤�B
// �G�f�B�^��œ��͂���Ƃ��ɁA���̐�����ǂނ��Ƃ��ł��܂��B
// �J���K�͂��傫���Ȃ�A�����l�ŊJ������悤�ɂȂ�ƁA���̂��肪���݂�������������悤�ɂȂ��Ă���ł��傤�B
internal interface IDice
{
    public string? GetDiceCommand();

    public string? GetRollResult();

    // TODO: Check�Ƃ����p��́A�����`�F�b�N���Ă��邩���g������܂ł킩��܂���B��̓I�Ȗ��O���l���Ă݂܂��傤�B
    // ����̎g�������悾�Ƃ͎v���܂��� BasicDiceRoll �ł����g��Ȃ��Ȃ�A�C���^�[�t�F�[�X�ɂ���K�v�͂��܂�Ȃ��ł��傤�B
    public string? CheckDiceCommandError();
}