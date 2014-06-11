using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class HighestQualificationClass
    {
        public HighestQualificationClass() { }

        string qualificationID;

        public string QualificationID
        {
            get { return qualificationID; }
            set { qualificationID = value; }
        }

        string qualifiactionName;

        public string QualifiactionName
        {
            get { return qualifiactionName; }
            set { qualifiactionName = value; }
        }

    }
}
