using Accident.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accident.Helpers
{
    public class FormHelper
    {
        public static bool SureToDelete(string text = "삭제하시겠습니까?")
        {
            return MessageBox.Show(text, "질문", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
        }

        public static void UserMakeIdSucces(Admin admin)
        {
            MessageBox.Show($"아이디가 정상적으로 추가되었습니다.\n성함 : {admin.AdminName}\n ID : {admin.AdminIdName}");
        }

      

        public static bool SureToAddIncident(string text = "정말로 추가 하시겠습니까? \n한번 입력된 자료는 더 이상 수정 및 삭제가 불가능 합니다.")
        {
            return MessageBox.Show(text, "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
        }
        public static void AddIncidentSucces()
        {
            MessageBox.Show($"사고등록이 정상적으로 처리되었습니다.");
        }

        public static void UserMakeIdFail()
        {
            MessageBox.Show("입력되지 않은 항목이 있거나 " +
                "이미 존재하는 ID입니다.");
        }

        public static void AddIncidentFail()
        {
            MessageBox.Show("입력되지 않은 항목이 있습니다.");
        }

        public static void LoginFail()
        {
            MessageBox.Show("존재하지 않는 ID이거나\n비밀번호가 일치하지 않습니다.");
        }

        public static void LoginSucces(Admin admin)
        {
            MessageBox.Show($"안녕하세요. {admin.AdminName.ToString()}님!" +
                   $"\n로그인 되었습니다.");
        }

        public static void ProposeFail()
        {
            MessageBox.Show("입력되지 않은 항목이 있습니다.");
        }

        public static void ProposeSucces(FuncPropose funcPropose)
        {
            MessageBox.Show($"안녕하세요 {funcPropose.mailFunc}님 \n정상적으로 전송되었습니다.\n관심가져주셔서 감사.");
        }

        

    }
}
