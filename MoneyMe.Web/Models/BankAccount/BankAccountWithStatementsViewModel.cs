using System.Collections.Generic;

namespace MoneyMe.Web.Models.BankAccount
{
    public class BankAccountWithStatementsViewModel : BankAccountViewModel
    {
        public IEnumerable<BankAccountStatementViewModel> Statements { get; set; }
    }
}