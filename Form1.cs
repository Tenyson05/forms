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
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            connectionString = @"Data Source=networkConnection;Initial Catalog=yourdatabase;Integrated Security=true";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            cmd.CommandText = ("INSERT into ExtraWork VALUES (@Name, @Hours, @Date)");

            //take and check the hours
            int hours;
            if (int.TryParse(txtHours.Text, out hours))
            {
                if (hours > 8 || hours == 0)
                {
                    MessageBox.Show("The number of hours cannot be greater than 8 hours! Please correct the entered value");
                    return;
                }
            }
            else if(hours == 0 || hours < 0)
            {
                MessageBox.Show("Please insert an integer into the hours textBox!");
                return;
            }

            //insert ok data into SQL Table
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Hours", hours);
            cmd.Parameters.AddWithValue("@Date", dateOverTime.Value);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("The hours where added !");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection!");
            }


        }
    }
}
