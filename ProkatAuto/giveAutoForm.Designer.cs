namespace ProkatAuto
{
    partial class GiveAutoForm
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
            this.autoComboBox = new System.Windows.Forms.ComboBox();
            this.autoLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.newClientButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // autoComboBox
            // 
            this.autoComboBox.FormattingEnabled = true;
            this.autoComboBox.Location = new System.Drawing.Point(161, 15);
            this.autoComboBox.Name = "autoComboBox";
            this.autoComboBox.Size = new System.Drawing.Size(259, 24);
            this.autoComboBox.TabIndex = 0;
            // 
            // autoLabel
            // 
            this.autoLabel.AutoSize = true;
            this.autoLabel.Location = new System.Drawing.Point(12, 22);
            this.autoLabel.Name = "autoLabel";
            this.autoLabel.Size = new System.Drawing.Size(143, 17);
            this.autoLabel.TabIndex = 2;
            this.autoLabel.Text = "Выдать автомобиль:";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(12, 52);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(60, 17);
            this.clientLabel.TabIndex = 3;
            this.clientLabel.Text = "Клиент:";
            // 
            // clientComboBox
            // 
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(161, 45);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(178, 24);
            this.clientComboBox.TabIndex = 4;
            // 
            // newClientButton
            // 
            this.newClientButton.Location = new System.Drawing.Point(345, 45);
            this.newClientButton.Name = "newClientButton";
            this.newClientButton.Size = new System.Drawing.Size(75, 25);
            this.newClientButton.TabIndex = 5;
            this.newClientButton.Text = "Новый...";
            this.newClientButton.UseVisualStyleBackColor = true;
            this.newClientButton.Click += new System.EventHandler(this.newClientButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(214, 91);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 25);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Готово";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(320, 91);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 25);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // GiveAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 128);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newClientButton);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.autoLabel);
            this.Controls.Add(this.autoComboBox);
            this.Name = "GiveAutoForm";
            this.Text = "Выдача автомобиля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox autoComboBox;
        private System.Windows.Forms.Label autoLabel;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.Button newClientButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}