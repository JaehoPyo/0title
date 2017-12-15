using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using AWS.Lib;

namespace AWS.form
{
    public partial class Login : Form
    {
        string id;
        string pw;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            id = tbId.Text;
            pw = tbPw.Text;
            string sql = "SELECT USERID, PW FROM TB_LOGIN WHERE USERID='" + id +"' AND PW='" + pw + "'";
            DBUtils.Connect(); // 커넥션 객체 생성
            SqlDataReader reader = DBUtils.GetSelectData(sql);
            if (reader.Read())
            {
                h_MainLib.NAME = reader["USERID"].ToString();
                h_MainLib.ID = reader["USERID"].ToString();
                h_MainLib.isLogin = true;
                this.Close();
                reader.Close();
            }
            else
            {
                h_MainLib.isLogin = false;
                MessageBox.Show("아이디 또는 비밀번호가 잘못되었습니다.");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!h_MainLib.isLogin && MessageBox.Show("종료 하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
    }
}
