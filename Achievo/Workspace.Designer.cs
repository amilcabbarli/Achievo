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
            this.checkTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.controlLabel = new System.Windows.Forms.Label();
            this.notesPanel = new System.Windows.Forms.Panel();
            this.profileLabel = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.notesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkTextBox
            // 
            this.checkTextBox.Location = new System.Drawing.Point(0, 38);
            this.checkTextBox.Name = "checkTextBox";
            this.checkTextBox.Size = new System.Drawing.Size(144, 20);
            this.checkTextBox.TabIndex = 1;
            this.checkTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkTextBox_KeyDown);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.MintCream;
            this.addButton.Location = new System.Drawing.Point(0, 75);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(144, 42);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(232, 38);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(202, 224);
            this.checkedListBox1.TabIndex = 3;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteButton.Location = new System.Drawing.Point(0, 135);
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
            this.controlLabel.Location = new System.Drawing.Point(3, 199);
            this.controlLabel.Name = "controlLabel";
            this.controlLabel.Size = new System.Drawing.Size(0, 16);
            this.controlLabel.TabIndex = 5;
            this.controlLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // notesPanel
            // 
            this.notesPanel.Controls.Add(this.addButton);
            this.notesPanel.Controls.Add(this.deleteButton);
            this.notesPanel.Controls.Add(this.controlLabel);
            this.notesPanel.Controls.Add(this.checkedListBox1);
            this.notesPanel.Controls.Add(this.checkTextBox);
            this.notesPanel.Location = new System.Drawing.Point(361, 30);
            this.notesPanel.Name = "notesPanel";
            this.notesPanel.Size = new System.Drawing.Size(434, 297);
            this.notesPanel.TabIndex = 6;
            this.notesPanel.Visible = false;
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLabel.LinkColor = System.Drawing.Color.Black;
            this.profileLabel.Location = new System.Drawing.Point(55, 30);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(96, 25);
            this.profileLabel.TabIndex = 7;
            this.profileLabel.TabStop = true;
            this.profileLabel.Text = "My profile";
            this.profileLabel.MouseLeave += new System.EventHandler(this.profileLabel_MouseLeave);
            this.profileLabel.MouseHover += new System.EventHandler(this.profileLabel_MouseHover);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(55, 82);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(63, 25);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Notes";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel1.MouseLeave += new System.EventHandler(this.linkLabel1_MouseLeave);
            this.linkLabel1.MouseHover += new System.EventHandler(this.linkLabel1_MouseHover);
            // 
            // Workspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(836, 533);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.profileLabel);
            this.Controls.Add(this.notesPanel);
            this.Name = "Workspace";
            this.Text = "Workspace";
            this.Load += new System.EventHandler(this.Workspace_Load);
            this.notesPanel.ResumeLayout(false);
            this.notesPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox checkTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label controlLabel;
        private System.Windows.Forms.Panel notesPanel;
        private System.Windows.Forms.LinkLabel profileLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}