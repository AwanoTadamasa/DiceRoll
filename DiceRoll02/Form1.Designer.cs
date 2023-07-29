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
            diceNumTextBox = new TextBox();
            diceTypeCoｍboBox = new ComboBox();
            rollDiceButtone = new Button();
            rollSignLabel = new Label();
            rollCommandLabel = new Label();
            rollResultLabel = new Label();
            toggleHistoryButton = new Button();
            saveHistoryButon = new Button();
            historyScrollBar = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            historySignLabel = new Label();
            historyCommandLabel = new Label();
            historyResultLabel = new Label();
            resetHistoryButton = new Button();
            checkBox1 = new CheckBox();
            diceTypeGroup = new GroupBox();
            upperDiceRadio = new RadioButton();
            lowerDiceRadio = new RadioButton();
            normalDiceRadio = new RadioButton();
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
            // diceNumTextBox
            // 
            diceNumTextBox.BorderStyle = BorderStyle.FixedSingle;
            diceNumTextBox.ImeMode = ImeMode.Alpha;
            diceNumTextBox.Location = new Point(82, 38);
            diceNumTextBox.MaxLength = 3;
            diceNumTextBox.Name = "diceNumTextBox";
            diceNumTextBox.Size = new Size(100, 23);
            diceNumTextBox.TabIndex = 3;
            // 
            // diceTypeCoｍboBox
            // 
            diceTypeCoｍboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            diceTypeCoｍboBox.FormattingEnabled = true;
            diceTypeCoｍboBox.Items.AddRange(new object[] { "コイン", "4面体", "6面体", "8面体", "10面体", "12面体", "20面体", "100面体", "星座", "おみくじ" });
            diceTypeCoｍboBox.Location = new Point(82, 67);
            diceTypeCoｍboBox.Name = "diceTypeCoｍboBox";
            diceTypeCoｍboBox.Size = new Size(100, 23);
            diceTypeCoｍboBox.TabIndex = 4;
            diceTypeCoｍboBox.SelectedIndexChanged += DiceType_SelectedIndexChanged;
            // 
            // rollDiceButtone
            // 
            rollDiceButtone.Location = new Point(82, 96);
            rollDiceButtone.Name = "rollDiceButtone";
            rollDiceButtone.Size = new Size(75, 23);
            rollDiceButtone.TabIndex = 5;
            rollDiceButtone.Text = "ロール!!";
            rollDiceButtone.UseVisualStyleBackColor = true;
            rollDiceButtone.Click += RollDice_Click;
            // 
            // rollSignLabel
            // 
            rollSignLabel.AutoSize = true;
            rollSignLabel.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rollSignLabel.Location = new Point(96, 0);
            rollSignLabel.Name = "rollSignLabel";
            rollSignLabel.Size = new Size(32, 21);
            rollSignLabel.TabIndex = 6;
            rollSignLabel.Text = "=>";
            rollSignLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rollCommandLabel
            // 
            rollCommandLabel.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rollCommandLabel.Location = new Point(0, 0);
            rollCommandLabel.Name = "rollCommandLabel";
            rollCommandLabel.Size = new Size(96, 23);
            rollCommandLabel.TabIndex = 7;
            rollCommandLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rollResultLabel
            // 
            rollResultLabel.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rollResultLabel.Location = new Point(128, 0);
            rollResultLabel.Name = "rollResultLabel";
            rollResultLabel.Size = new Size(96, 23);
            rollResultLabel.TabIndex = 8;
            rollResultLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toggleHistoryButton
            // 
            toggleHistoryButton.Location = new Point(4, 26);
            toggleHistoryButton.Name = "toggleHistoryButton";
            toggleHistoryButton.Size = new Size(75, 23);
            toggleHistoryButton.TabIndex = 9;
            toggleHistoryButton.TabStop = false;
            toggleHistoryButton.Text = "履歴";
            toggleHistoryButton.UseVisualStyleBackColor = true;
            toggleHistoryButton.Click += ToggleHistory_Click;
            // 
            // saveHistoryButon
            // 
            saveHistoryButon.Location = new Point(146, 26);
            saveHistoryButon.Name = "saveHistoryButon";
            saveHistoryButon.Size = new Size(75, 23);
            saveHistoryButon.TabIndex = 10;
            saveHistoryButon.TabStop = false;
            saveHistoryButon.Text = "保存";
            saveHistoryButon.UseVisualStyleBackColor = true;
            saveHistoryButon.Click += SaveHistory_Click;
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
            tableLayoutPanel1.Controls.Add(historySignLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(historyCommandLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(historyResultLabel, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MinimumSize = new Size(0, 218);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(216, 218);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // historySignLabel
            // 
            historySignLabel.Anchor = AnchorStyles.Top;
            historySignLabel.AutoSize = true;
            historySignLabel.Location = new Point(108, 1);
            historySignLabel.Name = "historySignLabel";
            historySignLabel.Size = new Size(0, 15);
            historySignLabel.TabIndex = 0;
            historySignLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // historyCommandLabel
            // 
            historyCommandLabel.AutoSize = true;
            historyCommandLabel.Dock = DockStyle.Top;
            historyCommandLabel.Location = new Point(4, 1);
            historyCommandLabel.Name = "historyCommandLabel";
            historyCommandLabel.Size = new Size(85, 15);
            historyCommandLabel.TabIndex = 1;
            historyCommandLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // historyResultLabel
            // 
            historyResultLabel.AutoSize = true;
            historyResultLabel.Dock = DockStyle.Top;
            historyResultLabel.Location = new Point(127, 1);
            historyResultLabel.Name = "historyResultLabel";
            historyResultLabel.Size = new Size(85, 15);
            historyResultLabel.TabIndex = 2;
            historyResultLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // resetHistoryButton
            // 
            resetHistoryButton.Location = new Point(153, 447);
            resetHistoryButton.Name = "resetHistoryButton";
            resetHistoryButton.Size = new Size(75, 23);
            resetHistoryButton.TabIndex = 12;
            resetHistoryButton.TabStop = false;
            resetHistoryButton.Text = "リセット";
            resetHistoryButton.UseVisualStyleBackColor = true;
            resetHistoryButton.Click += ResetHistory_Click;
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
            diceTypeGroup.Controls.Add(upperDiceRadio);
            diceTypeGroup.Controls.Add(lowerDiceRadio);
            diceTypeGroup.Controls.Add(normalDiceRadio);
            diceTypeGroup.Location = new Point(8, 120);
            diceTypeGroup.Name = "diceTypeGroup";
            diceTypeGroup.Size = new Size(224, 45);
            diceTypeGroup.TabIndex = 14;
            diceTypeGroup.TabStop = false;
            diceTypeGroup.Text = "使うサイコロ";
            // 
            // upperDiceRadio
            // 
            upperDiceRadio.AutoSize = true;
            upperDiceRadio.Location = new Point(132, 22);
            upperDiceRadio.Name = "upperDiceRadio";
            upperDiceRadio.Size = new Size(86, 19);
            upperDiceRadio.TabIndex = 2;
            upperDiceRadio.Text = "上方イカサマ";
            upperDiceRadio.UseVisualStyleBackColor = true;
            // 
            // lowerDiceRadio
            // 
            lowerDiceRadio.AutoSize = true;
            lowerDiceRadio.Location = new Point(50, 22);
            lowerDiceRadio.Name = "lowerDiceRadio";
            lowerDiceRadio.Size = new Size(86, 19);
            lowerDiceRadio.TabIndex = 1;
            lowerDiceRadio.Text = "下方イカサマ";
            lowerDiceRadio.UseVisualStyleBackColor = true;
            // 
            // normalDiceRadio
            // 
            normalDiceRadio.AutoSize = true;
            normalDiceRadio.Checked = true;
            normalDiceRadio.Location = new Point(6, 22);
            normalDiceRadio.Name = "normalDiceRadio";
            normalDiceRadio.Size = new Size(49, 19);
            normalDiceRadio.TabIndex = 0;
            normalDiceRadio.TabStop = true;
            normalDiceRadio.Text = "通常";
            normalDiceRadio.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(saveHistoryButon);
            panel1.Controls.Add(toggleHistoryButton);
            panel1.Controls.Add(historyScrollBar);
            panel1.Controls.Add(rollResultLabel);
            panel1.Controls.Add(rollCommandLabel);
            panel1.Controls.Add(rollSignLabel);
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
            Controls.Add(resetHistoryButton);
            Controls.Add(rollDiceButtone);
            Controls.Add(diceTypeCoｍboBox);
            Controls.Add(diceNumTextBox);
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
        private TextBox diceNumTextBox;
        private ComboBox diceTypeCoｍboBox;
        private Button rollDiceButtone;
        private Label rollSignLabel;
        private Label rollCommandLabel;
        private Label rollResultLabel;
        private Button toggleHistoryButton;
        private Button saveHistoryButon;
        private Panel historyScrollBar;
        private Button resetHistoryButton;
        private Label historySignLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label historyCommandLabel;
        private Label historyResultLabel;
        private CheckBox checkBox1;
        private GroupBox diceTypeGroup;
        private RadioButton normalDiceRadio;
        private RadioButton lowerDiceRadio;
        private RadioButton upperDiceRadio;
        private Panel panel1;
    }
}