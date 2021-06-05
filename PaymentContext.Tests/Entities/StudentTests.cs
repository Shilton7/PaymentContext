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
        private readonly Name _name;
        private readonly Email _email;
        private readonly Document _document;
        private readonly Address _address;
        private readonly Student _student;

        public StudentTests()
        {
            _name = new Name("Shilton", "Ferreira");
            _document = new Document("12345678909",EDocumentType.CPF);
            _email = new Email("shilton@gmail.com");
            _student = new Student(_name,_document,_email);
            _address = new Address("Rua de Lourdes","176","Bairro Havai","BH","MG","Brasil","34565909");
        }

        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription()
        {
            var subscription = new Subscription(null);
            var payment = new PaypalPayment("39087564469766565",DateTime.Now,DateTime.Now.AddDays(5),100,
                                            100,"Shilton",_email,_document,_address);

            subscription.AddPayment(payment);
            _student.AddSubscription(subscription);
            _student.AddSubscription(subscription);

            Assert.IsTrue(_student.Invalid);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenSubscriptionHashNoPayment()
        {
            var subscription = new Subscription(null);
            _student.AddSubscription(subscription);

            Assert.IsTrue(_student.Invalid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenAddSubscription()
        {
            var subscription = new Subscription(null);
            var payment = new PaypalPayment("39087564469766565",DateTime.Now,DateTime.Now.AddDays(5),100,
                                            100,"Shilton",_email,_document,_address);

            subscription.AddPayment(payment);
            _student.AddSubscription(subscription);

            Assert.IsTrue(_student.Valid);
        }
    }
}
