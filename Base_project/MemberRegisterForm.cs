using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConfirmNumLib;

namespace Base_project
{
    public partial class MemberRegisterForm : Form
    {
        public MemberRegisterForm()
        {
            InitializeComponent();
            cbox_domain.Items.Add("naver.com");
            cbox_domain.Items.Add("hanmail.net");
            cbox_domain.Items.Add("gmail.com");
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            if (tbox_name.Text == String.Empty)
            {
                MessageBox.Show("이름을 입력하세요");
                tbox_name.Focus();
                return;
            }
            if (tbox_snum.Text == String.Empty)
            {
                MessageBox.Show("학번을 입력하세요");
                tbox_snum.Focus();
                return;
            }
            if (tbox_id.Text == String.Empty)
            {
                MessageBox.Show("아이디를 입력하세요");
                tbox_id.Focus();
                return;
            }
            if (tbox_pw.Text == String.Empty)
            {
                MessageBox.Show("비밀번호를 입력하세요");
                tbox_pw.Focus();
                return;
            }
            if (tbox_email.Text == String.Empty)
            {
                MessageBox.Show("이메일을 입력하세요");
                tbox_email.Focus();
                if (cbox_domain.Text == String.Empty)
                {
                    MessageBox.Show("도메인을 선택하세요");
                    return;
                }
                return;
            }
            SendEmail();
        }

        ConfirmationForm cff;
        private void SendEmail()
        {
            string c_num = ConfirmNum.AuthNum;
            // 인증번호 생성          

            cff = new ConfirmationForm(c_num);
            cff.ShowDialog();
            cff.AuthorizedEvent += Cff_AuthorizedEvent;
        }

        private void Cff_AuthorizedEvent(object sender, AuthorizedEventArgs e)
        {
            if(e.Authorized)
            {
                cff = null;
                RegisterMember();
            }
        }

        public void RegisterMember()
        {
            string name = tbox_name.Text;
            string snum = tbox_snum.Text;
            string id = tbox_id.Text;
            string pw = tbox_pw.Text;
            string email = tbox_email.Text + "@" + cbox_domain.Text;

            //xml로 회원관리
        }

        private void MemberRegisterForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("HelloWorld");
        }
    }
}
