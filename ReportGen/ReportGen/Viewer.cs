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
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
        }
        
        private void BindDataCSV(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];

                string[] headerLabels = firstLine.Split(',');

                foreach(string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }

                //For Data
                for(int r=1; r <=lines.Length; r++)
                {
                    string[] dataWords = lines[r].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;

                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                }
            }
            if(dt.Rows.Count>0)
            {
                dataGridView2.DataSource = dt;
            }            
        }

        private void btnBrowseCSV_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            tbPath.Text = openFileDialog1.FileName;
            BindDataCSV(tbPath.Text);
        }
    }
}
