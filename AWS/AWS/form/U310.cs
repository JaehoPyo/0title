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
    public partial class U310 : Form
    {
        static int BANKNUM = 8;
        static int ROW = 8; // 행의 갯수
        static int COL = 12; // 열의 갯수
        Panel[] Bank;
        Panel[, ,] Cell;
        Label[, ,] CellLabel;
        Font labelFont;
        public U310()
        {
            InitializeComponent();
        }

        private void U310_Load(object sender, EventArgs e)
        {
            CreateCell();
            LoopUpStockData();
        }

        

        private void CreateCell()
        {
            Bank = new Panel[BANKNUM];
            Cell = new Panel[BANKNUM, ROW, COL];
            CellLabel = new Label[BANKNUM, ROW, COL];
            labelFont = new Font("돋움", 8);
            pnlContent1.Size = new Size(this.pnlMain.Size.Width / 2, this.pnlMain.Size.Height / 2); // 뱅크가 담길 패널 좌측
            pnlContent2.Size = new Size(this.pnlMain.Size.Width / 2, this.pnlMain.Size.Height / 2); // 뱅크가 담길 패널 우측
            pnlContent1.Parent = this.pnlMain;
            pnlContent2.Parent = this.pnlMain;
            pnlContent1.Dock = DockStyle.Left;
            pnlContent2.Dock = DockStyle.Left;
            Size bankSize = new Size(this.pnlContent2.Size.Width, this.pnlContent2.Size.Height / 4);
            Size cellSize = new Size(bankSize.Width / COL, bankSize.Height / ROW);

            for (int i = 0; i < BANKNUM; i++) // 셀을 담을 뱅크 8개 만들기
            {
                Bank[i] = new Panel();
                Bank[i].Size = bankSize;
                Bank[i].BorderStyle = BorderStyle.FixedSingle;
                if (i < 4)
                {
                    Bank[i].Parent = this.pnlContent1;
                    Bank[i].BackColor = Color.Beige;
                    Bank[i].Dock = DockStyle.Top;
                }
                else
                {
                    Bank[i].Parent = this.pnlContent2;
                    Bank[i].BackColor = Color.Beige;
                    Bank[i].Dock = DockStyle.Top;
                }
                
                for (int j = 0; j < ROW; j++)
                {
                    for (int k = 0; k < COL; k++)
                    {
                        // Cell 생성
                        Cell[i, j, k] = new Panel();
                        Cell[i, j, k].Size = cellSize;
                        Cell[i, j, k].Top = (bankSize.Height / ROW) * (ROW - j - 1);
                        Cell[i, j, k].Left = (bankSize.Width / COL) * (k);
                        Cell[i, j, k].Parent = Bank[i];
                        Cell[i, j, k].BorderStyle = BorderStyle.FixedSingle;
                        if (j == 0 && k == 0) Cell[i, j, k].BackColor = Color.AntiqueWhite;
                        else if (j == 0 && k != 0) Cell[i, j, k].BackColor = Color.Olive;
                        else if (k == 0 && j != 0) Cell[i, j, k].BackColor = Color.Olive;
                        
                        
                        // Cell Label 생성
                        CellLabel[i, j, k] = new Label();
                        CellLabel[i, j, k].Name = "Cell" + String.Format("{00}", (i + 1).ToString("D2")) + String.Format("{00}", k.ToString("D2")) + String.Format("{00}", j.ToString("D2")); // D2 는 정수 2자리
                        CellLabel[i, j, k].Parent = Cell[i, j, k];
                        CellLabel[i, j, k].Font = labelFont;
                        CellLabel[i, j, k].AutoSize = false;                         // 중앙 정렬을 위한 설정
                        CellLabel[i, j, k].Dock = DockStyle.Fill;                    // 중앙 정렬을 위한 설정
                        CellLabel[i, j, k].TextAlign = ContentAlignment.MiddleCenter;// 중앙 정렬을 위한 설정
                        CellLabel[i, j, k].Click += CellLabel_Click;
                        if (j > 0 && k == 0)  // 왼쪽 가장자리
                            CellLabel[i, j, k].Text = j.ToString() + "행";
                        else if (k > 0 && j == 0)  // 아랫쪽 가장자리
                            CellLabel[i, j, k].Text = k.ToString() + "열";
                        
                    }
                }
            }
        }// end CreateCell

        //셀 라벨 클릭 함수(이벤트)
        private void CellLabel_Click(object sender, EventArgs args)
        {
            string CellName = (sender as Label).Name;
            string CellLocation = CellName.Substring(4, 6);
            cbBank.Text = CellLocation.Substring(0, 2);
            cbCol.Text = CellLocation.Substring(2, 2);
            cbRow.Text = CellLocation.Substring(4, 2);
            string sql = "    SELECT CELL_CODE, CELL_BANK, CELL_BAY, CELL_LEVEL, CELL_STATUS,  " +
                         "           CELL_MEMO, CELL.CELL_IN_USE, CELL.CELL_OT_USE, " +
                         "           STOCK_ALC_CODE, STOCK_ALC_KIND, " +
                         "           STOCK_PLT_CODE, STOCK_LOT_NO1, " +
                         "           STOCK_LOT_NO2, STOCK_LOT_NO3, STOCK_LOT_NO4, " +
                         "           STOCK_LINE, STOCK_DATE, STOCK_TIME " +
                         "           FROM TM_CELL AS CELL " +
                         "         		LEFT JOIN TT_STOCK AS STOCK " +
                         "                     ON CELL.CELL_CODE = STOCK.STOCK_CODE " +
                         "           WHERE CELL_BANK  = '" + cbBank.Text.Trim() + "'" +
                         "             AND CELL_BAY   = '" + cbCol.Text.Trim() + "'" +
                         "             AND CELL_LEVEL = '" + cbRow.Text.Trim() + "'";
            
            SqlDataReader reader = DBUtils.GetSelectData(sql);
            if (reader.Read())
            {
                cbCellStatus.Text = reader["CELL_STATUS"].ToString();
                tbAlcCode.Text = reader["STOCK_ALC_CODE"].ToString();
                tbItem1.Text = reader["STOCK_LOT_NO1"].ToString();
                tbItem2.Text = reader["STOCK_LOT_NO2"].ToString();
                tbItem3.Text = reader["STOCK_LOT_NO3"].ToString();
                tbItem4.Text = reader["STOCK_LOT_NO4"].ToString();

                if (reader["STOCK_PLT_CODE"].ToString() == "00000")
                    tbPltCode.Text = "공PLT";
                else
                    tbPltCode.Text = reader["CELL_STATUS"].ToString();

                cbInPos.SelectedIndex = Int32.Parse(reader["STOCK_LINE"].ToString());
                dtDate.Value = DateTime.ParseExact(reader["STOCK_DATE"].ToString(),"yyyymmdd", null);
                dtTime.Value = DateTime.ParseExact(reader["STOCK_TIME"].ToString(), "HHmmss", null);
                tbBigo.Text = reader["CELL_MEMO"].ToString();
            }
            reader.Close();
        }

        private void SetCellStatus(string CellLocation, string Status, string AlcCode)
        {
            int BankNum = Int32.Parse(CellLocation.Substring(0, 2)) - 1;
            int Col = Int32.Parse(CellLocation.Substring(2, 2));
            int Row = Int32.Parse(CellLocation.Substring(4, 2));

            CellLabel[BankNum, Row, Col].Text = AlcCode; // 셀 라벨 문구 설정

            // 셀 색상 설정
            if (Status == "공셀")
                Cell[BankNum, Row, Col].BackColor = Empty.BackColor;
            else if (Status == "실셀")
                Cell[BankNum, Row, Col].BackColor = Exist.BackColor;
            else if (Status == "입고예약")
                Cell[BankNum, Row, Col].BackColor = IPGOReady.BackColor;
            else if (Status == "출고예약")
                Cell[BankNum, Row, Col].BackColor = CHULGOReady.BackColor;
            else if (Status == "이중입고")
                Cell[BankNum, Row, Col].BackColor = DOUBLEIPGO.BackColor;
            else if (Status == "공출고")
                Cell[BankNum, Row, Col].BackColor = EmptyCHULGO.BackColor;
            else if (Status == "금지셀")
                Cell[BankNum, Row, Col].BackColor = Prohibit.BackColor;
            else if (Status == "동일제품")
                Cell[BankNum, Row, Col].BackColor = SameProduct.BackColor;
            else
                MessageBox.Show("셀 상태명이 잘못되었습니다. [" + Status + "]");
        }// end SetCellStatus


        private void LoopUpStockData() // 재고 조회
        {
            string sql = "  SELECT CELL.*     " +
                         "    FROM (          " +
                         "          SELECT CE.CELL_CODE, CE.CELL_STATUS, CE.CELL_IN_USE, CE.CELL_OT_USE, " +
                         "                ST.STOCK_LINE, ST.STOCK_PLT_CODE, STOCK_ALC_CODE               " +
                         "            FROM TM_CELL CE                                                    " +
                         "            LEFT JOIN TT_STOCK ST                                              " +
                         "                   ON CE.CELL_CODE = ST.STOCK_CODE ) CELL                      " +
                         "                  LEFT JOIN TM_ALCC_MASTER ALC                                 " +
                         "                         ON CELL.STOCK_ALC_CODE = ALC.CODE ";
            SqlDataReader reader = DBUtils.GetSelectData(sql);
            while (reader.Read())
            {
                SetCellStatus(reader["CELL_CODE"].ToString(), reader["CELL_STATUS"].ToString(), reader["STOCK_ALC_CODE"].ToString()); 
            }
            reader.Close(); // 리더가 살아있으면 다른 리더객체 또는 어댑터가 SQL커넥션을 사용할 수 없으므로 닫아줌
        }// end LookUpStockData
    }
}
