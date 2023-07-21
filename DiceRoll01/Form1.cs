namespace DiceRoll01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Rollする
        private void RollDices_Click(object sender, EventArgs e)
        {
            int DiceNum = 0;
            int DiceSide = 0;
            string Option = "";
            if (int.TryParse(textBox1.Text, out DiceNum) && DiceNum > 0)
            {
                switch (comboBox1.Text)
                {
                    case "4面体": DiceSide = 4; break;
                    case "6面体": DiceSide = 6; break;
                    case "8面体": DiceSide = 8; break;
                    case "10面体": DiceSide = 10; break;
                    case "12面体": DiceSide = 12; break;
                    case "20面体": DiceSide = 20; break;
                    case "100面体": DiceSide = 100; break;
                    default: DiceSide = 2; break;
                }

                RollDice dice1 = new RollDice(DiceNum, DiceSide, Option);
                IDice dice = dice1;

                DiceCommand.Text = dice.GetDiceCommand();
                Result.Text = dice.GetResult().ToString();


            }
            else
            {
                MessageBox.Show("個数は正の整数を入力してください");
            }
        }

        //履歴の表示切替
        bool VisibleHistory = false;
        private void History_Click(object sender, EventArgs e)
        {

            if (VisibleHistory)
            {
                this.Height = 216;
                SaveHistory.Visible = false;
                VisibleHistory = false;
            }
            else
            {
                this.Height = 512;
                SaveHistory.Visible = true;
                VisibleHistory = true;
            }
        }

        //フォームの初期設定
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            DiceCommand.Text = " D ";
            Result.Text = "";
        }
    }
}