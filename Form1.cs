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
    public partial class Form1 : Form
    {
        public SqlConnection connect;
        string a = "Data Source = A209PC41;Initial Catalog = siem;Integrated Security = true";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Chac chan muon thoat","Thoat",MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "A209PC41" && textBox2.Text == "siem")
            {
                connect = new SqlConnection(a);
                connect.Open();
                MessageBox.Show("Thanh cong");
                Form2 fo = new Form2();
                fo.Show();
                this.Hide();
            }
            else
                MessageBox.Show("That Bai");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
