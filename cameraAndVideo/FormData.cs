using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cameraAndVideo
{
    public partial class FormData : Form
    {
        private SQLiteConnection conn;

        public FormData()
        {
            InitializeComponent();
            this.conn = Database.GetInstance();
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            string sql = "select startTime as \"START TIME:\", endTime as \"END TIME:\", fileName as \"FILE NAME:\" from RecordData";
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SQLiteCommand command = new SQLiteCommand(sql, conn);

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["START TIME:"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            dataGridView1.Columns["END TIME:"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";

            //auto width
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            int dgv_width = dataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            this.Width = dgv_width + 147;
        }
    }
}
