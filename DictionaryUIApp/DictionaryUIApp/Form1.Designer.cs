namespace DictionaryUIApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idToSaveTextBox = new System.Windows.Forms.TextBox();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.idToSearchTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // idToSaveTextBox
            // 
            this.idToSaveTextBox.Location = new System.Drawing.Point(134, 43);
            this.idToSaveTextBox.Name = "idToSaveTextBox";
            this.idToSaveTextBox.Size = new System.Drawing.Size(138, 20);
            this.idToSaveTextBox.TabIndex = 3;
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(134, 124);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(138, 70);
            this.detailsTextBox.TabIndex = 4;
            // 
            // idToSearchTextBox
            // 
            this.idToSearchTextBox.Location = new System.Drawing.Point(134, 306);
            this.idToSearchTextBox.Name = "idToSearchTextBox";
            this.idToSearchTextBox.Size = new System.Drawing.Size(138, 20);
            this.idToSearchTextBox.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(310, 124);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(310, 304);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllButton.Location = new System.Drawing.Point(175, 377);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 23);
            this.showAllButton.TabIndex = 8;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 435);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.idToSearchTextBox);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(this.idToSaveTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idToSaveTextBox;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.TextBox idToSearchTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button showAllButton;
    }
}

