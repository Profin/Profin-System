using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class DepartmentClass
    {
        public DepartmentClass(){}

        string departmentID;

        public string DepartmentID
        {
            get { return departmentID; }
            set { departmentID = value; }
        }

        string departmentName;

        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
    }
}
