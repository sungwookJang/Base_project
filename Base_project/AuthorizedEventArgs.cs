using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_project
{
    public class AuthorizedEventArgs : EventArgs// 인증번호 확인 된 경우 발생하는 이벤트
    {
        public bool Authorized 
        {
            get;
            private set;
        }
        public AuthorizedEventArgs(bool auth)
        {
            Authorized = auth;
        }
    }
    public delegate void AuthorizedEventHandler(object sender, AuthorizedEventArgs e);
}
