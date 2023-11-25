using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using IPT.myclass;

namespace IPT
{
    public partial class Form1 : Form
    {
        connection_class con = new connection_class();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                con.connectdb.Open();
                label1.Text = "You are Connected to the MySql Database!";
                label1.ForeColor = Color.White;
                con.connectdb.Close();
            }
            catch (Exception)
            {
                label1.Text = "Failed to Connect to MySql Database!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
