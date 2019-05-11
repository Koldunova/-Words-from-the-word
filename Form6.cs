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
    public partial class Form6 : Form
    {
        Form1 form1;
        MySqlConnection conn;
        public Form6(Form1 f, MySqlConnection con)
        {
            InitializeComponent();
            conn = con;
            form1 = f;

            string sql = "SELECT user_name, place, words FROM mywords.restart;";

            Adapter = new MySqlDataAdapter(sql, conn);
            DS = new DataSet();
            Adapter.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                users.Add(new User(dataGridView1[0, i].Value.ToString(), Convert.ToInt32(dataGridView1[1, i].Value.ToString()), Convert.ToInt32(dataGridView1[2, i].Value.ToString())));
            }
            foreach (User el in users)
            {
                comboBox1.Items.Add(el.user_name);
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            form1.Show();
            Close();
        }

        MySqlDataAdapter Adapter;
        DataSet DS;

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }
        List<User> users = new List<User>();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string rl in comboBox1.Items)
            {
                if (rl == comboBox1.Text)
                {
                    int j = users[comboBox1.SelectedIndex].user_score;
                    Form2 form2 = new Form2(form1, conn, j, users[comboBox1.SelectedIndex].words );
                    form2.Show();
                    Hide();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    class User
    {
        public string user_name { get; set; }
        public int user_score { get; set; }
        public int words { get; set; }

        public User(string n, int s, int w)
        {
            user_name = n;
            user_score = s;
            words = w;
        }
    }
}
