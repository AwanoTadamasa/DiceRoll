using System.Reflection.Metadata.Ecma335;

namespace DiceRoll02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // TODO(WIP): �C���X�^���X�̃��\�b�h��t�B�[���h�ɂ� this �����܂��傤�B
            // ���������_������܂����E�E�E
            // �����ƃt�B�[���h�������̏ꍇ����ʂł��܂��B
            // ��ɃC���X�^���X�ł��邱�Ƃ��ӎ��ł��܂��B
            // �N���X���\�b�h�ƍ������ this �������Ƌ�ʂł��Ȃ��Ȃ�܂��B
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diceType.SelectedIndex = 0;
            HideHistory();
            HideDetail();
        }

        private void ResetHistory_Click(object sender, EventArgs e)
        {
            historyCommand.Text = "";
            historySign.Text = "";
            historyResult.Text = "";
        }

        private void SaveHistory_Click(object sender, EventArgs e)
        {
            HistorySaver.SaveAsCSV(historyCommand.Text, historyResult.Text);
        }

        private void RollDice_Click(object sender, EventArgs e)
        {
            // TODO: IDice Dice �� dice
            // TODO: DiceTypeInfo ���g���Ĕ��ʂ���̂͂��������H�v���ł������ł��B
            // IDice �̃C���X�^���X���g�������͍H�v���ł��Ă���GOOD�ł��B
            IDice Dice = DiceTypeInfo.GetDiceType(diceType.Text, diceTypeGroup) switch
            {
                "constellation" => new ConstellationDiceRoll(),
                "omikuji" => new OmikujiRoll(),
                "normalDice" => new BasicDiceRoll(diceNum.Text, diceType.Text),
                "lowerDice" => new LowerDiceRoll(diceNum.Text, diceType.Text),
                "upperDice" => new UpperDiceRoll(diceNum.Text, diceType.Text),
                _ => new BasicDiceRoll("1", "0")
            };

            if (Dice.GetDiceCommand() == null)
            {
                _ = MessageBox.Show("�s���Ȑ����ł��B\r\n1�ȏ�̐�������͂��Ă��������B");
            }
            // TODO: ���̔�r�͏������ς��ƏC���̕K�v������܂��B�L�����A�����łȂ����𔻕ʂ��郁�\�b�h��p�ӂ���̂��悢�ł��傤�B
            //      => diceType��0�̎�null���A���悤�� (WIP)IDice�ɔ���̒ǉ�
            else if (Dice.GetDiceCommand() == null)
            {
                _ = MessageBox.Show("�s���ȃG���[�ł��B");
            }
            else
            {
                rollCommand.Text = Dice.GetDiceCommand();
                rollResult.Text = Dice.GetRollResult();

                historyCommand.Text += rollCommand.Text + "\r\n";
                historySign.Text += rollSign.Text + "\r\n";
                historyResult.Text += rollResult.Text + "\r\n";
            }
        }

        private void ToggleHistory_Click(object sender, EventArgs e)
        {
            if (saveHistory.Visible)
            {
                HideHistory();
            }
            else
            {
                ShowHistory();
            }
        }

        private void DiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DiceTypeInfo.CanDiceCustom(diceType.Text))
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
                ShowDetail();
            }
            else
            {
                HideDetail();
            }
        }

        private static readonly int formHeightFull = 512;
        private static readonly int formHeightDeteil = 262;
        private static readonly int formHeightShort = 216;

        private void HideHistory()
        {
            saveHistory.Visible = false;

            this.Height = checkBox1.Checked ? formHeightDeteil : formHeightShort;
        }

        private void ShowHistory()
        {
            saveHistory.Visible = true;

            // TODO(WIP): ���e�����l�͒��ڎg�킸�Astatic readonly �ȕϐ��ɓ���Ă��������B
            // const �Ƃ̈Ⴂ�����ׂĂ݂܂��傤�B
            this.Height = formHeightFull;
        }

        private void HideDetail()
        {
            // TODO: �������R���g���[���̕\��/��\����؂�ւ������Ƃ��́A�p�l����z�u���āA���̃p�l�����Ƒ��삷��Ɗy�ł��B
            historyScrollBar.Height = 264;
            historyScrollBar.Location = new Point(12, 177);
            tableLayoutPanel1.MinimumSize = new Size(0, 264);
            saveHistory.Location = new Point(153, 148);
            toggleHistory.Location = new Point(12, 148);
            rollCommand.Location = new Point(16, 122);
            rollSign.Location = new Point(104, 122);
            rollResult.Location = new Point(130, 122);
            diceTypeGroup.Visible = false;
            normalDice.Checked = true;
            if (!saveHistory.Visible)
            {
                this.Height = 216;
            }
        }

        private void ShowDetail()
        {
            historyScrollBar.Height = 218;
            historyScrollBar.Location = new Point(12, 223);
            tableLayoutPanel1.MinimumSize = new Size(0, 218);
            saveHistory.Location = new Point(153, 194);
            toggleHistory.Location = new Point(12, 194);
            rollCommand.Location = new Point(12, 168);
            rollSign.Location = new Point(104, 168);
            rollResult.Location = new Point(130, 168);
            diceTypeGroup.Visible = true;
            if (!saveHistory.Visible)
            {
                this.Height = 262;
            }
        }

        private void EnableDiceCustomControll()
        {
            diceNum.Enabled = true;
            diceTypeGroup.Enabled = true;
        }

        private void DisableDiceCustomControll()
        {
            diceNum.Enabled = false;
            diceTypeGroup.Enabled = false;
            normalDice.Checked = true;
        }
    }
}