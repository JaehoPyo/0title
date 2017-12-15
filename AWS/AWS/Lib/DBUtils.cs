using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AWS.Lib
{
    public static class DBUtils
    {
        public static string conStr = @"Password=1234;Persist Security Info=True;User ID=sa;Initial Catalog=AUTOWARE;Data Source=DESKTOP-1R3GCI6";
        
        // 객체를 매번 생성하지 않고 계속 재사용 하기 위함
        public static SqlConnection CONNECTION;
        public static SqlCommand COMMAND;
        public static SqlDataAdapter ADAPTER;


        public static void Connect()
        {
            CONNECTION = new SqlConnection(conStr);
            COMMAND = new SqlCommand("", CONNECTION);
            ADAPTER = new SqlDataAdapter();
            try
            {
                if (CONNECTION.State.ToString().Equals("Closed"))
                {
                    //connection.ConnectionString = conStr;
                    CONNECTION.Open();
                    h_MainLib.isDbConnect = true;
                }
            }
            catch (SqlException err)
            {
                h_MainLib.isDbConnect = false;
                MessageBox.Show(err.Message);                
            }
        }
        public static void Close()
        {
            if (CONNECTION != null)
            {
                CONNECTION.Close();
            }
        }

        public static SqlDataReader GetSelectData(string SelectSql)
        {
            if (CONNECTION == null)
            {
                MessageBox.Show("커넥션 객체가 없습니다.");
                return null;
            }
            else
            {
                COMMAND.CommandText = SelectSql;
                return COMMAND.ExecuteReader();
            }
        }

        public static DataTable GetSelectTable(string SelectSql)
        {
            if (CONNECTION == null)
            {
                MessageBox.Show("커넥션 객체가 없습니다.");
                return null;
            }
            else
            {
                COMMAND.CommandText = SelectSql;
                ADAPTER.SelectCommand = COMMAND;
                DataTable dataTable = new DataTable(); // 객체는 Reference type 이므로 새로 생성하여 리턴
                ADAPTER.Fill(dataTable); // 테이블에 데이터를 채워넣은 후 리턴
                return dataTable;
            }
        }

        public static int InsertData(string InsertSql)
        {
            COMMAND.CommandText = InsertSql;
            return COMMAND.ExecuteNonQuery(); // 영향받은 행의 갯수가 반환 됨 (1개 Insert 되면 1반환)
        }
        public static int DeleteData(string DeleteSql)
        {
            COMMAND.CommandText = DeleteSql;
            return COMMAND.ExecuteNonQuery();
        }
    }
}
