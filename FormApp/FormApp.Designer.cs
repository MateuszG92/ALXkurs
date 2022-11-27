namespace FormApp
{
    partial class FormApp
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
            this.DontClickButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClickIt = new System.Windows.Forms.Button();
            this.hightTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HightButton = new System.Windows.Forms.Button();
            this.XNumberTextbox = new System.Windows.Forms.TextBox();
            this.YNumberTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.AddRadioButton = new System.Windows.Forms.RadioButton();
            this.SubstractRadioButton = new System.Windows.Forms.RadioButton();
            this.MultiplyRadioButton = new System.Windows.Forms.RadioButton();
            this.DeevideRadioButton = new System.Windows.Forms.RadioButton();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DontClickButton
            // 
            this.DontClickButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.DontClickButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DontClickButton.Location = new System.Drawing.Point(12, 12);
            this.DontClickButton.Name = "DontClickButton";
            this.DontClickButton.Size = new System.Drawing.Size(75, 23);
            this.DontClickButton.TabIndex = 0;
            this.DontClickButton.Text = "Don\'t click";
            this.DontClickButton.UseVisualStyleBackColor = false;
            this.DontClickButton.Click += new System.EventHandler(this.DontClickButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(582, 389);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(100, 49);
            this.RestartButton.TabIndex = 1;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(688, 389);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 49);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClickIt
            // 
            this.ClickIt.Location = new System.Drawing.Point(12, 415);
            this.ClickIt.Name = "ClickIt";
            this.ClickIt.Size = new System.Drawing.Size(75, 23);
            this.ClickIt.TabIndex = 3;
            this.ClickIt.Text = "Clik It!";
            this.ClickIt.UseVisualStyleBackColor = true;
            this.ClickIt.Click += new System.EventHandler(this.button1_Click);
            // 
            // hightTextBox
            // 
            this.hightTextBox.Location = new System.Drawing.Point(582, 69);
            this.hightTextBox.Name = "hightTextBox";
            this.hightTextBox.Size = new System.Drawing.Size(206, 23);
            this.hightTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter your height";
            // 
            // HightButton
            // 
            this.HightButton.Location = new System.Drawing.Point(582, 98);
            this.HightButton.Name = "HightButton";
            this.HightButton.Size = new System.Drawing.Size(75, 23);
            this.HightButton.TabIndex = 6;
            this.HightButton.Text = "Run";
            this.HightButton.UseVisualStyleBackColor = true;
            this.HightButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // XNumberTextbox
            // 
            this.XNumberTextbox.Location = new System.Drawing.Point(12, 69);
            this.XNumberTextbox.Name = "XNumberTextbox";
            this.XNumberTextbox.Size = new System.Drawing.Size(100, 23);
            this.XNumberTextbox.TabIndex = 7;
            // 
            // YNumberTextbox
            // 
            this.YNumberTextbox.Location = new System.Drawing.Point(12, 126);
            this.YNumberTextbox.Name = "YNumberTextbox";
            this.YNumberTextbox.Size = new System.Drawing.Size(100, 23);
            this.YNumberTextbox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "X Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Y Number";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(12, 285);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 11;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(12, 314);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(100, 23);
            this.ResultTextBox.TabIndex = 12;
            // 
            // AddRadioButton
            // 
            this.AddRadioButton.AutoSize = true;
            this.AddRadioButton.Checked = true;
            this.AddRadioButton.Location = new System.Drawing.Point(12, 155);
            this.AddRadioButton.Name = "AddRadioButton";
            this.AddRadioButton.Size = new System.Drawing.Size(47, 19);
            this.AddRadioButton.TabIndex = 13;
            this.AddRadioButton.TabStop = true;
            this.AddRadioButton.Text = "Add";
            this.AddRadioButton.UseVisualStyleBackColor = true;
            // 
            // SubstractRadioButton
            // 
            this.SubstractRadioButton.AutoSize = true;
            this.SubstractRadioButton.Location = new System.Drawing.Point(12, 180);
            this.SubstractRadioButton.Name = "SubstractRadioButton";
            this.SubstractRadioButton.Size = new System.Drawing.Size(74, 19);
            this.SubstractRadioButton.TabIndex = 14;
            this.SubstractRadioButton.Text = "Substract";
            this.SubstractRadioButton.UseVisualStyleBackColor = true;
            // 
            // MultiplyRadioButton
            // 
            this.MultiplyRadioButton.AutoSize = true;
            this.MultiplyRadioButton.Location = new System.Drawing.Point(12, 205);
            this.MultiplyRadioButton.Name = "MultiplyRadioButton";
            this.MultiplyRadioButton.Size = new System.Drawing.Size(69, 19);
            this.MultiplyRadioButton.TabIndex = 15;
            this.MultiplyRadioButton.Text = "Multiply";
            this.MultiplyRadioButton.UseVisualStyleBackColor = true;
            // 
            // DeevideRadioButton
            // 
            this.DeevideRadioButton.AutoSize = true;
            this.DeevideRadioButton.Location = new System.Drawing.Point(12, 230);
            this.DeevideRadioButton.Name = "DeevideRadioButton";
            this.DeevideRadioButton.Size = new System.Drawing.Size(61, 19);
            this.DeevideRadioButton.TabIndex = 16;
            this.DeevideRadioButton.Text = "Devide";
            this.DeevideRadioButton.UseVisualStyleBackColor = true;
            // 
            // LogTextBox
            // 
            this.LogTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LogTextBox.Location = new System.Drawing.Point(139, 69);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(239, 268);
            this.LogTextBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Logs";
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.DeevideRadioButton);
            this.Controls.Add(this.MultiplyRadioButton);
            this.Controls.Add(this.SubstractRadioButton);
            this.Controls.Add(this.AddRadioButton);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YNumberTextbox);
            this.Controls.Add(this.XNumberTextbox);
            this.Controls.Add(this.HightButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hightTextBox);
            this.Controls.Add(this.ClickIt);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.DontClickButton);
            this.Name = "FormApp";
            this.Text = "ALX Course Form App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private Button DontClickButton;
        private Button RestartButton;
        private Button ExitButton;
        private Button ClickIt;
        private TextBox hightTextBox;
        private Label label1;
        private Button HightButton;
        private TextBox XNumberTextbox;
        private TextBox YNumberTextbox;
        private Label label2;
        private Label label3;
        private Button CalculateButton;
        private TextBox ResultTextBox;
        private RadioButton AddRadioButton;
        private RadioButton SubstractRadioButton;
        private RadioButton MultiplyRadioButton;
        private RadioButton DeevideRadioButton;
        private TextBox LogTextBox;
        private Label label4;
    }
}