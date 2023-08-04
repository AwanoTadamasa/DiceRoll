using DiceRoll02.Dices;
using DiceRoll02.enums;
using DiceRoll02.helper;
using DiceRoll02.type;
using System.Reflection;

namespace DiceRoll02;

internal class Form1ViewModel
{
    private static Form1ViewModel _viewModel = new Form1ViewModel();
    private string _diceNum;
    private string _diceType;
    private DiceOptions _diceOption;
    private string _rollCommand;
    private RollResult _rollResult;
    private List<string[]> _resultHistories;

    public string DiceNum
    {
        get { return _diceNum; }
        set { this._diceNum = value; }
    }
    public string DiceType
    {
        get { return _diceType; }
        set { this._diceType = value; }
    }
    public DiceOptions DiceOption
    {
        get { return _diceOption; }
        set { this._diceOption = value; }
    }
    public string RollCommand
    {
        get { return _rollCommand; }
        set { this._rollCommand = value; }
    }
    public RollResult RollResult
    {
        get { return this._rollResult; }
        set { this._rollResult = value; }
    }
    public List<string[]> ResultHistories
    {
        get { return _resultHistories; }
        set { this._resultHistories = value; }
    }

    private Form1ViewModel()
    {
        this._diceNum = string.Empty;
        this._diceType = string.Empty;
        this._diceOption = DiceOptions.ErrorDice;
        this._rollCommand = string.Empty;
        this._rollResult = new RollResult(string.Empty, new List<int>());
        this._resultHistories = new List<string[]>();
    }

    public static Form1ViewModel GetInstance()
    {
        return _viewModel;
    }

    public void SetFields(string diceNum, string diceType, DiceOptions diceOption)
    {
        this.DiceNum = diceNum;
        this.DiceType = diceType;
        this.DiceOption = diceOption;
    }

    public void ResetHistory()
    {
        this.ResultHistories.Clear();
    }

    public void DiceRoll()
    {
        IDice dice = SelectedDiceTypeHelper.Dice(this.DiceNum, this.DiceType, this.DiceOption);
        if (dice.HasError())
        {
            MessageBox.Show(dice.GetErrorMessage());
        }
        else
        {
            this.RollCommand = dice.GetRollCommand();
            this.RollResult = dice.Roll();

            this.ResultHistories.Add(new string[] { this.RollCommand, this.RollResult.Text });
        }

    }
}
//internal static class Form1ViewModelExtentions{

//    public static Form1ViewModel DiceRoll(this Form1ViewModel model) 
//    {
//        IDice dice = SelectedDiceTypeHelper.Dice(model.DiceNum, model.DiceType, model.DiceOption);
//        model.RollCommand = dice.GetRollCommand();
//        model.RollResult = dice.Roll();

//        model.ResultHistories.Add(new string[2] { model.RollCommand, model.RollResult.Text });
//        return model;
//    }
//}
