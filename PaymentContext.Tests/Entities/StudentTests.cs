using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var subscription = new Subscription(null);
            var student = new Student("Shilton","Sant","12345678909","shilton@gmail.com");
            //student.FirstName = "teste nome";
            student.AddSubscription(subscription);
        }
    }
}
