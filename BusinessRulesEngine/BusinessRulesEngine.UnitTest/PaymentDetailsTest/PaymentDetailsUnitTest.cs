using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessRulesEngineBL.Interfaces;
using BusinessRulesEngineBL.ObjectServices;
using BusinessRulesEngineHelper;

namespace BusinessRulesEngine.UnitTest.PaymentDetailsTest
{
    [TestClass]
    public class PaymentDetailsUnitTest
    {
        [TestMethod]
        public void TestMethod_PhysicalProduct()
        {
            string msg = "";
            IPaymentDetails obj = PaymentObjectServices.GetPaymentObjectDetails((int)PaymentItemsValue.PhysicalProduct);
            bool result = obj.Payment(out msg);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestMethod_Book()
        {
            string msg = "";
            IPaymentDetails obj = PaymentObjectServices.GetPaymentObjectDetails((int)PaymentItemsValue.Book);
            bool result = obj.Payment(out msg);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestMethod_ActivateMembership()
        {
            string msg = "";
            IPaymentDetails obj = PaymentObjectServices.GetPaymentObjectDetails((int)PaymentItemsValue.ActivateMembership);
            bool result = obj.Payment(out msg);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestMethod_UpgradeMembership()
        {
            string msg = "";
            IPaymentDetails obj = PaymentObjectServices.GetPaymentObjectDetails((int)PaymentItemsValue.UpgradeMembership);
            bool result = obj.Payment(out msg);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestMethod_Video()
        {
            string msg = "";
            IPaymentDetails obj = PaymentObjectServices.GetPaymentObjectDetails((int)PaymentItemsValue.Video);
            bool result = obj.Payment(out msg);
            Assert.AreEqual(result, true);
        }
    }
}
