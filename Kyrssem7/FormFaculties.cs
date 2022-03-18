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
    public partial class FormFaculties : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Student.accdb";
        private static OleDbConnection connection;

        public FormFaculties()
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

        private void FormFaculties_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentDataSet.Факультеты". При необходимости она может быть перемещена или удалена.
            this.факультетыTableAdapter.Fill(this.studentDataSet.Факультеты);

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Факультеты WHERE [КодФакультета] = " + textBox1.Text;
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Gotovo");
            this.факультетыTableAdapter.Fill(this.studentDataSet.Факультеты);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Факультеты VALUES ( " + textBox1.Text + ", '" + textBox2.Text + "', '" + textBox3.Text + "')";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Gotovo");
            this.факультетыTableAdapter.Fill(this.studentDataSet.Факультеты);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Факультеты SET Наименование = '" + textBox2.Text + "', Декан = '" + textBox3.Text + "' WHERE [КодФакультета] = " + textBox1.Text;
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Gotovo");
            this.факультетыTableAdapter.Fill(this.studentDataSet.Факультеты);
        }
    }
}
