namespace DiceRoll02;

public partial class Form1 : Form
{
    public Form1()
    {
        // DONE(WIP): �C���X�^���X�̃��\�b�h��t�B�[���h�ɂ� this �����܂��傤�B
        // ���������_������܂����E�E�E
        // �����ƃt�B�[���h�������̏ꍇ����ʂł��܂��B
        // ��ɃC���X�^���X�ł��邱�Ƃ��ӎ��ł��܂��B
        // �N���X���\�b�h�ƍ������ this �������Ƌ�ʂł��Ȃ��Ȃ�܂��B
        //      => ���悻�t�����Ǝv���܂��B
        this.InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        this.diceType.SelectedIndex = 0;
        HideHistory();
        HideDetail();
    }

    private void ResetHistory_Click(object sender, EventArgs e)
    {
        this.historyCommand.Text = "";
        this.historySign.Text = "";
        this.historyResult.Text = "";
    }

    private void SaveHistory_Click(object sender, EventArgs e)
    {
        HistorySaveToCSV.SaveAs(this.historyCommand.Text, this.historyResult.Text);
    }

    private void RollDice_Click(object sender, EventArgs e)
    {
        // TODO: DiceTypeInfo ���g���Ĕ��ʂ���̂͂��������H�v���ł������ł��B
        IDice dice = DiceTypeInfo.GetDiceType(this.diceType.Text, this.diceTypeGroup) switch
        {
            "constellation" => new ConstellationDiceRoll(),
            "omikuji" => new OmikujiRoll(),
            "normalDice" => new BasicDiceRoll(this.diceNum.Text, this.diceType.Text),
            "lowerDice" => new LowerDiceRoll(this.diceNum.Text, this.diceType.Text),
            "upperDice" => new UpperDiceRoll(this.diceNum.Text, this.diceType.Text),
            _ => new ErrorDiceRoll()
        };

        switch (dice.CheckDiceCommandError())
        {
            case null:
                this.rollCommand.Text = dice.GetDiceCommand();
                this.rollResult.Text = dice.GetRollResult();

                this.historyCommand.Text += this.rollCommand.Text + "\r\n";
                this.historySign.Text += this.rollSign.Text + "\r\n";
                this.historyResult.Text += this.rollResult.Text + "\r\n";
                break;
            case "HaveNoDice":
                _ = MessageBox.Show("�s���Ȑ����ł��B\r\n1�ȏ�̐�������͂��Ă��������B");
                break;
            case "HaveUnknownSide":
                _ = MessageBox.Show("�s���ȃT�C�R���ł��B");
                break;
            case "HaveUnknownType":
                _ = MessageBox.Show("�s���ȐU����ł��B");
                break;
            default:
                _ = MessageBox.Show("�s���ȃG���[�ł��B");
                break;
        }
    }

    private void ToggleHistory_Click(object sender, EventArgs e)
    {
        if (this.saveHistory.Visible)
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
        if (DiceTypeInfo.IsCustomDice(this.diceType.Text))
        {
            DisableDiceCustomControll();
        }
        else
        {
            EnableDiceCustomControll();
        }
    }

    private void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (this.checkBox1.Checked)
        {
            ShowDetail();
        }
        else
        {
            HideDetail();
        }
    }

    // TODO: static�Ȑ錾�́A�N���X�̐擪�Ɏ����Ă���Ƃ悢�ł��傤�B
    // �N���X���� region �Ő܂��߂�̈�����ƌ��ʂ����ǂ��Ȃ�܂��B
    // ���ł����Astatic �ȃt�B�[���h�Astatic �ȃ��\�b�h�A�ʏ�̃t�B�[���h�A�R���X�g���N�^�A�C�x���g���\�b�h�A����ȊO�̃��\�b�h�A�Ƃ����悤�ȕ��т��l�����܂��B
    // ��L�̂悤�ȈӖ��P�ʂł͂Ȃ��A�@�\�P�ʂɕ��ׂ邱�Ƃ�����܂��B
    // TODO: static readonly �̏ꍇ�̓p�X�J���P�[�X�ƂȂ�܂��B
    private static readonly int formHeightFull = 512;
    private static readonly int formHeightDeteil = 262;
    private static readonly int formHeightShort = 216;
    private static readonly int historyHeightLong = 264;
    private static readonly int historyHeightShort = 218;
    private static readonly int panelHeightLong = 320;
    private static readonly int panelHeightShort = 274;
    private static readonly Point panelLocationDetailHide = new(8, 121);
    private static readonly Point panelLocationDetailShow = new(8, 167);

    private void HideHistory()
    {
        this.saveHistory.Visible = false;

        this.Height = this.checkBox1.Checked ? Form1.formHeightDeteil : Form1.formHeightShort;
    }

    private void ShowHistory()
    {
        this.saveHistory.Visible = true;

        this.Height = Form1.formHeightFull;
    }

    private void HideDetail()
    {
        this.historyScrollBar.Height = Form1.historyHeightLong;
        this.tableLayoutPanel1.MinimumSize = new Size(0, Form1.historyHeightLong);
        this.panel1.Location = Form1.panelLocationDetailHide;
        this.panel1.Height = Form1.panelHeightLong;
        this.diceTypeGroup.Visible = false;
        this.normalDice.Checked = true;
        this.Height = this.saveHistory.Visible ? Form1.formHeightFull : Form1.formHeightShort;
    }

    private void ShowDetail()
    {
        this.historyScrollBar.Height = Form1.historyHeightShort;
        this.tableLayoutPanel1.MinimumSize = new Size(0, Form1.historyHeightShort);
        this.panel1.Location = Form1.panelLocationDetailShow;
        this.panel1.Height = Form1.panelHeightShort;
        this.diceTypeGroup.Visible = true;
        this.Height = this.saveHistory.Visible ? Form1.formHeightFull : Form1.formHeightDeteil;
    }

    private void EnableDiceCustomControll()
    {
        this.diceNum.Enabled = true;
        this.diceTypeGroup.Enabled = true;
    }

    private void DisableDiceCustomControll()
    {
        this.diceNum.Enabled = false;
        this.diceTypeGroup.Enabled = false;
        this.normalDice.Checked = true;
    }
}