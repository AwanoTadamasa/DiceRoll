using DiceRoll02.enums;
using DiceRoll02.helper;

namespace DiceRoll02;

public partial class Form1 : Form
{
    // DONE: Form は固定長にしないでデザインしてみましょう。
    // Formを固定長にすると環境によってズレます。ボタンが隠れたりすると詰みます。
    // なので、基本的にはサイズが変えられることを前提に設計します。

    public Form1()
    {
        this.InitializeComponent();
        //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("jp-JP");
        //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
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
        if (SelectedDiceTypeHelper.IsCustomDice(this.diceTypeCoｍboBox.Text))
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
        // TODO: DiceTypeInfo を使って判別するのはもう少し工夫ができそうです。
        var selectionDiceOption = this.diceTypeGroup.Controls.OfType<RadioButton>().Single(rb => rb.Checked).Name switch
        {
            "normalDiceRadio" => DiceOptions.NormalDice,
            "upperDiceRadio" => DiceOptions.UpperDice,
            "lowerDiceRadio" => DiceOptions.LowerDice,
            _ => DiceOptions.ErrorDice
        };
        var dice = SelectedDiceTypeHelper.Dice(this.diceNumTextBox.Text, this.diceTypeCoｍboBox.Text, selectionDiceOption);

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