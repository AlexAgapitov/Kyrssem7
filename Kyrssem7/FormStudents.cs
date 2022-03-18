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
    public partial class FormStudents : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Student.accdb";
        private static OleDbConnection connection;

        public FormStudents()
        {
            InitializeComponent();
            connection = new OleDbConnection(connectString);
            connection.Open();
        }

        private void FormStudents_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.studentDataSet.Студенты);
            if (ClassAdmin.admin == false)
            {
                buttonAdd.Enabled = false;
                buttonChange.Enabled = false;
                buttonDelete.Enabled = false;
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Студенты WHERE [КодСтудента] = " + textBox1.Text;
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Gotovo");
            this.студентыTableAdapter.Fill(this.studentDataSet.Студенты);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Студенты VALUES ( " + textBox1.Text + ", " + textBox2.Text + ", '" + textBox3.Text + "', " + textBox4.Text + ")";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Gotovo");
            this.студентыTableAdapter.Fill(this.studentDataSet.Студенты);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Студенты SET НомерЗачетки = " + textBox2.Text + ", ФИО = '" + textBox3.Text + "', КодГруппы = " + textBox4.Text + " WHERE [КодСтудента] = " + textBox1.Text;
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Gotovo");
            this.студентыTableAdapter.Fill(this.studentDataSet.Студенты);
        }
    }
}
