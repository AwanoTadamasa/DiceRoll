namespace DiceRoll02;

public partial class Form1 : Form
{
    #region Form stretch constant

    // TODO: Form は固定長にしないでデザインしてみましょう。
    // Formを固定長にすると環境によってズレます。ボタンが隠れたりすると詰みます。
    // なので、基本的にはサイズが変えられることを前提に設計します。
    private static readonly int FormHeightFull = 512;
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
        // TODO: 各コントロールが何なのか名前から判別できるようにした方が読みやすいです。
        // saveHistory だけだと、保存された履歴の一覧と思うかもしれません。
        // でも動詞から始まってるので動きのある何か、ボタンかな？という推測はできます。
        // こういった推測は間違いの元ですし、確認の手間がありますので、明確な命名が大切です。
        // これは古いテクニックのひとつですが、btnSaveHistory とプレフィックスでコントロールを表すやり方があります。
        // ハンガリアン記法の一種なので、最近はあまり見ないかもしれまん。
        // 素直に書くなら saveHistoryButton となるでしょうか。
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
        if (SelectedDiceType.IsCustomDice(this.diceType.Text))
        {
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
        HistorySaveToCsv.SaveAs(this.historyCommand.Text, this.historyResult.Text);
    }

    private void RollDice_Click(object sender, EventArgs e)
    {
        // TODO: DiceTypeInfo を使って判別するのはもう少し工夫ができそうです。
        var dice = SelectedDiceType.Dice(this.diceNum.Text, this.diceType.Text, this.diceTypeGroup);

        if (dice.HasError())
        {
            MessageBox.Show(dice.GetErrorMessage());
        }
        else
        {
            this.rollCommand.Text = dice.GetRollCommand();
            this.rollResult.Text = dice.GetRollResult();

            this.historyCommand.Text += this.rollCommand.Text + "\r\n";
            this.historySign.Text += this.rollSign.Text + "\r\n";
            this.historyResult.Text += this.rollResult.Text + "\r\n";
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

    #endregion Form stretch method
}