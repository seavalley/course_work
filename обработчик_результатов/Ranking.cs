using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;

namespace обработчик_результатов
{
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
        }

        
        DB db = new DB();
        System.Data.DataTable table;
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        string str;
        int flag = 0;
        private void types_SelectionChangeCommitted(object sender, EventArgs e)
        {
            subject.Visible = false;
            name.Visible = false;
            if (types.Text == "Сводка по предмету")
            {
                subject.Visible = true;
                flag = 1;                
            }
            if (types.Text == "Сводка по учащемуся")
            {
                name.Visible = true;
                flag = 2;
            }
            if (types.Text == "Полная сводка") flag = 3;
        }

        private void show_Click(object sender, EventArgs e)
        {
            db.OpenConnection();
            try
            {
                if (name.Text == "" && flag == 2) throw new Exception("Не было введено имя");
                if (subject.Text == "" && flag == 1) throw new Exception("Не был выбран предмет");
                switch (flag)
                {
                    case 1:
                        str = $"SELECT №, name, {subject.Text} FROM 0k0000";
                        break;
                    case 2:
                        str = $"SELECT * FROM 0k0000 WHERE name LIKE '%{name.Text}%'";
                       // MessageBox.Show("Перед созданием сводки, убедитесь, что выбрана только одна строка таблицы");
                        break;
                    case 3:
                        str = "SELECT * FROM 0k0000";
                        break;
                    default: throw new Exception("Не был выбран тип сводки");
                }
                MySqlCommand command = new MySqlCommand(str, db.getConnection());
                adapter.SelectCommand = command;
                table = new System.Data.DataTable();
                adapter.Fill(table);
                dataGridView2.DataSource = table;
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
            db.CloseConnection();
        }

        private void Count_Click(object sender, EventArgs e)
        {
            if (flag == 3)
            {
                Application app = new Application();
                Document doc = app.Documents.Add(Visible: true);
                Range r = doc.Range();
                Table t = doc.Tables.Add(r, 30, 5);
                t.Borders.Enable = 1;
                t.Rows[1].Range.Font.Name = "times new roman";
                t.Rows[1].Range.Bold = 1;
                t.Rows[1].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                t.Rows[1].Cells[1].Range.Text = "№";
                t.Rows[1].Cells[2].Range.Text = "Ф.И.О";
                t.Rows[1].Cells[3].Range.Text = "Экономика";
                t.Rows[1].Cells[4].Range.Text = "ТРПО";
                t.Rows[1].Cells[5].Range.Text = "ЗКИ";
                for (int i = 1; i<=dataGridView2.Rows.Count; i++)
                {
                    t.Rows.Add();
                    for (int j = 1; j < 6; j++)
                    {
                        t.Rows[i + 1].Cells[j].Range.Text = dataGridView2.Rows[i-1].Cells[j-1].Value.ToString();
                    }                       
                }
                doc.Save();
                //  app.Documents.Open(@"C:\Users\ASUS\Desktop\Doc1.docx");
                try
                {
                    doc.Close();
                    app.Quit();
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.Message);
                }
            }
        }
    }
}
