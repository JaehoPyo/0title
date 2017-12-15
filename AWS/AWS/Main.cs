using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AWS.form;
using AWS.Lib;

namespace AWS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void MenuClick(object sender, EventArgs args)
        {
            Form form;
            Button btn = sender as Button;
            switch (Convert.ToInt32(btn.Tag))
            {
                case 110:
                    if (!IsFormOpen("U110"))
                    {
                        form = new U110();
                        form.MdiParent = this;
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                    else
                    {
                        form = FindOpenForm("U110");
                        form.Activate();
                        form.BringToFront();
                    }
                    break;
                case 120:
                    if (!IsFormOpen("U120"))
                    {
                        form = new U120();
                        form.MdiParent = this;
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                    else
                    {
                        form = FindOpenForm("U120");
                        form.Activate();
                        form.BringToFront();
                    }
                    break;
                case 210 :
                    if (!IsFormOpen("U210"))
                    {
                        form = new U120();
                        form.MdiParent = this;
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                    else
                    {
                        form = FindOpenForm("U210");
                        form.Activate();
                        form.BringToFront();
                    }
                    break;
                case 220 :
                    if (!IsFormOpen("U220"))
                    {
                        form = new U120();
                        form.MdiParent = this;
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                    else
                    {
                        form = FindOpenForm("U220");
                        form.Activate();
                        form.BringToFront();
                    }
                    break;
                case 230 :
                    break;

                case 240 :
                    if (!IsFormOpen("U240"))
                    {
                        form = new U240();
                        form.MdiParent = this;
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                    else
                    {
                        form = FindOpenForm("U240");
                        form.Activate();
                        form.BringToFront();
                    }
                    break;

                case 310:
                    if (!IsFormOpen("U310"))
                    {
                        form = new U310();
                        form.MdiParent = this;
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                    else
                    {
                        form = FindOpenForm("U310");
                        form.Activate();
                        form.BringToFront();
                    }

                    break;

                default: MessageBox.Show("지정되어있지 않은 메뉴입니다.");
                    break;
            }
        }

        private Form FindOpenForm(string formName)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == formName)
                    return form;
            }
            return null;

        }

        private bool IsFormOpen(string formName)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == formName)
                    return true;
            }
            return false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            tsStatus1.Text = "사용자 : " + h_MainLib.NAME;

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("종료 하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
                return;
            }
        }

  }
}
