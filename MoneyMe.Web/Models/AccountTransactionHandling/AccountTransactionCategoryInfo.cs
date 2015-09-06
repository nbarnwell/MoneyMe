using System.Collections.Generic;

namespace MoneyMe.Web.Models.AccountTransactionHandling
{
    public class AccountTransactionCategoryInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<MatchPattern> MatchPatterns { get; set; }

        public class MatchPattern
        {
            public int Id { get; set; }
            public int CategoryId { get; set; }
            public string Pattern { get; set; }
            public MatchMethod MatchMethod { get; set; }
        }

        public enum MatchMethod
        {
            ContainsText = 1,
            RegularExpression,
            LevenshteinDistance
        }
    }
}