using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using MoneyMe.Web.Models.AccountTransactionHandling;

namespace MoneyMe.Web.Services
{
    public static class CategoryService
    {
        public static IEnumerable<AccountTransactionCategoryInfo> SuggestCategories(
            IEnumerable<AccountTransactionCategoryInfo> categories,
            string description)
        {
            var result = new List<AccountTransactionCategoryInfo>();

            foreach (var category in categories)
            {
                foreach (var matchPattern in category.MatchPatterns)
                {
                    switch (matchPattern.MatchMethod)
                    {
                        case AccountTransactionCategoryInfo.MatchMethod.ContainsText:
                            if (description.Contains(matchPattern.Pattern))
                            {
                                result.Add(category);
                            }
                            break;
                        case AccountTransactionCategoryInfo.MatchMethod.RegularExpression:
                            if (Regex.IsMatch(description, matchPattern.Pattern))
                            {
                                result.Add(category);
                            }
                            break;
                        case AccountTransactionCategoryInfo.MatchMethod.LevenshteinDistance:
                        default:
                            throw new NotImplementedException(string.Format("{0} is not yet implemented", matchPattern.MatchMethod));
                    }
                }
            }

            return result.Distinct().OrderBy(x => x.Name).ToList();
        }
    }
}