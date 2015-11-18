using System.ComponentModel.DataAnnotations;

namespace MoneyMe.Web.Models.BankAccount
{
    public class BankAccountViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
        public decimal CreditLimit { get; set; }
        
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
        public decimal CurrentBalance { get; set; }
    }
}