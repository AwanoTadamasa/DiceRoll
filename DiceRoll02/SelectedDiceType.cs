using Accessibility;

namespace DiceRoll02;

/// <summary>
/// 選択されているサイコロの種類からデータを返すクラス
/// </summary>
internal static class SelectedDiceType
{
    /// <summary>
    /// 表から選択するサイコロか、合計を出すサイコロか
    /// </summary>
    /// <param name="selectionDiceType">選択されているサイコロの種類</param>
    /// <returns>表から選択するサイコロならtrue、合計を出すサイコロならfalse</returns>
    internal static bool IsCustomDice(string selectionDiceType)
    {
        return selectionDiceType switch
        {
            "星座" or "おみくじ" => true,
            _ => false
        };
    }

    /// <summary>
    /// サイコロを振ったデータを返す
    /// </summary>
    /// <param name="diceNum">サイコロの数</param>
    /// <param name="selectionDiceType">選択されているサイコロの種類</param>
    /// <param name="radioButtonGroup">詳細設定のラジオボタングループ</param>
    /// <returns>サイコロを振ったデータ</returns>
    internal static IDice Dice(string diceNum, string selectionDiceType, GroupBox radioButtonGroup)
    {
        if (SelectedDiceType.IsCustomDice(selectionDiceType))
        {
            return SelectedDiceType.TableChoosingDice(selectionDiceType);
        }
        else
        {
            return SelectedDiceType.RollingDice(diceNum, selectionDiceType, radioButtonGroup);
        }
    }
    /// <summary>
    /// RollingDiceを継承したIDiceを返す
    /// </summary>
    /// <param name="diceNum">サイコロの数</param>
    /// <param name="diceType">選択されているサイコロの種類</param>
    /// <param name="radioButtonGroup">詳細設定のラジオボタングループ</param>
    /// <returns>サイコロを振ったデータ</returns>
    private static IDice RollingDice(string diceNum, string diceType, GroupBox radioButtonGroup)
    {
        try
        {
            var selectionRadioButton = radioButtonGroup.Controls.OfType<RadioButton>().Single(rb => rb.Checked);
            return selectionRadioButton.Name switch
            {
                "normalDice" => new BasicDiceRoll(diceNum, diceType),
                "lowerDice" => new LowerDiceRoll(diceNum, diceType),
                "upperDice" => new UpperDiceRoll(diceNum, diceType),
                _ => new ErrorDice(),
            };
        }
        catch
        {
            return new ErrorDice();
        }
    }

    /// <summary>
    /// TableChoosingDiceを継承したIDiceを返す
    /// </summary>
    /// <param name="diceType">選択されているサイコロの種類</param>
    /// <returns>サイコロを振ったデータ</returns>
    private static IDice TableChoosingDice(string diceType)
    {
        try
        {
            return diceType switch
            {
                "星座" => new ZodiacSignTableChoose(),
                "おみくじ" => new OmikujiTableChoose(),
                _ => new ErrorDice()
            };
        }
        catch
        {
            return new ErrorDice();
        }
    }
}
