namespace DiceRoll02;

internal class Form1ViewModel
{
    private static Form1ViewModel _viewModel = new Form1ViewModel();
    private string _diceNum;
    private string _diceType;
    private string _diceSeed;
    private List<string[]> _resultHistory;
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
    public string DiceSeed
    {
        get { return _diceSeed; }
        set { this._diceSeed = value; }
    }
    public List<string[]> ResultHistory
    {
        get { return _resultHistory; }
        set { this._resultHistory = value; }
    }

    private Form1ViewModel()
    {
        this._diceNum = string.Empty;
        this._diceType = string.Empty;
        this._diceSeed = string.Empty;
        this._resultHistory = new List<string[]>();
    }

    public static Form1ViewModel GetInstance()
    {
        return _viewModel;
    }

    public void SetFields(string diceNum, string diceType, string diceSeed)
    {
        this._diceNum = diceNum;
        this._diceType = diceType;
        this._diceSeed = diceSeed;
    }

    public List<string> GetHistoryCommands()
    {
        return _resultHistory.Select(x => x[1]).ToList();
    }

    public List<string> GetHistoryResults()
    {
        return _resultHistory.Select(x => x[0]).ToList();
    }

    public void ResetHistory()
    {
        this._resultHistory.Clear();
    }
}
