namespace MyTestListProject
{
    partial class TestListProject
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.InTextBox = new System.Windows.Forms.TextBox();
            this.OutTextBox = new System.Windows.Forms.TextBox();
            this.WriteListButton = new System.Windows.Forms.Button();
            this.AddStartButton = new System.Windows.Forms.Button();
            this.AddEndButton = new System.Windows.Forms.Button();
            this.AddAfterIndexButton = new System.Windows.Forms.Button();
            this.DeleteValueButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InTextBox
            // 
            this.InTextBox.Location = new System.Drawing.Point(12, 12);
            this.InTextBox.Name = "InTextBox";
            this.InTextBox.Size = new System.Drawing.Size(116, 20);
            this.InTextBox.TabIndex = 0;
            this.InTextBox.Click += new System.EventHandler(this.InTextBox_Click);
            // 
            // OutTextBox
            // 
            this.OutTextBox.Location = new System.Drawing.Point(12, 93);
            this.OutTextBox.Multiline = true;
            this.OutTextBox.Name = "OutTextBox";
            this.OutTextBox.ReadOnly = true;
            this.OutTextBox.Size = new System.Drawing.Size(532, 350);
            this.OutTextBox.TabIndex = 0;
            // 
            // WriteListButton
            // 
            this.WriteListButton.Location = new System.Drawing.Point(598, 12);
            this.WriteListButton.Name = "WriteListButton";
            this.WriteListButton.Size = new System.Drawing.Size(135, 30);
            this.WriteListButton.TabIndex = 1;
            this.WriteListButton.Text = "WriteList";
            this.WriteListButton.UseVisualStyleBackColor = true;
            this.WriteListButton.Click += new System.EventHandler(this.WriteListButton_Click);
            // 
            // AddStartButton
            // 
            this.AddStartButton.Location = new System.Drawing.Point(598, 87);
            this.AddStartButton.Name = "AddStartButton";
            this.AddStartButton.Size = new System.Drawing.Size(135, 30);
            this.AddStartButton.TabIndex = 1;
            this.AddStartButton.Text = "AddStart";
            this.AddStartButton.UseVisualStyleBackColor = true;
            this.AddStartButton.Click += new System.EventHandler(this.AddStartButton_Click);
            // 
            // AddEndButton
            // 
            this.AddEndButton.Location = new System.Drawing.Point(598, 123);
            this.AddEndButton.Name = "AddEndButton";
            this.AddEndButton.Size = new System.Drawing.Size(135, 30);
            this.AddEndButton.TabIndex = 1;
            this.AddEndButton.Text = "AddEnd";
            this.AddEndButton.UseVisualStyleBackColor = true;
            this.AddEndButton.Click += new System.EventHandler(this.AddEndButton_Click);
            // 
            // AddAfterIndexButton
            // 
            this.AddAfterIndexButton.Location = new System.Drawing.Point(598, 159);
            this.AddAfterIndexButton.Name = "AddAfterIndexButton";
            this.AddAfterIndexButton.Size = new System.Drawing.Size(135, 30);
            this.AddAfterIndexButton.TabIndex = 1;
            this.AddAfterIndexButton.Text = "AddAfterIndex";
            this.AddAfterIndexButton.UseVisualStyleBackColor = true;
            this.AddAfterIndexButton.Click += new System.EventHandler(this.AddAfterIndexButton_Click);
            // 
            // DeleteValueButton
            // 
            this.DeleteValueButton.Location = new System.Drawing.Point(598, 195);
            this.DeleteValueButton.Name = "DeleteValueButton";
            this.DeleteValueButton.Size = new System.Drawing.Size(135, 30);
            this.DeleteValueButton.TabIndex = 1;
            this.DeleteValueButton.Text = "DeleteValue";
            this.DeleteValueButton.UseVisualStyleBackColor = true;
            this.DeleteValueButton.Click += new System.EventHandler(this.DeleteValueButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClearButton.Location = new System.Drawing.Point(598, 48);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(135, 30);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // TestListProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 455);
            this.Controls.Add(this.DeleteValueButton);
            this.Controls.Add(this.AddAfterIndexButton);
            this.Controls.Add(this.AddEndButton);
            this.Controls.Add(this.AddStartButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.WriteListButton);
            this.Controls.Add(this.OutTextBox);
            this.Controls.Add(this.InTextBox);
            this.Name = "TestListProject";
            this.Text = "TestList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InTextBox;
        private System.Windows.Forms.TextBox OutTextBox;
        private System.Windows.Forms.Button WriteListButton;
        private System.Windows.Forms.Button AddStartButton;
        private System.Windows.Forms.Button AddEndButton;
        private System.Windows.Forms.Button AddAfterIndexButton;
        private System.Windows.Forms.Button DeleteValueButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

