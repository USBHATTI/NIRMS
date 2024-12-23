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
    public partial class Signup : Form
    {
        User_Control.SignupControl SignupControl = new
     User_Control.SignupControl();
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

            Signup_panel.Controls.Clear();
            Signup_panel.Controls.Add(SignupControl);
            SignupControl.Dock = DockStyle.Fill;

        }

        private void Signup_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
