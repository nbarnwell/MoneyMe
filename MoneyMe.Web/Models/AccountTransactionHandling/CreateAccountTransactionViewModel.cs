using System;

namespace MoneyMe.Web.Models.AccountTransactionHandling
{
    public class CreateAccountTransactionViewModel
    {
        public DateTimeOffset ReceiptDate                { get; set; }
        public decimal        Amount                     { get; set; }
        public string         Payee                      { get; set; }
        public string         Description                { get; set; }
        public int            AccountTransactionTypeId   { get; set; }
    }
}