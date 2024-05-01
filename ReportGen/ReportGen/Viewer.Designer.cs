
namespace ReportGen
{
    partial class Viewer
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnBrowseCSV = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(922, 540);
            this.dataGridView2.TabIndex = 0;
            // 
            // btnBrowseCSV
            // 
            this.btnBrowseCSV.Location = new System.Drawing.Point(452, 16);
            this.btnBrowseCSV.Name = "btnBrowseCSV";
            this.btnBrowseCSV.Size = new System.Drawing.Size(178, 26);
            this.btnBrowseCSV.TabIndex = 1;
            this.btnBrowseCSV.Text = "Browse CSV";
            this.btnBrowseCSV.UseVisualStyleBackColor = true;
            this.btnBrowseCSV.Click += new System.EventHandler(this.btnBrowseCSV_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(13, 20);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(433, 20);
            this.tbPath.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 594);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnBrowseCSV);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Viewer";
            this.Text = "Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnBrowseCSV;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}