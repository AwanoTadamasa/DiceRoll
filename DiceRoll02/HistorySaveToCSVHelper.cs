namespace DiceRoll02;


// TODO: こういうクラスは、命名が難しいのですが、Historyを助けるための
// ユーティリティクラス(便利クラス)という意味でHistoryHelperと呼ばれることが多いです。
// ユーティリティクラスの特徴として、staticなメソッドしか持たないというものがあります。
internal static class HistorySaveToCSVHelper
{

    internal static void SaveAsWithShowDialog(string[] commandHistory, string[] resultHistory)
    {

        // DONE: 保存先を選択する処理は、このメソッドの外に持っていきましょう。
        // そうすると、SaveAsというメソッドはSaveというメソッド名に変えて、よりシンプルな感じになります。
        // さらにその上で、SaveAsというメソッドを作ってみましょう。
        // ただ、ユーティリティクラスとして見た場合は、Windowが表示されて処理が止まったりするのは避けたいので、
        // パスはあらかじめ外部で選んでおくのが通例です。
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

    // DONE: 補足です。通常の保存は Save ですが、例えば、エクセルからCSVに変換する場合は、Export という単語が使われます。
    // Export は変換して出力する意味を持ちます。対義語の Import は取り込んで変換するというニュアンスがあります。
    // 変換を挟まない場合は Output/Input という単語がよく使われます。
    // 今回は元となるデータがなくて初めて保存する形式がたまたまCSVというだけなので、Saveでも違和感はありません。
    internal static void SaveAs(string[] commandHistories, string[] resultHistories, string fileName)
    {
        if (commandHistories.Length <= 0)
        {
            return;
        }

        try
        {
            // DONE: デフォルトのエンコーディングについて調べてみましょう。
            var uniEncoding = System.Text.Encoding.GetEncoding("UTF-8");
            // DONE: Class c = new() の省略形よりも、var c = new Class() の方が取り回しがよいです。
            // コピペして別のものに変えて使おうと思った時、左端のクラス名を変えジャンプしてコンストラクタの内容を変えるより、
            // new 以降で変えたほうが移動が少なくて済みます。
            //      => 見つけ次第変更していきます。
            using var w = new StreamWriter(fileName, false, uniEncoding);

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

