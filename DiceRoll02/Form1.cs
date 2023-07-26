using System.Reflection.Metadata.Ecma335;

namespace DiceRoll02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // TODO(WIP): インスタンスのメソッドやフィールドには this をつけましょう。
            // いくつか利点がありますが・・・
            // 引数とフィールドが同名の場合も区別できます。
            // 常にインスタンスであることを意識できます。
            // クラスメソッドと混ざると this が無いと区別できなくなります。
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diceType.SelectedIndex = 0;
            HideHistory();
            HideDetail();
        }

        private void ResetHistory_Click(object sender, EventArgs e)
        {
            historyCommand.Text = "";
            historySign.Text = "";
            historyResult.Text = "";
        }

        private void SaveHistory_Click(object sender, EventArgs e)
        {
            HistorySaver.SaveAsCSV(historyCommand.Text, historyResult.Text);
        }

        private void RollDice_Click(object sender, EventArgs e)
        {
            // TODO: IDice Dice → dice
            // TODO: DiceTypeInfo を使って判別するのはもう少し工夫ができそうです。
            // IDice のインスタンスを使うやり方は工夫ができていてGOODです。
            IDice Dice = DiceTypeInfo.GetDiceType(diceType.Text, diceTypeGroup) switch
            {
                "constellation" => new ConstellationDiceRoll(),
                "omikuji" => new OmikujiRoll(),
                "normalDice" => new BasicDiceRoll(diceNum.Text, diceType.Text),
                "lowerDice" => new LowerDiceRoll(diceNum.Text, diceType.Text),
                "upperDice" => new UpperDiceRoll(diceNum.Text, diceType.Text),
                _ => new BasicDiceRoll("1", "0")
            };

            if (Dice.GetDiceCommand() == null)
            {
                _ = MessageBox.Show("不正な数字です。\r\n1以上の整数を入力してください。");
            }
            // TODO: この比較は条件が変わると修正の必要があります。有効か、そうでないかを判別するメソッドを用意するのがよいでしょう。
            //      => diceTypeが0の時nullを帰すように (WIP)IDiceに判定の追加
            else if (Dice.GetDiceCommand() == null)
            {
                _ = MessageBox.Show("不明なエラーです。");
            }
            else
            {
                rollCommand.Text = Dice.GetDiceCommand();
                rollResult.Text = Dice.GetRollResult();

                historyCommand.Text += rollCommand.Text + "\r\n";
                historySign.Text += rollSign.Text + "\r\n";
                historyResult.Text += rollResult.Text + "\r\n";
            }
        }

        private void ToggleHistory_Click(object sender, EventArgs e)
        {
            if (saveHistory.Visible)
            {
                HideHistory();
            }
            else
            {
                ShowHistory();
            }
        }

        private void DiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DiceTypeInfo.CanDiceCustom(diceType.Text))
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
                ShowDetail();
            }
            else
            {
                HideDetail();
            }
        }

        private static readonly int formHeightFull = 512;
        private static readonly int formHeightDeteil = 262;
        private static readonly int formHeightShort = 216;

        private void HideHistory()
        {
            saveHistory.Visible = false;

            this.Height = checkBox1.Checked ? formHeightDeteil : formHeightShort;
        }

        private void ShowHistory()
        {
            saveHistory.Visible = true;

            // TODO(WIP): リテラル値は直接使わず、static readonly な変数に入れてください。
            // const との違いも調べてみましょう。
            this.Height = formHeightFull;
        }

        private void HideDetail()
        {
            // TODO: 複数をコントロールの表示/非表示を切り替えたいときは、パネルを配置して、そのパネルごと操作すると楽です。
            historyScrollBar.Height = 264;
            historyScrollBar.Location = new Point(12, 177);
            tableLayoutPanel1.MinimumSize = new Size(0, 264);
            saveHistory.Location = new Point(153, 148);
            toggleHistory.Location = new Point(12, 148);
            rollCommand.Location = new Point(16, 122);
            rollSign.Location = new Point(104, 122);
            rollResult.Location = new Point(130, 122);
            diceTypeGroup.Visible = false;
            normalDice.Checked = true;
            if (!saveHistory.Visible)
            {
                this.Height = 216;
            }
        }

        private void ShowDetail()
        {
            historyScrollBar.Height = 218;
            historyScrollBar.Location = new Point(12, 223);
            tableLayoutPanel1.MinimumSize = new Size(0, 218);
            saveHistory.Location = new Point(153, 194);
            toggleHistory.Location = new Point(12, 194);
            rollCommand.Location = new Point(12, 168);
            rollSign.Location = new Point(104, 168);
            rollResult.Location = new Point(130, 168);
            diceTypeGroup.Visible = true;
            if (!saveHistory.Visible)
            {
                this.Height = 262;
            }
        }

        private void EnableDiceCustomControll()
        {
            diceNum.Enabled = true;
            diceTypeGroup.Enabled = true;
        }

        private void DisableDiceCustomControll()
        {
            diceNum.Enabled = false;
            diceTypeGroup.Enabled = false;
            normalDice.Checked = true;
        }
    }
}