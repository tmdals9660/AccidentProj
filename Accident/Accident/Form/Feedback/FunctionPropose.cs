using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accident.Data;

namespace Accident.From.Feedback
{
    public partial class FunctionPropose : Form
    {
        public FunctionPropose()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            FuncPropose funcPropose = new FuncPropose();

            funcPropose.mailFunc = txbMailFunc.Text;
            funcPropose.subjFunc = txbSubj.Text;
            funcPropose.contentsFunc = txbContents.Text;

            if(funcPropose.InputCheck(funcPropose))
            { 
            funcPropose.SuccesProposeSend(funcPropose);

            MessageBox.Show($"안녕하세요 {funcPropose.mailFunc}님 \n정상적으로 전송되었습니다.\n관심가져주셔서 감사.");

            Close();
            }
            else MessageBox.Show("입력되지 않은 항목이 있습니다.");
        }
    }
}
