using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Width,this.loginField.Height);
        }

        private void ShowPass_Click(object sender, EventArgs e)
        {
            passField.UseSystemPasswordChar= false;
            ShowPass.Visible = false;
            HidePass.Visible = true;
        }

        private void HidePass_Click(object sender, EventArgs e)
        {
            passField.UseSystemPasswordChar = true;
            ShowPass.Visible = true;
            HidePass.Visible = false;
        }
    }
}
