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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //Delegate truyen du lieu cho form1
        public delegate void GetData(string name, SqlConnection sql);
        public GetData mydata;

       
        

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Server=198.37.116.39;Database=FlappyBird;User Id=AndyT_SQLLogin_1;Password=4tq148x3xc;");
            string query = "Select * from [Table] where username = '" + txt_username.Text.Trim() + "' and password = '" + txt_password.Text.Trim() + "'";
            try
            {
                SqlDataAdapter sqlData = new SqlDataAdapter(query, sqlCon);
                DataTable dtbl = new DataTable();

                sqlData.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    var form = new Form1(this);
                    mydata = new GetData(form.GetValue);
                    mydata(txt_username.Text, sqlCon);
                    this.Hide();
                    form.ShowDialog(); 
                }
                else
                {
                    MessageBox.Show("username hoặc password không chính xác.");
                }
            }catch(Exception)
            {
                MessageBox.Show("Kiểm tra kết nối internet.");
            }
            
            
        }

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

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_signUp_Click(object sender, EventArgs e)
        {
            Signup frm = new Signup(this);
            this.Hide();
            frm.ShowDialog();
        }
    }
}
