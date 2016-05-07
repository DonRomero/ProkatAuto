namespace ProkatAuto
{
    partial class AddAutoForm
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
            this.markLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.markTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // markLabel
            // 
            this.markLabel.AutoSize = true;
            this.markLabel.Location = new System.Drawing.Point(12, 19);
            this.markLabel.Name = "markLabel";
            this.markLabel.Size = new System.Drawing.Size(54, 17);
            this.markLabel.TabIndex = 1;
            this.markLabel.Text = "Марка:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(12, 49);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(94, 17);
            this.yearLabel.TabIndex = 2;
            this.yearLabel.Text = "Год выпуска:";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(12, 79);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(45, 17);
            this.colorLabel.TabIndex = 3;
            this.colorLabel.Text = "Цвет:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(12, 109);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(70, 17);
            this.typeLabel.TabIndex = 4;
            this.typeLabel.Text = "Тип КПП:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(215, 141);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 25);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // markTextBox
            // 
            this.markTextBox.Location = new System.Drawing.Point(170, 14);
            this.markTextBox.Name = "markTextBox";
            this.markTextBox.Size = new System.Drawing.Size(250, 22);
            this.markTextBox.TabIndex = 5;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(170, 44);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(250, 22);
            this.yearTextBox.TabIndex = 6;
            this.yearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearTextBox_KeyPress);
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(170, 74);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(250, 22);
            this.colorTextBox.TabIndex = 7;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(170, 104);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(250, 22);
            this.typeTextBox.TabIndex = 8;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(321, 141);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 25);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 178);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.markTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.markLabel);
            this.Name = "AddAutoForm";
            this.Text = "Добавление автомобиля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label markLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox markTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Button cancelButton;
    }
}