using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StariApp
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private string dateS;
        private string resourceName;
        private float amount;
        private DateTime date;
        private int id;

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stariAppDBDataSet7.StockView' table. You can move, or remove it, as needed.
            //this.stockViewTableAdapter.Fill(this.stariAppDBDataSet7.StockView);
            DisplayDataStock();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            dateS = temp.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            amount = float.Parse(temp.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            resourceName = temp.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            date = Convert.ToDateTime(dateS);
            Connection.addStock(date, resourceName, amount);
            DisplayDataStock();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayDataStatus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayDataStock();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            id = int.Parse(temp.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Connection.removeById(id, "Stock");
            DisplayDataStock();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DisplayDataStatusUsed();
        }

        private void DisplayDataStock()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Projects\\StariApp\\StariApp\\StariApp\\StariAppDB.mdf;Integrated Security=True");
            con.Open();
            SqlDataAdapter adapt;
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from StockView", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void DisplayDataStatus()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Projects\\StariApp\\StariApp\\StariApp\\StariAppDB.mdf;Integrated Security=True");
            con.Open();
            SqlDataAdapter adapt;
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from StockStatusView", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void DisplayDataStatusUsed()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Projects\\StariApp\\StariApp\\StariApp\\StariAppDB.mdf;Integrated Security=True");
            con.Open();
            SqlDataAdapter adapt;
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from StockStatusUsedView", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

      
    }
}
