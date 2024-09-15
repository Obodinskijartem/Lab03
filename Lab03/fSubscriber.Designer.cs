namespace Lab03
{
    partial class fSubscriber
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMonthlyFee = new System.Windows.Forms.TextBox();
            this.tbSMSPerMonth = new System.Windows.Forms.TextBox();
            this.tbCallMinutes = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbHasRoaming = new System.Windows.Forms.CheckBox();
            this.chbHasDataPlan = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMonthlyFee);
            this.groupBox1.Controls.Add(this.tbSMSPerMonth);
            this.groupBox1.Controls.Add(this.tbCallMinutes);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.tbPhoneNumber);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні дані";
            // 
            // tbMonthlyFee
            // 
            this.tbMonthlyFee.Location = new System.Drawing.Point(212, 180);
            this.tbMonthlyFee.Name = "tbMonthlyFee";
            this.tbMonthlyFee.Size = new System.Drawing.Size(115, 22);
            this.tbMonthlyFee.TabIndex = 10;
            // 
            // tbSMSPerMonth
            // 
            this.tbSMSPerMonth.Location = new System.Drawing.Point(212, 152);
            this.tbSMSPerMonth.Name = "tbSMSPerMonth";
            this.tbSMSPerMonth.Size = new System.Drawing.Size(115, 22);
            this.tbSMSPerMonth.TabIndex = 9;
            this.tbSMSPerMonth.TextChanged += new System.EventHandler(this.tbCallMinutes_TextChanged);
            // 
            // tbCallMinutes
            // 
            this.tbCallMinutes.Location = new System.Drawing.Point(212, 124);
            this.tbCallMinutes.Name = "tbCallMinutes";
            this.tbCallMinutes.Size = new System.Drawing.Size(115, 22);
            this.tbCallMinutes.TabIndex = 8;
            this.tbCallMinutes.TextChanged += new System.EventHandler(this.tbSMSPerMonth_TextChanged);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(212, 96);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(115, 22);
            this.tbAddress.TabIndex = 7;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(212, 68);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(115, 22);
            this.tbPhoneNumber.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(212, 36);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(115, 22);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Місячний платіж";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Кількість SMS на місяць";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Кількість дзвінків на місяць";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Адреса абонента";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер телефону";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ім\'я абонента";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbHasRoaming);
            this.groupBox2.Controls.Add(this.chbHasDataPlan);
            this.groupBox2.Location = new System.Drawing.Point(12, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Абонентська інформація";
            // 
            // chbHasRoaming
            // 
            this.chbHasRoaming.AutoSize = true;
            this.chbHasRoaming.Location = new System.Drawing.Point(24, 76);
            this.chbHasRoaming.Name = "chbHasRoaming";
            this.chbHasRoaming.Size = new System.Drawing.Size(166, 20);
            this.chbHasRoaming.TabIndex = 3;
            this.chbHasRoaming.Text = "Абонент має роумінг";
            this.chbHasRoaming.UseVisualStyleBackColor = true;
            this.chbHasRoaming.CheckedChanged += new System.EventHandler(this.chbHasRoaming_CheckedChanged);
            // 
            // chbHasDataPlan
            // 
            this.chbHasDataPlan.AutoSize = true;
            this.chbHasDataPlan.Location = new System.Drawing.Point(24, 36);
            this.chbHasDataPlan.Name = "chbHasDataPlan";
            this.chbHasDataPlan.Size = new System.Drawing.Size(246, 20);
            this.chbHasDataPlan.TabIndex = 2;
            this.chbHasDataPlan.Text = "Абонент має тариф з інтернетом";
            this.chbHasDataPlan.UseVisualStyleBackColor = true;
            this.chbHasDataPlan.CheckedChanged += new System.EventHandler(this.chbHasDataPlan_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(403, 36);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(154, 44);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(403, 108);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 44);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // fSubscriber
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(613, 430);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "fSubscriber";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fSubscriber_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbMonthlyFee;
        private System.Windows.Forms.TextBox tbSMSPerMonth;
        private System.Windows.Forms.TextBox tbCallMinutes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbHasRoaming;
        private System.Windows.Forms.CheckBox chbHasDataPlan;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}