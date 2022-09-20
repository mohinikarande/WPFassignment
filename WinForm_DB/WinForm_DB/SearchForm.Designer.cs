namespace WinForm_DB
{
    partial class SearchForm
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
            this.lblDeptno = new System.Windows.Forms.Label();
            this.txtdeptno = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblJob = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeptno
            // 
            this.lblDeptno.AutoSize = true;
            this.lblDeptno.Location = new System.Drawing.Point(121, 85);
            this.lblDeptno.Name = "lblDeptno";
            this.lblDeptno.Size = new System.Drawing.Size(85, 16);
            this.lblDeptno.TabIndex = 0;
            this.lblDeptno.Text = "Enter Deptno";
            // 
            // txtdeptno
            // 
            this.txtdeptno.Location = new System.Drawing.Point(359, 82);
            this.txtdeptno.Name = "txtdeptno";
            this.txtdeptno.Size = new System.Drawing.Size(225, 22);
            this.txtdeptno.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(743, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1277, 477);
            this.dataGridView1.TabIndex = 3;
            // 
            // lblJob
            // 
            this.lblJob.Location = new System.Drawing.Point(121, 129);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(100, 23);
            this.lblJob.TabIndex = 4;
            this.lblJob.Text = "Enter Job";
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(359, 126);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(225, 22);
            this.txtJob.TabIndex = 5;
           // this.txtJob.TextChanged += new System.EventHandler(this.txtJob_TextChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 696);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtdeptno);
            this.Controls.Add(this.lblDeptno);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeptno;
        private System.Windows.Forms.TextBox txtdeptno;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.TextBox txtJob;
    }
}