using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //var subscription = new Subscription(null);
            //var student = new Student("Shilton","Sant","12345678909","shilton@gmail.com");
            //student.FirstName = "teste nome";
            //student.AddSubscription(subscription);

            var name = new Name("teste", "jhjh");

            foreach(var not in name.Notifications)
            {
                
            }
            
        }
    }
}
