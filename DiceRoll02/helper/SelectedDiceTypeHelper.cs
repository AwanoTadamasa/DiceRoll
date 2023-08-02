using DiceRoll02.Dices;
using DiceRoll02.enums;

namespace DiceRoll02.helper;

/// <summary>
/// 選択されているサイコロの種類からデータを返すクラス
/// </summary>
internal static class SelectedDiceTypeHelper
{
    /// <summary>
    /// 表から選択するサイコロか、合計を出すサイコロか
    /// </summary>
    /// <param name="selectionDiceType">選択されているサイコロの種類</param>
    /// <returns>表から選択するサイコロならtrue、合計を出すサイコロならfalse</returns>
    internal static bool IsCustomDice(string selectionDiceType)
    {

        return !(SelectedDiceTypeHelper.CustomDiceType(selectionDiceType) == TextDices.OtherDice);
    }

    /// <summary>
    /// 表から選択するサイコロの時、そのタイプを列挙型で返す
    /// </summary>
    /// <param name="selectionDiceType">選択されているサイコロの種類</param>
    /// <returns></returns>
    private static TextDices CustomDiceType(string selectionDiceType)
    {
        return TextDicesHelper.GetValueFromString(selectionDiceType);
    }

    /// <summary>
    /// サイコロを振ったデータを返す
    /// </summary>
    /// <param name="diceNum">サイコロの数</param>
    /// <param name="selectionDiceType">選択されているサイコロの種類</param>
    /// <param name="selectionDiceOption">選択されている詳細設定の値</param>
    /// <returns>サイコロを振ったデータ</returns>
    internal static IDice Dice(string diceNum, string selectionDiceType, DiceOptions selectionDiceOption)
    {
        if (IsCustomDice(selectionDiceType))
        {
            return TableChoosingDice(TextDicesHelper.GetValueFromString(selectionDiceType));
        }
        else
        {
            return RollingDice(diceNum, selectionDiceType, selectionDiceOption);
        }
    }
    /// <summary>
    /// RollingDiceを継承したIDiceを返す
    /// </summary>
    /// <param name="diceNum">サイコロの数</param>
    /// <param name="diceType">選択されているサイコロの種類</param>
    /// <param name="selectionDiceOption">選択されている詳細設定の値</param>
    /// <returns>サイコロを振ったデータ</returns>
    private static IDice RollingDice(string diceNum, string diceType, DiceOptions selectionDiceOption)
    {
        return selectionDiceOption switch
        {
            DiceOptions.NormalDice => new NormalBasicDice(diceNum, diceType),
            DiceOptions.UpperDice => new UpperBasicDice(diceNum, diceType),
            DiceOptions.LowerDice => new LowerBasicDice(diceNum, diceType),
            _ => new ErrorDice(),
        };
    }

    /// <summary>
    /// TableChoosingDiceを継承したIDiceを返す
    /// </summary>
    /// <param name="diceType">選択されているサイコロの種類</param>
    /// <returns>サイコロを振ったデータ</returns>
    private static IDice TableChoosingDice(TextDices diceType)
    {
        try
        {
            return diceType switch
            {
                TextDices.星座=> new ZodiacSignTextDice(),
                TextDices.おみくじ => new OmikujiTextDice(),
                _ => new ErrorDice()
            };
        }
        catch
        {
            return new ErrorDice();
        }
    }
}
