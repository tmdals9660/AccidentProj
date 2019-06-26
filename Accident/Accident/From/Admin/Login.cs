using Accident.Data;
using Accident.Helpers;
using Accident.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Accident.From
{
    public partial class Login : Form
    {
        private MainForm _form;

        public Login(MainForm form)
        {
            InitializeComponent();

            _form = form;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            Admin admins = DB.Admin.LoginCheck(txbId.Text, txbPw.Text);
            if (admins != null)
            {
                FormHelper.LoginSucces(admins);

                _form.ModeAdmin();

                Close();
            }
            else FormHelper.LoginFail();
               
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
