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
        this.diceTypeCoｍboBox.SelectedIndex = 0;
        this.HideHistory();
        this.HideDetail();
    }

    private void ResetHistory_Click(object sender, EventArgs e)
    {
        this.historyCommandLabel.Text = "";
        this.historySignLabel.Text = "";
        this.historyResultLabel.Text = "";
    }

    private void ToggleHistory_Click(object sender, EventArgs e)
    {
        if (this.saveHistoryButton.Visible)
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
        if (SelectedDiceType.IsCustomDice(this.diceTypeCoｍboBox.Text))
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
        HistorySaveToCsv.SaveAs(this.historyCommandLabel.Text, this.historyResultLabel.Text);
    }

    private void RollDice_Click(object sender, EventArgs e)
    {
        // TODO: DiceTypeInfo を使って判別するのはもう少し工夫ができそうです。
        var dice = SelectedDiceType.Dice(this.diceNumTextBox.Text, this.diceTypeCoｍboBox.Text, this.diceTypeGroup);

        if (dice.HasError())
        {
            MessageBox.Show(dice.GetErrorMessage());
        }
        else
        {
            this.rollCommandLabel.Text = dice.GetRollCommand();
            this.rollResultLabel.Text = dice.GetRollResult();

            this.historyCommandLabel.Text += this.rollCommandLabel.Text + "\r\n";
            this.historySignLabel.Text += this.rollSignLabel.Text + "\r\n";
            this.historyResultLabel.Text += this.rollResultLabel.Text + "\r\n";
        }
    }

    #region Form stretch method

    private void HideHistory()
    {
        this.saveHistoryButton.Visible = false;

        this.Height = this.checkBox1.Checked ? Form1.FormHeightDetail : Form1.FormHeightShort;
    }

    private void ShowHistory()
    {
        this.saveHistoryButton.Visible = true;

        this.Height = Form1.FormHeightFull;
    }

    private void HideDetail()
    {
        this.historyScrollBar.Height = Form1.HistoryHeightLong;
        this.tableLayoutPanel1.MinimumSize = new Size(0, Form1.HistoryHeightLong);
        this.panel1.Location = Form1.PanelLocationDetailHide;
        this.panel1.Height = Form1.PanelHeightLong;
        this.diceTypeGroup.Visible = false;
        this.normalDiceRadio.Checked = true;
        this.Height = this.saveHistoryButton.Visible ? Form1.FormHeightFull : Form1.FormHeightShort;
    }

    private void ShowDetail()
    {
        this.historyScrollBar.Height = Form1.HistoryHeightShort;
        this.tableLayoutPanel1.MinimumSize = new Size(0, Form1.HistoryHeightShort);
        this.panel1.Location = Form1.PanelLocationDetailShow;
        this.panel1.Height = Form1.PanelHeightShort;
        this.diceTypeGroup.Visible = true;
        this.Height = this.saveHistoryButton.Visible ? Form1.FormHeightFull : Form1.FormHeightDetail;
    }

    private void EnableDiceCustomControll()
    {
        this.diceNumTextBox.Enabled = true;
        this.diceTypeGroup.Enabled = true;
    }

    private void DisableDiceCustomControll()
    {
        this.diceNumTextBox.Enabled = false;
        this.diceTypeGroup.Enabled = false;
        this.normalDiceRadio.Checked = true;
    }

    #endregion Form stretch method
}