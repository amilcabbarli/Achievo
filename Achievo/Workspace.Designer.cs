namespace Achievo
{
    partial class Workspace
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
            this.profileLabel = new System.Windows.Forms.Label();
            this.checkTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.controlLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.BackColor = System.Drawing.SystemColors.Control;
            this.profileLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileLabel.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLabel.ForeColor = System.Drawing.Color.Black;
            this.profileLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.profileLabel.Location = new System.Drawing.Point(46, 30);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Padding = new System.Windows.Forms.Padding(5);
            this.profileLabel.Size = new System.Drawing.Size(128, 41);
            this.profileLabel.TabIndex = 0;
            this.profileLabel.Text = "My profile";
            this.profileLabel.MouseLeave += new System.EventHandler(this.profileLabel_MouseLeave);
            this.profileLabel.MouseHover += new System.EventHandler(this.profileLabel_MouseHover);
            // 
            // checkTextBox
            // 
            this.checkTextBox.Location = new System.Drawing.Point(286, 30);
            this.checkTextBox.Name = "checkTextBox";
            this.checkTextBox.Size = new System.Drawing.Size(144, 20);
            this.checkTextBox.TabIndex = 1;
            this.checkTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkTextBox_KeyDown);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(286, 68);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(144, 42);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(532, 30);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(202, 224);
            this.checkedListBox1.TabIndex = 3;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteButton.Location = new System.Drawing.Point(286, 128);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(144, 42);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // controlLabel
            // 
            this.controlLabel.AutoSize = true;
            this.controlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.controlLabel.ForeColor = System.Drawing.Color.Red;
            this.controlLabel.Location = new System.Drawing.Point(283, 200);
            this.controlLabel.Name = "controlLabel";
            this.controlLabel.Size = new System.Drawing.Size(0, 16);
            this.controlLabel.TabIndex = 5;
            this.controlLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Workspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 533);
            this.Controls.Add(this.controlLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.checkTextBox);
            this.Controls.Add(this.profileLabel);
            this.Name = "Workspace";
            this.Text = "Workspace";
            this.Load += new System.EventHandler(this.Workspace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.TextBox checkTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label controlLabel;
    }
}