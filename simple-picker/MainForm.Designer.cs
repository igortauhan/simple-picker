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
            this.titleLabel = new System.Windows.Forms.Label();
            this.rgbLabel = new System.Windows.Forms.Label();
            this.rgbTextBox = new System.Windows.Forms.TextBox();
            this.hexLabel = new System.Windows.Forms.Label();
            this.hexTextBox = new System.Windows.Forms.TextBox();
            this.rgbButtonCpy = new System.Windows.Forms.Button();
            this.hexButtonCpy = new System.Windows.Forms.Button();
            this.argbLabel = new System.Windows.Forms.Label();
            this.argbTextBox = new System.Windows.Forms.TextBox();
            this.argbButtonCpy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(61, 18);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(178, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Simple Color Picker";
            // 
            // rgbLabel
            // 
            this.rgbLabel.AutoSize = true;
            this.rgbLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgbLabel.Location = new System.Drawing.Point(12, 68);
            this.rgbLabel.Name = "rgbLabel";
            this.rgbLabel.Size = new System.Drawing.Size(40, 21);
            this.rgbLabel.TabIndex = 1;
            this.rgbLabel.Text = "RGB";
            // 
            // rgbTextBox
            // 
            this.rgbTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgbTextBox.Location = new System.Drawing.Point(66, 70);
            this.rgbTextBox.Name = "rgbTextBox";
            this.rgbTextBox.ReadOnly = true;
            this.rgbTextBox.Size = new System.Drawing.Size(157, 23);
            this.rgbTextBox.TabIndex = 2;
            // 
            // hexLabel
            // 
            this.hexLabel.AutoSize = true;
            this.hexLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hexLabel.Location = new System.Drawing.Point(12, 172);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(36, 21);
            this.hexLabel.TabIndex = 3;
            this.hexLabel.Text = "Hex";
            // 
            // hexTextBox
            // 
            this.hexTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hexTextBox.Location = new System.Drawing.Point(66, 174);
            this.hexTextBox.Name = "hexTextBox";
            this.hexTextBox.ReadOnly = true;
            this.hexTextBox.Size = new System.Drawing.Size(157, 23);
            this.hexTextBox.TabIndex = 4;
            // 
            // rgbButtonCpy
            // 
            this.rgbButtonCpy.Location = new System.Drawing.Point(237, 69);
            this.rgbButtonCpy.Name = "rgbButtonCpy";
            this.rgbButtonCpy.Size = new System.Drawing.Size(55, 24);
            this.rgbButtonCpy.TabIndex = 5;
            this.rgbButtonCpy.Text = "Copy";
            this.rgbButtonCpy.UseVisualStyleBackColor = true;
            this.rgbButtonCpy.Click += new System.EventHandler(this.rgbButtonCpy_Click);
            // 
            // hexButtonCpy
            // 
            this.hexButtonCpy.Location = new System.Drawing.Point(237, 174);
            this.hexButtonCpy.Name = "hexButtonCpy";
            this.hexButtonCpy.Size = new System.Drawing.Size(55, 23);
            this.hexButtonCpy.TabIndex = 6;
            this.hexButtonCpy.Text = "Copy";
            this.hexButtonCpy.UseVisualStyleBackColor = true;
            this.hexButtonCpy.Click += new System.EventHandler(this.hexButtonCpy_Click);
            // 
            // argbLabel
            // 
            this.argbLabel.AutoSize = true;
            this.argbLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.argbLabel.Location = new System.Drawing.Point(12, 120);
            this.argbLabel.Name = "argbLabel";
            this.argbLabel.Size = new System.Drawing.Size(48, 21);
            this.argbLabel.TabIndex = 7;
            this.argbLabel.Text = "aRGB";
            // 
            // argbTextBox
            // 
            this.argbTextBox.Location = new System.Drawing.Point(66, 122);
            this.argbTextBox.Name = "argbTextBox";
            this.argbTextBox.ReadOnly = true;
            this.argbTextBox.Size = new System.Drawing.Size(157, 23);
            this.argbTextBox.TabIndex = 8;
            // 
            // argbButtonCpy
            // 
            this.argbButtonCpy.Location = new System.Drawing.Point(237, 122);
            this.argbButtonCpy.Name = "argbButtonCpy";
            this.argbButtonCpy.Size = new System.Drawing.Size(55, 23);
            this.argbButtonCpy.TabIndex = 9;
            this.argbButtonCpy.Text = "Copy";
            this.argbButtonCpy.UseVisualStyleBackColor = true;
            this.argbButtonCpy.Click += new System.EventHandler(this.argbButtonCpy_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 226);
            this.Controls.Add(this.argbButtonCpy);
            this.Controls.Add(this.argbTextBox);
            this.Controls.Add(this.argbLabel);
            this.Controls.Add(this.hexButtonCpy);
            this.Controls.Add(this.rgbButtonCpy);
            this.Controls.Add(this.hexTextBox);
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.rgbTextBox);
            this.Controls.Add(this.rgbLabel);
            this.Controls.Add(this.titleLabel);
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

        private Label titleLabel;
        private Label rgbLabel;
        public TextBox rgbTextBox;
        private Label hexLabel;
        public TextBox hexTextBox;
        private Button rgbButtonCpy;
        private Button hexButtonCpy;
        private Label argbLabel;
        public TextBox argbTextBox;
        private Button argbButtonCpy;
    }
}