namespace MovingButton
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
            this.ChangePositionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChangePositionButton
            // 

            this.ChangePositionButton.Location = new System.Drawing.Point(50, 50);
            this.ChangePositionButton.Name = "ChangePositionButton";
            this.ChangePositionButton.Size = new System.Drawing.Size(150, 50);
            this.ChangePositionButton.TabIndex = 0;
            this.ChangePositionButton.Text = "Change Position";
            this.ChangePositionButton.UseVisualStyleBackColor = true;
            this.ChangePositionButton.Click += new System.EventHandler(this.ChangePositionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChangePositionButton);
            this.Name = "Form1";
            this.Text = "Super App";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ChangePositionButton;
    }
}