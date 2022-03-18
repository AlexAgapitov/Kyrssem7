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
    public partial class FormSELECT : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Student.accdb";
        private static OleDbConnection connection;

        public FormSELECT()
        {
            InitializeComponent();
            connection = new OleDbConnection(connectString);
            connection.Open();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            string query = "SELECT [Студенты.НомерЗачетки], [Студенты.ФИО], [Оценки.КодДисциплины], [Оценки.Оценка]" +
                "FROM ([Оценки] INNER JOIN [Студенты] ON Оценки.КодСтудента = Студенты.КодСтудента) INNER JOIN [Группы] ON Студенты.КодГруппы = Группы.КодГруппы " +
                "WHERE [Группы.ГодСоздания]<=2018";
            OleDbDataAdapter command = new OleDbDataAdapter(query, connection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("Gotovo");
        }
    }
}
