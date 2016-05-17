using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_project
{
    public partial class ConfirmationForm : Form
    {
        string c_num;
        public ConfirmationForm(string c_num)
        {
            InitializeComponent();
            this.c_num = c_num;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (tbox_cfnum.Text == String.Empty)
            {
                MessageBox.Show("인증번호를 적으세요");
                tbox_cfnum.Focus();
                return;
            }

            if (tbox_cfnum.Text == c_num)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("인증번호가 틀렸습니다.");
                tbox_cfnum.Focus();
                return;
            }
        }

    }
}
