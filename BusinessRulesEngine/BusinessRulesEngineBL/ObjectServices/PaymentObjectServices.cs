using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRulesEngineBL;
using BusinessRulesEngineBL.Interfaces;
using BusinessRulesEngineHelper;
 
 
namespace BusinessRulesEngineBL.ObjectServices
{
    public class PaymentObjectServices 
    {
        public static IPaymentDetails GetPaymentObjectDetails(int orderType)
        {
            IPaymentDetails paymentForObject;

            if (orderType == (int)PaymentItemsValue.PhysicalProduct)
            {
                paymentForObject = new PhysicalProductPayment();
            }
            else if (orderType == (int)PaymentItemsValue.Book)
            {
                paymentForObject = new BookPayment();
            }
            else if (orderType == (int)PaymentItemsValue.ActivateMembership)
            {
                paymentForObject = new ActivateMembershipPayment();
            }
            else if (orderType == (int)PaymentItemsValue.UpgradeMembership)
            {
                paymentForObject = new UpgradeMembershipPayment();
            }
            else if (orderType == (int)PaymentItemsValue.Video)
            {
                paymentForObject = new VideoLearningPayment();
            }
            else
            {
                paymentForObject = null;
            }

            return paymentForObject;
        }
    }
}
