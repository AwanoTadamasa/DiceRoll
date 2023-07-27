using System.IO;

namespace DiceRoll02
{
    internal static class HistorySaver
    {
        // TODO: SaveAs は名前をつけて保存でよく使われる名前です。CSVはクラス名の方で判別できるようにした方がよいでしょう。
        internal static void SaveAsCSV(string commandHistory, string resultHistory)
        {
            // TODO: _(アンダースコア) はインスタンスの private フィールド名に使われます。
            // また、配列やリストの変数名は複数形を使います。
            // 例外はありますが、変数名が複数形だと配列だと判断します。
            string[] _commandHistory = commandHistory.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
            string[] _resultHistory = resultHistory.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

            // TODO: 早期リターンを使ってみましょう。
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
                        // TODO: Class c = new() の省略形よりも、var c = new Class() の方が取り回しがよいです。
                        // コピペして別のものに変えて使おうと思った時、左端のクラス名を変えジャンプしてコンストラクタの内容を変えるより、
                        // new 以降で変えたほうが移動が少なくて済みます。
                        // 外部リリーそに using を使ったのはGOODです。
                        // TODO: 少し長いのでsjis のエンコーディングは一度変数に入れたほうが見通しが良くなりそうです。
                        using StreamWriter w = new(saveFileDialog.FileName, false, System.Text.Encoding.GetEncoding("shift_jis"));
                        w.WriteLine(@"コマンド,結果");

                        // TODO: for より foreach を使ってみましょう。
                        for (int i = 0; i < _commandHistory.Length; i++)
                        {
                            w.WriteLine("{0},{1}", _commandHistory[i], _resultHistory[i]);
                        }
                    }
                    catch (IOException ex)
                    {
                        // TODO: 今回の場合は Writer ですので、書き込みですね。
                        _ = MessageBox.Show($"エラーが発生しました。指定されたファイルは読み込めませんでした。\r\n{ex}");
                    }
                    catch (Exception ex)
                    {
                        _ = MessageBox.Show($"不明なエラーが発生しました。\r\n{ex}");
                    }
                    finally
                    {
                        // TODO: ここだと、if で入らなかったときに Dispose() されないことになります。
                        saveFileDialog.Dispose();
                    }
                }
            }
        }
    }
}
