using Accident.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Accident.From
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void Login_Load(object sender, EventArgs e)
		{
			txbId.Text = Settings.Default.LoginId;
		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{

			List<AddAdminInfo> AdminLists = new List<AddAdminInfo>();

			StreamReader rd = new StreamReader("AdminInfo.txt");

			while (!rd.EndOfStream)
			{
				string list = rd.ReadLine();
				string[] cols = list.Split(',');

				AddAdminInfo info  = new AddAdminInfo();
				info.AdminId = cols[0];
				info.AdminPw = cols[1];

				AdminLists.Add(info);

				if (txbId.Text == info.AdminId && txbPw.Text == info.AdminPw)
				{
					MessageBox.Show("Login Success");

					Settings.Default.LoginId = txbId.Text;
					Settings.Default.Save();
					Close();
				}
				else if (rd.EndOfStream)
					MessageBox.Show("Login Fail");
			}
			rd.Close();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void BtnSingUp_Click(object sender, EventArgs e)
		{
			AddAdminInfo addInfo = new AddAdminInfo();
			addInfo.ShowDialog();
		}
	}
}
