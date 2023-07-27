namespace DiceRoll02;

public partial class Form1 : Form
{
    #region Form stretch constant

    private static readonly int FormHeightFull = 512;
    // DONE: タイポ
    private static readonly int FormHeightDetail = 262;
    private static readonly int FormHeightShort = 216;
    private static readonly int HistoryHeightLong = 264;
    private static readonly int HistoryHeightShort = 218;
    private static readonly int PanelHeightLong = 320;
    private static readonly int PanelHeightShort = 274;
    private static readonly Point PanelLocationDetailHide = new(8, 121);
    private static readonly Point PanelLocationDetailShow = new(8, 167);

    #endregion Form stretch constant

    public Form1()
    {
        this.InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        this.diceType.SelectedIndex = 0;
        // DONE: this
        this.HideHistory();
        this.HideDetail();
    }

    private void ResetHistory_Click(object sender, EventArgs e)
    {
        this.historyCommand.Text = "";
        this.historySign.Text = "";
        this.historyResult.Text = "";
    }

    private void ToggleHistory_Click(object sender, EventArgs e)
    {
        if (this.saveHistory.Visible)
        {
            this.HideHistory();
        }
        else
        {
            this.ShowHistory();
        }
    }

    private void DiceType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DiceTypeInfo.IsCustomDice(this.diceType.Text))
        {
            // DONE: this
            this.DisableDiceCustomControll();
        }
        else
        {
            this.EnableDiceCustomControll();
        }
    }

    private void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (this.checkBox1.Checked)
        {
            this.ShowDetail();
        }
        else
        {
            this.HideDetail();
        }
    }
    private void SaveHistory_Click(object sender, EventArgs e)
    {
        HistorySaveToCSV.SaveAs(this.historyCommand.Text, this.historyResult.Text);
    }

    private void RollDice_Click(object sender, EventArgs e)
    {
        // TODO: DiceTypeInfo を使って判別するのはもう少し工夫ができそうです。
        IDice dice = DiceTypeInfo.GetDiceType(this.diceType.Text, this.diceTypeGroup) switch
        {
            "constellation" => new ZodiacSignTableChooseDice(),
            "omikuji" => new OmikujiTableChooseDice(),
            "normalDice" => new BasicRollDice(this.diceNum.Text, this.diceType.Text),
            "lowerDice" => new LowerRollDice(this.diceNum.Text, this.diceType.Text),
            "upperDice" => new UpperRollDice(this.diceNum.Text, this.diceType.Text),
            _ => new ErrorDice()
        };

        switch (dice.CommandError)
        {
            case null:
                this.rollCommand.Text = dice.GetRollCommand();
                this.rollResult.Text = dice.GetRollResult();

                this.historyCommand.Text += this.rollCommand.Text + "\r\n";
                this.historySign.Text += this.rollSign.Text + "\r\n";
                this.historyResult.Text += this.rollResult.Text + "\r\n";
                break;
            case "HaveNoDice":
                _ = MessageBox.Show("不正な数字です。\r\n1以上の整数を入力してください。");
                break;
            case "HaveUnknownSide":
                _ = MessageBox.Show("不明なサイコロです。");
                break;
            case "HaveUnknownType":
                _ = MessageBox.Show("不明な振り方です。");
                break;
            default:
                _ = MessageBox.Show("不明なエラーです。");
                break;
        }
    }

    #region Form stretch method

    private void HideHistory()
    {
        this.saveHistory.Visible = false;

        this.Height = this.checkBox1.Checked ? Form1.FormHeightDetail : Form1.FormHeightShort;
    }

    private void ShowHistory()
    {
        this.saveHistory.Visible = true;

        this.Height = Form1.FormHeightFull;
    }

    private void HideDetail()
    {
        this.historyScrollBar.Height = Form1.HistoryHeightLong;
        this.tableLayoutPanel1.MinimumSize = new Size(0, Form1.HistoryHeightLong);
        this.panel1.Location = Form1.PanelLocationDetailHide;
        this.panel1.Height = Form1.PanelHeightLong;
        this.diceTypeGroup.Visible = false;
        this.normalDice.Checked = true;
        this.Height = this.saveHistory.Visible ? Form1.FormHeightFull : Form1.FormHeightShort;
    }

    private void ShowDetail()
    {
        this.historyScrollBar.Height = Form1.HistoryHeightShort;
        this.tableLayoutPanel1.MinimumSize = new Size(0, Form1.HistoryHeightShort);
        this.panel1.Location = Form1.PanelLocationDetailShow;
        this.panel1.Height = Form1.PanelHeightShort;
        this.diceTypeGroup.Visible = true;
        this.Height = this.saveHistory.Visible ? Form1.FormHeightFull : Form1.FormHeightDetail;
    }

    private void EnableDiceCustomControll()
    {
        this.diceNum.Enabled = true;
        this.diceTypeGroup.Enabled = true;
    }

    private void DisableDiceCustomControll()
    {
        this.diceNum.Enabled = false;
        this.diceTypeGroup.Enabled = false;
        this.normalDice.Checked = true;
    }

    // DONE: region は長くなることが多いので、ペアがわかるように、開始時と同じメッセージを書いておくとよいです。
    #endregion Form stretch method
}