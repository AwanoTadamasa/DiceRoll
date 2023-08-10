
// TODO: 大文字小文字だけの変更だと、ファイル名が変更されなくて困りませんでした？
namespace DiceRollLib.Enums;

// TODO: DiceSelectKeys → DiceType
// enum で複数形の名前をつけるときは特別なときです。
// enum の命名について調べてみましょう。
public enum DiceSelectKeys
{
    ErrorDice = 0,
    NormalDice = 1,
    LowerDice = 2,
    UpperDice = 3,
    ZodiacSign = 4,
    Omikuji = 5,
}
