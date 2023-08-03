using DiceRoll02.type;

namespace DiceRoll02.Dices;

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
    /// �T�C�R����U��������
    /// </summary>
    /// <returns>����</returns>
    public RollResult Roll();

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
