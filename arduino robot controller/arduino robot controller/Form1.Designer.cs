namespace arduino_robot_controller
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
            this.EnableButton = new System.Windows.Forms.Button();
            this.DisableButton = new System.Windows.Forms.Button();
            this.EnabledText = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.controllerConnected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnableButton
            // 
            this.EnableButton.Location = new System.Drawing.Point(97, 454);
            this.EnableButton.Name = "EnableButton";
            this.EnableButton.Size = new System.Drawing.Size(75, 23);
            this.EnableButton.TabIndex = 1;
            this.EnableButton.Text = "Enable";
            this.EnableButton.UseVisualStyleBackColor = true;
            this.EnableButton.Click += new System.EventHandler(this.EnableButton_Click);
            // 
            // DisableButton
            // 
            this.DisableButton.Location = new System.Drawing.Point(191, 454);
            this.DisableButton.Name = "DisableButton";
            this.DisableButton.Size = new System.Drawing.Size(75, 23);
            this.DisableButton.TabIndex = 2;
            this.DisableButton.Text = "Disable";
            this.DisableButton.UseVisualStyleBackColor = true;
            this.DisableButton.Click += new System.EventHandler(this.DisableButton_Click);
            // 
            // EnabledText
            // 
            this.EnabledText.AutoSize = true;
            this.EnabledText.Location = new System.Drawing.Point(162, 436);
            this.EnabledText.Name = "EnabledText";
            this.EnabledText.Size = new System.Drawing.Size(38, 15);
            this.EnabledText.TabIndex = 3;
            this.EnabledText.Tag = "";
            this.EnabledText.Text = "label1";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Window;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 39);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.checkedListBox1.Size = new System.Drawing.Size(19, 364);
            this.checkedListBox1.TabIndex = 4;
            // 
            // controllerConnected
            // 
            this.controllerConnected.AutoSize = true;
            this.controllerConnected.Location = new System.Drawing.Point(43, 16);
            this.controllerConnected.Name = "controllerConnected";
            this.controllerConnected.Size = new System.Drawing.Size(38, 15);
            this.controllerConnected.TabIndex = 5;
            this.controllerConnected.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 501);
            this.Controls.Add(this.controllerConnected);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.EnabledText);
            this.Controls.Add(this.DisableButton);
            this.Controls.Add(this.EnableButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button EnableButton;
        private Button DisableButton;
        private Label EnabledText;
        private CheckedListBox checkedListBox1;
        private Label controllerConnected;
    }
}