namespace WindowsATMFormDemo
{
    partial class AtmOperation
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
            this.lblTransaction = new System.Windows.Forms.Label();
            this.btnCashWithdraw = new System.Windows.Forms.Button();
            this.btnCashDeposite = new System.Windows.Forms.Button();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnTransactionStatement = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaction.Location = new System.Drawing.Point(543, 57);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(431, 39);
            this.lblTransaction.TabIndex = 0;
            this.lblTransaction.Text = "Choose Transaction Option";
            this.lblTransaction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTransaction.Click += new System.EventHandler(this.lblTransaction_Click);
            // 
            // btnCashWithdraw
            // 
            this.btnCashWithdraw.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCashWithdraw.Location = new System.Drawing.Point(507, 182);
            this.btnCashWithdraw.Name = "btnCashWithdraw";
            this.btnCashWithdraw.Size = new System.Drawing.Size(166, 82);
            this.btnCashWithdraw.TabIndex = 1;
            this.btnCashWithdraw.Text = "Cash Withdraw";
            this.btnCashWithdraw.UseVisualStyleBackColor = false;
            this.btnCashWithdraw.Click += new System.EventHandler(this.btnCashWithdraw_Click);
            // 
            // btnCashDeposite
            // 
            this.btnCashDeposite.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCashDeposite.Location = new System.Drawing.Point(823, 182);
            this.btnCashDeposite.Name = "btnCashDeposite";
            this.btnCashDeposite.Size = new System.Drawing.Size(187, 82);
            this.btnCashDeposite.TabIndex = 2;
            this.btnCashDeposite.Text = "Cash Deposite";
            this.btnCashDeposite.UseVisualStyleBackColor = false;
            this.btnCashDeposite.Click += new System.EventHandler(this.btnCashDeposite_Click);
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCheckBalance.Location = new System.Drawing.Point(507, 317);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(166, 77);
            this.btnCheckBalance.TabIndex = 3;
            this.btnCheckBalance.Text = "CheckBalance";
            this.btnCheckBalance.UseVisualStyleBackColor = false;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // btnTransactionStatement
            // 
            this.btnTransactionStatement.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTransactionStatement.Location = new System.Drawing.Point(823, 317);
            this.btnTransactionStatement.Name = "btnTransactionStatement";
            this.btnTransactionStatement.Size = new System.Drawing.Size(187, 77);
            this.btnTransactionStatement.TabIndex = 4;
            this.btnTransactionStatement.Text = "Transaction Statement";
            this.btnTransactionStatement.UseVisualStyleBackColor = false;
            this.btnTransactionStatement.Click += new System.EventHandler(this.btnTransactionStatement_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(730, 504);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 59);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // AtmOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1443, 742);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTransactionStatement);
            this.Controls.Add(this.btnCheckBalance);
            this.Controls.Add(this.btnCashDeposite);
            this.Controls.Add(this.btnCashWithdraw);
            this.Controls.Add(this.lblTransaction);
            this.Name = "AtmOperation";
            this.Text = "AtmOperation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.Button btnCashWithdraw;
        private System.Windows.Forms.Button btnCashDeposite;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Button btnTransactionStatement;
        private System.Windows.Forms.Button btnCancel;
    }
}