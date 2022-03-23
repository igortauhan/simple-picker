namespace simple_picker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pickButton = new System.Windows.Forms.Button();
            this.hexLabel = new System.Windows.Forms.Label();
            this.hexLabelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pickButton
            // 
            this.pickButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pickButton.Location = new System.Drawing.Point(112, 210);
            this.pickButton.Margin = new System.Windows.Forms.Padding(0);
            this.pickButton.Name = "pickButton";
            this.pickButton.Size = new System.Drawing.Size(75, 20);
            this.pickButton.TabIndex = 0;
            this.pickButton.Text = "Pick";
            this.pickButton.UseVisualStyleBackColor = true;
            this.pickButton.Click += new System.EventHandler(this.pickButton_Click);
            // 
            // hexLabel
            // 
            this.hexLabel.AutoSize = true;
            this.hexLabel.Location = new System.Drawing.Point(28, 105);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(63, 15);
            this.hexLabel.TabIndex = 1;
            this.hexLabel.Text = "Hex Color:";
            // 
            // hexLabelText
            // 
            this.hexLabelText.AutoSize = true;
            this.hexLabelText.Location = new System.Drawing.Point(97, 105);
            this.hexLabelText.Name = "hexLabelText";
            this.hexLabelText.Size = new System.Drawing.Size(56, 15);
            this.hexLabelText.TabIndex = 2;
            this.hexLabelText.Text = "#######";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.hexLabelText);
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.pickButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Simple Picker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button pickButton;
        private Label hexLabel;
        private Label hexLabelText;
    }
}