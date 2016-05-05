namespace ProkatAuto
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.giveAutoButton = new System.Windows.Forms.Button();
            this.getAutoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(245, 45);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(163, 23);
            this.reportButton.TabIndex = 0;
            this.reportButton.Text = "Отчёт";
            this.reportButton.UseVisualStyleBackColor = true;
            // 
            // backupButton
            // 
            this.backupButton.Location = new System.Drawing.Point(245, 74);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(163, 23);
            this.backupButton.TabIndex = 1;
            this.backupButton.Text = "Бекап";
            this.backupButton.UseVisualStyleBackColor = true;
            // 
            // addAutoButton
            // 
            this.addAutoButton.Location = new System.Drawing.Point(12, 45);
            this.addAutoButton.Name = "addAutoButton";
            this.addAutoButton.Size = new System.Drawing.Size(186, 23);
            this.addAutoButton.TabIndex = 2;
            this.addAutoButton.Text = "Добавить автомобиль";
            this.addAutoButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Работа с автопарком:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Работа с базой данных:";
            // 
            // giveAutoButton
            // 
            this.giveAutoButton.Location = new System.Drawing.Point(12, 99);
            this.giveAutoButton.Name = "giveAutoButton";
            this.giveAutoButton.Size = new System.Drawing.Size(186, 23);
            this.giveAutoButton.TabIndex = 5;
            this.giveAutoButton.Text = "Выдать автомобиль";
            this.giveAutoButton.UseVisualStyleBackColor = true;
            // 
            // getAutoButton
            // 
            this.getAutoButton.Location = new System.Drawing.Point(15, 129);
            this.getAutoButton.Name = "getAutoButton";
            this.getAutoButton.Size = new System.Drawing.Size(183, 23);
            this.getAutoButton.TabIndex = 6;
            this.getAutoButton.Text = "Принять автомобиль";
            this.getAutoButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 205);
            this.Controls.Add(this.getAutoButton);
            this.Controls.Add(this.giveAutoButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addAutoButton);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.reportButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.Button addAutoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button giveAutoButton;
        private System.Windows.Forms.Button getAutoButton;
    }
}

