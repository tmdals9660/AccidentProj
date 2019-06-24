using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accident.From
{
	public partial class AddAdminInfo : Form
	{
		public AddAdminInfo()
		{
			InitializeComponent();
		}


		private void BtnSaveAddimInfo_Click(object sender, EventArgs e)
		{
			if (txbCode.Text == "0000")
			{
				string id = txbId.Text;
				string passward = txbPassward.Text;

				string AdminInfo = id + "," + passward;

				StreamWriter wr = new StreamWriter("AdminInfo.txt", true);
				wr.WriteLine(AdminInfo);
				wr.Close();
				Close();
				MessageBox.Show("Success");
			}
			else
				MessageBox.Show("Fail");
		}

		public string AdminId { get; set; }
		public string AdminPw { get; set; }
	}
}
