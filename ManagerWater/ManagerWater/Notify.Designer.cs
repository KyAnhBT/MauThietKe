namespace ManagerWater
{
    partial class Notify
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
            this.btn_convertToEuro = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lb_dollar = new System.Windows.Forms.Label();
            this.btn_convertToDollar = new System.Windows.Forms.Button();
            this.lb_cost = new System.Windows.Forms.Label();
            this.lb_used = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_Pay = new System.Windows.Forms.Label();
            this.labelPay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_convertToEuro
            // 
            this.btn_convertToEuro.BackColor = System.Drawing.Color.Navy;
            this.btn_convertToEuro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_convertToEuro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_convertToEuro.Location = new System.Drawing.Point(646, 209);
            this.btn_convertToEuro.Name = "btn_convertToEuro";
            this.btn_convertToEuro.Size = new System.Drawing.Size(89, 38);
            this.btn_convertToEuro.TabIndex = 23;
            this.btn_convertToEuro.Text = "Euro";
            this.btn_convertToEuro.UseVisualStyleBackColor = false;
            this.btn_convertToEuro.Click += new System.EventHandler(this.btn_convertToEuro_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(530, 175);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 25);
            this.label15.TabIndex = 26;
            this.label15.Text = "VND";
            // 
            // lb_dollar
            // 
            this.lb_dollar.AutoSize = true;
            this.lb_dollar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_dollar.ForeColor = System.Drawing.Color.Navy;
            this.lb_dollar.Location = new System.Drawing.Point(376, 217);
            this.lb_dollar.Name = "lb_dollar";
            this.lb_dollar.Size = new System.Drawing.Size(24, 25);
            this.lb_dollar.TabIndex = 25;
            this.lb_dollar.Text = "0";
            // 
            // btn_convertToDollar
            // 
            this.btn_convertToDollar.BackColor = System.Drawing.Color.Navy;
            this.btn_convertToDollar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_convertToDollar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_convertToDollar.Location = new System.Drawing.Point(530, 209);
            this.btn_convertToDollar.Name = "btn_convertToDollar";
            this.btn_convertToDollar.Size = new System.Drawing.Size(91, 38);
            this.btn_convertToDollar.TabIndex = 24;
            this.btn_convertToDollar.Text = "Dollar";
            this.btn_convertToDollar.UseVisualStyleBackColor = false;
            this.btn_convertToDollar.Click += new System.EventHandler(this.btn_convertToDollar_Click);
            // 
            // lb_cost
            // 
            this.lb_cost.AutoSize = true;
            this.lb_cost.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_cost.ForeColor = System.Drawing.Color.Navy;
            this.lb_cost.Location = new System.Drawing.Point(376, 76);
            this.lb_cost.Name = "lb_cost";
            this.lb_cost.Size = new System.Drawing.Size(42, 25);
            this.lb_cost.TabIndex = 22;
            this.lb_cost.Text = "0.0";
            // 
            // lb_used
            // 
            this.lb_used.AutoSize = true;
            this.lb_used.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_used.ForeColor = System.Drawing.Color.Navy;
            this.lb_used.Location = new System.Drawing.Point(376, 123);
            this.lb_used.Name = "lb_used";
            this.lb_used.Size = new System.Drawing.Size(42, 25);
            this.lb_used.TabIndex = 21;
            this.lb_used.Text = "0.0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(25, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(257, 26);
            this.label14.TabIndex = 20;
            this.label14.Text = "Số khối nước đã sử dụng: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(25, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 26);
            this.label13.TabIndex = 19;
            this.label13.Text = "Giá tiền: ";
            // 
            // lb_Pay
            // 
            this.lb_Pay.AutoSize = true;
            this.lb_Pay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Pay.ForeColor = System.Drawing.Color.Navy;
            this.lb_Pay.Location = new System.Drawing.Point(376, 164);
            this.lb_Pay.Name = "lb_Pay";
            this.lb_Pay.Size = new System.Drawing.Size(54, 25);
            this.lb_Pay.TabIndex = 18;
            this.lb_Pay.Text = "0.00";
            // 
            // labelPay
            // 
            this.labelPay.AutoSize = true;
            this.labelPay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPay.ForeColor = System.Drawing.Color.Navy;
            this.labelPay.Location = new System.Drawing.Point(25, 164);
            this.labelPay.Name = "labelPay";
            this.labelPay.Size = new System.Drawing.Size(165, 26);
            this.labelPay.TabIndex = 17;
            this.labelPay.Text = "Số tiền phải trả: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(292, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 35);
            this.label7.TabIndex = 16;
            this.label7.Text = "THÔNG BÁO";
            // 
            // Notify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_convertToEuro);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lb_dollar);
            this.Controls.Add(this.btn_convertToDollar);
            this.Controls.Add(this.lb_cost);
            this.Controls.Add(this.lb_used);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lb_Pay);
            this.Controls.Add(this.labelPay);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notify";
            this.Text = "Notify";
            this.Load += new System.EventHandler(this.Notify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_convertToEuro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lb_dollar;
        private System.Windows.Forms.Button btn_convertToDollar;
        private System.Windows.Forms.Label lb_cost;
        private System.Windows.Forms.Label lb_used;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_Pay;
        private System.Windows.Forms.Label labelPay;
        private System.Windows.Forms.Label label7;
    }
}