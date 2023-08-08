using DiceRoll02.enums;
using DiceRollLib.type;
using DiceRollLib.enums;
using DiceRollLib.util;

namespace DiceRoll02;

internal class Form1ViewModel
{
    private static readonly Form1ViewModel _viewModel = new();
    private string _diceNum;
    private string _diceType;
    private DiceOptions _diceOption;
    private RollResult _rollResult;
    private List<RollResult> _resultHistories;

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
    
    public RollResult RollResult
    {
        get { return this._rollResult; }
        set { this._rollResult = value; }
    }
    public List<RollResult> ResultHistories
    {
        get { return _resultHistories; }
        set { this._resultHistories = value; }
    }

    private Form1ViewModel()
    {
        this._diceNum = string.Empty;
        this._diceType = string.Empty;
        this._diceOption = DiceOptions.ErrorDice;
        this._rollResult = new RollResult(string.Empty, string.Empty, new List<int>());
        this._resultHistories = new List<RollResult>();
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
        DiceSelectKeys key = DiceSelectKeys.ErrorDice;
        if(this.DiceType == "黄道12星座")
        {
            key = DiceSelectKeys.ZodiacSign;
        }
        else if(this.DiceType == "おみくじ")
        {
            key = DiceSelectKeys.Omikuji;
        }else if (this.DiceOption == DiceOptions.NormalDice)
        {
            key = DiceSelectKeys.NormalDice;
        }
        else if(this.DiceOption == DiceOptions.LowerDice)
        {
            key= DiceSelectKeys.LowerDice;
        }
        else if (this.DiceOption == DiceOptions.UpperDice)
        {
            key = DiceSelectKeys.UpperDice;
        }
         
        var dice = DiceSelectConteiner.LoadDice(key, this.DiceNum, this.DiceType); 

        if (dice.HasError())
        {
            MessageBox.Show(dice.GetErrorMessage());
        }
        else
        {
            this.RollResult = dice.Roll();

            this.ResultHistories.Add(this.RollResult);
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
