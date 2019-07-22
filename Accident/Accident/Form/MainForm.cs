using Accident.Data;
using Accident.From;
using Accident.From.Feedback;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accident
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();            
        }
        private bool CurrentModeAdmin = false;

        private void BtnSearchEnter_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();            
        }

		private void BtnAdminEnter_Click(object sender, EventArgs e)
		{
			Login login = new Login(this);
			login.ShowDialog();
		}

        private void MsStatistics_Click(object sender, EventArgs e)
        {

        }

        private void MsSearch_Click(object sender, EventArgs e)
        {
            btnSearchEnter.PerformClick();
        }

        private void MsAdminMode_Click(object sender, EventArgs e)
        {
            btnAdminEnter.PerformClick();
        }

        private void MsVoca_Click(object sender, EventArgs e)
        {
            Process.Start("http://taas.koroad.or.kr/sta/acs/exs/wordArngPopup.do");
        }

        private void MsRef_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.data.go.kr/");
        }

        private void MsProblemReporting_Click(object sender, EventArgs e)
        {

        }

        private void MsFunction_Click(object sender, EventArgs e)
        {
            FunctionPropose functionPropose = new FunctionPropose();
            functionPropose.ShowDialog();
        }

        private void MsClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void ModeAdmin()
        {
            CurrentModeAdmin = true;
            stlMode.Text = "관리자 모드";
            btnAdverMakeId.Image = global::Accident.Properties.Resources.SignUp;
            btnLogout.Visible = true;
            btnInsert.Visible = true;
        }

        public void ModeUser()
        {
            CurrentModeAdmin = false;
            stlMode.Text = "일반 모드";
            btnAdverMakeId.Image = global::Accident.Properties.Resources.Adv;
            btnLogout.Visible = false;
            btnInsert.Visible = false;
        }
       
        private void BtnMakeId_Click(object sender, EventArgs e)
        {
        }

        private void BtnAdver_Click(object sender, EventArgs e)
        {

            if (CurrentModeAdmin)
            {
                UserListForm userListForm = new UserListForm();
                userListForm.ShowDialog();
            }
            else Process.Start("http://www.koroad.or.kr/kp_web/krNewsList.do?board_code=GABBS_060");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            ModeUser();
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            InsertForm form = new InsertForm();
            form.ShowDialog();
        }
    }
}
