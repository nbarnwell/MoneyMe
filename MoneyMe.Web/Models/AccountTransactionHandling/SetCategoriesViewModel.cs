using System.Collections.Generic;

namespace MoneyMe.Web.Models.AccountTransactionHandling
{
    public class SetCategoriesViewModel
    {
        public int TransactionId { get; set; }
        public IEnumerable<CategoryViewModel> SuggestedCategories { get; set; }
        public string SelectedCategoryIds { get; set; }
    }
}