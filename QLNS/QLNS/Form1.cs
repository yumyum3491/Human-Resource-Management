using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.BangCongNhanVien' table. You can move, or remove it, as needed.
           // this.BangCongNhanVienTableAdapter.Fill(this.DataSet2.BangCongNhanVien);
            // TODO: This line of code loads data into the 'DataSet2.BangCongNhanVien' table. You can move, or remove it, as needed.
            //this.BangCongNhanVienTableAdapter.Fill(this.DataSet2.BangCongNhanVien);
            // TODO: This line of code loads data into the 'DataSet2.BangCongNhanVien' table. You can move, or remove it, as needed.
            //this.BangCongNhanVienTableAdapter.Fill(this.DataSet2.BangCongNhanVien);
            // TODO: This line of code loads data into the 'DataSet2.BangCongNhanVien' table. You can move, or remove it, as needed.
            //this.BangCongNhanVienTableAdapter.Fill(this.DataSet2.BangCongNhanVien);
           

            //this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.BangCongNhanVienTableAdapter.Fill(this.DataSet2.BangCongNhanVien,textBox1.Text);
            try
            {
                this.BangCongNhanVienTableAdapter.Fill(this.DataSet2.BangCongNhanVien, textBox1.Text);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
