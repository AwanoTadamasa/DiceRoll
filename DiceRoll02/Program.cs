namespace DiceRoll02
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    // TODO: 別ファイルにしましょう。
    // 継承したクラスも別々のファイルにしましょう。
    interface IDice
    {
        string GetDiceCommand();
        string GetRollResult();
    }

    class RollBasicDice : IDice
    {
        // TODO: 命名規則はこのあたりが参考になるでしょう。
        // https://learn.microsoft.com/ja-jp/dotnet/standard/design-guidelines/naming-guidelines
        // privateなフィールド変数は、いくつかの流派があるのですが、小文字から始めるか、さらに _(アンダースコア) をつけてください。
        // ここではアンダースコアを推しておきます。
        private string DiceNum;
        private string DiceType;

        public RollBasicDice(string num, string type)
        {
            // TODO: 変数やメソッドには this をつけてインスタンスのものであるという意識を関連付けましょう。
            DiceNum = num;
            DiceType = type;
        }

        public string GetDiceCommand()
        {
            // TODO: 毎回変換するより、コンストラクタでもらったときに数値にしておくとよいでしょう。
            int DNum = StoI(DiceNum);
            if (DNum == 0)
            {
                // TODO: null を返す場合は Nullable にする必要があります。
                // なお、C# 8 以降では、デフォルトでnullが無効になっています。
                // これは null チェックの負担を減らすための処置です。
                return null;
            }
            else
            {
                // TODO: String.Format() について調べてみましょう。
                // TODO: さらに $"{value}" という記法について調べてみましょう。
                return DNum.ToString() + "D" + DSide(DiceType).ToString();
            }
        }

        public string GetRollResult()
        {
            int DNum = StoI(DiceNum);
            int Result = 0;
            if(DNum != 0)
            {
                for (int i = 0; i < DNum; i++)
                {
                    // TODO: ループの外で宣言した方がよいでしょう。
                    // TODO: seed について調べてみましょう。
                    Random r = new();
                    // TODO: max もループの外で一度だけ宣言した方がよいでしょう。
                    Result += r.Next(DSide(DiceType)) + 1;
                }
            }
            // TODO: {} 中括弧は省略しないようにしましょう。
            else Result = 0;

            return Result.ToString();
        }

        // TODO: StringToInteger の処理ですね。省略せずに記述しましょう。
        static int StoI(string s)
        {
            // DONE: int は C# の型名です。これはCLRのクラス名のエイリアスになっているので、同様に使えます。
            // しかし、クラスのメソッドを使う場合は、CLRのクラス名を使った方が文脈的に正しいです。
            // 細かいことですが、クラスやインスタンスを常に意識できるといいですね。
            // Parse ではなく TryParse を使っているところはGOODです。
            // ちょっと古いですが、下記の記事が参考になります。
            // https://dobon.net/vb/dotnet/beginner/intvsint32.html
            return Int32.TryParse(s, out var i) && i > 0 ? i : 0;
        }

        // TODO: メソッド名は基本的には動詞から始めます。
        // インスタンス(主語) + メソッド(動詞) で英文として読めるのが理想です。
        static int DSide(string s)
        {
            // TODO: デフォルトで2面を返すのは問題でしょう。D120が指定されて、D2になったらバグの元です。
            // switch 式を使ってみたのはGOODです。短く記述できて読みやすいです。
            int i = s switch
            {
                "4面体" => 4,
                "6面体" => 6,
                "8面体" => 8,
                "10面体" => 10,
                "12面体" => 12,
                "20面体" => 20,
                "100面体" => 100,
                _ => 2,
            };
            return i;
        }
    }

    class ConstellationDice : IDice
    {
        public string GetDiceCommand()
        {
            return "STARS";
        }

        public string GetRollResult()
        {
            Random r = new();
            // TODO: 11 のリテラルは変数にしましょう。
            // UTFで星座を扱ってみたのはGOODです。
            string Result = r.Next(11) switch
            {
                0 => "\u2648(牡羊座)",
                1 => "\u2649(牡牛座)",
                2 => "\u264a(双子座)",
                3 => "\u264b(蟹座)",
                4 => "\u264c(獅子座)",
                5 => "\u264d(乙女座)",
                6 => "\u264e(天秤座)",
                7 => "\u264f(蠍座)",
                8 => "\u2650(射手座)",
                9 => "\u2651(山羊座)",
                10 => "\u2652(水瓶座)",
                11 => "\u2653(魚座)",
                _ => "エラーです",
            };
            return Result;
        }

    }
}