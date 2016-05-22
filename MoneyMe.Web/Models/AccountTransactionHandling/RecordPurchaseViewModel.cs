using System;

namespace MoneyMe.Web.Models.AccountTransactionHandling
{
    public class RecordPurchaseViewModel
    {
        public DateTimeOffset PurchasedAt         { get; set; }
        public string         Payee               { get; set; }
        public string         OverviewDescription { get; set; }
        public decimal        Amount              { get; set; }
        public int            PaymentMethodId     { get; set; }
    }
}