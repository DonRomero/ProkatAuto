namespace ProkatAuto
{
    partial class GetAutoForm
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
            this.orderLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.prokatComboBox = new System.Windows.Forms.ComboBox();
            this.autoTextBox = new System.Windows.Forms.TextBox();
            this.clientTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.autoLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(12, 24);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(51, 17);
            this.orderLabel.TabIndex = 11;
            this.orderLabel.Text = "Заказ:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(320, 141);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 25);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(214, 141);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 25);
            this.saveButton.TabIndex = 25;
            this.saveButton.Text = "Возврат";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // prokatComboBox
            // 
            this.prokatComboBox.FormattingEnabled = true;
            this.prokatComboBox.Location = new System.Drawing.Point(170, 15);
            this.prokatComboBox.Name = "prokatComboBox";
            this.prokatComboBox.Size = new System.Drawing.Size(250, 24);
            this.prokatComboBox.TabIndex = 27;
            this.prokatComboBox.SelectedIndexChanged += new System.EventHandler(this.prokatComboBox_SelectedIndexChanged);
            // 
            // autoTextBox
            // 
            this.autoTextBox.Location = new System.Drawing.Point(170, 108);
            this.autoTextBox.Name = "autoTextBox";
            this.autoTextBox.ReadOnly = true;
            this.autoTextBox.Size = new System.Drawing.Size(250, 22);
            this.autoTextBox.TabIndex = 33;
            // 
            // clientTextBox
            // 
            this.clientTextBox.Location = new System.Drawing.Point(170, 78);
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.ReadOnly = true;
            this.clientTextBox.Size = new System.Drawing.Size(250, 22);
            this.clientTextBox.TabIndex = 32;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(170, 48);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(250, 22);
            this.dateTextBox.TabIndex = 31;
            // 
            // autoLabel
            // 
            this.autoLabel.AutoSize = true;
            this.autoLabel.Location = new System.Drawing.Point(12, 113);
            this.autoLabel.Name = "autoLabel";
            this.autoLabel.Size = new System.Drawing.Size(91, 17);
            this.autoLabel.TabIndex = 30;
            this.autoLabel.Text = "Автомобиль:";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(12, 83);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(74, 17);
            this.clientLabel.TabIndex = 29;
            this.clientLabel.Text = "Заказчик:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 53);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 17);
            this.dateLabel.TabIndex = 28;
            this.dateLabel.Text = "От:";
            // 
            // GetAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 178);
            this.Controls.Add(this.autoTextBox);
            this.Controls.Add(this.clientTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.autoLabel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.prokatComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.orderLabel);
            this.Name = "GetAutoForm";
            this.Text = "Возврат автомобиля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox prokatComboBox;
        private System.Windows.Forms.TextBox autoTextBox;
        private System.Windows.Forms.TextBox clientTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label autoLabel;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}