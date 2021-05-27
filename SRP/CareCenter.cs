using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class CareCenter
    {
        /*
          Stakeholder 1: Allow visits in person
        */
        public bool AcceptVisitor(DateTime visitTime)
        {
            return IsCareCenterOpen(visitTime);
        }

        /*
         Stakeholder 2: Connect incoming call to nurse
        */
        public bool AcceptPhoneCall(DateTime visitTime)
        {
            return IsCareCenterOpen(visitTime);
        }

        private bool IsCareCenterOpen(DateTime datetime)
        {
            return datetime.Hour >= 6 && datetime.Hour <= 21;
        }
    }
}
