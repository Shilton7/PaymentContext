using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barCode, string boletoNumber , DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Email email, Document document, Address address) 
                            : base(paidDate, expireDate, total, totalPaid, payer, email, document, address)
        {
            this.BarCode = barCode;
            this.BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
    }


}