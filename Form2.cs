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
    public partial class Form2 : Form
    {
        int f_word = 0;
        Form1 f;
        MySqlConnection conn;

        MySqlDataAdapter Adapter;
        DataSet DS;

        public Form2(Form1 form, MySqlConnection conn, int pos)
        {
            InitializeComponent();
            f = form;
            quest = pos;
            this.conn = conn;
            string sql = "Select max(id) From mywords.words;";
            MySqlCommand comand = new MySqlCommand(sql, conn);

            string max_id = comand.ExecuteScalar().ToString();
            max_q = Convert.ToInt32(max_id);
            next_word();
           

        }

        public Form2(Form1 form, MySqlConnection conn, int pos , int l)
        {
            InitializeComponent();
            f = form;
            quest = pos;
            this.conn = conn;
            string sql = "Select max(id) From mywords.words;";
            MySqlCommand comand = new MySqlCommand(sql, conn);

            string max_id = comand.ExecuteScalar().ToString();
            max_q = Convert.ToInt32(max_id);
            next_word();
            f_word = l;
        }
        int quest = 1;
        int max_q = 0;

        public void next_word()
        {

            label2.Text = quest.ToString();
            string sql = "Select word From mywords.words where id = " + quest;
            MySqlCommand comand = new MySqlCommand(sql, conn);
            main_word = comand.ExecuteScalar().ToString();

            sql = "Select new_words From mywords.words where id = " + quest;
            comand = new MySqlCommand(sql, conn);
            string[] n_w = comand.ExecuteScalar().ToString().Split(',');
            foreach (string w in n_w)
            {
                new_words.Add(w.Trim());
            }
            if (main_word.Length == 9)
            {
                // 4-12
                button4.Text = main_word[0].ToString().ToUpper();
                button5.Text = main_word[1].ToString().ToUpper();
                button6.Text = main_word[2].ToString().ToUpper();
                button7.Text = main_word[3].ToString().ToUpper();
                button8.Text = main_word[4].ToString().ToUpper();
                button9.Text = main_word[5].ToString().ToUpper();
                button10.Text = main_word[6].ToString().ToUpper();
                button11.Text = main_word[7].ToString().ToUpper();
                button12.Text = main_word[8].ToString().ToUpper();
                button12.Visible = true;
            }

            if (main_word.Length == 8)
            {
                // 4-12
                button4.Text = main_word[0].ToString().ToUpper();
                button5.Text = main_word[1].ToString().ToUpper();
                button6.Text = main_word[2].ToString().ToUpper();
                button7.Text = main_word[3].ToString().ToUpper();
                button8.Text = main_word[4].ToString().ToUpper();
                button9.Text = main_word[5].ToString().ToUpper();
                button10.Text = main_word[6].ToString().ToUpper();
                button11.Text = main_word[7].ToString().ToUpper();
                button12.Visible = false;
            }
            label5.Text = new_words.Count.ToString();
        }

        string main_word = "";
        List<string> new_words = new List<string>();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(2, 90, 153);
            label1.ForeColor = Color.FromArgb(247, 214, 41);
            label2.BackColor = Color.FromArgb(2, 90, 153);
            label2.ForeColor = Color.FromArgb(247, 214, 41);
            label3.BackColor = Color.FromArgb(2, 90, 153);
            label3.ForeColor = Color.FromArgb(247, 214, 41);
            label4.BackColor = Color.FromArgb(2, 90, 153);
            label4.ForeColor = Color.FromArgb(247, 214, 41);
            label5.BackColor = Color.FromArgb(2, 90, 153);
            label5.ForeColor = Color.FromArgb(247, 214, 41);
            label6.BackColor = Color.FromArgb(2, 90, 153);
            label6.ForeColor = Color.FromArgb(247, 214, 41);
            label7.BackColor = Color.FromArgb(2, 90, 153);
            label7.ForeColor = Color.FromArgb(247, 214, 41);

            listBox1.BackColor= Color.FromArgb(2, 90, 153);

            button1.BackColor = Color.FromArgb(158, 68, 255);
            button1.ForeColor = Color.FromArgb(247, 214, 41);

            button3.BackColor = Color.FromArgb(158, 68, 255);
            button3.ForeColor = Color.FromArgb(247, 214, 41);

            groupBox1.BackColor= Color.FromArgb(2, 90, 153);
            groupBox2.BackColor = Color.FromArgb(2, 90, 153);
            listBox1.ForeColor = Color.FromArgb(247, 214, 41);

            button4.BackColor = Color.FromArgb(158, 68, 255);
            button5.BackColor = Color.FromArgb(158, 68, 255);
            button6.BackColor = Color.FromArgb(158, 68, 255);
            button7.BackColor = Color.FromArgb(158, 68, 255);
            button8.BackColor = Color.FromArgb(158, 68, 255);
            button9.BackColor = Color.FromArgb(158, 68, 255);
            button10.BackColor = Color.FromArgb(158, 68, 255);
            button11.BackColor = Color.FromArgb(158, 68, 255);
            button12.BackColor = Color.FromArgb(158, 68, 255);
            button13.BackColor = Color.FromArgb(158, 68, 255);
            button14.BackColor = Color.FromArgb(158, 68, 255);

            button4.ForeColor = Color.FromArgb(247, 214, 41);
            button5.ForeColor = Color.FromArgb(247, 214, 41);
            button6.ForeColor = Color.FromArgb(247, 214, 41);
            button7.ForeColor = Color.FromArgb(247, 214, 41);
            button8.ForeColor = Color.FromArgb(247, 214, 41);
            button9.ForeColor = Color.FromArgb(247, 214, 41);
            button10.ForeColor = Color.FromArgb(247, 214, 41);
            button11.ForeColor = Color.FromArgb(247, 214, 41);
            button12.ForeColor = Color.FromArgb(247, 214, 41);
            button13.ForeColor = Color.FromArgb(247, 214, 41);
            button14.ForeColor = Color.FromArgb(247, 214, 41);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(f, conn, quest,f_word);
            form4.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (quest == 20)
            {
                //все
                Form3 form3 = new Form3(f, conn, f_word);
                form3.Show();
                Close();
            }
            else
            {
                button1.Enabled = false;
                find_words.Clear();
                new_words.Clear();
                listBox1.Items.Clear();
                quest++;
                next_word();
                label6.Text = "0";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text += button4.Text;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text += button5.Text;
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text += button6.Text;
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label3.Text += button7.Text;
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label3.Text += button8.Text;
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label3.Text += button9.Text;
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label3.Text += button10.Text;
            button10.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label3.Text += button11.Text;
            button11.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label3.Text += button12.Text;
            button12.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            fresh();
        }

        public void fresh()
        {
            label3.Text = "";
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
        }
        List<string> find_words = new List<string>();
        private void button14_Click(object sender, EventArgs e)
        {
            int fl = 0;
            foreach (string l in new_words)
            {
                if (label3.Text == l.ToUpper())
                {
                    foreach (string f in find_words)
                    {
                        if (f.ToUpper().Trim() == label3.Text.ToUpper().Trim())
                        {
                            fl = 1;
                            break;
                        }
                    }
                    if (fl == 0)
                    {
                        find_words.Add(l.ToUpper());
                        listBox1.Items.Add(l + "   ");
                        label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
                        f_word++;
                        if (Convert.ToInt32(label6.Text) >= Convert.ToInt32(label5.Text) / 2)
                        {
                            button1.Enabled = true;
                        }

                    }
                }
            }
            fresh();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
