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

namespace Day22
{
    public partial class Form5 : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter Adapter;
        DataSet DS;

        Form1 form1;

        public Form5(Form1 f, MySqlConnection con)
        {
            InitializeComponent();
            form1 = f;
            conn = con;
            string sql = "SELECT user_name as 'Пользователь', user_score as 'Рекорд' FROM mywords.score;";
            Adapter = new MySqlDataAdapter(sql, conn);
            DS = new DataSet();
            Adapter.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.BackgroundColor = Color.FromArgb(254,212,32);
            label1.BackColor= Color.FromArgb(254, 212, 32);
            button1.BackColor= Color.FromArgb(254, 212, 32); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.Show();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
