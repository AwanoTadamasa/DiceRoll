namespace DiceRoll02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RollResult.Text = "";
            RollCommand.Text = "";
            HistoryCommand.Text = "";
            HistorySign.Text = "";
            HistoryResult.Text = "";
            DiceType.SelectedIndex = 0;

            SaveHistory.Visible = false;
            Height = 216;
        }

        private void ToggleHistory_Click(object sender, EventArgs e)
        {
            if (SaveHistory.Visible)
            {
                SaveHistory.Visible = false;
                this.Height = 216;
            }
            else
            {
                SaveHistory.Visible = true;
                this.Height = 512;
            }
        }

        private void ResetHistory_Click(object sender, EventArgs e)
        {
            HistoryCommand.Text = "";
            HistorySign.Text = "";
            HistoryResult.Text = "";
        }

        private void SaveHistory_Click(object sender, EventArgs e)
        {

        }

        private void RollDice_Click(object sender, EventArgs e)
        {
            IDice Dice = DiceType.Text switch
            {
                "êØç¿" => new ConstellationDice(),
                _ => new RollBasicDice(DiceNum.Text, DiceType.Text),
            };
            if (Dice.GetDiceCommand() == null)
            {
                MessageBox.Show("ïsê≥Ç»êîéöÇ≈Ç∑ÅB\r\n1à»è„ÇÃêÆêîÇì¸óÕÇµÇƒÇ≠ÇæÇ≥Ç¢ÅB");
            }
            else
            {
                RollCommand.Text = Dice.GetDiceCommand();
                RollResult.Text = Dice.GetRollResult();

                HistoryCommand.Text += RollCommand.Text + "\r\n";
                HistorySign.Text += RollSign.Text + "\r\n";
                HistoryResult.Text += RollResult.Text + "\r\n";
            }
        }

        private void DiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DiceType.Text == "êØç¿")
            {
                DiceNum.Enabled = false;
            }
            else
            {
                DiceNum.Enabled = true;
            }
        }
    }
}