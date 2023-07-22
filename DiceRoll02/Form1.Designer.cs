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
            DiceNum = new TextBox();
            DiceType = new ComboBox();
            RollDice = new Button();
            RollSign = new Label();
            RollCommand = new Label();
            RollResult = new Label();
            ToggleHistory = new Button();
            SaveHistory = new Button();
            HistoryScrollBar = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            HistorySign = new Label();
            HistoryCommand = new Label();
            HistoryResult = new Label();
            ResetHistory = new Button();
            HistoryScrollBar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            // DiceNum
            // 
            DiceNum.BorderStyle = BorderStyle.FixedSingle;
            DiceNum.ImeMode = ImeMode.Alpha;
            DiceNum.Location = new Point(82, 38);
            DiceNum.MaxLength = 3;
            DiceNum.Name = "DiceNum";
            DiceNum.Size = new Size(100, 23);
            DiceNum.TabIndex = 3;
            // 
            // DiceType
            // 
            DiceType.DropDownStyle = ComboBoxStyle.DropDownList;
            DiceType.FormattingEnabled = true;
            DiceType.Items.AddRange(new object[] { "コイン", "4面体", "6面体", "8面体", "10面体", "12面体", "20面体", "100面体", "星座" });
            DiceType.Location = new Point(82, 67);
            DiceType.Name = "DiceType";
            DiceType.Size = new Size(100, 23);
            DiceType.TabIndex = 4;
            DiceType.SelectedIndexChanged += DiceType_SelectedIndexChanged;
            // 
            // RollDice
            // 
            RollDice.Location = new Point(82, 96);
            RollDice.Name = "RollDice";
            RollDice.Size = new Size(75, 23);
            RollDice.TabIndex = 5;
            RollDice.Text = "ロール!!";
            RollDice.UseVisualStyleBackColor = true;
            RollDice.Click += RollDice_Click;
            // 
            // RollSign
            // 
            RollSign.AutoSize = true;
            RollSign.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RollSign.Location = new Point(104, 122);
            RollSign.Name = "RollSign";
            RollSign.Size = new Size(32, 21);
            RollSign.TabIndex = 6;
            RollSign.Text = "=>";
            RollSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RollCommand
            // 
            RollCommand.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RollCommand.Location = new Point(16, 122);
            RollCommand.Name = "RollCommand";
            RollCommand.Size = new Size(85, 23);
            RollCommand.TabIndex = 7;
            RollCommand.Text = "label5";
            RollCommand.TextAlign = ContentAlignment.MiddleRight;
            // 
            // RollResult
            // 
            RollResult.AutoSize = true;
            RollResult.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RollResult.Location = new Point(130, 122);
            RollResult.Name = "RollResult";
            RollResult.Size = new Size(52, 21);
            RollResult.TabIndex = 8;
            RollResult.Text = "label6";
            RollResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ToggleHistory
            // 
            ToggleHistory.Location = new Point(12, 148);
            ToggleHistory.Name = "ToggleHistory";
            ToggleHistory.Size = new Size(75, 23);
            ToggleHistory.TabIndex = 9;
            ToggleHistory.Text = "履歴";
            ToggleHistory.UseVisualStyleBackColor = true;
            ToggleHistory.Click += ToggleHistory_Click;
            // 
            // SaveHistory
            // 
            SaveHistory.Location = new Point(153, 148);
            SaveHistory.Name = "SaveHistory";
            SaveHistory.Size = new Size(75, 23);
            SaveHistory.TabIndex = 10;
            SaveHistory.Text = "保存";
            SaveHistory.UseVisualStyleBackColor = true;
            SaveHistory.Click += SaveHistory_Click;
            // 
            // HistoryScrollBar
            // 
            HistoryScrollBar.AutoScroll = true;
            HistoryScrollBar.Controls.Add(tableLayoutPanel1);
            HistoryScrollBar.Location = new Point(12, 177);
            HistoryScrollBar.Name = "HistoryScrollBar";
            HistoryScrollBar.Size = new Size(216, 264);
            HistoryScrollBar.TabIndex = 11;
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
            tableLayoutPanel1.Controls.Add(HistorySign, 1, 0);
            tableLayoutPanel1.Controls.Add(HistoryCommand, 0, 0);
            tableLayoutPanel1.Controls.Add(HistoryResult, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MinimumSize = new Size(0, 264);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(216, 264);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // HistorySign
            // 
            HistorySign.Anchor = AnchorStyles.Top;
            HistorySign.AutoSize = true;
            HistorySign.Location = new Point(96, 1);
            HistorySign.Name = "HistorySign";
            HistorySign.Size = new Size(23, 15);
            HistorySign.TabIndex = 0;
            HistorySign.Text = "=>";
            HistorySign.TextAlign = ContentAlignment.TopCenter;
            // 
            // HistoryCommand
            // 
            HistoryCommand.AutoSize = true;
            HistoryCommand.Dock = DockStyle.Top;
            HistoryCommand.Location = new Point(4, 1);
            HistoryCommand.Name = "HistoryCommand";
            HistoryCommand.Size = new Size(85, 15);
            HistoryCommand.TabIndex = 1;
            HistoryCommand.Text = "999D100";
            HistoryCommand.TextAlign = ContentAlignment.TopCenter;
            // 
            // HistoryResult
            // 
            HistoryResult.AutoSize = true;
            HistoryResult.Dock = DockStyle.Top;
            HistoryResult.Location = new Point(127, 1);
            HistoryResult.Name = "HistoryResult";
            HistoryResult.Size = new Size(85, 15);
            HistoryResult.TabIndex = 2;
            HistoryResult.Text = "99900";
            HistoryResult.TextAlign = ContentAlignment.TopCenter;
            // 
            // ResetHistory
            // 
            ResetHistory.Location = new Point(153, 447);
            ResetHistory.Name = "ResetHistory";
            ResetHistory.Size = new Size(75, 23);
            ResetHistory.TabIndex = 12;
            ResetHistory.Text = "リセット";
            ResetHistory.UseVisualStyleBackColor = true;
            ResetHistory.Click += ResetHistory_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 473);
            Controls.Add(ResetHistory);
            Controls.Add(HistoryScrollBar);
            Controls.Add(SaveHistory);
            Controls.Add(ToggleHistory);
            Controls.Add(RollResult);
            Controls.Add(RollCommand);
            Controls.Add(RollSign);
            Controls.Add(RollDice);
            Controls.Add(DiceType);
            Controls.Add(DiceNum);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "DiceRoll";
            Load += Form1_Load;
            HistoryScrollBar.ResumeLayout(false);
            HistoryScrollBar.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox DiceNum;
        private ComboBox DiceType;
        private Button RollDice;
        private Label RollSign;
        private Label RollCommand;
        private Label RollResult;
        private Button ToggleHistory;
        private Button SaveHistory;
        private Panel HistoryScrollBar;
        private Button ResetHistory;
        private Label HistorySign;
        private TableLayoutPanel tableLayoutPanel1;
        private Label HistoryCommand;
        private Label HistoryResult;
    }
}