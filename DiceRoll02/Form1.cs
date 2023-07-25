using System.Reflection.Metadata.Ecma335;

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
            DiceType.SelectedIndex = 0;
            HideHistory();
            DetailHide();
        }

        private void ToggleHistory_Click(object sender, EventArgs e)
        {
            if (SaveHistory.Visible)
            {
                HideHistory();
            }
            else
            {
                ShowHistory();
            }
        }

        private void HideHistory()
        {
            SaveHistory.Visible = false;
            if (checkBox1.Checked)
            {
                this.Height = 262;
            }
            else
            {
                this.Height = 216;
            }
        }

        private void ShowHistory()
        {
            SaveHistory.Visible = true;
            this.Height = 512;
        }

        private void ResetHistory_Click(object sender, EventArgs e)
        {
            HistoryCommand.Text = "";
            HistorySign.Text = "";
            HistoryResult.Text = "";
        }

        private void SaveHistory_Click(object sender, EventArgs e)
        {
            new SaveHistoryAsCSV(HistoryCommand.Text, HistoryResult.Text).SaveHistory();
        }

        private void RollDice_Click(object sender, EventArgs e)
        {
            IDice Dice = new DiceTypeInfo(this.DiceType.Text, this.diceTypeGroup).GetDiceType() switch
            {
                // TODO: "����" ���e������GetDiceCommand() �Ɠ����悤�ɁAGetDiceName() ������Ŏ擾�ł���悤�ɂ��܂��傤�B
                "constellation" => new ConstellationDiceRoll(),
                "omikuji" => new OmikujiRoll(),
                "normalDice" => new BasicDiceRoll(DiceNum.Text, DiceType.Text),
                "lowerDice" => new LowerDiceRoll(DiceNum.Text, DiceType.Text),
                "upperDice" => new UpperDiceRoll(DiceNum.Text, DiceType.Text),
                _ => new BasicDiceRoll("1", "0")
            };

            if (Dice.GetDiceCommand() == null)
            {
                _ = MessageBox.Show("�s���Ȑ����ł��B\r\n1�ȏ�̐�������͂��Ă��������B");
            }
            else if (Dice.GetDiceCommand() == "1D0")
            {
                _ = MessageBox.Show("�s���ȃG���[�ł��B");
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
            if (new DiceTypeInfo(this.DiceType.Text, this.diceTypeGroup).IsDiceCustomable())
            {
                EnableDiceCustomControll();
            }
            else
            {
                DisableDiceCustomControll();
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                DetailShow();
            }
            else
            {
                DetailHide();
            }
        }

        private void DetailHide()
        {
            HistoryScrollBar.Height = 264;
            HistoryScrollBar.Location = new Point(12, 177);
            tableLayoutPanel1.MinimumSize = new Size(0, 264);
            SaveHistory.Location = new Point(153, 148);
            ToggleHistory.Location = new Point(12, 148);
            RollCommand.Location = new Point(16, 122);
            RollSign.Location = new Point(104, 122);
            RollResult.Location = new Point(130, 122);
            diceTypeGroup.Visible = false;
            normalDice.Checked = true;
            if (!SaveHistory.Visible)
            {
                this.Height = 216;
            }
        }

        private void DetailShow()
        {
            HistoryScrollBar.Height = 218;
            HistoryScrollBar.Location = new Point(12, 223);
            tableLayoutPanel1.MinimumSize = new Size(0, 218);
            SaveHistory.Location = new Point(153, 194);
            ToggleHistory.Location = new Point(12, 194);
            RollCommand.Location = new Point(12, 168);
            RollSign.Location = new Point(104, 168);
            RollResult.Location = new Point(130, 168);
            diceTypeGroup.Visible = true;
            if (!SaveHistory.Visible)
            {
                this.Height = 262;
            }
        }

        private void EnableDiceCustomControll()
        {
            DiceNum.Enabled = true;
            diceTypeGroup.Enabled = true;
        }

        private void DisableDiceCustomControll()
        {
            DiceNum.Enabled = false;
            diceTypeGroup.Enabled = false;
            normalDice.Checked = true;
        }
    }
}