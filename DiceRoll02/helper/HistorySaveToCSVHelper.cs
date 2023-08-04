namespace DiceRoll02.helper;

// DONE: CSV → Csv
internal static class HistorySaveToCsvHelper
{

    internal static void SaveAsWithShowDialog(string[] commandHistory, string[] resultHistory)
    {

        var saveFileDialog = new SaveFileDialog()
        {
            FileName = "RollHistory.csv",
            Filter = "CSVファイル(*.csv)|*.csv|すべてのファイル(*.*)|*.*",
            FilterIndex = 0,
            RestoreDirectory = true,
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
        };

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            SaveAs(commandHistory, resultHistory, saveFileDialog.FileName);
        }
    }

    internal static void SaveAs(string[] commandHistories, string[] resultHistories, string fileName)
    {
        if (commandHistories.Length <= 0)
        {
            return;
        }

        try
        {
            // DONE: UTF-8はデフォルトエンコーディングなので、省略可能です。
            using var w = new StreamWriter(fileName);

            w.WriteLine(@"コマンド,結果");
            foreach (var (command, result) in commandHistories.Zip(resultHistories))
            {
                w.WriteLine("{0},{1}", command, result);
            }
        }
        catch (IOException ex)
        {
            MessageBox.Show($"エラーが発生しました。指定されたファイルは書き込めませんでした。\r\n{ex}");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"不明なエラーが発生しました。\r\n{ex}");
        }
    }
}

