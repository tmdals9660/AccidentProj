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

        private void BtnSearchEnter_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

		private void BtnAdminEnter_Click(object sender, EventArgs e)
		{
			Login login = new Login();
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
    }
}
