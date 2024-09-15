namespace Lab03
{
    partial class fMain
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
            this.tbSubscribersInfo = new System.Windows.Forms.TextBox();
            this.btnAddSubscriber = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSubscribersInfo
            // 
            this.tbSubscribersInfo.Location = new System.Drawing.Point(12, 19);
            this.tbSubscribersInfo.Multiline = true;
            this.tbSubscribersInfo.Name = "tbSubscribersInfo";
            this.tbSubscribersInfo.ReadOnly = true;
            this.tbSubscribersInfo.Size = new System.Drawing.Size(807, 412);
            this.tbSubscribersInfo.TabIndex = 0;
            // 
            // btnAddSubscriber
            // 
            this.btnAddSubscriber.Location = new System.Drawing.Point(875, 19);
            this.btnAddSubscriber.Name = "btnAddSubscriber";
            this.btnAddSubscriber.Size = new System.Drawing.Size(192, 63);
            this.btnAddSubscriber.TabIndex = 2;
            this.btnAddSubscriber.Text = "Додати абонента";
            this.btnAddSubscriber.UseVisualStyleBackColor = true;
            this.btnAddSubscriber.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(875, 368);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(192, 63);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddSubscriber);
            this.Controls.Add(this.tbSubscribersInfo);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSubscribersInfo;
        private System.Windows.Forms.Button btnAddSubscriber;
        private System.Windows.Forms.Button btnClose;
    }
}

