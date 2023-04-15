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
namespace Ex1
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        SqlConnection cn;
        private void connect()
        {
            string s = "server=DESKTOP-DN8EH6I\\SQLEXPRESS;database=credit_task;Trusted_Connection=true";
            cn = new SqlConnection(s);
            cn.Open();
        }
        private void changeData(string sql)
        {
            connect();
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        private DataTable getData(string sql)
        {
            connect();
            SqlDataAdapter dt = new SqlDataAdapter(sql, cn);
            DataTable tb = new DataTable();
            dt.Fill(tb);
            cn.Close();
            return tb;
        }
        private void Order_Load(object sender, EventArgs e)
        {
            printdtGV();
        }
        private void printdtGV()
        {
            string s = "select * from Orders";
            dtGV.DataSource = getData(s);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string s = String.Format("insert into Orders values('{0}','{1}','{2}')", txtOID.Text, txtTime.Value.ToString("yyyy-MM-dd"), txtAID.Text);
            changeData(s);
            MessageBox.Show("Insert data success");
            txtAID.Text = "";
            txtOID.Text = "";
            printdtGV();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
