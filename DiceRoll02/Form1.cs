using System.Reflection.Metadata.Ecma335;

namespace DiceRoll02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // TODO: TODO�R�����g�ɑΉ������ꍇ�� DONE �ɕς��Ă��������B�m�F����폜���Ă����܂��B
            // TODO: �C���X�^���X�̃��\�b�h��t�B�[���h�ɂ� this �����܂��傤�B
            // ���������_������܂����E�E�E
            // �����ƃt�B�[���h�������̏ꍇ����ʂł��܂��B
            // ��ɃC���X�^���X�ł��邱�Ƃ��ӎ��ł��܂��B
            // �N���X���\�b�h�ƍ������ this �������Ƌ�ʂł��Ȃ��Ȃ�܂��B
            this.InitializeComponent();
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

            // TODO: �O�����Z�q���g���Ă݂܂��傤�B
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

            // TODO: ���e�����l�͒��ڎg�킸�Astatic readonly �ȕϐ��ɓ���Ă��������B
            // const �Ƃ̈Ⴂ�����ׂĂ݂܂��傤�B
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
            // TODO: new �������ă��\�b�h���Ăт����ꍇ�́A�C���X�^���X��錾����K�v�̂Ȃ��Astatic �ȃ��\�b�h�ɂł��Ȃ����������܂��B
            new SaveHistoryAsCSV(HistoryCommand.Text, HistoryResult.Text).SaveHistory();
        }

        private void RollDice_Click(object sender, EventArgs e)
        {
            // TODO: Dice �� dice
            // TODO: this.DiceType �� this.diceTypeGroup �Ŗ����̂�炬������܂��B�p�X�J���P�[�X���A�L�������P�[�X���A�ǂ�����g���̂��悢�ł��傤���H
            // TODO: DiceTypeInfo ���g���Ĕ��ʂ���̂͂��������H�v���ł������ł��B
            // IDice �̃C���X�^���X���g�������͍H�v���ł��Ă���GOOD�ł��B
            IDice Dice = new DiceTypeInfo(this.DiceType.Text, this.diceTypeGroup).GetDiceType() switch
            {
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
            // TODO: ���̔�r�͏������ς��ƏC���̕K�v������܂��B�L�����A�����łȂ����𔻕ʂ��郁�\�b�h��p�ӂ���̂��悢�ł��傤�B
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
            // TODO: ���������g�����ł���΁AIsDiceCustomable() �� static �ȃ��\�b�h�ɂł��Ȃ����������܂��B
            // ���ʂ��邽�߂����ɃC���X�^���X�����ꍇ�́A�^���s��̂Ƃ��ɓ��I�ɉ���������ꍇ�Ȃ̂ŁA���܂�s���܂���B
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

        // TODO: ���\�b�h���͓�������n�߂܂��B
        private void DetailHide()
        {
            // TODO: �������R���g���[���̕\��/��\����؂�ւ������Ƃ��́A�p�l����z�u���āA���̃p�l�����Ƒ��삷��Ɗy�ł��B
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