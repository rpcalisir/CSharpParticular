
namespace EventsUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstChecking = new System.Windows.Forms.ListBox();
            this.lstSaving = new System.Windows.Forms.ListBox();
            this.btnRecordTransaction = new System.Windows.Forms.Button();
            this.txtCheckingBalance = new System.Windows.Forms.TextBox();
            this.txtSavingBalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banking Demo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Checking Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saving Balance";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(303, 122);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(0, 25);
            this.lblCustomer.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(446, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Checking Transactions";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(778, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Saving Transactions";
            // 
            // lstChecking
            // 
            this.lstChecking.FormattingEnabled = true;
            this.lstChecking.ItemHeight = 16;
            this.lstChecking.Location = new System.Drawing.Point(451, 118);
            this.lstChecking.Name = "lstChecking";
            this.lstChecking.Size = new System.Drawing.Size(274, 276);
            this.lstChecking.TabIndex = 8;
            // 
            // lstSaving
            // 
            this.lstSaving.FormattingEnabled = true;
            this.lstSaving.ItemHeight = 16;
            this.lstSaving.Location = new System.Drawing.Point(783, 118);
            this.lstSaving.Name = "lstSaving";
            this.lstSaving.Size = new System.Drawing.Size(271, 276);
            this.lstSaving.TabIndex = 9;
            // 
            // btnRecordTransaction
            // 
            this.btnRecordTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordTransaction.Location = new System.Drawing.Point(101, 326);
            this.btnRecordTransaction.Name = "btnRecordTransaction";
            this.btnRecordTransaction.Size = new System.Drawing.Size(181, 68);
            this.btnRecordTransaction.TabIndex = 10;
            this.btnRecordTransaction.Text = "RECORD TRANSACTIONS";
            this.btnRecordTransaction.UseVisualStyleBackColor = true;
            this.btnRecordTransaction.Click += new System.EventHandler(this.btnRecordTransaction_Click);
            // 
            // txtCheckingBalance
            // 
            this.txtCheckingBalance.Location = new System.Drawing.Point(308, 169);
            this.txtCheckingBalance.Name = "txtCheckingBalance";
            this.txtCheckingBalance.Size = new System.Drawing.Size(122, 22);
            this.txtCheckingBalance.TabIndex = 11;
            // 
            // txtSavingBalance
            // 
            this.txtSavingBalance.Location = new System.Drawing.Point(308, 226);
            this.txtSavingBalance.Name = "txtSavingBalance";
            this.txtSavingBalance.Size = new System.Drawing.Size(122, 22);
            this.txtSavingBalance.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 532);
            this.Controls.Add(this.txtSavingBalance);
            this.Controls.Add(this.txtCheckingBalance);
            this.Controls.Add(this.btnRecordTransaction);
            this.Controls.Add(this.lstSaving);
            this.Controls.Add(this.lstChecking);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCustomer);
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
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstChecking;
        private System.Windows.Forms.ListBox lstSaving;
        private System.Windows.Forms.Button btnRecordTransaction;
        private System.Windows.Forms.TextBox txtCheckingBalance;
        private System.Windows.Forms.TextBox txtSavingBalance;
    }
}

