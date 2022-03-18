using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kyrssem7
{
    public partial class FormGroup : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Student.accdb";
        private static OleDbConnection connection;

        public FormGroup()
        {
            InitializeComponent();
            connection = new OleDbConnection(connectString);
            connection.Open();
            if (ClassAdmin.admin == false)
            {
                buttonAdd.Enabled = false;
                buttonChange.Enabled = false;
                buttonDelete.Enabled = false;
            }
        }

        private void FormGroup_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentDataSet.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter.Fill(this.studentDataSet.Группы);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Группы WHERE [КодГруппы] = " + textBox1.Text;
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Gotovo");
            this.группыTableAdapter.Fill(this.studentDataSet.Группы);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Группы VALUES ( " + textBox1.Text + ", '" + textBox2.Text + "', " + textBox3.Text + ", " + textBox4.Text + ")";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Gotovo");
            this.группыTableAdapter.Fill(this.studentDataSet.Группы);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Группы SET НомерГруппы = '" + textBox2.Text + "', КодФакультета = " + textBox3.Text + ", ГодСоздания = " + textBox4.Text + " WHERE [КодГруппы] = " + textBox1.Text;
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Gotovo");
            this.группыTableAdapter.Fill(this.studentDataSet.Группы);
        }
    }
}
