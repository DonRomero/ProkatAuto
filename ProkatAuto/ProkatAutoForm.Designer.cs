namespace ProkatAuto
{
    partial class ProkatAutoForm
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
            this.reportButton = new System.Windows.Forms.Button();
            this.backupButton = new System.Windows.Forms.Button();
            this.addAutoButton = new System.Windows.Forms.Button();
            this.autoParkLabel = new System.Windows.Forms.Label();
            this.workWithDBLabel = new System.Windows.Forms.Label();
            this.giveAutoButton = new System.Windows.Forms.Button();
            this.getAutoButton = new System.Windows.Forms.Button();
            this.clientLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(245, 45);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(163, 25);
            this.reportButton.TabIndex = 0;
            this.reportButton.Text = "Отчёт";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // backupButton
            // 
            this.backupButton.Location = new System.Drawing.Point(245, 76);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(163, 25);
            this.backupButton.TabIndex = 1;
            this.backupButton.Text = "Бекап";
            this.backupButton.UseVisualStyleBackColor = true;
            // 
            // addAutoButton
            // 
            this.addAutoButton.Location = new System.Drawing.Point(12, 45);
            this.addAutoButton.Name = "addAutoButton";
            this.addAutoButton.Size = new System.Drawing.Size(186, 25);
            this.addAutoButton.TabIndex = 2;
            this.addAutoButton.Text = "Добавить автомобиль";
            this.addAutoButton.UseVisualStyleBackColor = true;
            this.addAutoButton.Click += new System.EventHandler(this.addAutoButton_Click);
            // 
            // autoParkLabel
            // 
            this.autoParkLabel.AutoSize = true;
            this.autoParkLabel.Location = new System.Drawing.Point(12, 13);
            this.autoParkLabel.Name = "autoParkLabel";
            this.autoParkLabel.Size = new System.Drawing.Size(153, 17);
            this.autoParkLabel.TabIndex = 3;
            this.autoParkLabel.Text = "Работа с автопарком:";
            // 
            // workWithDBLabel
            // 
            this.workWithDBLabel.AutoSize = true;
            this.workWithDBLabel.Location = new System.Drawing.Point(242, 13);
            this.workWithDBLabel.Name = "workWithDBLabel";
            this.workWithDBLabel.Size = new System.Drawing.Size(166, 17);
            this.workWithDBLabel.TabIndex = 4;
            this.workWithDBLabel.Text = "Работа с базой данных:";
            // 
            // giveAutoButton
            // 
            this.giveAutoButton.Location = new System.Drawing.Point(12, 136);
            this.giveAutoButton.Name = "giveAutoButton";
            this.giveAutoButton.Size = new System.Drawing.Size(186, 25);
            this.giveAutoButton.TabIndex = 5;
            this.giveAutoButton.Text = "Выдать автомобиль";
            this.giveAutoButton.UseVisualStyleBackColor = true;
            this.giveAutoButton.Click += new System.EventHandler(this.giveAutoButton_Click);
            // 
            // getAutoButton
            // 
            this.getAutoButton.Location = new System.Drawing.Point(12, 167);
            this.getAutoButton.Name = "getAutoButton";
            this.getAutoButton.Size = new System.Drawing.Size(186, 25);
            this.getAutoButton.TabIndex = 6;
            this.getAutoButton.Text = "Принять автомобиль";
            this.getAutoButton.UseVisualStyleBackColor = true;
            this.getAutoButton.Click += new System.EventHandler(this.getAutoButton_Click);
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(12, 104);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(134, 17);
            this.clientLabel.TabIndex = 7;
            this.clientLabel.Text = "Работа с клиентом";
            // 
            // ProkatAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 203);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.getAutoButton);
            this.Controls.Add(this.giveAutoButton);
            this.Controls.Add(this.workWithDBLabel);
            this.Controls.Add(this.autoParkLabel);
            this.Controls.Add(this.addAutoButton);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.reportButton);
            this.Name = "ProkatAutoForm";
            this.Text = "ПрокатАвто";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProkatAutoForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.Button addAutoButton;
        private System.Windows.Forms.Label autoParkLabel;
        private System.Windows.Forms.Label workWithDBLabel;
        private System.Windows.Forms.Button giveAutoButton;
        private System.Windows.Forms.Button getAutoButton;
        private System.Windows.Forms.Label clientLabel;
    }
}

