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
            this.components = new System.ComponentModel.Container();
            this.EnableButton = new System.Windows.Forms.Button();
            this.DisableButton = new System.Windows.Forms.Button();
            this.EnabledText = new System.Windows.Forms.Label();
            this.buttonDisplay = new System.Windows.Forms.CheckedListBox();
            this.controllerConnected = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.connectionMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comPorts = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // EnableButton
            // 
            this.EnableButton.Location = new System.Drawing.Point(154, 440);
            this.EnableButton.Name = "EnableButton";
            this.EnableButton.Size = new System.Drawing.Size(75, 23);
            this.EnableButton.TabIndex = 1;
            this.EnableButton.Text = "Enable";
            this.EnableButton.UseVisualStyleBackColor = true;
            this.EnableButton.Click += new System.EventHandler(this.EnableButton_Click);
            // 
            // DisableButton
            // 
            this.DisableButton.Location = new System.Drawing.Point(248, 440);
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
            this.EnabledText.Location = new System.Drawing.Point(191, 422);
            this.EnabledText.Name = "EnabledText";
            this.EnabledText.Size = new System.Drawing.Size(38, 15);
            this.EnabledText.TabIndex = 3;
            this.EnabledText.Tag = "";
            this.EnabledText.Text = "label1";
            this.EnabledText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.buttonDisplay.FormattingEnabled = true;
            this.buttonDisplay.Location = new System.Drawing.Point(12, 64);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.buttonDisplay.Size = new System.Drawing.Size(48, 274);
            this.buttonDisplay.TabIndex = 4;
            // 
            // controllerConnected
            // 
            this.controllerConnected.AutoSize = true;
            this.controllerConnected.Location = new System.Drawing.Point(95, 9);
            this.controllerConnected.Name = "controllerConnected";
            this.controllerConnected.Size = new System.Drawing.Size(38, 15);
            this.controllerConnected.TabIndex = 5;
            this.controllerConnected.Text = "label1";
            // 
            // connectionMode
            // 
            this.connectionMode.AllowDrop = true;
            this.connectionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.connectionMode.FormattingEnabled = true;
            this.connectionMode.Items.AddRange(new object[] {
            "Serial",
            "Wifi",
            "Bluetooth"});
            this.connectionMode.Location = new System.Drawing.Point(12, 440);
            this.connectionMode.Name = "connectionMode";
            this.connectionMode.Size = new System.Drawing.Size(121, 23);
            this.connectionMode.TabIndex = 6;
            this.connectionMode.SelectedIndexChanged += new System.EventHandler(this.connectionMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Connection Mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Buttons";
            // 
            // comPorts
            // 
            this.comPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPorts.FormattingEnabled = true;
            this.comPorts.Location = new System.Drawing.Point(202, 347);
            this.comPorts.Name = "comPorts";
            this.comPorts.Size = new System.Drawing.Size(121, 23);
            this.comPorts.TabIndex = 9;
            this.comPorts.SelectedIndexChanged += new System.EventHandler(this.comPorts_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 501);
            this.Controls.Add(this.comPorts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectionMode);
            this.Controls.Add(this.controllerConnected);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.EnabledText);
            this.Controls.Add(this.DisableButton);
            this.Controls.Add(this.EnableButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino Driver Station";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button EnableButton;
        private Button DisableButton;
        private Label EnabledText;
        private CheckedListBox buttonDisplay;
        private Label controllerConnected;
        private BindingSource bindingSource1;
        private ComboBox connectionMode;
        private Label label1;
        private Label label2;
        private ComboBox comPorts;
    }
}