﻿namespace DiceRoll02;

internal abstract class RollDice : IDice
{
    protected readonly int _diceNum;
    protected readonly int _diceSide;

    public RollDice(string diceNum, string diceType)
    {
        _diceNum = Int32.TryParse(diceNum, out var num) && num > 0 ? num : 0;
        _diceSide = diceType switch
        {
            "コイン" => 2,
            "4面体" => 4,
            "6面体" => 6,
            "8面体" => 8,
            "10面体" => 10,
            "12面体" => 12,
            "20面体" => 20,
            "100面体" => 100,
            _ => 0,
        };
    }

    public string GetDiceCommand()
    {
        if (this.HasError() is null)
        {
            return this.CreatDiceCommand;
        }
        else
        {
            return "ERROR";
        }
    }

    public string GetRollResult()
    {
        if (this.HasError() is null)
        {
            return this.CreatRollResult.ToString();
        }
        else
        {
            return "ERROR";
        }
    }

    public string? HasError()
    {
        if (this._diceNum == 0) { return "HaveNoDice"; }
        else if (this._diceSide <= 0) { return "HaveUnknownSide"; }
        else { return null; }
    }

    protected abstract string CreatDiceCommand { get; }

    protected abstract int CreatRollResult { get; }
}
