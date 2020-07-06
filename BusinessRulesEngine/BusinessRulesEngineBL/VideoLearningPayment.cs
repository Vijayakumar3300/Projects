using BusinessRulesEngineBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngineBL
{
    public class VideoLearningPayment : IPaymentDetails
    {
        public bool Payment(out string msg)
        {
            bool result = GenerateVideoLearningPackingSlip();
            if (result == true)
                msg = "1.Video Learning Packing Slip Generated Successfully. <br/> <br/> 2. Free First Aid Video Added Successfully with the Packing Slip.";
            else
                msg = "Payment Failed";

            return result;
        }

        public bool GenerateVideoLearningPackingSlip()
        {
            //Logic here
            return AddFirstAidVideo();
        }

        private bool AddFirstAidVideo()
        {
            //Logic here
            return true;
        }
    }
}
