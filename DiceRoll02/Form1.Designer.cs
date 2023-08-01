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
            saveHistoryButton = new Button();
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
            resultLabelCollection = new Panel();
            historyDisplayCollection = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            userInputGroupe = new Panel();
            typeComboGroupe = new Panel();
            numTextGroupe = new Panel();
            historyScrollBar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            diceTypeGroup.SuspendLayout();
            resultLabelCollection.SuspendLayout();
            historyDisplayCollection.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            userInputGroupe.SuspendLayout();
            typeComboGroupe.SuspendLayout();
            numTextGroupe.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 21);
            label1.TabIndex = 0;
            label1.Text = "サイコロを振ります";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 4);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "個数：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 3);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "種類：";
            // 
            // diceNumTextBox
            // 
            diceNumTextBox.BorderStyle = BorderStyle.FixedSingle;
            diceNumTextBox.ImeMode = ImeMode.Alpha;
            diceNumTextBox.Location = new Point(51, 0);
            diceNumTextBox.MaxLength = 3;
            diceNumTextBox.Name = "diceNumTextBox";
            diceNumTextBox.Size = new Size(101, 23);
            diceNumTextBox.TabIndex = 3;
            // 
            // diceTypeCoｍboBox
            // 
            diceTypeCoｍboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            diceTypeCoｍboBox.FormattingEnabled = true;
            diceTypeCoｍboBox.Items.AddRange(new object[] { "コイン", "4面体", "6面体", "8面体", "10面体", "12面体", "20面体", "100面体", "星座", "おみくじ" });
            diceTypeCoｍboBox.Location = new Point(51, 0);
            diceTypeCoｍboBox.Name = "diceTypeCoｍboBox";
            diceTypeCoｍboBox.Size = new Size(101, 23);
            diceTypeCoｍboBox.TabIndex = 4;
            diceTypeCoｍboBox.SelectedIndexChanged += DiceType_SelectedIndexChanged;
            // 
            // rollDiceButtone
            // 
            rollDiceButtone.Location = new Point(80, 82);
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
            toggleHistoryButton.Location = new Point(12, 230);
            toggleHistoryButton.Margin = new Padding(12, 3, 12, 3);
            toggleHistoryButton.Name = "toggleHistoryButton";
            toggleHistoryButton.Size = new Size(75, 23);
            toggleHistoryButton.TabIndex = 9;
            toggleHistoryButton.TabStop = false;
            toggleHistoryButton.Text = "履歴";
            toggleHistoryButton.UseVisualStyleBackColor = true;
            toggleHistoryButton.Click += ToggleHistory_Click;
            // 
            // saveHistoryButton
            // 
            saveHistoryButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveHistoryButton.Location = new Point(3, 190);
            saveHistoryButton.Name = "saveHistoryButton";
            saveHistoryButton.Size = new Size(75, 23);
            saveHistoryButton.TabIndex = 10;
            saveHistoryButton.TabStop = false;
            saveHistoryButton.Text = "保存";
            saveHistoryButton.UseVisualStyleBackColor = true;
            saveHistoryButton.Click += SaveHistory_Click;
            // 
            // historyScrollBar
            // 
            historyScrollBar.AutoScroll = true;
            historyScrollBar.Controls.Add(tableLayoutPanel1);
            historyScrollBar.Location = new Point(0, 0);
            historyScrollBar.Margin = new Padding(0);
            historyScrollBar.Name = "historyScrollBar";
            historyScrollBar.Size = new Size(216, 185);
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(historySignLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(historyCommandLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(historyResultLabel, 2, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.MinimumSize = new Size(216, 185);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(216, 185);
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
            historyCommandLabel.Size = new Size(97, 15);
            historyCommandLabel.TabIndex = 1;
            historyCommandLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // historyResultLabel
            // 
            historyResultLabel.AutoSize = true;
            historyResultLabel.Dock = DockStyle.Top;
            historyResultLabel.Location = new Point(115, 1);
            historyResultLabel.Name = "historyResultLabel";
            historyResultLabel.Size = new Size(97, 15);
            historyResultLabel.TabIndex = 2;
            historyResultLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // resetHistoryButton
            // 
            resetHistoryButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            resetHistoryButton.Location = new Point(138, 190);
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
            checkBox1.Location = new Point(0, 85);
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
            diceTypeGroup.Location = new Point(12, 126);
            diceTypeGroup.Margin = new Padding(12, 3, 12, 3);
            diceTypeGroup.Name = "diceTypeGroup";
            diceTypeGroup.Size = new Size(216, 69);
            diceTypeGroup.TabIndex = 14;
            diceTypeGroup.TabStop = false;
            diceTypeGroup.Text = "使うサイコロ";
            // 
            // upperDiceRadio
            // 
            upperDiceRadio.AutoSize = true;
            upperDiceRadio.Location = new Point(88, 47);
            upperDiceRadio.Name = "upperDiceRadio";
            upperDiceRadio.Size = new Size(122, 19);
            upperDiceRadio.TabIndex = 2;
            upperDiceRadio.Text = "上方イカサマサイコロ";
            upperDiceRadio.UseVisualStyleBackColor = true;
            // 
            // lowerDiceRadio
            // 
            lowerDiceRadio.AutoSize = true;
            lowerDiceRadio.Location = new Point(88, 22);
            lowerDiceRadio.Name = "lowerDiceRadio";
            lowerDiceRadio.Size = new Size(122, 19);
            lowerDiceRadio.TabIndex = 1;
            lowerDiceRadio.Text = "下方イカサマサイコロ";
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
            // resultLabelCollection
            // 
            resultLabelCollection.Controls.Add(rollResultLabel);
            resultLabelCollection.Controls.Add(rollCommandLabel);
            resultLabelCollection.Controls.Add(rollSignLabel);
            resultLabelCollection.Location = new Point(8, 201);
            resultLabelCollection.Margin = new Padding(8, 3, 8, 3);
            resultLabelCollection.Name = "resultLabelCollection";
            resultLabelCollection.Size = new Size(224, 23);
            resultLabelCollection.TabIndex = 15;
            // 
            // historyDisplayCollection
            // 
            historyDisplayCollection.Controls.Add(historyScrollBar);
            historyDisplayCollection.Controls.Add(saveHistoryButton);
            historyDisplayCollection.Controls.Add(resetHistoryButton);
            historyDisplayCollection.Location = new Point(12, 259);
            historyDisplayCollection.Margin = new Padding(12, 3, 12, 3);
            historyDisplayCollection.Name = "historyDisplayCollection";
            historyDisplayCollection.Size = new Size(216, 216);
            historyDisplayCollection.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(userInputGroupe);
            flowLayoutPanel1.Controls.Add(diceTypeGroup);
            flowLayoutPanel1.Controls.Add(resultLabelCollection);
            flowLayoutPanel1.Controls.Add(toggleHistoryButton);
            flowLayoutPanel1.Controls.Add(historyDisplayCollection);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(240, 478);
            flowLayoutPanel1.TabIndex = 18;
            // 
            // userInputGroupe
            // 
            userInputGroupe.Controls.Add(checkBox1);
            userInputGroupe.Controls.Add(typeComboGroupe);
            userInputGroupe.Controls.Add(rollDiceButtone);
            userInputGroupe.Controls.Add(numTextGroupe);
            userInputGroupe.Controls.Add(label1);
            userInputGroupe.Location = new Point(12, 12);
            userInputGroupe.Margin = new Padding(12, 12, 12, 3);
            userInputGroupe.Name = "userInputGroupe";
            userInputGroupe.Size = new Size(216, 108);
            userInputGroupe.TabIndex = 19;
            // 
            // typeComboGroupe
            // 
            typeComboGroupe.Controls.Add(label3);
            typeComboGroupe.Controls.Add(diceTypeCoｍboBox);
            typeComboGroupe.Location = new Point(32, 53);
            typeComboGroupe.Name = "typeComboGroupe";
            typeComboGroupe.Size = new Size(152, 23);
            typeComboGroupe.TabIndex = 15;
            // 
            // numTextGroupe
            // 
            numTextGroupe.Controls.Add(label2);
            numTextGroupe.Controls.Add(diceNumTextBox);
            numTextGroupe.Location = new Point(32, 24);
            numTextGroupe.Name = "numTextGroupe";
            numTextGroupe.Size = new Size(152, 23);
            numTextGroupe.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(335, 503);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(256, 216);
            Name = "Form1";
            Text = "DiceRoll";
            Load += Form1_Load;
            historyScrollBar.ResumeLayout(false);
            historyScrollBar.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            diceTypeGroup.ResumeLayout(false);
            diceTypeGroup.PerformLayout();
            resultLabelCollection.ResumeLayout(false);
            resultLabelCollection.PerformLayout();
            historyDisplayCollection.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            userInputGroupe.ResumeLayout(false);
            userInputGroupe.PerformLayout();
            typeComboGroupe.ResumeLayout(false);
            typeComboGroupe.PerformLayout();
            numTextGroupe.ResumeLayout(false);
            numTextGroupe.PerformLayout();
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
        private Button saveHistoryButton;
        private Panel historyScrollBar;
        private Button resetHistoryButton;
        private CheckBox checkBox1;
        private GroupBox diceTypeGroup;
        private RadioButton normalDiceRadio;
        private RadioButton lowerDiceRadio;
        private RadioButton upperDiceRadio;
        private Panel resultLabelCollection;
        private Panel historyDisplayCollection;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel numTextGroupe;
        private Panel typeComboGroupe;
        private Panel userInputGroupe;
        private Label historyResultLabel;
        private Label historyCommandLabel;
        private Label historySignLabel;
        private TableLayoutPanel tableLayoutPanel1;
    }
}