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
            // TODO: ���̂�����̒l�͊�{�I�ɂ̓f�U�C�i���Őݒ肵�܂��B
            RollResult.Text = "";
            RollCommand.Text = "";
            HistoryCommand.Text = "";
            HistorySign.Text = "";
            HistoryResult.Text = "";
            DiceType.SelectedIndex = 0;

            // TODO: ToggleHistory�̏����Ɠ���ɂł������ł��B
            // ���\�b�h���ł��Ȃ����������Ă݂܂��傤�B
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
                // TODO: "����" ���e������GetDiceCommand() �Ɠ����悤�ɁAGetDiceName() ������Ŏ擾�ł���悤�ɂ��܂��傤�B
                "����" => new ConstellationDice(),
                _ => new RollBasicDice(DiceNum.Text, DiceType.Text),
            };

            if (Dice.GetDiceCommand() == null)
            {
                MessageBox.Show("�s���Ȑ����ł��B\r\n1�ȏ�̐�������͂��Ă��������B");
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
            // TODO: IDiceNumberable �Ƃ����C���^�[�t�F�C�X��p�ӂ��Ďg���Ă݂܂��傤�B
            // Numberable �͑���ł��B�����ƓK���Ȗ��O�����邩�l���Ă݂܂��傤�B
            // �Ȃ��ȉ��̏����� true / false ��Ԃ������Ȃ̂ŁAif ���͖������܂��B
            if (DiceType.Text == "����")
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