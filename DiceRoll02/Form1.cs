using DiceRoll02.enums;
using DiceRoll02.helper;
using DiceRollLib.Types;

namespace DiceRoll02;

public partial class Form1 : Form
{
    private readonly Form1ViewModel _model = Form1ViewModel.GetInstance();
    private static readonly string ResentFolderPath = Application.StartupPath;
    private static readonly string ResentHistoryFileName = @"\ResentHistory.json";
    private static readonly string ResentHistoryFilePath = ResentFolderPath + ResentHistoryFileName;

    public Form1()
    {
        this.InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        this.diceTypeCoÇçboBox.SelectedIndex = 0;
        this.HideHistory();
        this.HideDetail();

        if (HistoryToJsonIoHelper.IsThere(ResentHistoryFilePath))
        {
            var input = HistoryToJsonIoHelper.ImportJson<List<RollResult>>(ResentHistoryFilePath);
            if (input != null)
            {
                var confirmation = MessageBox.Show("óöóÇïúå≥ÇµÇ‹Ç∑Ç©ÅH", "óöóÇÃïúå≥",
                                              MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    _model.ResultHistories = input;
                }
            }
            HistoryToJsonIoHelper.DeleteFile(ResentHistoryFilePath);
        }

        this.UpdateDisplay();
    }


    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (_model.ResultHistories.Count > 0)
        {
            HistoryToJsonIoHelper.ExportJson(_model.ResultHistories, ResentHistoryFilePath);
        }

    }

    private void ResetHistory_Click(object sender, EventArgs e)
    {
        this._model.ResetHistory();
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
        _model.DiceType = this.diceTypeCoÇçboBox.Text;
        if (_model.IsCustomDice())
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
        HistorySaveToCsvHelper.SaveAsWithShowDialog(
            this._model.ResultHistories.Select(x => x.Command).ToArray(),
            this._model.ResultHistories.Select(x => x.Result).ToArray());
    }

    private void RollDice_Click(object sender, EventArgs e)
    {
        var selectionDiceOption = this.diceTypeGroup.Controls.OfType<RadioButton>().Single(rb => rb.Checked).Name switch
        {
            "normalDiceRadio" => DiceOptions.NormalDice,
            "upperDiceRadio" => DiceOptions.UpperDice,
            "lowerDiceRadio" => DiceOptions.LowerDice,
            _ => DiceOptions.ErrorDice
        };
        _model.SetFields(
            this.diceNumTextBox.Text,
            this.diceTypeCoÇçboBox.Text,
            selectionDiceOption);

        _model.RollDice();

        this.UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        this.rollCommandLabel.Text = this._model.RollResult.Command;
        this.rollResultLabel.Text = this._model.RollResult.Result;
        if (this._model.ResultHistories.Count > 0)
        {
            this.historyCommandLabel.Text = this._model.ResultHistories
                .Select(x => x.Command)
                .Aggregate((x, y) => x + "\r\n" + y);
            this.historyResultLabel.Text = this._model.ResultHistories
                .Select(x => x.Result)
                .Aggregate((x, y) => x + "\r\n" + y);
            this.historySignLabel.Text =
                Enumerable.Repeat("=>\r\n", this._model.ResultHistories.Count)
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