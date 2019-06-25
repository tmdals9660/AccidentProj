using Accident.Data;
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
        public AddAdminInfo(Admin admin)
        {
            InitializeComponent();

            _admin = admin;
        }

        private Admin _admin;

        private void BtnSaveAddimInfo_Click(object sender, EventArgs e)
        {
            WriteToEntity();

            if (_admin.AdminId == 0)
                DB.Admin.Insert(_admin);
            else
                DB.Admin.Update(_admin);

            Close();
        }
        private void WriteToEntity()
        {
            _admin.AdminIdName = txbId.Text;
            _admin.AdminPassword = txbPassward.Text;
            _admin.AdminName = txbCode.Text;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
