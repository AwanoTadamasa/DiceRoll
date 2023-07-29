namespace DiceRoll02;

// TODO(WIP): /// �Ńh�L�������e�[�V�����R�����g����͂ł��܂��B
// ���ꂼ��̃N���X�⃁�\�b�h�Ƀh�L�������e�[�V�����R�����g�����Ă݂܂��傤�B
// �G�f�B�^��œ��͂���Ƃ��ɁA���̐�����ǂނ��Ƃ��ł��܂��B
// �J���K�͂��傫���Ȃ�A�����l�ŊJ������悤�ɂȂ�ƁA���̂��肪���݂�������������悤�ɂȂ��Ă���ł��傤�B

/// <summary>
/// �T�C�R����U��B�������ꂽ�R�}���h�A���ʁA�U��Ȃ��������̃G���[��Ԃ��B
/// </summary>
internal interface IDice
{
    /// <summary>
    /// �������ꂽ�R�}���h�B2D6�ASTARS �Ȃ�"
    /// </summary>
    /// <returns>�R�}���h</returns>
    public string GetRollCommand();

    /// <summary>
    /// �T�C�R����U�������ʂ̍��v�𕶎���ɂ������� 
    /// </summary>
    /// <returns>����</returns>
    public string GetRollResult();

    /// <summary>
    /// �T�C�R����U�������ʂ̃��X�g
    /// </summary>
    /// <returns></returns>
    public int[] GetRollResultArray();

    /// <summary>
    /// �G���[�Ō��ʂ��o�Ȃ�������true
    /// </summary>
    /// <returns>true/false</returns>
    public bool HasError();

    /// <summary>
    /// �G���[���̃��b�Z�[�W�A���ʂ��o�����ɂ�null
    /// </summary>
    /// <returns>���b�Z�[�W/null</returns>
    public string? GetErrorMessage();
}