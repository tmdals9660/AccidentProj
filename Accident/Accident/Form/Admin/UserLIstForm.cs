using Accident.Data;
using Accident.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accident.From
{
    public partial class UserListForm : Form
    {
        public UserListForm()
        {
            InitializeComponent();

            dgvAdminList.DataSource = DB.Admin.GetAll();
        }

        private void UserListForm_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgcAdminList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvAdminList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                Admin admin = new Admin();
                AddAdminInfo form = new AddAdminInfo(admin, this);
                form.Show();

            }
            else if (e.KeyCode == Keys.Delete)
            {
                Admin admin = dgvAdminList.CurrentRow.DataBoundItem as Admin;

                if (admin == null) return;

                if (FormHelper.SureToDelete())
                {
                    DB.Admin.Delete(admin);
                    Close();
                }


            }
        }
    }
}
