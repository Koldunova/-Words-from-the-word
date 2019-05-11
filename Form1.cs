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
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player;
        public Form1()
        {
            conn.Open();
            InitializeComponent();
            player = new System.Media.SoundPlayer();

            player.SoundLocation = "simpsony--glavnaya-tema.wav";
            player.Play();

        }

        MySqlConnection conn = DBUtils.GetDBConnection();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(158, 68, 255);
            label1.ForeColor = Color.FromArgb(247, 214, 41);
            label2.BackColor=Color.FromArgb(158, 68, 255);
            label2.ForeColor = Color.FromArgb(255, 148, 0);
            button1.BackColor = Color.FromArgb(42, 107, 211);
            button1.ForeColor=Color.FromArgb(247, 214, 41);
            button2.BackColor = Color.FromArgb(42, 107, 211);
            button2.ForeColor = Color.FromArgb(247, 214, 41);
            button3.BackColor = Color.FromArgb(42, 107, 211);
            button3.ForeColor = Color.FromArgb(247, 214, 41);
            button4.BackColor = Color.FromArgb(42, 107, 211);
            button4.ForeColor = Color.FromArgb(247, 214, 41);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this, conn);
            form6.Show();
            //Form2 form2 = new Form2(this, conn,2);
           // form2.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this,conn,1);
            form2.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this, conn);
            form5.Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.Play();
        }
    }
}
