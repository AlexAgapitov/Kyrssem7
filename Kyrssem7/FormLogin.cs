using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrssem7
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonDecan_Click(object sender, EventArgs e)
        {
            ClassAdmin.admin = false;
            FormMain fm =   new FormMain();
            fm.ShowDialog();
            this.Hide();
        }

        private void buttonZamDecana_Click(object sender, EventArgs e)
        {
            ClassAdmin.admin = false;
            FormMain fm = new FormMain();
            fm.ShowDialog();
            this.Hide();
        }

        private void buttonUserDecanata_Click(object sender, EventArgs e)
        {
            ClassAdmin.admin = true;
            FormMain fm = new FormMain();
            fm.ShowDialog();
            this.Hide();
        }
    }
}
