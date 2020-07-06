using BusinessRulesEngineBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngineBL
{
    public class UpgradeMembershipPayment : IPaymentDetails
    {
        public bool Payment(out string msg)
        {
            bool result = UpgradeMembership();
            if (result == true)
                msg = "1.Membership Upgraded Successfully. <br/> <br/> 2. Email Sent to the Member.";
            else
                msg = "Payment Failed";

            return result;
        }

        public bool UpgradeMembership()
        {
            //Logic here
            return SendEmailToMember();
        }

        private bool SendEmailToMember()
        {
            //Logic here
            return true;
        }
    }
}
