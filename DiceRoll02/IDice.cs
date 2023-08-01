namespace DiceRoll02;

// DONE: /// �Ńh�L�������e�[�V�����R�����g����͂ł��܂��B
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

    #region ��������

    // DONE: GetRollResult() �� GetRollResultArray() �ł����A
    // �T�C�R���̌��ʂ̎擾���@����������Ƃǂ�����g�����A�g�����Ŏg�������Ȃ���΂����܂���B
    // �����͂Ȃ����āARoll() ���āA���ʂ� List<string> �ŕԂ��΁A
    // �V���v���ɂȂ�̂ł͂Ȃ��ł��傤���H
    // RollDices() �Ƃ���ƁADice.RollDices() �ƂȂ�̂ŁA�������Ȋ����ɂȂ�܂��B
    // Roll() �����Ŏ������œ]�������ƕ\������̂��悢�ł��B

    // DONE:  List<string> ��Ǝ��̌^�ɂ��Ă݂悤�I�I

    /// <summary>
    /// �T�C�R����U��������
    /// </summary>
    /// <returns>����</returns>
    public RollResult Roll();

    #endregion �����܂�

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