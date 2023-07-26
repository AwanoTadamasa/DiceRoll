namespace DiceRoll02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            diceNum = new TextBox();
            diceType = new ComboBox();
            rollDice = new Button();
            rollSign = new Label();
            rollCommand = new Label();
            rollResult = new Label();
            toggleHistory = new Button();
            saveHistory = new Button();
            historyScrollBar = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            historySign = new Label();
            historyCommand = new Label();
            historyResult = new Label();
            resetHistory = new Button();
            checkBox1 = new CheckBox();
            diceTypeGroup = new GroupBox();
            upperDice = new RadioButton();
            lowerDice = new RadioButton();
            normalDice = new RadioButton();
            panel1 = new Panel();
            historyScrollBar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            diceTypeGroup.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 21);
            label1.TabIndex = 0;
            label1.Text = "サイコロを振ります";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 40);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "個数：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 70);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "種類：";
            // 
            // diceNum
            // 
            diceNum.BorderStyle = BorderStyle.FixedSingle;
            diceNum.ImeMode = ImeMode.Alpha;
            diceNum.Location = new Point(82, 38);
            diceNum.MaxLength = 3;
            diceNum.Name = "diceNum";
            diceNum.Size = new Size(100, 23);
            diceNum.TabIndex = 3;
            // 
            // diceType
            // 
            diceType.DropDownStyle = ComboBoxStyle.DropDownList;
            diceType.FormattingEnabled = true;
            diceType.Items.AddRange(new object[] { "コイン", "4面体", "6面体", "8面体", "10面体", "12面体", "20面体", "100面体", "星座", "おみくじ" });
            diceType.Location = new Point(82, 67);
            diceType.Name = "diceType";
            diceType.Size = new Size(100, 23);
            diceType.TabIndex = 4;
            diceType.SelectedIndexChanged += DiceType_SelectedIndexChanged;
            // 
            // rollDice
            // 
            rollDice.Location = new Point(82, 96);
            rollDice.Name = "rollDice";
            rollDice.Size = new Size(75, 23);
            rollDice.TabIndex = 5;
            rollDice.Text = "ロール!!";
            rollDice.UseVisualStyleBackColor = true;
            rollDice.Click += RollDice_Click;
            // 
            // rollSign
            // 
            rollSign.AutoSize = true;
            rollSign.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rollSign.Location = new Point(96, 0);
            rollSign.Name = "rollSign";
            rollSign.Size = new Size(32, 21);
            rollSign.TabIndex = 6;
            rollSign.Text = "=>";
            rollSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rollCommand
            // 
            rollCommand.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rollCommand.Location = new Point(0, 0);
            rollCommand.Name = "rollCommand";
            rollCommand.Size = new Size(96, 23);
            rollCommand.TabIndex = 7;
            rollCommand.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rollResult
            // 
            rollResult.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rollResult.Location = new Point(128, 0);
            rollResult.Name = "rollResult";
            rollResult.Size = new Size(96, 23);
            rollResult.TabIndex = 8;
            rollResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toggleHistory
            // 
            toggleHistory.Location = new Point(4, 26);
            toggleHistory.Name = "toggleHistory";
            toggleHistory.Size = new Size(75, 23);
            toggleHistory.TabIndex = 9;
            toggleHistory.TabStop = false;
            toggleHistory.Text = "履歴";
            toggleHistory.UseVisualStyleBackColor = true;
            toggleHistory.Click += ToggleHistory_Click;
            // 
            // saveHistory
            // 
            saveHistory.Location = new Point(146, 26);
            saveHistory.Name = "saveHistory";
            saveHistory.Size = new Size(75, 23);
            saveHistory.TabIndex = 10;
            saveHistory.TabStop = false;
            saveHistory.Text = "保存";
            saveHistory.UseVisualStyleBackColor = true;
            saveHistory.Click += SaveHistory_Click;
            // 
            // historyScrollBar
            // 
            historyScrollBar.AutoScroll = true;
            historyScrollBar.Controls.Add(tableLayoutPanel1);
            historyScrollBar.Location = new Point(4, 56);
            historyScrollBar.Name = "historyScrollBar";
            historyScrollBar.Size = new Size(216, 218);
            historyScrollBar.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = SystemColors.Window;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(historySign, 1, 0);
            tableLayoutPanel1.Controls.Add(historyCommand, 0, 0);
            tableLayoutPanel1.Controls.Add(historyResult, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MinimumSize = new Size(0, 218);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(216, 218);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // historySign
            // 
            historySign.Anchor = AnchorStyles.Top;
            historySign.AutoSize = true;
            historySign.Location = new Point(108, 1);
            historySign.Name = "historySign";
            historySign.Size = new Size(0, 15);
            historySign.TabIndex = 0;
            historySign.TextAlign = ContentAlignment.TopCenter;
            // 
            // historyCommand
            // 
            historyCommand.AutoSize = true;
            historyCommand.Dock = DockStyle.Top;
            historyCommand.Location = new Point(4, 1);
            historyCommand.Name = "historyCommand";
            historyCommand.Size = new Size(85, 15);
            historyCommand.TabIndex = 1;
            historyCommand.TextAlign = ContentAlignment.TopCenter;
            // 
            // historyResult
            // 
            historyResult.AutoSize = true;
            historyResult.Dock = DockStyle.Top;
            historyResult.Location = new Point(127, 1);
            historyResult.Name = "historyResult";
            historyResult.Size = new Size(85, 15);
            historyResult.TabIndex = 2;
            historyResult.TextAlign = ContentAlignment.TopCenter;
            // 
            // resetHistory
            // 
            resetHistory.Location = new Point(153, 447);
            resetHistory.Name = "resetHistory";
            resetHistory.Size = new Size(75, 23);
            resetHistory.TabIndex = 12;
            resetHistory.TabStop = false;
            resetHistory.Text = "リセット";
            resetHistory.UseVisualStyleBackColor = true;
            resetHistory.Click += ResetHistory_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.Control;
            checkBox1.Location = new Point(8, 99);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(74, 19);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "詳細設定";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            // 
            // diceTypeGroup
            // 
            diceTypeGroup.Controls.Add(upperDice);
            diceTypeGroup.Controls.Add(lowerDice);
            diceTypeGroup.Controls.Add(normalDice);
            diceTypeGroup.Location = new Point(8, 120);
            diceTypeGroup.Name = "diceTypeGroup";
            diceTypeGroup.Size = new Size(224, 45);
            diceTypeGroup.TabIndex = 14;
            diceTypeGroup.TabStop = false;
            diceTypeGroup.Text = "使うサイコロ";
            // 
            // upperDice
            // 
            upperDice.AutoSize = true;
            upperDice.Location = new Point(132, 22);
            upperDice.Name = "upperDice";
            upperDice.Size = new Size(86, 19);
            upperDice.TabIndex = 2;
            upperDice.Text = "上方イカサマ";
            upperDice.UseVisualStyleBackColor = true;
            // 
            // lowerDice
            // 
            lowerDice.AutoSize = true;
            lowerDice.Location = new Point(50, 22);
            lowerDice.Name = "lowerDice";
            lowerDice.Size = new Size(86, 19);
            lowerDice.TabIndex = 1;
            lowerDice.Text = "下方イカサマ";
            lowerDice.UseVisualStyleBackColor = true;
            // 
            // normalDice
            // 
            normalDice.AutoSize = true;
            normalDice.Checked = true;
            normalDice.Location = new Point(6, 22);
            normalDice.Name = "normalDice";
            normalDice.Size = new Size(49, 19);
            normalDice.TabIndex = 0;
            normalDice.TabStop = true;
            normalDice.Text = "通常";
            normalDice.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(saveHistory);
            panel1.Controls.Add(toggleHistory);
            panel1.Controls.Add(historyScrollBar);
            panel1.Controls.Add(rollResult);
            panel1.Controls.Add(rollCommand);
            panel1.Controls.Add(rollSign);
            panel1.Location = new Point(8, 167);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 274);
            panel1.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 473);
            Controls.Add(panel1);
            Controls.Add(diceTypeGroup);
            Controls.Add(checkBox1);
            Controls.Add(resetHistory);
            Controls.Add(rollDice);
            Controls.Add(diceType);
            Controls.Add(diceNum);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "DiceRoll";
            Load += Form1_Load;
            historyScrollBar.ResumeLayout(false);
            historyScrollBar.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            diceTypeGroup.ResumeLayout(false);
            diceTypeGroup.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox diceNum;
        private ComboBox diceType;
        private Button rollDice;
        private Label rollSign;
        private Label rollCommand;
        private Label rollResult;
        private Button toggleHistory;
        private Button saveHistory;
        private Panel historyScrollBar;
        private Button resetHistory;
        private Label historySign;
        private TableLayoutPanel tableLayoutPanel1;
        private Label historyCommand;
        private Label historyResult;
        private CheckBox checkBox1;
        private GroupBox diceTypeGroup;
        private RadioButton normalDice;
        private RadioButton lowerDice;
        private RadioButton upperDice;
        private Panel panel1;
    }
}