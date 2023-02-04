namespace BookLibrary
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.bookListComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.inStockCheckBox = new System.Windows.Forms.CheckBox();
            this.borrowButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.addBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 33);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(297, 23);
            this.searchTextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(336, 33);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // bookListComboBox
            // 
            this.bookListComboBox.FormattingEnabled = true;
            this.bookListComboBox.Location = new System.Drawing.Point(444, 33);
            this.bookListComboBox.Name = "bookListComboBox";
            this.bookListComboBox.Size = new System.Drawing.Size(297, 23);
            this.bookListComboBox.TabIndex = 2;
            this.bookListComboBox.SelectedIndexChanged += new System.EventHandler(this.bookListComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Szukaj ksiązki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista książek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Autor:";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(72, 80);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(237, 23);
            this.authorTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tytuł:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(72, 119);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(237, 23);
            this.titleTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gatunek:";
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(72, 159);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(237, 23);
            this.genreTextBox.TabIndex = 10;
            // 
            // inStockCheckBox
            // 
            this.inStockCheckBox.AutoSize = true;
            this.inStockCheckBox.Location = new System.Drawing.Point(72, 204);
            this.inStockCheckBox.Name = "inStockCheckBox";
            this.inStockCheckBox.Size = new System.Drawing.Size(76, 19);
            this.inStockCheckBox.TabIndex = 12;
            this.inStockCheckBox.Text = "Dostępna";
            this.inStockCheckBox.UseVisualStyleBackColor = true;
            // 
            // borrowButton
            // 
            this.borrowButton.Location = new System.Drawing.Point(56, 255);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(75, 23);
            this.borrowButton.TabIndex = 13;
            this.borrowButton.Text = "Wypożycz";
            this.borrowButton.UseVisualStyleBackColor = true;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(191, 255);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 14;
            this.returnButton.Text = "Zwróć";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(358, 118);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(75, 23);
            this.addBookButton.TabIndex = 15;
            this.addBookButton.Text = "Dodaj książkę";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.inStockCheckBox);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookListComboBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox searchTextBox;
        private Button searchButton;
        private ComboBox bookListComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox authorTextBox;
        private Label label4;
        private TextBox titleTextBox;
        private Label label5;
        private TextBox genreTextBox;
        private CheckBox inStockCheckBox;
        private Button borrowButton;
        private Button returnButton;
        private Button addBookButton;
    }
}