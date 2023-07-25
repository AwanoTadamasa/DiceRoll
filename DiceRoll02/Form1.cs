using System.Reflection.Metadata.Ecma335;

namespace DiceRoll02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // TODO: TODOコメントに対応した場合は DONE に変えてください。確認次第削除していきます。
            // TODO: インスタンスのメソッドやフィールドには this をつけましょう。
            // いくつか利点がありますが・・・
            // 引数とフィールドが同名の場合も区別できます。
            // 常にインスタンスであることを意識できます。
            // クラスメソッドと混ざると this が無いと区別できなくなります。
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiceType.SelectedIndex = 0;
            HideHistory();
            DetailHide();
        }

        private void ToggleHistory_Click(object sender, EventArgs e)
        {
            if (SaveHistory.Visible)
            {
                HideHistory();
            }
            else
            {
                ShowHistory();
            }
        }

        private void HideHistory()
        {
            SaveHistory.Visible = false;

            // TODO: 三項演算子を使ってみましょう。
            if (checkBox1.Checked)
            {
                this.Height = 262;
            }
            else
            {
                this.Height = 216;
            }
        }

        private void ShowHistory()
        {
            SaveHistory.Visible = true;

            // TODO: リテラル値は直接使わず、static readonly な変数に入れてください。
            // const との違いも調べてみましょう。
            this.Height = 512;
        }

        private void ResetHistory_Click(object sender, EventArgs e)
        {
            HistoryCommand.Text = "";
            HistorySign.Text = "";
            HistoryResult.Text = "";
        }

        private void SaveHistory_Click(object sender, EventArgs e)
        {
            // TODO: new だけしてメソッドを呼びたい場合は、インスタンスを宣言する必要のない、static なメソッドにできないか検討します。
            new SaveHistoryAsCSV(HistoryCommand.Text, HistoryResult.Text).SaveHistory();
        }

        private void RollDice_Click(object sender, EventArgs e)
        {
            // TODO: Dice → dice
            // TODO: this.DiceType と this.diceTypeGroup で命名のゆらぎがあります。パスカルケースか、キャメルケースか、どちらを使うのがよいでしょうか？
            // TODO: DiceTypeInfo を使って判別するのはもう少し工夫ができそうです。
            // IDice のインスタンスを使うやり方は工夫ができていてGOODです。
            IDice Dice = new DiceTypeInfo(this.DiceType.Text, this.diceTypeGroup).GetDiceType() switch
            {
                "constellation" => new ConstellationDiceRoll(),
                "omikuji" => new OmikujiRoll(),
                "normalDice" => new BasicDiceRoll(DiceNum.Text, DiceType.Text),
                "lowerDice" => new LowerDiceRoll(DiceNum.Text, DiceType.Text),
                "upperDice" => new UpperDiceRoll(DiceNum.Text, DiceType.Text),
                _ => new BasicDiceRoll("1", "0")
            };

            if (Dice.GetDiceCommand() == null)
            {
                _ = MessageBox.Show("不正な数字です。\r\n1以上の整数を入力してください。");
            }
            // TODO: この比較は条件が変わると修正の必要があります。有効か、そうでないかを判別するメソッドを用意するのがよいでしょう。
            else if (Dice.GetDiceCommand() == "1D0")
            {
                _ = MessageBox.Show("不明なエラーです。");
            }
            else
            {
                RollCommand.Text = Dice.GetDiceCommand();
                RollResult.Text = Dice.GetRollResult();

                HistoryCommand.Text += RollCommand.Text + "\r\n";
                HistorySign.Text += RollSign.Text + "\r\n";
                HistoryResult.Text += RollResult.Text + "\r\n";
            }
        }

        private void DiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: こういう使い方であれば、IsDiceCustomable() を static なメソッドにできないか検討します。
            // 判別するためだけにインスタンスを作る場合は、型が不定のときに動的に何かをする場合なので、あまり行いません。
            if (new DiceTypeInfo(this.DiceType.Text, this.diceTypeGroup).IsDiceCustomable())
            {
                EnableDiceCustomControll();
            }
            else
            {
                DisableDiceCustomControll();
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                DetailShow();
            }
            else
            {
                DetailHide();
            }
        }

        // TODO: メソッド名は動詞から始めます。
        private void DetailHide()
        {
            // TODO: 複数をコントロールの表示/非表示を切り替えたいときは、パネルを配置して、そのパネルごと操作すると楽です。
            HistoryScrollBar.Height = 264;
            HistoryScrollBar.Location = new Point(12, 177);
            tableLayoutPanel1.MinimumSize = new Size(0, 264);
            SaveHistory.Location = new Point(153, 148);
            ToggleHistory.Location = new Point(12, 148);
            RollCommand.Location = new Point(16, 122);
            RollSign.Location = new Point(104, 122);
            RollResult.Location = new Point(130, 122);
            diceTypeGroup.Visible = false;
            normalDice.Checked = true;
            if (!SaveHistory.Visible)
            {
                this.Height = 216;
            }
        }

        private void DetailShow()
        {
            HistoryScrollBar.Height = 218;
            HistoryScrollBar.Location = new Point(12, 223);
            tableLayoutPanel1.MinimumSize = new Size(0, 218);
            SaveHistory.Location = new Point(153, 194);
            ToggleHistory.Location = new Point(12, 194);
            RollCommand.Location = new Point(12, 168);
            RollSign.Location = new Point(104, 168);
            RollResult.Location = new Point(130, 168);
            diceTypeGroup.Visible = true;
            if (!SaveHistory.Visible)
            {
                this.Height = 262;
            }
        }

        private void EnableDiceCustomControll()
        {
            DiceNum.Enabled = true;
            diceTypeGroup.Enabled = true;
        }

        private void DisableDiceCustomControll()
        {
            DiceNum.Enabled = false;
            diceTypeGroup.Enabled = false;
            normalDice.Checked = true;
        }
    }
}