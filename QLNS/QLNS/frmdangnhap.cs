using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using DevComponents.DotNetBar;

namespace QLNS
{
    public partial class frmdangnhap : Form
    {
        Clsdatabase cls = new Clsdatabase();
        private SqlConnection Con = null;
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=DESKTOP-39CDSDL\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True";
            Con.Open();
            string select = "SELECT * FROM Users WHERE Username='" + textBox1.Text + "' AND Pass='" + textBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(select, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string str1 = "admin";
                string role = reader.GetString(reader.GetOrdinal("Quyen"));
                if (role.Trim().Equals("Admin", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Đăng nhập vào hệ thống (Quyền Admin)!", "Thông báo!");
                    FrmMain.quyen = "Admin";
                }
                else
                {
                    MessageBox.Show("Đăng nhập vào hệ thống (Quyền user)!", "Thông báo!");
                    FrmMain.quyen = "user";
                }
                reader.Close();
                cmd.Dispose();
                this.Hide();
                FrmMain frm = new FrmMain();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo!");
                reader.Close();
                cmd.Dispose();
            }

        }

    }
}
 
