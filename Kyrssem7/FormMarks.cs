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
    public partial class FormMarks : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Student.accdb";
        private static OleDbConnection connection;

        public FormMarks()
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

        private void FormMarks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentDataSet.Оценки". При необходимости она может быть перемещена или удалена.
            this.оценкиTableAdapter.Fill(this.studentDataSet.Оценки);

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Оценки WHERE [КодСтудента] = " + textBox1.Text;
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Gotovo");
            this.оценкиTableAdapter.Fill(this.studentDataSet.Оценки);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Оценки VALUES ( " + textBox1.Text + ", " + textBox2.Text + ", " + textBox3.Text + ")";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Gotovo");
            this.оценкиTableAdapter.Fill(this.studentDataSet.Оценки);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Оценки SET КодДисциплины = " + textBox2.Text + ", Оценка = " + textBox3.Text + " WHERE [КодСтудента] = " + textBox1.Text;
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Gotovo");
            this.оценкиTableAdapter.Fill(this.studentDataSet.Оценки);
        }
    }
}
