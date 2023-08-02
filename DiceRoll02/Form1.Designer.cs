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
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 0;
            label1.Text = "サイコロを振ります";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 2);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 1;
            label2.Text = "個数：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 5);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 2;
            label3.Text = "種類：";
            // 
            // diceNumTextBox
            // 
            diceNumTextBox.BorderStyle = BorderStyle.FixedSingle;
            diceNumTextBox.ImeMode = ImeMode.Alpha;
            diceNumTextBox.Location = new Point(73, 0);
            diceNumTextBox.Margin = new Padding(4, 5, 4, 5);
            diceNumTextBox.MaxLength = 3;
            diceNumTextBox.Name = "diceNumTextBox";
            diceNumTextBox.Size = new Size(143, 31);
            diceNumTextBox.TabIndex = 3;
            // 
            // diceTypeCoｍboBox
            // 
            diceTypeCoｍboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            diceTypeCoｍboBox.FormattingEnabled = true;
            diceTypeCoｍboBox.Items.AddRange(new object[] { "コイン", "4面体", "6面体", "8面体", "10面体", "12面体", "20面体", "100面体", "星座", "おみくじ" });
            diceTypeCoｍboBox.Location = new Point(73, 0);
            diceTypeCoｍboBox.Margin = new Padding(4, 5, 4, 5);
            diceTypeCoｍboBox.Name = "diceTypeCoｍboBox";
            diceTypeCoｍboBox.Size = new Size(143, 33);
            diceTypeCoｍboBox.TabIndex = 4;
            diceTypeCoｍboBox.SelectedIndexChanged += DiceType_SelectedIndexChanged;
            // 
            // rollDiceButtone
            // 
            rollDiceButtone.Location = new Point(119, 124);
            rollDiceButtone.Margin = new Padding(4, 5, 4, 5);
            rollDiceButtone.Name = "rollDiceButtone";
            rollDiceButtone.Size = new Size(107, 38);
            rollDiceButtone.TabIndex = 5;
            rollDiceButtone.Text = "ロール!!";
            rollDiceButtone.UseVisualStyleBackColor = true;
            rollDiceButtone.Click += RollDice_Click;
            // 
            // rollSignLabel
            // 
            rollSignLabel.AutoSize = true;
            rollSignLabel.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rollSignLabel.Location = new Point(137, 0);
            rollSignLabel.Margin = new Padding(4, 0, 4, 0);
            rollSignLabel.Name = "rollSignLabel";
            rollSignLabel.Size = new Size(46, 32);
            rollSignLabel.TabIndex = 6;
            rollSignLabel.Text = "=>";
            rollSignLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rollCommandLabel
            // 
            rollCommandLabel.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rollCommandLabel.Location = new Point(0, 0);
            rollCommandLabel.Margin = new Padding(4, 0, 4, 0);
            rollCommandLabel.Name = "rollCommandLabel";
            rollCommandLabel.Size = new Size(137, 38);
            rollCommandLabel.TabIndex = 7;
            rollCommandLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rollResultLabel
            // 
            rollResultLabel.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rollResultLabel.Location = new Point(183, 0);
            rollResultLabel.Margin = new Padding(4, 0, 4, 0);
            rollResultLabel.Name = "rollResultLabel";
            rollResultLabel.Size = new Size(137, 38);
            rollResultLabel.TabIndex = 8;
            rollResultLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toggleHistoryButton
            // 
            toggleHistoryButton.Location = new Point(17, 374);
            toggleHistoryButton.Margin = new Padding(17, 5, 17, 5);
            toggleHistoryButton.Name = "toggleHistoryButton";
            toggleHistoryButton.Size = new Size(107, 38);
            toggleHistoryButton.TabIndex = 9;
            toggleHistoryButton.TabStop = false;
            toggleHistoryButton.Text = "履歴";
            toggleHistoryButton.UseVisualStyleBackColor = true;
            toggleHistoryButton.Click += ToggleHistory_Click;
            // 
            // saveHistoryButton
            // 
            saveHistoryButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveHistoryButton.Location = new Point(4, 317);
            saveHistoryButton.Margin = new Padding(4, 5, 4, 5);
            saveHistoryButton.Name = "saveHistoryButton";
            saveHistoryButton.Size = new Size(107, 38);
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
            historyScrollBar.Size = new Size(309, 308);
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
            tableLayoutPanel1.MinimumSize = new Size(309, 308);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(309, 308);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // historySignLabel
            // 
            historySignLabel.Anchor = AnchorStyles.Top;
            historySignLabel.AutoSize = true;
            historySignLabel.Location = new Point(154, 1);
            historySignLabel.Margin = new Padding(4, 0, 4, 0);
            historySignLabel.Name = "historySignLabel";
            historySignLabel.Size = new Size(0, 25);
            historySignLabel.TabIndex = 0;
            historySignLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // historyCommandLabel
            // 
            historyCommandLabel.AutoSize = true;
            historyCommandLabel.Dock = DockStyle.Top;
            historyCommandLabel.Location = new Point(5, 1);
            historyCommandLabel.Margin = new Padding(4, 0, 4, 0);
            historyCommandLabel.Name = "historyCommandLabel";
            historyCommandLabel.Size = new Size(140, 25);
            historyCommandLabel.TabIndex = 1;
            historyCommandLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // historyResultLabel
            // 
            historyResultLabel.AutoSize = true;
            historyResultLabel.Dock = DockStyle.Top;
            historyResultLabel.Location = new Point(163, 1);
            historyResultLabel.Margin = new Padding(4, 0, 4, 0);
            historyResultLabel.Name = "historyResultLabel";
            historyResultLabel.Size = new Size(141, 25);
            historyResultLabel.TabIndex = 2;
            historyResultLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // resetHistoryButton
            // 
            resetHistoryButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            resetHistoryButton.Location = new Point(197, 317);
            resetHistoryButton.Margin = new Padding(4, 5, 4, 5);
            resetHistoryButton.Name = "resetHistoryButton";
            resetHistoryButton.Size = new Size(107, 38);
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
            checkBox1.Location = new Point(5, 129);
            checkBox1.Margin = new Padding(4, 5, 4, 5);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(110, 29);
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
            diceTypeGroup.Location = new Point(17, 201);
            diceTypeGroup.Margin = new Padding(17, 5, 17, 5);
            diceTypeGroup.Name = "diceTypeGroup";
            diceTypeGroup.Padding = new Padding(4, 5, 4, 5);
            diceTypeGroup.Size = new Size(309, 115);
            diceTypeGroup.TabIndex = 14;
            diceTypeGroup.TabStop = false;
            diceTypeGroup.Text = "使うサイコロ";
            // 
            // upperDiceRadio
            // 
            upperDiceRadio.AutoSize = true;
            upperDiceRadio.Location = new Point(126, 78);
            upperDiceRadio.Margin = new Padding(4, 5, 4, 5);
            upperDiceRadio.Name = "upperDiceRadio";
            upperDiceRadio.Size = new Size(182, 29);
            upperDiceRadio.TabIndex = 2;
            upperDiceRadio.Text = "上方イカサマサイコロ";
            upperDiceRadio.UseVisualStyleBackColor = true;
            // 
            // lowerDiceRadio
            // 
            lowerDiceRadio.AutoSize = true;
            lowerDiceRadio.Location = new Point(126, 37);
            lowerDiceRadio.Margin = new Padding(4, 5, 4, 5);
            lowerDiceRadio.Name = "lowerDiceRadio";
            lowerDiceRadio.Size = new Size(182, 29);
            lowerDiceRadio.TabIndex = 1;
            lowerDiceRadio.Text = "下方イカサマサイコロ";
            lowerDiceRadio.UseVisualStyleBackColor = true;
            // 
            // normalDiceRadio
            // 
            normalDiceRadio.AutoSize = true;
            normalDiceRadio.Checked = true;
            normalDiceRadio.Location = new Point(9, 37);
            normalDiceRadio.Margin = new Padding(4, 5, 4, 5);
            normalDiceRadio.Name = "normalDiceRadio";
            normalDiceRadio.Size = new Size(73, 29);
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
            resultLabelCollection.Location = new Point(11, 326);
            resultLabelCollection.Margin = new Padding(11, 5, 11, 5);
            resultLabelCollection.Name = "resultLabelCollection";
            resultLabelCollection.Size = new Size(320, 38);
            resultLabelCollection.TabIndex = 15;
            // 
            // historyDisplayCollection
            // 
            historyDisplayCollection.Controls.Add(historyScrollBar);
            historyDisplayCollection.Controls.Add(saveHistoryButton);
            historyDisplayCollection.Controls.Add(resetHistoryButton);
            historyDisplayCollection.Location = new Point(17, 422);
            historyDisplayCollection.Margin = new Padding(17, 5, 17, 5);
            historyDisplayCollection.Name = "historyDisplayCollection";
            historyDisplayCollection.Size = new Size(309, 360);
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
            flowLayoutPanel1.Size = new Size(343, 787);
            flowLayoutPanel1.TabIndex = 18;
            // 
            // userInputGroupe
            // 
            userInputGroupe.Controls.Add(checkBox1);
            userInputGroupe.Controls.Add(typeComboGroupe);
            userInputGroupe.Controls.Add(rollDiceButtone);
            userInputGroupe.Controls.Add(numTextGroupe);
            userInputGroupe.Controls.Add(label1);
            userInputGroupe.Location = new Point(17, 20);
            userInputGroupe.Margin = new Padding(17, 20, 17, 5);
            userInputGroupe.Name = "userInputGroupe";
            userInputGroupe.Size = new Size(309, 171);
            userInputGroupe.TabIndex = 19;
            // 
            // typeComboGroupe
            // 
            typeComboGroupe.Controls.Add(label3);
            typeComboGroupe.Controls.Add(diceTypeCoｍboBox);
            typeComboGroupe.Location = new Point(46, 81);
            typeComboGroupe.Margin = new Padding(4, 5, 4, 5);
            typeComboGroupe.Name = "typeComboGroupe";
            typeComboGroupe.Size = new Size(217, 38);
            typeComboGroupe.TabIndex = 15;
            // 
            // numTextGroupe
            // 
            numTextGroupe.Controls.Add(label2);
            numTextGroupe.Controls.Add(diceNumTextBox);
            numTextGroupe.Location = new Point(46, 40);
            numTextGroupe.Margin = new Padding(4, 5, 4, 5);
            numTextGroupe.Name = "numTextGroupe";
            numTextGroupe.Size = new Size(217, 38);
            numTextGroupe.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(479, 838);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(356, 323);
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