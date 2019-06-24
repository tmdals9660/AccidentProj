using Accident.Properties;
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
			Settings.Default.LoginId = txbId.Text;
			Settings.Default.Save();
		}


		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void BtnSingUp_Click(object sender, EventArgs e)
		{

		}
	}
}
