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
    public partial class Form4 : Form
    {
        MySqlConnection conn;
        Form1 f;
        int pos =0;
        int find_words = 0;
        public Form4(Form1 form1, MySqlConnection conn, int pos, int f_w)
        {
            InitializeComponent();
            f = form1;
            this.pos = pos;
            this.conn = conn;
            find_words = f_w;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(252, 218, 32);
            label2.BackColor = Color.FromArgb(252, 218, 32);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO mywords.restart (user_name, place, words) VALUES ('" + textBox1.Text + "'," + pos + ",+ "+find_words+")";
            MySqlCommand comand = new MySqlCommand(sql, conn);
            comand.ExecuteNonQuery();
            f.Show();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
