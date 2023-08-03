using DiceRoll02.enums;
using DiceRoll02.helper;

namespace DiceRoll02;

public partial class Form1 : Form
{
    Form1ViewModel model = Form1ViewModel.GetInstance();

    public Form1()
    {
        this.InitializeComponent();
    }


    private void Form1_Load(object sender, EventArgs e)
    {

        this.diceTypeCoÇçboBox.SelectedIndex = 0;
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
        if (SelectedDiceTypeHelper.IsCustomDice(this.diceTypeCoÇçboBox.Text))
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
        HistorySaveToCSVHelper.SaveAsWithShowDialog(this.historyCommandLabel.Text.Split("\r\n", StringSplitOptions.RemoveEmptyEntries),
                                              this.historyResultLabel.Text.Split("\r\n", StringSplitOptions.RemoveEmptyEntries));
    }

    private void RollDice_Click(object sender, EventArgs e)
    {
        // TODO: DiceTypeInfo ÇégÇ¡Çƒîªï Ç∑ÇÈÇÃÇÕÇ‡Ç§è≠ÇµçHïvÇ™Ç≈Ç´ÇªÇ§Ç≈Ç∑ÅB
        var selectionDiceOption = this.diceTypeGroup.Controls.OfType<RadioButton>().Single(rb => rb.Checked).Name switch
        {
            "normalDiceRadio" => DiceOptions.NormalDice,
            "upperDiceRadio" => DiceOptions.UpperDice,
            "lowerDiceRadio" => DiceOptions.LowerDice,
            _ => DiceOptions.ErrorDice
        };
        var dice = SelectedDiceTypeHelper.Dice(this.diceNumTextBox.Text, this.diceTypeCoÇçboBox.Text, selectionDiceOption);

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

    private void UpdateDisplay()
    {
        this.rollCommandLabel.Text = this.model.GetHistoryCommands().First();
        this.rollResultLabel.Text = this.model.GetHistoryResults().First();

        this.historyCommandLabel.Text = this.model.GetHistoryCommands()
                                                  .Select(x => x + "\r\n")
                                                  .ToString();
        this.historyResultLabel.Text = this.model.GetHistoryResults()
                                                 .Select(x => x + "\r\n")
                                                 .ToString();
        this.historySignLabel.Text = Enumerable.Repeat("=>\r\n", this.model.ResultHistory.Count)
                                               .ToString();
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