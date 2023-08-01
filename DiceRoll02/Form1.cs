namespace DiceRoll02;

public partial class Form1 : Form
{
    // DONE: Form �͌Œ蒷�ɂ��Ȃ��Ńf�U�C�����Ă݂܂��傤�B
    // Form���Œ蒷�ɂ���Ɗ��ɂ���ăY���܂��B�{�^�����B�ꂽ�肷��Ƌl�݂܂��B
    // �Ȃ̂ŁA��{�I�ɂ̓T�C�Y���ς����邱�Ƃ�O��ɐ݌v���܂��B

    public Form1()
    {
        this.InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

        this.diceTypeCo��boBox.SelectedIndex = 0;
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
        if (this.historyDisplayCollection.Visible)
        {
            this.HideHistory();
        }
        else
        {
            this.ShowHistory();
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

    private void DiceType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (SelectedDiceType.IsCustomDice(this.diceTypeCo��boBox.Text))
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
        HistorySaveToCsv.SaveAsWithShowDialog(this.historyCommandLabel.Text.Split("\r\n", StringSplitOptions.RemoveEmptyEntries),
                                              this.historyResultLabel.Text.Split("\r\n", StringSplitOptions.RemoveEmptyEntries));
    }

    private void RollDice_Click(object sender, EventArgs e)
    {
        // TODO: DiceTypeInfo ���g���Ĕ��ʂ���̂͂��������H�v���ł������ł��B
        var dice = SelectedDiceType.Dice(this.diceNumTextBox.Text, this.diceTypeCo��boBox.Text, this.diceTypeGroup);

        if (dice.HasError())
        {
            MessageBox.Show(dice.GetErrorMessage());
        }
        else
        {
            this.rollCommandLabel.Text = dice.GetRollCommand();
            this.rollResultLabel.Text = dice.Roll().Text;

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
        this.diceTypeGroup.Visible = false;
        this.normalDiceRadio.Checked = true;
    }

    private void ShowDetail()
    {
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

    #endregion Form stretch method
}