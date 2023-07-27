namespace DiceRoll02;

public partial class Form1 : Form
{
    #region Form stretch constant

    private static readonly int FormHeightFull = 512;
    private static readonly int FormHeightDeteil = 262;
    private static readonly int FormHeightShort = 216;
    private static readonly int HistoryHeightLong = 264;
    private static readonly int HistoryHeightShort = 218;
    private static readonly int PanelHeightLong = 320;
    private static readonly int PanelHeightShort = 274;
    private static readonly Point PanelLocationDetailHide = new(8, 121);
    private static readonly Point PanelLocationDetailShow = new(8, 167);

    #endregion

    public Form1()
    {
        // DONE(WIP): インスタンスのメソッドやフィールドには this をつけましょう。
        // いくつか利点がありますが・・・
        // 引数とフィールドが同名の場合も区別できます。
        // 常にインスタンスであることを意識できます。
        // クラスメソッドと混ざると this が無いと区別できなくなります。
        //      => およそ付けたと思います。
        this.InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        this.diceType.SelectedIndex = 0;
        HideHistory();
        HideDetail();
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
            HideHistory();
        }
        else
        {
            ShowHistory();
        }
    }

    private void DiceType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DiceTypeInfo.IsCustomDice(this.diceType.Text))
        {
            DisableDiceCustomControll();
        }
        else
        {
            EnableDiceCustomControll();
        }
    }

    private void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (this.checkBox1.Checked)
        {
            ShowDetail();
        }
        else
        {
            HideDetail();
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
            "constellation" => new ConstellationDiceRoll(),
            "omikuji" => new OmikujiRoll(),
            "normalDice" => new BasicRollDice(this.diceNum.Text, this.diceType.Text),
            "lowerDice" => new LowerDiceRoll(this.diceNum.Text, this.diceType.Text),
            "upperDice" => new UpperDiceRoll(this.diceNum.Text, this.diceType.Text),
            _ => new ErrorDiceRoll()
        };

        switch (dice.HasError())
        {
            case null:
                this.rollCommand.Text = dice.GetDiceCommand();
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

    // DONE: staticな宣言は、クラスの先頭に持ってくるとよいでしょう。
    // クラス内に region で折り畳める領域を作ると見通しが良くなります。
    // 一例ですが、static なフィールド、static なメソッド、通常のフィールド、コンストラクタ、イベントメソッド、それ以外のメソッド、というような並びが考えられます。
    // 上記のような意味単位ではなく、機能単位に並べることもあります。
    // DONE: static readonly の場合はパスカルケースとなります。
    #region Form stretch method
    private void HideHistory()
    {
        this.saveHistory.Visible = false;

        this.Height = this.checkBox1.Checked ? Form1.FormHeightDeteil : Form1.FormHeightShort;
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
        this.Height = this.saveHistory.Visible ? Form1.FormHeightDeteil : Form1.FormHeightShort;
    }

    private void ShowDetail()
    {
        this.historyScrollBar.Height = Form1.HistoryHeightShort;
        this.tableLayoutPanel1.MinimumSize = new Size(0, Form1.HistoryHeightShort);
        this.panel1.Location = Form1.PanelLocationDetailShow;
        this.panel1.Height = Form1.PanelHeightShort;
        this.diceTypeGroup.Visible = true;
        this.Height = this.saveHistory.Visible ? Form1.FormHeightDeteil : Form1.FormHeightShort;
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
    #endregion
}