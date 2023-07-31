namespace DiceRoll02;

public partial class Form1 : Form
{
    #region Form stretch constant

    // TODO: Form は固定長にしないでデザインしてみましょう。
    // Formを固定長にすると環境によってズレます。ボタンが隠れたりすると詰みます。
    // なので、基本的にはサイズが変えられることを前提に設計します。
    private static readonly int FormHeightDifferenceHistory = 186;
    private static readonly int FormHeightShowHistoryMinimam = 384;
    private static readonly int FormHeightDifferenceDetail = 46;
    private static readonly int FormHeightFull = 512;
    private static readonly int FormHeightShort = 216;
    private static readonly Point ResultLabelCollectionLocationDetailHide = new(8, 121);
    private static readonly Point ResultLabelCollectionLocationDetailShow = new(8, 167);
    private static readonly Point HistoryDisplayCollectionLocationDetailHide = new(12, 147);
    private static readonly Point HistoryDisplayCollectionLocationDetailShow = new(12, 193);

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
        this.Height = FormHeightShort;
    }

    private void ResetHistory_Click(object sender, EventArgs e)
    {
        this.historyCommandLabel.Text = "";
        this.historySignLabel.Text = "";
        this.historyResultLabel.Text = "";
    }

    private void ToggleHistory_Click(object sender, EventArgs e)
    {
        if (this.historyDisplayCollection.Visible)
        {
            this.HideHistory();
        }
        else
        {
            this.ShowHistory();
            this.Height = Math.Max(this.Height, Form1.FormHeightFull);
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

    private void Form1_SizeChanged(object sender, EventArgs e)
    {
        if (this.historyDisplayCollection.Visible)
        {
            if (this.Height < Form1.FormHeightShowHistoryMinimam)
            {
                this.historyDisplayCollection.Visible = false;
            }
            else
            {
                this.HistoryDisplayCollectionStretch();
            }
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
        this.historyDisplayCollection.Visible = false;
    }

    private void ShowHistory()
    {
        this.historyDisplayCollection.Visible = true;
    }

    private void HideDetail()
    {
        this.Height -= Form1.FormHeightDifferenceDetail;
        this.resultLabelCollection.Location = Form1.ResultLabelCollectionLocationDetailHide;
        this.historyDisplayCollection.Location = Form1.HistoryDisplayCollectionLocationDetailHide;
        this.toggleHistoryButton.Location = Form1.HistoryDisplayCollectionLocationDetailHide;
        this.diceTypeGroup.Visible = false;
        this.normalDiceRadio.Checked = true;
    }

    private void ShowDetail()
    {
        this.Height += Form1.FormHeightDifferenceDetail;
        this.resultLabelCollection.Location = Form1.ResultLabelCollectionLocationDetailShow;
        this.historyDisplayCollection.Location = Form1.HistoryDisplayCollectionLocationDetailShow;
        this.toggleHistoryButton.Location = Form1.HistoryDisplayCollectionLocationDetailShow;
        this.diceTypeGroup.Visible = true;
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

    private void HistoryDisplayCollectionStretch()
    {
        int targetHeight = this.Height - Form1.FormHeightDifferenceHistory;
        targetHeight -= this.checkBox1.Checked ? Form1.FormHeightDifferenceDetail : 0;
        this.historyDisplayCollection.Height = targetHeight;
        this.historyDisplayCollection.Width = this.Width - 40;
        this.historyScrollBar.Height = targetHeight - 62;
        this.historyScrollBar.Width = this.Width - 40;
        this.tableLayoutPanel1.MinimumSize = new Size(this.historyScrollBar.Width, this.historyScrollBar.Height);
    }

    #endregion Form stretch method
}