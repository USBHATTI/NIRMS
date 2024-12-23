using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Guard : Form
    {
        private int receivedData;
        public Guard(int data)
        {
            InitializeComponent();
            receivedData = data;
        }

        private void Report_btn_Click(object sender, EventArgs e)
        {
            ReportIssue reportIssue = new ReportIssue(receivedData);
            reportIssue.Show();
        }
    }
}
