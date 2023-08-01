namespace DiceRoll02;

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
    internal static IDice Dice(string diceNum, string selectionDiceType, string selectionDiceOption)
    {
        if (SelectedDiceTypeHelper.IsCustomDice(selectionDiceType))
        {
            return SelectedDiceTypeHelper.TableChoosingDice(selectionDiceType);
        }
        else
        {
            return SelectedDiceTypeHelper.RollingDice(diceNum, selectionDiceType, selectionDiceOption);
        }
    }
    /// <summary>
    /// RollingDiceを継承したIDiceを返す
    /// </summary>
    /// <param name="diceNum">サイコロの数</param>
    /// <param name="diceType">選択されているサイコロの種類</param>
    /// <param name="radioButtonGroup">詳細設定のラジオボタングループ</param>
    /// <returns>サイコロを振ったデータ</returns>
    private static IDice RollingDice(string diceNum, string diceType, string selectionDiceOption)
    {
        try
        {
            return selectionDiceOption switch
            {
                "NormalDice" => new NormalBasicDice(diceNum, diceType),
                "LowerDice" => new LowerBasicDice(diceNum, diceType),
                "UpperDice" => new UpperBasicDice(diceNum, diceType),
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
                "星座" => new ZodiacSignTextDice(),
                "おみくじ" => new OmikujiTextDice(),
                _ => new ErrorDice()
            };
        }
        catch
        {
            return new ErrorDice();
        }
    }
}
