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

namespace forms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string connectionString = null;
            connectionString = @"Data Source=PracticeDB1;Initial Catalog=Test_app;UserID=Rojah;Integrated Security=SSPI";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            cmd.CommandText = ("INSERT into ExtraWork VALUES (@Name, @Hours, @Date)");

            //take and check the hours
            int hours;
            if (int.TryParse(txtHours.Text,out hours))
            {
                if(hours > 8)
                {
                    MessageBox.Show("The numbe rof hours cannot be greater than 8! Please correct the entered value");
                }
                else
                {
                    //Correct value entered so just go ahead.
                }
            }
            else
            {
                MessageBox.Show("Please insert an integer into the hours textBox!");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
