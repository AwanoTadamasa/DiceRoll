using DiceRoll02.enums;
using DiceRoll02.helper;

namespace DiceRoll02;

public partial class Form1 : Form
{
    Form1ViewModel model = Form1ViewModel.GetInstance();
    private readonly static string ResentHistoryFolderPath = Application.StartupPath;
    private readonly static string ResentHistoryFileName = @"\ResentHistory.json";
    private readonly static string ResentHistoryFilePath = ResentHistoryFolderPath + ResentHistoryFileName;

    public Form1()
    {
        this.InitializeComponent();
        System.Diagnostics.Debug.WriteLine(ResentHistoryFilePath);
    }


    private void Form1_Load(object sender, EventArgs e)
    {
        this.diceTypeCoｍboBox.SelectedIndex = 0;
        this.HideHistory();
        this.HideDetail();

        if (HistoryToJsonIoHelper.IsThere(ResentHistoryFilePath))
        {
            var imput = HistoryToJsonIoHelper.ImportJson(ResentHistoryFilePath);
            if (imput != null)
            {
                var confilmation = MessageBox.Show("履歴を復元しますか？", "履歴の復元",
                                              MessageBoxButtons.YesNo);
                if (confilmation == DialogResult.Yes)
                {
                    model.ResultHistories = imput;
                }
            }
            HistoryToJsonIoHelper.DeleteFile(ResentHistoryFilePath);
        }

        this.UpdateDisplay();
    }


    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (model.ResultHistories.Count > 0)
        {
            HistoryToJsonIoHelper.ExportJson(model.ResultHistories, ResentHistoryFilePath);
        }

    }

    private void ResetHistory_Click(object sender, EventArgs e)
    {
        this.model.ResetHistory();
        this.UpdateDisplay();
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
        HistorySaveToCsvHelper.SaveAsWithShowDialog(this.model.ResultHistories.Select(x => x.Command).ToArray(),
                                                    this.model.ResultHistories.Select(x => x.Result).ToArray());
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
        model.SetFields(this.diceNumTextBox.Text,
                        this.diceTypeCoｍboBox.Text,
                        selectionDiceOption);

        model.DiceRoll();

        this.UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        this.rollCommandLabel.Text = this.model.RollCommand;
        this.rollResultLabel.Text = this.model.RollResult.Text;
        if (this.model.ResultHistories.Count > 0)
        {
            var tmp =
            this.historyCommandLabel.Text = this.model.ResultHistories
                                                      .Select(x => x.Command)
                                                      .Aggregate((x, y) => x + "\r\n" + y);
            this.historyResultLabel.Text = this.model.ResultHistories
                                                     .Select(x => x.Result)
                                                     .Aggregate((x, y) => x + "\r\n" + y);
            this.historySignLabel.Text = Enumerable.Repeat("=>\r\n", this.model.ResultHistories.Count)
                                                   .Aggregate((x, y) => x + y);
        }
        else
        {
            this.historyCommandLabel.Text = string.Empty;
            this.historySignLabel.Text = string.Empty;
            this.historyResultLabel.Text = string.Empty;
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