using System.IO;

namespace DiceRoll02;

internal static class HistorySaveToCSV
{
    // TODO: SaveAs は名前をつけて保存でよく使われる名前です。CSVはクラス名の方で判別できるようにした方がよいでしょう。
    internal static void SaveAs(string commandHistory, string resultHistory)
    {
        // DONE: _(アンダースコア) はインスタンスの private フィールド名に使われます。
        // また、配列やリストの変数名は複数形を使います。
        // 例外はありますが、変数名が複数形だと配列だと判断します。
        string[] commandHistorys = commandHistory.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
        string[] resultHistorys = resultHistory.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

        // DONE: 早期リターンを使ってみましょう。
        if (commandHistorys.Length <= 0) { return; }
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
                var shift_jisEncoeding = System.Text.Encoding.GetEncoding("Shift_JIS");

                // TODO: Class c = new() の省略形よりも、var c = new Class() の方が取り回しがよいです。
                // コピペして別のものに変えて使おうと思った時、左端のクラス名を変えジャンプしてコンストラクタの内容を変えるより、
                // new 以降で変えたほうが移動が少なくて済みます。
                //      => 見つけ次第変更していきます。
                // 外部リリーそに using を使ったのはGOODです。
                // DONE: 少し長いのでsjis のエンコーディングは一度変数に入れたほうが見通しが良くなりそうです。
                using StreamWriter w = new(saveFileDialog.FileName, false, shift_jisEncoeding);

                try
                {
                    w.WriteLine(@"コマンド,結果");
                    // DONE: for より foreach を使ってみましょう。
                    //      => 星座で使う記号が化けてしまいます。どうしたらよいでしょうか？
                    foreach (var (command, result) in commandHistorys.Zip(resultHistorys))
                    {
                        w.WriteLine("{0},{1}", command, result);
                    }
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show($"書き込み中にエラーが発生しました\r\n{ex}");
                }
            }
        }
        catch (IOException ex)
        {
            // DONE: 今回の場合は Writer ですので、書き込みですね。
            _ = MessageBox.Show($"エラーが発生しました。指定されたファイルは書き込めませんでした。\r\n{ex}");
        }
        catch (Exception ex)
        {
            _ = MessageBox.Show($"不明なエラーが発生しました。\r\n{ex}");
        }
        finally
        {
            // DONE: ここだと、if で入らなかったときに Dispose() されないことになります。
            saveFileDialog.Dispose();
        }
    }
}

