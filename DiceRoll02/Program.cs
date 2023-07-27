
// DONE: 他に合わせてnamespaceの中括弧を省略しましょう。まだいくつか残っていました。
// その際のインデントが大幅に変わるため、コミットは他とは分けてください。
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