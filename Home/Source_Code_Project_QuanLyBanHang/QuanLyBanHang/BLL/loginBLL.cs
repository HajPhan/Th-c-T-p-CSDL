using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class loginBLL
    {
        LoginAccess loginAccess = new LoginAccess();
        public bool CheckLogin(Login login)
        {
            return loginAccess.KiemTraDangNhap(login);
        }

        
    }
}
