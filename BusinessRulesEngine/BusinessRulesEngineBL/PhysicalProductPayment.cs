using BusinessRulesEngineBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngineBL
{
    public class PhysicalProductPayment : IPaymentDetails
    {
        public bool Payment(out string msg)
        {
            bool result = GeneratePackagingSlipForShipping();
            if (result == true)
                msg = "1. Packing Slip for Shipping Generated Successfully. <br/> <br/> 2. Commission Payment to the Agent Generated Successfully.";
            else
                msg = "Payment Failed";

            return result;
        }

        public bool GeneratePackagingSlipForShipping()
        {
            //Logic here
            return GenerateCommisionPaymentToAgent();
        }

        private bool GenerateCommisionPaymentToAgent()
        {
            //Logic here
            return true;
        }
    }
}
