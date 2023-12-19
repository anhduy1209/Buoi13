using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public SqlConnection connect;
        string a = "Data Source = A209PC41;Initial Catalog = siem;Integrated Security = true";

        public Form2()
        {
            InitializeComponent();
            
        }
        private void LoadDataCBB()
        {
            connect = new SqlConnection(a);
            connect.Open();
            string load = "Select TenCoSo from COSO";
            SqlCommand cmd = new SqlCommand(load, connect);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["TenCoSo"].ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fo = new Form1();
            fo.Show();
            this.Hide();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
             connect = new SqlConnection(a);
            connect.Open();
            string ShowString = "select * from COSO";
            SqlDataAdapter adapter = new SqlDataAdapter(ShowString, connect);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
