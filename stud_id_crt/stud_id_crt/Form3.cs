using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace stud_id_crt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static OleDbConnection con = new OleDbConnection("provider=msdaora.1:user_id=system;password=oracle");
        OleDbCommand cmd = new OleDbCommand("select * from stud", con);
        OleDbDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("insert into stud values(" + int.Parse(textBox2.Text) + ",'" + textBox1.Text + "','" + textBox3.Text + "','" + richTextBox1.Text + "'," + int.Parse(textBox4.Text) + ");", con);
            cmd.ExecuteNonQuery();
        }
    }
}
