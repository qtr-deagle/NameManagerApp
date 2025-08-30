namespace Alamares_Ptask
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
            this.FirstName = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.MiddleName = new System.Windows.Forms.Label();
            this.MiddleNameBox = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.FirstNameList = new System.Windows.Forms.ListBox();
            this.MiddleNameList = new System.Windows.Forms.ListBox();
            this.LastNameList = new System.Windows.Forms.ListBox();
            this.Result = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.FNText = new System.Windows.Forms.Label();
            this.MNText = new System.Windows.Forms.Label();
            this.LNText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(299, 55);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(78, 16);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "First Name: ";
            this.FirstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(383, 52);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(104, 22);
            this.FirstNameBox.TabIndex = 1;
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSize = true;
            this.MiddleName.Location = new System.Drawing.Point(283, 87);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(94, 16);
            this.MiddleName.TabIndex = 2;
            this.MiddleName.Text = "Middle Name: ";
            this.MiddleName.Click += new System.EventHandler(this.label2_Click);
            // 
            // MiddleNameBox
            // 
            this.MiddleNameBox.Location = new System.Drawing.Point(383, 86);
            this.MiddleNameBox.Name = "MiddleNameBox";
            this.MiddleNameBox.Size = new System.Drawing.Size(104, 22);
            this.MiddleNameBox.TabIndex = 3;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(299, 122);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(75, 16);
            this.LastName.TabIndex = 4;
            this.LastName.Text = "Last Name:";
            this.LastName.Click += new System.EventHandler(this.label3_Click);
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(383, 121);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(104, 22);
            this.LastNameBox.TabIndex = 5;
            // 
            // FirstNameList
            // 
            this.FirstNameList.ForeColor = System.Drawing.Color.Black;
            this.FirstNameList.FormattingEnabled = true;
            this.FirstNameList.ItemHeight = 16;
            this.FirstNameList.Location = new System.Drawing.Point(160, 187);
            this.FirstNameList.Name = "FirstNameList";
            this.FirstNameList.Size = new System.Drawing.Size(120, 84);
            this.FirstNameList.TabIndex = 6;
            this.FirstNameList.SelectedIndexChanged += new System.EventHandler(this.listbox1_SelectedIndexChanged);
            // 
            // MiddleNameList
            // 
            this.MiddleNameList.FormattingEnabled = true;
            this.MiddleNameList.ItemHeight = 16;
            this.MiddleNameList.Location = new System.Drawing.Point(345, 187);
            this.MiddleNameList.Name = "MiddleNameList";
            this.MiddleNameList.Size = new System.Drawing.Size(120, 84);
            this.MiddleNameList.TabIndex = 7;
            // 
            // LastNameList
            // 
            this.LastNameList.FormattingEnabled = true;
            this.LastNameList.ItemHeight = 16;
            this.LastNameList.Location = new System.Drawing.Point(547, 187);
            this.LastNameList.Name = "LastNameList";
            this.LastNameList.Size = new System.Drawing.Size(120, 84);
            this.LastNameList.TabIndex = 8;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(231, 315);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(77, 16);
            this.Result.TabIndex = 9;
            this.Result.Text = "Result Text:";
            this.Result.Click += new System.EventHandler(this.label4_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(205, 369);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(133, 52);
            this.Add.TabIndex = 10;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(458, 369);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(133, 52);
            this.Remove.TabIndex = 11;
            this.Remove.Text = "REMOVE";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.button2_Click);
            // 
            // FNText
            // 
            this.FNText.AutoSize = true;
            this.FNText.Location = new System.Drawing.Point(157, 168);
            this.FNText.Name = "FNText";
            this.FNText.Size = new System.Drawing.Size(95, 16);
            this.FNText.TabIndex = 12;
            this.FNText.Text = "First Name List";
            this.FNText.Click += new System.EventHandler(this.label5_Click);
            // 
            // MNText
            // 
            this.MNText.AutoSize = true;
            this.MNText.Location = new System.Drawing.Point(342, 168);
            this.MNText.Name = "MNText";
            this.MNText.Size = new System.Drawing.Size(111, 16);
            this.MNText.TabIndex = 13;
            this.MNText.Text = "Middle Name List";
            // 
            // LNText
            // 
            this.LNText.AutoSize = true;
            this.LNText.Location = new System.Drawing.Point(544, 168);
            this.LNText.Name = "LNText";
            this.LNText.Size = new System.Drawing.Size(95, 16);
            this.LNText.TabIndex = 14;
            this.LNText.Text = "Last Name List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 491);
            this.Controls.Add(this.LNText);
            this.Controls.Add(this.MNText);
            this.Controls.Add(this.FNText);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.LastNameList);
            this.Controls.Add(this.MiddleNameList);
            this.Controls.Add(this.FirstNameList);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.MiddleNameBox);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.FirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Label MiddleName;
        private System.Windows.Forms.TextBox MiddleNameBox;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.ListBox FirstNameList;
        private System.Windows.Forms.ListBox MiddleNameList;
        private System.Windows.Forms.ListBox LastNameList;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Label FNText;
        private System.Windows.Forms.Label MNText;
        private System.Windows.Forms.Label LNText;
    }
}

