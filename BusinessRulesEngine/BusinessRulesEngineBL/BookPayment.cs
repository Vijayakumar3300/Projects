using BusinessRulesEngineBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngineBL
{
    public class BookPayment : IPaymentDetails 
    {
        public bool Payment(out string msg)
        {
            bool result = GenerateDuplicatePackagingSlipForRoyality();
            if (result == true)
                msg = "1.Duplicate Packing Slip Created for the Royality Department. <br/> <br/> 2. Commission Payment to the Agent Generated Successfully.";
            else
                msg = "Payment Failed";

            return result;
        }

        public bool GenerateDuplicatePackagingSlipForRoyality()
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
