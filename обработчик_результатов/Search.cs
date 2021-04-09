using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace обработчик_результатов
{
    public partial class Search : Form
    {
        public Search()
        {
            
            InitializeComponent();
        }
        DB db = new DB();
        DataTable table;
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        private void gosearch_Click(object sender, EventArgs e)
        {
            string str = "SELECT * FROM 0k0000";
            if (name.Text != "")
            {
                str = $"SELECT * FROM 0k0000 WHERE name LIKE '%{name.Text}%'";                             
            }
            if (subject.Text != "")
            {
                if (name.Text != "")
                {
                    str = $"SELECT №, name, {subject.Text} FROM ({str}) AS f";
                }
                else 
                str = $"SELECT №, name, {subject.Text} FROM 0k0000";
            }
            if (grade.Text != "")
            {
                if (subject.Text != "")
                {
                    str = $"SELECT * FROM ({str}) AS s WHERE {subject.Text} = {Convert.ToInt32(grade.Text)}";
                }
                else str = $"SELECT * FROM 0k0000 WHERE трпо = {Convert.ToInt32(grade.Text)} OR экономика = {Convert.ToInt32(grade.Text)} OR зки = {Convert.ToInt32(grade.Text)} ";
            }
            
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand(str, db.getConnection());
            adapter.SelectCommand = command;
            table = new DataTable();
            adapter.Fill(table);
            dataGridView2.DataSource = table;

            db.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.OpenConnection();
            adapter = new MySqlDataAdapter(@"SELECT * FROM 0k0000", db.getConnection());
            table = new DataTable();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
            db.CloseConnection();
        }
        
    }
}
