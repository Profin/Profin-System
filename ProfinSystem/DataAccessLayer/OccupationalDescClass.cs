using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OccupationalDescClass
    {
        public OccupationalDescClass() { }

        string occDescID;

        public string OccDescID
        {
            get { return occDescID; }
            set { occDescID = value; }
        }

        string occName;

        public string OccName
        {
            get { return occName; }
            set { occName = value; }
        }

        string ofoCode;

        public string OfoCode
        {
            get { return ofoCode; }
            set { ofoCode = value; }
        }
    }
}
