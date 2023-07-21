namespace DiceRoll01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RollDices_Click(object sender, EventArgs e)
        {
            int DiceNum = 0;
            int DiceSide = 0;
            string Option = "";
            if (int.TryParse(textBox1.Text, out DiceNum))
            {
                switch (comboBox1.Text)
                {
                    case "4面体": DiceSide = 4; break;
                    case "6面体": DiceSide = 6; break;
                    case "8面体": DiceSide = 8; break;
                    case "10面体": DiceSide = 10; break;
                    case "12面体": DiceSide = 12; break;
                    case "20面体": DiceSide = 20; break;
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
    }
}