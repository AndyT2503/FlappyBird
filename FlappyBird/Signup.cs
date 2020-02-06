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
namespace FlappyBird
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(@"Server=198.37.116.39;Database=FlappyBird;User Id=AndyT_SQLLogin_1;Password=4tq148x3xc;");
        

        private void Txt_username_MouseClick(object sender, MouseEventArgs e)
        {
            txt_username.Text = "";
            txt_username.ForeColor = Color.Black;
        }

        private void Txt_password_MouseClick(object sender, MouseEventArgs e)
        {
            txt_password.Text = "";
            txt_password.ForeColor = Color.Black;
            txt_password.UseSystemPasswordChar = true;
        }

        private void Txt_confirm_MouseClick(object sender, MouseEventArgs e)
        {
            txt_confirm.Text = "";
            txt_confirm.ForeColor = Color.Black;
            txt_confirm.UseSystemPasswordChar = true;
        }

        private bool CheckUsername() //kiem tra username da ton tai hay chua
        {
            string query = "Select * from [Table] where username = '" + txt_username.Text.Trim() + "'";
            SqlDataAdapter sqlData = new SqlDataAdapter(query, sqlCon);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
                return false;
            else
                return true;
        }

        private void Btn_signUp_Click(object sender, EventArgs e)
        {
            if (txt_confirm.Text == txt_password.Text && CheckUsername() == true)
            {
                
                string query = "insert into [table] values('" + txt_username.Text + "', '" + txt_password.Text + "', 0)";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                this.Close();
                LoginForm frm = new LoginForm();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Username đã tồn tại hoặc Mật khẩu nhập lại không khớp");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            this.Close();
            frm.ShowDialog();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            sqlCon.Open();
        }
    }
}
