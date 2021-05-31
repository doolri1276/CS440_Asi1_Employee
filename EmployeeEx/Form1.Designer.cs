
namespace EmployeeEx
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtHourseWorked = new System.Windows.Forms.TextBox();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnComputePay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pay Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hourse Worked";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Employee ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(285, 43);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 39);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtHourseWorked
            // 
            this.txtHourseWorked.Location = new System.Drawing.Point(285, 186);
            this.txtHourseWorked.Name = "txtHourseWorked";
            this.txtHourseWorked.Size = new System.Drawing.Size(200, 39);
            this.txtHourseWorked.TabIndex = 6;
            // 
            // txtPayRate
            // 
            this.txtPayRate.Location = new System.Drawing.Point(285, 231);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(200, 39);
            this.txtPayRate.TabIndex = 7;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(285, 139);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(200, 39);
            this.txtEmpID.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(285, 93);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 39);
            this.txtLastName.TabIndex = 9;
            // 
            // btnComputePay
            // 
            this.btnComputePay.Location = new System.Drawing.Point(97, 346);
            this.btnComputePay.Name = "btnComputePay";
            this.btnComputePay.Size = new System.Drawing.Size(436, 46);
            this.btnComputePay.TabIndex = 10;
            this.btnComputePay.Text = "Compute Pay and Over Time Pay";
            this.btnComputePay.UseVisualStyleBackColor = true;
            this.btnComputePay.Click += new System.EventHandler(this.btnComputePay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComputePay);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.txtPayRate);
            this.Controls.Add(this.txtHourseWorked);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtHourseWorked;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnComputePay;
    }
}

