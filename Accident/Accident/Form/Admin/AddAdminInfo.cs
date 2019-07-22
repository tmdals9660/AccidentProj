using Accident.Data;
using Accident.Helpers;
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
        public AddAdminInfo(Admin admin,UserListForm userListForm)
        {
            InitializeComponent();

            _userListForm = userListForm;

            _admin = admin;
        }

        private UserListForm _userListForm;
        private Admin _admin;

        private void BtnSaveAddimInfo_Click(object sender, EventArgs e)
        {
            WriteToEntity();
            if (InputCheck(_admin) && DB.Admin.UserMakeCheck(_admin))
            {

                if (_admin.AdminId == 0)
                    DB.Admin.Insert(_admin);
                else
                    DB.Admin.Update(_admin);


                FormHelper.UserMakeIdSucces(_admin);

                Close();

                _userListForm.Close();

            }
            else FormHelper.UserMakeIdFail();


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
        public bool InputCheck(Admin admin)
        {
            bool check = true;

            if (admin.AdminIdName == string.Empty) check = false;
            if (admin.AdminPassword == string.Empty) check = false;
            if (admin.AdminName == string.Empty) check = false;

            return check;
        }
    }
}
