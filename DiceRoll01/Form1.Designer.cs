namespace DiceRoll01
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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            RollDices = new Button();
            Result = new Label();
            History = new Button();
            SaveHistory = new Button();
            listView1 = new ListView();
            button1 = new Button();
            label4 = new Label();
            DiceCommand = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ImeMode = ImeMode.NoControl;
            textBox1.Location = new Point(63, 40);
            textBox1.MaxLength = 3;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 0;
            textBox1.WordWrap = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "コイン", "4面体", "6面体", "8面体", "10面体", "12面体", "20面体", "100面体" });
            comboBox1.Location = new Point(63, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 21);
            label1.TabIndex = 2;
            label1.Text = "サイコロを振ります";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 43);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "個数：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 72);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "種類：";
            // 
            // RollDices
            // 
            RollDices.Location = new Point(63, 98);
            RollDices.Name = "RollDices";
            RollDices.Size = new Size(75, 23);
            RollDices.TabIndex = 5;
            RollDices.Text = "ロール!!";
            RollDices.UseVisualStyleBackColor = true;
            RollDices.Click += RollDices_Click;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Result.Location = new Point(124, 124);
            Result.Name = "Result";
            Result.Size = new Size(28, 21);
            Result.TabIndex = 6;
            Result.Text = "00";
            // 
            // History
            // 
            History.Location = new Point(12, 148);
            History.Name = "History";
            History.Size = new Size(75, 23);
            History.TabIndex = 7;
            History.Text = "履歴";
            History.UseVisualStyleBackColor = true;
            // 
            // SaveHistory
            // 
            SaveHistory.Location = new Point(124, 148);
            SaveHistory.Name = "SaveHistory";
            SaveHistory.Size = new Size(75, 23);
            SaveHistory.TabIndex = 8;
            SaveHistory.Text = "保存";
            SaveHistory.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 177);
            listView1.Name = "listView1";
            listView1.Size = new Size(187, 261);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(124, 444);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "リセット";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(86, 124);
            label4.Name = "label4";
            label4.Size = new Size(32, 21);
            label4.TabIndex = 11;
            label4.Text = "=>";
            // 
            // DiceCommand
            // 
            DiceCommand.AutoSize = true;
            DiceCommand.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DiceCommand.Location = new Point(41, 124);
            DiceCommand.Name = "DiceCommand";
            DiceCommand.Size = new Size(39, 21);
            DiceCommand.TabIndex = 12;
            DiceCommand.Text = "0D0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(211, 473);
            Controls.Add(DiceCommand);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(SaveHistory);
            Controls.Add(History);
            Controls.Add(Result);
            Controls.Add(RollDices);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "DiceRoll";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button RollDices;
        private Label Result;
        private Button History;
        private Button SaveHistory;
        private ListView listView1;
        private Button button1;
        private Label label4;
        private Label DiceCommand;
    }
}