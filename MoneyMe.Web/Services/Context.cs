using System;
using System.Security.Cryptography;
using System.Web;
using Dapper;

namespace MoneyMe.Web.Services
{
    public static class Context
    {
        public static int GetUserId()
        {
            var email = HttpContext.Current.User.Identity.Name;

            using (var tx = DataService.BeginTransactionScope())
            using (var c = DataService.OpenConnection())
            {
                var result = c.ExecuteScalar<int>(
                    @"select u.Id
                    from [User] u
                    inner join AspNetUsers au
                        on u.AspNetUserId = au.Id
                    where au.Email = 'mailbox@neilbarnwell.co.uk';",
                    new { email });

                tx.Complete();

                return result;
            }
        }
    }
}