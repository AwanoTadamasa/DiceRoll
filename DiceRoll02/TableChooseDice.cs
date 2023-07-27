namespace DiceRoll02;

internal abstract class TableChooseDice : IDice
{
    public string GetRollCommand()
    {
        if (this.CommandError is null)
        {
            return this.DiceRollCommand;
        }
        else
        {
            return "ERROR";
        }
    }

    public string GetRollResult()
    {
        if (this.CommandError is null)
        {
            var r = new Random();
            return this.DiceChooseTable[r.Next(this.DiceChooseTable.Length)];
        }
        else
        {
            return "ERROR";
        }
    }

    public string? CommandError
    {
        get
        {
            {
                if (this.DiceChooseTable.Length == 0)
                {
                    return "HaveNoTableContent";
                }
                else
                {
                    return null;
                }
            }
        }
    }

    abstract protected string DiceRollCommand { get; }
    abstract protected string[] DiceChooseTable { get; }
}
