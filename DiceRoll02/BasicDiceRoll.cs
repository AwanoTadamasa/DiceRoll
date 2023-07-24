namespace DiceRoll02
{
    // TODO: 別ファイルにしましょう。
    // 継承したクラスも別々のファイルにしましょう。
    class BasicDiceRoll : IDice
    {
        // TODO: 命名規則はこのあたりが参考になるでしょう。
        // https://learn.microsoft.com/ja-jp/dotnet/standard/design-guidelines/naming-guidelines
        // privateなフィールド変数は、いくつかの流派があるのですが、小文字から始めるか、さらに _(アンダースコア) をつけてください。
        // ここではアンダースコアを推しておきます。
        private int _diceNumber;
        private int _diceSide;

        public BasicDiceRoll(string diceNum, string diceType)
        {
            // TODO: 変数やメソッドには this をつけてインスタンスのものであるという意識を関連付けましょう。
            // TODO: 毎回変換するより、コンストラクタでもらったときに数値にしておくとよいでしょう。
            this._diceNumber = StringToInt(diceNum);
            this._diceSide = DiceTypeToSide(diceType);
        }

        public string? GetDiceCommand()
        {
            if (this._diceNumber != 0)
            {
                // TODO: String.Format() について調べてみましょう。
                // TODO: さらに $"{value}" という記法について調べてみましょう。
                return $"{this._diceNumber}D{this._diceSide}";
            }
            else 
            {
                // TODO: null を返す場合は Nullable にする必要があります。
                // なお、C# 8 以降では、デフォルトでnullが無効になっています。
                // これは null チェックの負担を減らすための処置です。
                return null; 
            }
        }

        public string GetRollResult()
        {
            int result = 0;
            // TODO: ループの外で宣言した方がよいでしょう。
            // TODO: seed について調べてみましょう。
            // TODO: max もループの外で一度だけ宣言した方がよいでしょう。
            Random r = new();
            if (this._diceNumber != 0 )
            {
                for (int i = 0; i < this._diceNumber; i++)
                {
                    result += r.Next(this._diceSide)+1;
                }
            }
            // TODO: {} 中括弧は省略しないようにしましょう。
            return result.ToString();
        }

        // TODO: StringToInteger の処理ですね。省略せずに記述しましょう。
        private int StringToInt(string str)
        {            
            // DONE: int は C# の型名です。これはCLRのクラス名のエイリアスになっているので、同様に使えます。
            // しかし、クラスのメソッドを使う場合は、CLRのクラス名を使った方が文脈的に正しいです。
            // 細かいことですが、クラスやインスタンスを常に意識できるといいですね。
            // Parse ではなく TryParse を使っているところはGOODです。
            // ちょっと古いですが、下記の記事が参考になります。
            // https://dobon.net/vb/dotnet/beginner/intvsint32.html
            return Int32.TryParse(str, out int num) && num > 0 ? num : 0;
        }

        // TODO: メソッド名は基本的には動詞から始めます。
        // インスタンス(主語) + メソッド(動詞) で英文として読めるのが理想です。
        private int DiceTypeToSide(string str) 
        {
            return str switch
            {
                // TODO: デフォルトで2面を返すのは問題でしょう。D120が指定されて、D2になったらバグの元です。
                // switch 式を使ってみたのはGOODです。短く記述できて読みやすいです。
                "コイン" => 2,
                "4面体" => 4,
                "8面体" => 8,
                "10面体" => 10,
                "12面体" => 12,
                "20面体" => 20,
                "100面体" => 100,
                _ => 0,
            };
        }
    }
}