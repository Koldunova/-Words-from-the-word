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
    public partial class Form3 : Form
    {
        int r = 0;
        Form1 form1;
        MySqlConnection conn;
        public Form3(Form1 f1, MySqlConnection conn, int res)
        {
            InitializeComponent();
            this.conn = conn;
            form1 = f1;
            r = res;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(255, 204, 0);
            button1.ForeColor = Color.FromArgb(204, 0, 1);
            label4.Text = r.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO mywords.score (user_name, user_score) VALUES ('"+textBox1.Text+"',"+r+")";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            form1.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.Show();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
