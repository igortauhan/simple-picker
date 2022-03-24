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
            this.valuesLabel = new System.Windows.Forms.Label();
            this.rgbLabel = new System.Windows.Forms.Label();
            this.rgbTextBox = new System.Windows.Forms.TextBox();
            this.hexLabel = new System.Windows.Forms.Label();
            this.hexTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // valuesLabel
            // 
            this.valuesLabel.AutoSize = true;
            this.valuesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valuesLabel.Location = new System.Drawing.Point(122, 9);
            this.valuesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.valuesLabel.Name = "valuesLabel";
            this.valuesLabel.Size = new System.Drawing.Size(55, 21);
            this.valuesLabel.TabIndex = 0;
            this.valuesLabel.Text = "Values";
            // 
            // rgbLabel
            // 
            this.rgbLabel.AutoSize = true;
            this.rgbLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgbLabel.Location = new System.Drawing.Point(12, 72);
            this.rgbLabel.Name = "rgbLabel";
            this.rgbLabel.Size = new System.Drawing.Size(40, 21);
            this.rgbLabel.TabIndex = 1;
            this.rgbLabel.Text = "RGB";
            // 
            // rgbTextBox
            // 
            this.rgbTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgbTextBox.Location = new System.Drawing.Point(79, 69);
            this.rgbTextBox.Name = "rgbTextBox";
            this.rgbTextBox.ReadOnly = true;
            this.rgbTextBox.Size = new System.Drawing.Size(142, 29);
            this.rgbTextBox.TabIndex = 2;
            // 
            // hexLabel
            // 
            this.hexLabel.AutoSize = true;
            this.hexLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hexLabel.Location = new System.Drawing.Point(12, 125);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(36, 21);
            this.hexLabel.TabIndex = 3;
            this.hexLabel.Text = "Hex";
            // 
            // hexTextBox
            // 
            this.hexTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hexTextBox.Location = new System.Drawing.Point(79, 122);
            this.hexTextBox.Name = "hexTextBox";
            this.hexTextBox.ReadOnly = true;
            this.hexTextBox.Size = new System.Drawing.Size(142, 29);
            this.hexTextBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.hexTextBox);
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.rgbTextBox);
            this.Controls.Add(this.rgbLabel);
            this.Controls.Add(this.valuesLabel);
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

        private Label valuesLabel;
        private Label rgbLabel;
        private TextBox rgbTextBox;
        private Label hexLabel;
        private TextBox hexTextBox;
    }
}