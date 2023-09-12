using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MARS.TestTask.ClassLibrary;
using MARS.TestTask.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MARS.TestTask.Forms
{
    public partial class TableViewForm : Form
    {
        public TableViewForm()
        {
            InitializeComponent();
            var tableNames = SqlServerMethods.GetTableNames();

            dataGridView1.DataSource = tableNames;
        }

        public void GetInformation()
        {
            using (var db = new MsSqlContext())
            {

            }
        }

        public void UpdateTableColumns(string tableName)
        {
            var list = SqlServerMethods.GetColumns(tableName).ToList();

            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            dataGridView2.Columns.Add("Название колонки", "Название колонки");
            dataGridView2.Columns.Add("Тип данных", "Тип данных");

            for (int i = 0; i < list.Count; i = i + 2)
            {
                var index = dataGridView2.Rows.Add();
                dataGridView2.Rows[index].Cells[0].Value = list[i];
                dataGridView2.Rows[index].Cells[1].Value = list[i+1];
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var tableName =  dataGridView1.CurrentRow.Cells[0].Value.ToString();
            UpdateTableColumns(tableName);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
