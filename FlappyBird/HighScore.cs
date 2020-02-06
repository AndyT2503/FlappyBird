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
    public partial class HighScore : Form
    {
        public HighScore()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon;

        //lay du lieu tu form1
        public HighScore(SqlConnection sql):this()
        {
            sqlCon = sql;
        }
        
        
        private void HighScore_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = "select top(5) username, score from [table] order by score DESC";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, sqlCon);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
