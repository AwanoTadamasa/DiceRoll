
// DONE: ���ɍ��킹��namespace�̒����ʂ��ȗ����܂��傤�B�܂��������c���Ă��܂����B
// ���̍ۂ̃C���f���g���啝�ɕς�邽�߁A�R�~�b�g�͑��Ƃ͕����Ă��������B
namespace DiceRoll02;

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