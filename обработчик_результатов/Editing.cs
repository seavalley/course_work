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
    public partial class Editing : Form
    {
        public Editing()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable table;
        MySqlDataAdapter adapter;
        MySqlCommandBuilder scb;
        private void button2_Click(object sender, EventArgs e)
        {
            db.OpenConnection();
            scb = new MySqlCommandBuilder(adapter);
            adapter.Update(table);
            db.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            db.OpenConnection();
            adapter = new MySqlDataAdapter(@"SELECT №, name, экономика, трпо, зки FROM 0k0000", db.getConnection());
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            db.CloseConnection();
        }
        
    }
}
