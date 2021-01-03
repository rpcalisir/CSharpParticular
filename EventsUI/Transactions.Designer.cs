
namespace EventsUI
{
    partial class Transactions
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnMakePurchase = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.NumericUpDown();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Credit Card Machine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(206, 82);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(80, 25);
            this.lblCustomerName.TabIndex = 5;
            this.lblCustomerName.Text = "<none>";
            // 
            // btnMakePurchase
            // 
            this.btnMakePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakePurchase.Location = new System.Drawing.Point(162, 184);
            this.btnMakePurchase.Name = "btnMakePurchase";
            this.btnMakePurchase.Size = new System.Drawing.Size(171, 41);
            this.btnMakePurchase.TabIndex = 7;
            this.btnMakePurchase.Text = "Make Purchase";
            this.btnMakePurchase.UseVisualStyleBackColor = true;
            this.btnMakePurchase.Click += new System.EventHandler(this.btnMakePurchase_Click);
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(192, 133);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(120, 22);
            this.Amount.TabIndex = 9;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(140, 242);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(95, 29);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "<none>";
            this.lblError.Visible = false;
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 296);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.btnMakePurchase);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Transactions";
            this.Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnMakePurchase;
        private System.Windows.Forms.NumericUpDown Amount;
        private System.Windows.Forms.Label lblError;
    }
}