using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class PaypalPayment : Payment
    {
        public PaypalPayment(string transactionCode, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Email email, Document document, Address address) 
                            : base(paidDate, expireDate, total, totalPaid, payer, email, document, address)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }
    }


}