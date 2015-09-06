using System;

namespace MoneyMe.Web.Models.AccountTransaction
{
    public class CreateAccountTransactionViewModel
    {
        public DateTimeOffset TransactionDate            { get; set; }
        public DateTimeOffset ReceiptDate                { get; set; }
        public decimal        Amount                     { get; set; }
        public string         Payee                      { get; set; }
        public string         Description                { get; set; }
        public int            PaymentMethodId            { get; set; }
    }
}