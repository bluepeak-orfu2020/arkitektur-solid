using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class CareCenterCallCenter
    {
        /*
         Stakeholder 2: Connect incoming call to nurse
        */
        public bool AcceptPhoneCall(DateTime visitTime)
        {
            return IsCallCenterAcceptingCalls(visitTime);
        }

        private bool IsCallCenterAcceptingCalls(DateTime datetime)
        {
            return datetime.Hour >= 6 && datetime.Hour <= 21;
        }
    }
}
