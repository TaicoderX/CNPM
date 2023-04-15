using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Ex1
{
    public partial class Item : Form
    {
        public Item()
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string s = String.Format("insert into Item values('{0}','{1}','{2}')", txtID.Text, txtName.Text, txtSize.Text);
            changeData(s);
            printdtGV();
            MessageBox.Show("Insert data success");
            txtSize.Text = "";
            txtID.Text = "";
            txtName.Text = "";
        }
        private void printdtGV()
        {
            string s = "select * from item";
            dtGV.DataSource = getData(s);
        }

        private void Item_Load(object sender, EventArgs e)
        {
            printdtGV();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
