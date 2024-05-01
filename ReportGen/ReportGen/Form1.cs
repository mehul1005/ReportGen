using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using System.Timers;
using System.Globalization; 

namespace ReportGen
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        public void SaveDataGridViewToCSV(string filename)
        {
            try
            {
                //Build the CSV file data as a Comma separated string.
                string csv = string.Empty;
                
                //Adding the Rows
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            //Add the Data rows.
                            csv += cell.Value.ToString().TrimEnd(',').Replace(",", ";") + ',';
                        }
                        //break;
                    }
                }   

                //Exporting to CSV.
                string folderPath = "C:\\CSV\\";

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                File.AppendAllText(folderPath + "Report.csv", csv += "\r\n");
            }
            catch
            {
            }
        }

        public void DataGridView()
        {
            dataGridView1.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dataGridView1, true, null);

            string[] files = Directory.GetFiles(@"D:\SCAN_PENDING", "*.Gal", SearchOption.AllDirectories);
            TimeSpan diff = DateTime.Now.Subtract(DateTime.Now);

            dataGridView1.RowHeadersVisible = false;
            DataTable table = new DataTable();
            DataRow dr;

            table.Columns.Add("File Name");
            table.Columns.Add("Time Stamp");
            table.Columns.Add("Time Difference");

            for (int i = 0; i <= files.Length - 1; i++)
            {
                FileSystemInfo file2 = new FileInfo(files[i]);
                dr = table.NewRow();

                dr["File Name"] = file2.Name;
                dr["Time Stamp"] = file2.CreationTime;
                dr["Time Difference"] = file2.CreationTime-diff;

                table.Rows.Add(dr);
            }
            dataGridView1.DataSource = table;
            SaveDataGridViewToCSV("Report.csv");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridView();
            timer1.Interval = 40000;
            timer1.Start();
        }

        private void btnCsv_Click(object sender, EventArgs e)
        {
            SaveDataGridViewToCSV("Report.csv");
            MessageBox.Show("Csv Exported Successfully!!");
        }
        
        private void Form1_Shown(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            //this.Hide();
        }

        private void btnRefrsh_Click(object sender, EventArgs e)
        {
            dataGridView1.RefreshEdit();
            DataGridView();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (true) //check new entry
            {
                DataGridView();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = true;
        }

        private void btnLoadCsv_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Viewer view = new Viewer();
            view.Visible = true;
        }
    }
}
