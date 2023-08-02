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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // diceNumTextBox
            // 
            resources.ApplyResources(diceNumTextBox, "diceNumTextBox");
            diceNumTextBox.BorderStyle = BorderStyle.FixedSingle;
            diceNumTextBox.Name = "diceNumTextBox";
            // 
            // diceTypeCoｍboBox
            // 
            resources.ApplyResources(diceTypeCoｍboBox, "diceTypeCoｍboBox");
            diceTypeCoｍboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            diceTypeCoｍboBox.FormattingEnabled = true;
            diceTypeCoｍboBox.Items.AddRange(new object[] { resources.GetString("diceTypeCoｍboBox.Items"), resources.GetString("diceTypeCoｍboBox.Items1"), resources.GetString("diceTypeCoｍboBox.Items2"), resources.GetString("diceTypeCoｍboBox.Items3"), resources.GetString("diceTypeCoｍboBox.Items4"), resources.GetString("diceTypeCoｍboBox.Items5"), resources.GetString("diceTypeCoｍboBox.Items6"), resources.GetString("diceTypeCoｍboBox.Items7"), resources.GetString("diceTypeCoｍboBox.Items8"), resources.GetString("diceTypeCoｍboBox.Items9") });
            diceTypeCoｍboBox.Name = "diceTypeCoｍboBox";
            diceTypeCoｍboBox.SelectedIndexChanged += DiceType_SelectedIndexChanged;
            // 
            // rollDiceButtone
            // 
            resources.ApplyResources(rollDiceButtone, "rollDiceButtone");
            rollDiceButtone.Name = "rollDiceButtone";
            rollDiceButtone.UseVisualStyleBackColor = true;
            rollDiceButtone.Click += RollDice_Click;
            // 
            // rollSignLabel
            // 
            resources.ApplyResources(rollSignLabel, "rollSignLabel");
            rollSignLabel.Name = "rollSignLabel";
            // 
            // rollCommandLabel
            // 
            resources.ApplyResources(rollCommandLabel, "rollCommandLabel");
            rollCommandLabel.Name = "rollCommandLabel";
            // 
            // rollResultLabel
            // 
            resources.ApplyResources(rollResultLabel, "rollResultLabel");
            rollResultLabel.Name = "rollResultLabel";
            // 
            // toggleHistoryButton
            // 
            resources.ApplyResources(toggleHistoryButton, "toggleHistoryButton");
            toggleHistoryButton.Name = "toggleHistoryButton";
            toggleHistoryButton.TabStop = false;
            toggleHistoryButton.UseVisualStyleBackColor = true;
            toggleHistoryButton.Click += ToggleHistory_Click;
            // 
            // saveHistoryButton
            // 
            resources.ApplyResources(saveHistoryButton, "saveHistoryButton");
            saveHistoryButton.Name = "saveHistoryButton";
            saveHistoryButton.TabStop = false;
            saveHistoryButton.UseVisualStyleBackColor = true;
            saveHistoryButton.Click += SaveHistory_Click;
            // 
            // historyScrollBar
            // 
            resources.ApplyResources(historyScrollBar, "historyScrollBar");
            historyScrollBar.Controls.Add(tableLayoutPanel1);
            historyScrollBar.Name = "historyScrollBar";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.BackColor = SystemColors.Window;
            tableLayoutPanel1.Controls.Add(historySignLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(historyCommandLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(historyResultLabel, 2, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // historySignLabel
            // 
            resources.ApplyResources(historySignLabel, "historySignLabel");
            historySignLabel.Name = "historySignLabel";
            // 
            // historyCommandLabel
            // 
            resources.ApplyResources(historyCommandLabel, "historyCommandLabel");
            historyCommandLabel.Name = "historyCommandLabel";
            // 
            // historyResultLabel
            // 
            resources.ApplyResources(historyResultLabel, "historyResultLabel");
            historyResultLabel.Name = "historyResultLabel";
            // 
            // resetHistoryButton
            // 
            resources.ApplyResources(resetHistoryButton, "resetHistoryButton");
            resetHistoryButton.Name = "resetHistoryButton";
            resetHistoryButton.TabStop = false;
            resetHistoryButton.UseVisualStyleBackColor = true;
            resetHistoryButton.Click += ResetHistory_Click;
            // 
            // checkBox1
            // 
            resources.ApplyResources(checkBox1, "checkBox1");
            checkBox1.BackColor = SystemColors.Control;
            checkBox1.Name = "checkBox1";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            // 
            // diceTypeGroup
            // 
            resources.ApplyResources(diceTypeGroup, "diceTypeGroup");
            diceTypeGroup.Controls.Add(upperDiceRadio);
            diceTypeGroup.Controls.Add(lowerDiceRadio);
            diceTypeGroup.Controls.Add(normalDiceRadio);
            diceTypeGroup.Name = "diceTypeGroup";
            diceTypeGroup.TabStop = false;
            // 
            // upperDiceRadio
            // 
            resources.ApplyResources(upperDiceRadio, "upperDiceRadio");
            upperDiceRadio.Name = "upperDiceRadio";
            upperDiceRadio.UseVisualStyleBackColor = true;
            // 
            // lowerDiceRadio
            // 
            resources.ApplyResources(lowerDiceRadio, "lowerDiceRadio");
            lowerDiceRadio.Name = "lowerDiceRadio";
            lowerDiceRadio.UseVisualStyleBackColor = true;
            // 
            // normalDiceRadio
            // 
            resources.ApplyResources(normalDiceRadio, "normalDiceRadio");
            normalDiceRadio.Checked = true;
            normalDiceRadio.Name = "normalDiceRadio";
            normalDiceRadio.TabStop = true;
            normalDiceRadio.UseVisualStyleBackColor = true;
            // 
            // resultLabelCollection
            // 
            resources.ApplyResources(resultLabelCollection, "resultLabelCollection");
            resultLabelCollection.Controls.Add(rollResultLabel);
            resultLabelCollection.Controls.Add(rollCommandLabel);
            resultLabelCollection.Controls.Add(rollSignLabel);
            resultLabelCollection.Name = "resultLabelCollection";
            // 
            // historyDisplayCollection
            // 
            resources.ApplyResources(historyDisplayCollection, "historyDisplayCollection");
            historyDisplayCollection.Controls.Add(historyScrollBar);
            historyDisplayCollection.Controls.Add(saveHistoryButton);
            historyDisplayCollection.Controls.Add(resetHistoryButton);
            historyDisplayCollection.Name = "historyDisplayCollection";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.Controls.Add(userInputGroupe);
            flowLayoutPanel1.Controls.Add(diceTypeGroup);
            flowLayoutPanel1.Controls.Add(resultLabelCollection);
            flowLayoutPanel1.Controls.Add(toggleHistoryButton);
            flowLayoutPanel1.Controls.Add(historyDisplayCollection);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // userInputGroupe
            // 
            resources.ApplyResources(userInputGroupe, "userInputGroupe");
            userInputGroupe.Controls.Add(checkBox1);
            userInputGroupe.Controls.Add(typeComboGroupe);
            userInputGroupe.Controls.Add(rollDiceButtone);
            userInputGroupe.Controls.Add(numTextGroupe);
            userInputGroupe.Controls.Add(label1);
            userInputGroupe.Name = "userInputGroupe";
            // 
            // typeComboGroupe
            // 
            resources.ApplyResources(typeComboGroupe, "typeComboGroupe");
            typeComboGroupe.Controls.Add(label3);
            typeComboGroupe.Controls.Add(diceTypeCoｍboBox);
            typeComboGroupe.Name = "typeComboGroupe";
            // 
            // numTextGroupe
            // 
            resources.ApplyResources(numTextGroupe, "numTextGroupe");
            numTextGroupe.Controls.Add(label2);
            numTextGroupe.Controls.Add(diceNumTextBox);
            numTextGroupe.Name = "numTextGroupe";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
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