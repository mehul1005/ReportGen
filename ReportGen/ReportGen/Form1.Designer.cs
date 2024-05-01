
namespace ReportGen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCsv = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefrsh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnLoadCsv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCsv
            // 
            this.btnCsv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCsv.Location = new System.Drawing.Point(547, 63);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(99, 30);
            this.btnCsv.TabIndex = 1;
            this.btnCsv.Text = "Export To CSV";
            this.btnCsv.UseVisualStyleBackColor = false;
            this.btnCsv.Visible = false;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 26;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 592);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnRefrsh
            // 
            this.btnRefrsh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefrsh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrsh.Location = new System.Drawing.Point(547, 113);
            this.btnRefrsh.Name = "btnRefrsh";
            this.btnRefrsh.Size = new System.Drawing.Size(99, 30);
            this.btnRefrsh.TabIndex = 3;
            this.btnRefrsh.Text = "Refresh List";
            this.btnRefrsh.UseVisualStyleBackColor = false;
            this.btnRefrsh.Visible = false;
            this.btnRefrsh.Click += new System.EventHandler(this.btnRefrsh_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Keep Out";
            this.notifyIcon.BalloonTipTitle = "Do Not Exit";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Report (Do Not Exit)";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // btnLoadCsv
            // 
            this.btnLoadCsv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoadCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadCsv.Location = new System.Drawing.Point(547, 12);
            this.btnLoadCsv.Name = "btnLoadCsv";
            this.btnLoadCsv.Size = new System.Drawing.Size(99, 30);
            this.btnLoadCsv.TabIndex = 4;
            this.btnLoadCsv.Text = "View CSV Data";
            this.btnLoadCsv.UseVisualStyleBackColor = false;
            this.btnLoadCsv.Click += new System.EventHandler(this.btnLoadCsv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 592);
            this.Controls.Add(this.btnLoadCsv);
            this.Controls.Add(this.btnRefrsh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCsv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCsv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefrsh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btnLoadCsv;
    }
}

