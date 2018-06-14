using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class TestBLL
    {
        TestAccess testAccess = new TestAccess();
        //public DataTable ShowAllData(Test test)
        //{
        //    return testAccess.HienThiLenDataGridView();
        //}


        public List<Test> TestData()
        {
            return testAccess.TestData();
        }
    }
}
