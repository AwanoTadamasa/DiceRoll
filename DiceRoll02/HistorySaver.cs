using System.IO;

namespace DiceRoll02
{
    internal static class HistorySaver
    {
        internal static void SaveAsCSV(string commandHistory, string resultHistory)
        {
            string[] _commandHistory = commandHistory.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
            string[] _resultHistory = resultHistory.Split("\r\n", StringSplitOptions.RemoveEmptyEntries) ;

            if (_commandHistory.Length > 0)
            {
                SaveFileDialog saveFileDialog = new()
                {
                    FileName = "RollHistory.csv",
                    Filter = "CSVファイル(*.csv)|*.csv|すべてのファイル(*.*)|*.*",
                    FilterIndex = 0,
                    RestoreDirectory = true,
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                    try
                    {
                        using StreamWriter w = new(saveFileDialog.FileName, false, System.Text.Encoding.GetEncoding("shift_jis"));
                        w.WriteLine(@"コマンド,結果");
                        for (int i = 0; i < _commandHistory.Length; i++)
                        {
                            w.WriteLine("{0},{1}", _commandHistory[i], _resultHistory[i]);
                        }
                    }
                    catch (IOException ex) 
                    {
                        _ = MessageBox.Show($"エラーが発生しました。指定されたファイルは読み込めませんでした。\r\n{ex}");
                    }
                    catch (Exception ex)  
                    {
                        _ = MessageBox.Show($"不明なエラーが発生しました。\r\n{ex}");
                    }
                    finally 
                    {
                        saveFileDialog.Dispose();
                    }
                }
            }
        }
    }
}
