namespace Alamares_Ptask
{
    partial class RemoveForm
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
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.buttonConfirm_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(276, 85);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(223, 22);
            this.textBoxFullName.TabIndex = 0;
            this.textBoxFullName.Tag = "";
            // 
            // buttonConfirm_Click
            // 
            this.buttonConfirm_Click.Location = new System.Drawing.Point(310, 327);
            this.buttonConfirm_Click.Name = "buttonConfirm_Click";
            this.buttonConfirm_Click.Size = new System.Drawing.Size(140, 53);
            this.buttonConfirm_Click.TabIndex = 1;
            this.buttonConfirm_Click.Text = "button1";
            this.buttonConfirm_Click.UseVisualStyleBackColor = true;
            this.buttonConfirm_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the full name to remove";
            // 
            // RemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConfirm_Click);
            this.Controls.Add(this.textBoxFullName);
            this.Name = "RemoveForm";
            this.Text = "RemoveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Button buttonConfirm_Click;
        private System.Windows.Forms.Label label1;
    }
}