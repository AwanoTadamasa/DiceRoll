using System.IO;

namespace DiceRoll02
{
    internal class SaveHistoryAsCSV
    {
        private readonly string[] _commandHistory;
        private readonly string[] _resultHistory ;

        internal SaveHistoryAsCSV(string commandHistory, string resultHistory)
        {
            _commandHistory=(commandHistory.Split("\r\n", StringSplitOptions.RemoveEmptyEntries));
            _resultHistory=(resultHistory.Split("\r\n", StringSplitOptions.RemoveEmptyEntries));
        }
        
        public void SaveHistory()
        {
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
                    using StreamWriter w = new(saveFileDialog.FileName,false,System.Text.Encoding.GetEncoding("shift_jis"));
                    w.WriteLine(@"コマンド,結果");
                    for (int i = 0; i < _commandHistory.Length; i++)
                    {
                        w.WriteLine("{0},{1}", _commandHistory[i], _resultHistory[i]);
                    }
                }
            }
        }
    }
}
