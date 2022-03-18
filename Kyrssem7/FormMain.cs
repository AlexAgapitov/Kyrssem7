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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            FormGroup fg = new FormGroup();
            fg.ShowDialog();
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            FormStudents fs = new FormStudents();
            fs.ShowDialog();
        }

        private void buttonDisciplines_Click(object sender, EventArgs e)
        {
            FormDisciplines fd = new FormDisciplines();
            fd.ShowDialog();
        }

        private void buttonFaculties_Click(object sender, EventArgs e)
        {
            FormFaculties ff = new FormFaculties();
            ff.ShowDialog();
        }

        private void buttonRating_Click(object sender, EventArgs e)
        {
            FormMarks fm = new FormMarks();
            fm.ShowDialog();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            FormSELECT fselect = new FormSELECT();
            fselect.ShowDialog();
        }
    }
}
