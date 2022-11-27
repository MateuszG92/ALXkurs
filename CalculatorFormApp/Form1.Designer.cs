namespace CalculatorFormApp
{
    partial class CalculatorForm
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
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.Key7Button = new System.Windows.Forms.Button();
            this.Key8Button = new System.Windows.Forms.Button();
            this.Key9Button = new System.Windows.Forms.Button();
            this.Key4Button = new System.Windows.Forms.Button();
            this.Key5Button = new System.Windows.Forms.Button();
            this.Key6Button = new System.Windows.Forms.Button();
            this.Key1Button = new System.Windows.Forms.Button();
            this.Key2Button = new System.Windows.Forms.Button();
            this.Key3Button = new System.Windows.Forms.Button();
            this.Key0Button = new System.Windows.Forms.Button();
            this.KeySubstractButton = new System.Windows.Forms.Button();
            this.KeyAddButton = new System.Windows.Forms.Button();
            this.PointButton = new System.Windows.Forms.Button();
            this.DobleZeroButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DevideButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.StringBuilderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultTextBox.Location = new System.Drawing.Point(12, 12);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(324, 93);
            this.ResultTextBox.TabIndex = 0;
            this.ResultTextBox.Text = "\r\n0";
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Key7Button
            // 
            this.Key7Button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Key7Button.Location = new System.Drawing.Point(12, 177);
            this.Key7Button.Name = "Key7Button";
            this.Key7Button.Size = new System.Drawing.Size(60, 60);
            this.Key7Button.TabIndex = 1;
            this.Key7Button.Tag = "7";
            this.Key7Button.Text = "7";
            this.Key7Button.UseVisualStyleBackColor = true;
            this.Key7Button.Click += new System.EventHandler(this.ExpressionButton_Click);
            // 
            // Key8Button
            // 
            this.Key8Button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Key8Button.Location = new System.Drawing.Point(78, 177);
            this.Key8Button.Name = "Key8Button";
            this.Key8Button.Size = new System.Drawing.Size(60, 60);
            this.Key8Button.TabIndex = 2;
            this.Key8Button.Tag = "8";
            this.Key8Button.Text = "8";
            this.Key8Button.UseVisualStyleBackColor = true;
            this.Key8Button.Click += new System.EventHandler(this.ExpressionButton_Click);
            // 
            // Key9Button
            // 
            this.Key9Button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Key9Button.Location = new System.Drawing.Point(144, 177);
            this.Key9Button.Name = "Key9Button";
            this.Key9Button.Size = new System.Drawing.Size(60, 60);
            this.Key9Button.TabIndex = 3;
            this.Key9Button.Tag = "9";
            this.Key9Button.Text = "9";
            this.Key9Button.UseVisualStyleBackColor = true;
            this.Key9Button.Click += new System.EventHandler(this.ExpressionButton_Click);
            // 
            // Key4Button
            // 
            this.Key4Button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Key4Button.Location = new System.Drawing.Point(12, 243);
            this.Key4Button.Name = "Key4Button";
            this.Key4Button.Size = new System.Drawing.Size(60, 60);
            this.Key4Button.TabIndex = 4;
            this.Key4Button.Tag = "4";
            this.Key4Button.Text = "4";
            this.Key4Button.UseVisualStyleBackColor = true;
            this.Key4Button.Click += new System.EventHandler(this.ExpressionButton_Click);
            // 
            // Key5Button
            // 
            this.Key5Button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Key5Button.Location = new System.Drawing.Point(78, 243);
            this.Key5Button.Name = "Key5Button";
            this.Key5Button.Size = new System.Drawing.Size(60, 60);
            this.Key5Button.TabIndex = 5;
            this.Key5Button.Tag = "5";
            this.Key5Button.Text = "5";
            this.Key5Button.UseVisualStyleBackColor = true;
            this.Key5Button.Click += new System.EventHandler(this.ExpressionButton_Click);
            // 
            // Key6Button
            // 
            this.Key6Button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Key6Button.Location = new System.Drawing.Point(144, 243);
            this.Key6Button.Name = "Key6Button";
            this.Key6Button.Size = new System.Drawing.Size(60, 60);
            this.Key6Button.TabIndex = 6;
            this.Key6Button.Tag = "6";
            this.Key6Button.Text = "6";
            this.Key6Button.UseVisualStyleBackColor = true;
            this.Key6Button.Click += new System.EventHandler(this.ExpressionButton_Click);
            // 
            // Key1Button
            // 
            this.Key1Button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Key1Button.Location = new System.Drawing.Point(12, 309);
            this.Key1Button.Name = "Key1Button";
            this.Key1Button.Size = new System.Drawing.Size(60, 60);
            this.Key1Button.TabIndex = 7;
            this.Key1Button.Tag = "1";
            this.Key1Button.Text = "1";
            this.Key1Button.UseVisualStyleBackColor = true;
            this.Key1Button.Click += new System.EventHandler(this.ExpressionButton_Click);
            // 
            // Key2Button
            // 
            this.Key2Button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Key2Button.Location = new System.Drawing.Point(78, 309);
            this.Key2Button.Name = "Key2Button";
            this.Key2Button.Size = new System.Drawing.Size(60, 60);
            this.Key2Button.TabIndex = 8;
            this.Key2Button.Tag = "2";
            this.Key2Button.Text = "2";
            this.Key2Button.UseVisualStyleBackColor = true;
            this.Key2Button.Click += new System.EventHandler(this.ExpressionButton_Click);
            // 
            // Key3Button
            // 
            this.Key3Button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Key3Button.Location = new System.Drawing.Point(144, 309);
            this.Key3Button.Name = "Key3Button";
            this.Key3Button.Size = new System.Drawing.Size(60, 60);
            this.Key3Button.TabIndex = 9;
            this.Key3Button.Tag = "3";
            this.Key3Button.Text = "3";
            this.Key3Button.UseVisualStyleBackColor = true;
            this.Key3Button.Click += new System.EventHandler(this.ExpressionButton_Click);
            // 
            // Key0Button
            // 
            this.Key0Button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Key0Button.Location = new System.Drawing.Point(78, 375);
            this.Key0Button.Name = "Key0Button";
            this.Key0Button.Size = new System.Drawing.Size(60, 60);
            this.Key0Button.TabIndex = 10;
            this.Key0Button.Tag = "0";
            this.Key0Button.Text = "0";
            this.Key0Button.UseVisualStyleBackColor = true;
            this.Key0Button.Click += new System.EventHandler(this.ExpressionButton_Click);
            // 
            // KeySubstractButton
            // 
            this.KeySubstractButton.Location = new System.Drawing.Point(210, 243);
            this.KeySubstractButton.Name = "KeySubstractButton";
            this.KeySubstractButton.Size = new System.Drawing.Size(60, 60);
            this.KeySubstractButton.TabIndex = 11;
            this.KeySubstractButton.Tag = "-";
            this.KeySubstractButton.Text = "-";
            this.KeySubstractButton.UseVisualStyleBackColor = true;
            this.KeySubstractButton.Click += new System.EventHandler(this.ExpressionButton_Click);
            // 
            // KeyAddButton
            // 
            this.KeyAddButton.Location = new System.Drawing.Point(210, 177);
            this.KeyAddButton.Name = "KeyAddButton";
            this.KeyAddButton.Size = new System.Drawing.Size(60, 60);
            this.KeyAddButton.TabIndex = 12;
            this.KeyAddButton.Tag = "+";
            this.KeyAddButton.Text = "+";
            this.KeyAddButton.UseVisualStyleBackColor = true;
            this.KeyAddButton.Click += new System.EventHandler(this.ExpressionButton_Click);
            // 
            // PointButton
            // 
            this.PointButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PointButton.Location = new System.Drawing.Point(144, 375);
            this.PointButton.Name = "PointButton";
            this.PointButton.Size = new System.Drawing.Size(60, 60);
            this.PointButton.TabIndex = 13;
            this.PointButton.Tag = ".";
            this.PointButton.Text = ",";
            this.PointButton.UseVisualStyleBackColor = true;
            this.PointButton.Click += new System.EventHandler(this.ExpressionButton_Click);
            // 
            // DobleZeroButton
            // 
            this.DobleZeroButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DobleZeroButton.Location = new System.Drawing.Point(12, 375);
            this.DobleZeroButton.Name = "DobleZeroButton";
            this.DobleZeroButton.Size = new System.Drawing.Size(60, 60);
            this.DobleZeroButton.TabIndex = 14;
            this.DobleZeroButton.Tag = "00";
            this.DobleZeroButton.Text = "00";
            this.DobleZeroButton.UseVisualStyleBackColor = true;
            this.DobleZeroButton.Click += new System.EventHandler(this.ExpressionButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(210, 309);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(60, 60);
            this.MultiplyButton.TabIndex = 15;
            this.MultiplyButton.Tag = "*";
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.ExpressionButton_Click);
            // 
            // DevideButton
            // 
            this.DevideButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DevideButton.Location = new System.Drawing.Point(210, 375);
            this.DevideButton.Name = "DevideButton";
            this.DevideButton.Size = new System.Drawing.Size(60, 60);
            this.DevideButton.TabIndex = 16;
            this.DevideButton.Tag = "/";
            this.DevideButton.Text = "/";
            this.DevideButton.UseVisualStyleBackColor = true;
            this.DevideButton.Click += new System.EventHandler(this.ExpressionButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(276, 111);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(60, 60);
            this.ClearButton.TabIndex = 17;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculateButton.Location = new System.Drawing.Point(276, 177);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(60, 258);
            this.CalculateButton.TabIndex = 18;
            this.CalculateButton.Text = "=";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // StringBuilderButton
            // 
            this.StringBuilderButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StringBuilderButton.Location = new System.Drawing.Point(12, 111);
            this.StringBuilderButton.Name = "StringBuilderButton";
            this.StringBuilderButton.Size = new System.Drawing.Size(258, 60);
            this.StringBuilderButton.TabIndex = 19;
            this.StringBuilderButton.Text = "StringBuilder Demo";
            this.StringBuilderButton.UseVisualStyleBackColor = true;
            this.StringBuilderButton.Click += new System.EventHandler(this.StringBuilderButton_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(348, 448);
            this.Controls.Add(this.StringBuilderButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DevideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.DobleZeroButton);
            this.Controls.Add(this.PointButton);
            this.Controls.Add(this.KeyAddButton);
            this.Controls.Add(this.KeySubstractButton);
            this.Controls.Add(this.Key0Button);
            this.Controls.Add(this.Key3Button);
            this.Controls.Add(this.Key2Button);
            this.Controls.Add(this.Key1Button);
            this.Controls.Add(this.Key6Button);
            this.Controls.Add(this.Key5Button);
            this.Controls.Add(this.Key4Button);
            this.Controls.Add(this.Key9Button);
            this.Controls.Add(this.Key8Button);
            this.Controls.Add(this.Key7Button);
            this.Controls.Add(this.ResultTextBox);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ResultTextBox;
        private Button Key7Button;
        private Button Key8Button;
        private Button Key9Button;
        private Button Key4Button;
        private Button Key5Button;
        private Button Key6Button;
        private Button Key1Button;
        private Button Key2Button;
        private Button Key3Button;
        private Button Key0Button;
        private Button KeySubstractButton;
        private Button KeyAddButton;
        private Button PointButton;
        private Button DobleZeroButton;
        private Button MultiplyButton;
        private Button DevideButton;
        private Button ClearButton;
        private Button CalculateButton;
        private Button StringBuilderButton;
    }
}