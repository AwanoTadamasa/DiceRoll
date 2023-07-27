using System.IO;

namespace DiceRoll02;

// DONE: CSV → Csv
internal static class HistorySaveToCsv
{
    internal static void SaveAs(string commandHistory, string resultHistory)
    {
        // DONE: Histories → Histories
        string[] commandHistories = commandHistory.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
        string[] resultHistories = resultHistory.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

        // DONE: if を 1行にする場合もありますが、その場合は { } は書きません。ここではきちんと改行しましょう。
        if (commandHistories.Length <= 0)
        {
            return;
        }
        var saveFileDialog = new SaveFileDialog()
        {
            FileName = "RollHistory.csv",
            Filter = "CSVファイル(*.csv)|*.csv|すべてのファイル(*.*)|*.*",
            FilterIndex = 0,
            RestoreDirectory = true,
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
        };

        try
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                // DONE: スネークケースは使いません。shiftJis か sjis となります。
                var sjisEncoeding = System.Text.Encoding.GetEncoding("Shift_JIS");

                // TODO: Class c = new() の省略形よりも、var c = new Class() の方が取り回しがよいです。
                // コピペして別のものに変えて使おうと思った時、左端のクラス名を変えジャンプしてコンストラクタの内容を変えるより、
                // new 以降で変えたほうが移動が少なくて済みます。
                //      => 見つけ次第変更していきます。
                using var w = new StreamWriter(saveFileDialog.FileName, false, sjisEncoeding);

                // DONE: ここの try-catch は不要と思います。

                w.WriteLine(@"コマンド,結果");
                // UNDONE: 星座で使う記号が化けてしまいます。どうしたらよいでしょうか？
                // TODO: 文字コードの問題です。星座のコードはUnicodeでしたが、ここではSJISで保存しています。UTF-8で保存してみましょう。
                foreach (var (command, result) in commandHistories.Zip(resultHistories))
                {
                    w.WriteLine("{0},{1}", command, result);
                }
            }
        }
        catch (IOException ex)
        {
            // DONE: 丁寧にやる場合は _(アンダースコア) による破棄で正しいですが、冗長に感じます。ない方がよさそうです。
            // このあたりは昔からやってる人の慣例があると思われます。
            // _(アンダースコア) による破棄自体がC#言語の新しい機能となります。
            MessageBox.Show($"エラーが発生しました。指定されたファイルは書き込めませんでした。\r\n{ex}");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"不明なエラーが発生しました。\r\n{ex}");
        }
        finally
        {
            saveFileDialog.Dispose();
        }
    }
}

