using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class PermissonBLL
    {
        PermissonAccess permissonAccess = new PermissonAccess();
        public bool InsertPermissonInfo(Permission pms)
        {
            return permissonAccess.InsertPermissonInfo(pms);
        }
    }
}
