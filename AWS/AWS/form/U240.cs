using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AWS.Lib;

namespace AWS.form
{
    public partial class U240 : Form
    {
        DataTable dataTable;
        string sql;
        public U240()
        {
            InitializeComponent();
        }

        private void U240_Load(object sender, EventArgs e)
        {
            ListUpdate();
        }

        private void ListUpdate()
        {
            
            listView1.Items.Clear();
            sql = " SELECT (SUBSTRING(BR_RCVDATE,1,4) + "+ "'-'" + " + SUBSTRING(BR_RCVDATE,5,2) + "+ "'-'" + " + SUBSTRING(BR_RCVDATE,7,2)) AS dBR_DATE, " +
                  "        (SUBSTRING(BR_RCVTIME,1,2) + "+ "':'" + " + SUBSTRING(BR_RCVTIME,3,2) + "+ "':'" + " + SUBSTRING(BR_RCVTIME,5,2)) AS iBR_TIME, " +
                  "        BR_ALC_CODE + BR_KIND as HOST_ALC_CODE, " +
                  "        BR_ALC_NAME, BR_CMD, BR_BODYNO,         " +
                  "        BODY_COLOR, INNER_COLOR, REGION_NAME,   " +
                  "        HANGLE_PART, HOST_STATUS, BR_RCVTIME    " +
                  "   FROM TT_HOST " +
                  "  WHERE 1=1 " +
                  "  ORDER BY BR_RCVDATE, BR_RCVTIME " ;
            dataTable = DBUtils.GetSelectTable(sql);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                ListViewItem viewItem = new ListViewItem(dataTable.Rows[i]["dBR_DATE"].ToString());  // 첫번째 열의 데이터는 뷰아이템 객체 생성시 할당
                viewItem.SubItems.Add(dataTable.Rows[i]["iBR_TIME"].ToString());
                viewItem.SubItems.Add(dataTable.Rows[i]["HOST_ALC_CODE"].ToString());
                viewItem.SubItems.Add(dataTable.Rows[i]["BR_ALC_NAME"].ToString());
                viewItem.SubItems.Add(dataTable.Rows[i]["BR_CMD"].ToString());
                viewItem.SubItems.Add(dataTable.Rows[i]["BR_BODYNO"].ToString());
                viewItem.SubItems.Add(dataTable.Rows[i]["BODY_COLOR"].ToString());
                viewItem.SubItems.Add(dataTable.Rows[i]["INNER_COLOR"].ToString());
                viewItem.SubItems.Add(dataTable.Rows[i]["REGION_NAME"].ToString());
                viewItem.SubItems.Add(dataTable.Rows[i]["HANGLE_PART"].ToString());
                viewItem.SubItems.Add(dataTable.Rows[i]["HOST_STATUS"].ToString());
                
                listView1.Items.Add(viewItem);
            }
            
        }

        private void SelectTimer_Tick(object sender, EventArgs e)
        {
            SelectTimer.Enabled = false;
            ListUpdate();
            SelectTimer.Enabled = true;
        }
    }
}
