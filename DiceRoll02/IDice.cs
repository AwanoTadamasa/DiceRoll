namespace DiceRoll02;

// TODO: /// �Ńh�L�������e�[�V�����R�����g����͂ł��܂��B
// ���ꂼ��̃N���X�⃁�\�b�h�Ƀh�L�������e�[�V�����R�����g�����Ă݂܂��傤�B
// �G�f�B�^��œ��͂���Ƃ��ɁA���̐�����ǂނ��Ƃ��ł��܂��B
// �J���K�͂��傫���Ȃ�A�����l�ŊJ������悤�ɂȂ�ƁA���̂��肪���݂�������������悤�ɂȂ��Ă���ł��傤�B
internal interface IDice
{
    public string GetRollCommand();

    public string GetRollResult();

    // TODO: bool HasError() �Ƃ������O�̃��\�b�h��p�ӂ���ƂƂ��ɁA
    // string? GetErrorMessage() �Ƃ������O�̃��\�b�h��p�ӂ���̂��悳�����ł��B
    // ��L���g�����ƂŌĂяo�����ŃG���[���b�Z�[�W�̓��e���l���Ȃ��Ă悭�Ȃ�܂��B
    public string? CommandError { get; }
}