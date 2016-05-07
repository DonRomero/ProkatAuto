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
            this.autoGroupBox = new System.Windows.Forms.GroupBox();
            this.addAutoButton = new System.Windows.Forms.Button();
            this.clientGroupBox = new System.Windows.Forms.GroupBox();
            this.getAutoButton = new System.Windows.Forms.Button();
            this.giveAutoButton = new System.Windows.Forms.Button();
            this.dbGroupBox = new System.Windows.Forms.GroupBox();
            this.backupButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.autoGroupBox.SuspendLayout();
            this.clientGroupBox.SuspendLayout();
            this.dbGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // autoGroupBox
            // 
            this.autoGroupBox.Controls.Add(this.addAutoButton);
            this.autoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.autoGroupBox.Name = "autoGroupBox";
            this.autoGroupBox.Size = new System.Drawing.Size(200, 89);
            this.autoGroupBox.TabIndex = 8;
            this.autoGroupBox.TabStop = false;
            this.autoGroupBox.Text = "Работа с автопарком";
            // 
            // addAutoButton
            // 
            this.addAutoButton.Location = new System.Drawing.Point(6, 21);
            this.addAutoButton.Name = "addAutoButton";
            this.addAutoButton.Size = new System.Drawing.Size(188, 25);
            this.addAutoButton.TabIndex = 9;
            this.addAutoButton.Text = "Добавить автомобиль";
            this.addAutoButton.UseVisualStyleBackColor = true;
            this.addAutoButton.Click += new System.EventHandler(this.addAutoButton_Click);
            // 
            // clientGroupBox
            // 
            this.clientGroupBox.Controls.Add(this.getAutoButton);
            this.clientGroupBox.Controls.Add(this.giveAutoButton);
            this.clientGroupBox.Location = new System.Drawing.Point(13, 108);
            this.clientGroupBox.Name = "clientGroupBox";
            this.clientGroupBox.Size = new System.Drawing.Size(200, 83);
            this.clientGroupBox.TabIndex = 9;
            this.clientGroupBox.TabStop = false;
            this.clientGroupBox.Text = "Работа с клиентом";
            // 
            // getAutoButton
            // 
            this.getAutoButton.Location = new System.Drawing.Point(6, 52);
            this.getAutoButton.Name = "getAutoButton";
            this.getAutoButton.Size = new System.Drawing.Size(187, 25);
            this.getAutoButton.TabIndex = 8;
            this.getAutoButton.Text = "Принять автомобиль";
            this.getAutoButton.UseVisualStyleBackColor = true;
            this.getAutoButton.Click += new System.EventHandler(this.getAutoButton_Click);
            // 
            // giveAutoButton
            // 
            this.giveAutoButton.Location = new System.Drawing.Point(6, 21);
            this.giveAutoButton.Name = "giveAutoButton";
            this.giveAutoButton.Size = new System.Drawing.Size(187, 25);
            this.giveAutoButton.TabIndex = 7;
            this.giveAutoButton.Text = "Выдать автомобиль";
            this.giveAutoButton.UseVisualStyleBackColor = true;
            this.giveAutoButton.Click += new System.EventHandler(this.giveAutoButton_Click);
            // 
            // dbGroupBox
            // 
            this.dbGroupBox.Controls.Add(this.backupButton);
            this.dbGroupBox.Controls.Add(this.reportButton);
            this.dbGroupBox.Location = new System.Drawing.Point(220, 12);
            this.dbGroupBox.Name = "dbGroupBox";
            this.dbGroupBox.Size = new System.Drawing.Size(200, 179);
            this.dbGroupBox.TabIndex = 10;
            this.dbGroupBox.TabStop = false;
            this.dbGroupBox.Text = "Работа с базой данных";
            // 
            // backupButton
            // 
            this.backupButton.Location = new System.Drawing.Point(6, 52);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(188, 25);
            this.backupButton.TabIndex = 3;
            this.backupButton.Text = "Бекап";
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.MouseCaptureChanged += new System.EventHandler(this.backupButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(6, 21);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(188, 25);
            this.reportButton.TabIndex = 2;
            this.reportButton.Text = "Отчёт";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // ProkatAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 203);
            this.Controls.Add(this.dbGroupBox);
            this.Controls.Add(this.clientGroupBox);
            this.Controls.Add(this.autoGroupBox);
            this.Name = "ProkatAutoForm";
            this.Text = "ПрокатАвто";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProkatAutoForm_FormClosed);
            this.autoGroupBox.ResumeLayout(false);
            this.clientGroupBox.ResumeLayout(false);
            this.dbGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox autoGroupBox;
        private System.Windows.Forms.Button addAutoButton;
        private System.Windows.Forms.GroupBox clientGroupBox;
        private System.Windows.Forms.Button getAutoButton;
        private System.Windows.Forms.Button giveAutoButton;
        private System.Windows.Forms.GroupBox dbGroupBox;
        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.Button reportButton;
    }
}

