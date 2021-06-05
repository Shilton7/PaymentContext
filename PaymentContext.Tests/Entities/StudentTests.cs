using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        //[TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription()
        {
            var name = new Name("Shilton", "Ferreira");
            var document = new Document("12345678909",EDocumentType.CPF);
            var email = new Email("shilton@gmail.com");

            var student = new Student(name,document,email);

            var subscription = new Subscription(null);
            var adress = new Address("Rua de Lourdes","176","Bairro Havai","BH","MG","Brasil","34565909");
            var payment = new PaypalPayment("39087564469766565",DateTime.Now,DateTime.Now.AddDays(5),100,
                                            100,"Shilton",email,document,adress);

            subscription.AddPayment(payment);
            student.AddSubscription(subscription);
            student.AddSubscription(subscription);

            Assert.IsTrue(student.Invalid);
        }

        public void ShouldReturnErrorWhenSubscriptionHashNoPayment()
        {
            
        }

        public void ShouldReturnSuccessWhenHadNoActiveSubscription()
        {
            var name = new Name("Shilton", "Ferreira");
            var document = new Document("12345678909",EDocumentType.CPF);
            var email = new Email("shilton@gmail.com");

            var student = new Student(name,document,email);

            var subscription = new Subscription(null);
            var adress = new Address("Rua de Lourdes","176","Bairro Havai","BH","MG","Brasil","34565909");
            var payment = new PaypalPayment("39087564469766565",DateTime.Now,DateTime.Now.AddDays(5),100,
                                            100,"Shilton",email,document,adress);

            subscription.AddPayment(payment);
            student.AddSubscription(subscription);
        }
    }
}
