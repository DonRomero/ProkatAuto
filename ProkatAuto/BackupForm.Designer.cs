namespace ProkatAuto
{
    partial class BackupForm
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
            this.autoGridView = new System.Windows.Forms.DataGridView();
            this.clientGridView = new System.Windows.Forms.DataGridView();
            this.prokatGridView = new System.Windows.Forms.DataGridView();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.autoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prokatGridView)).BeginInit();
            this.dataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // autoGridView
            // 
            this.autoGridView.AllowUserToAddRows = false;
            this.autoGridView.AllowUserToDeleteRows = false;
            this.autoGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.autoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autoGridView.Location = new System.Drawing.Point(3, 3);
            this.autoGridView.Name = "autoGridView";
            this.autoGridView.RowTemplate.Height = 24;
            this.autoGridView.Size = new System.Drawing.Size(733, 169);
            this.autoGridView.TabIndex = 0;
            // 
            // clientGridView
            // 
            this.clientGridView.AllowUserToAddRows = false;
            this.clientGridView.AllowUserToDeleteRows = false;
            this.clientGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientGridView.Location = new System.Drawing.Point(3, 178);
            this.clientGridView.Name = "clientGridView";
            this.clientGridView.ReadOnly = true;
            this.clientGridView.RowTemplate.Height = 24;
            this.clientGridView.Size = new System.Drawing.Size(733, 169);
            this.clientGridView.TabIndex = 1;
            // 
            // prokatGridView
            // 
            this.prokatGridView.AllowUserToAddRows = false;
            this.prokatGridView.AllowUserToDeleteRows = false;
            this.prokatGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prokatGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prokatGridView.Location = new System.Drawing.Point(3, 353);
            this.prokatGridView.Name = "prokatGridView";
            this.prokatGridView.RowTemplate.Height = 24;
            this.prokatGridView.Size = new System.Drawing.Size(733, 169);
            this.prokatGridView.TabIndex = 2;
            // 
            // dataPanel
            // 
            this.dataPanel.AutoScroll = true;
            this.dataPanel.Controls.Add(this.autoGridView);
            this.dataPanel.Controls.Add(this.prokatGridView);
            this.dataPanel.Controls.Add(this.clientGridView);
            this.dataPanel.Location = new System.Drawing.Point(12, 12);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(760, 316);
            this.dataPanel.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(680, 334);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 25);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(574, 334);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 25);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 369);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataPanel);
            this.Name = "BackupForm";
            this.Text = "BackupForm";
            ((System.ComponentModel.ISupportInitialize)(this.autoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prokatGridView)).EndInit();
            this.dataPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView autoGridView;
        private System.Windows.Forms.DataGridView clientGridView;
        private System.Windows.Forms.DataGridView prokatGridView;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
    }
}