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
    public partial class FormDisciplines : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Student.accdb";
        private static OleDbConnection connection;

        public FormDisciplines()
        {
            InitializeComponent();
            connection = new OleDbConnection(connectString);
            connection.Open();
        }

        private void FormDisciplines_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentDataSet.Дисциплины". При необходимости она может быть перемещена или удалена.
            this.дисциплиныTableAdapter.Fill(this.studentDataSet.Дисциплины);

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Дисциплины WHERE [КодДисциплины] = " + textBox1.Text;
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Gotovo");
            this.дисциплиныTableAdapter.Fill(this.studentDataSet.Дисциплины);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Дисциплины VALUES ( " + textBox1.Text + ", " + textBox2.Text + ")";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Gotovo");
            this.дисциплиныTableAdapter.Fill(this.studentDataSet.Дисциплины);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Дисциплины SET НазваниеДисциплины = '" + textBox2.Text + "' WHERE [КодДисциплины] = " + textBox1.Text;
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Gotovo");
            this.дисциплиныTableAdapter.Fill(this.studentDataSet.Дисциплины);
        }
    }
}
