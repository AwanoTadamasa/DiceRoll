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
                    case "4ñ ëÃ": DiceSide = 4; break;
                    case "6ñ ëÃ": DiceSide = 6; break;
                    case "8ñ ëÃ": DiceSide = 8; break;
                    case "10ñ ëÃ": DiceSide = 10; break;
                    case "12ñ ëÃ": DiceSide = 12; break;
                    case "20ñ ëÃ": DiceSide = 20; break;
                    default: DiceSide = 2; break;
                }

                RollDice dice1 = new RollDice(DiceNum, DiceSide, Option);
                IDice dice = dice1;

                DiceCommand.Text = dice.GetDiceCommand();
                Result.Text = dice.GetResult().ToString();
            }
            else
            {
                MessageBox.Show("å¬êîÇÕê≥ÇÃêÆêîÇì¸óÕÇµÇƒÇ≠ÇæÇ≥Ç¢");
            }
        }
    }
}