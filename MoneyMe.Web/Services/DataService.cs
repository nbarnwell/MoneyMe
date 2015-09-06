﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Transactions;
using Dapper;
using MoneyMe.Web.Models;
using IsolationLevel = System.Transactions.IsolationLevel;

namespace MoneyMe.Web.Services
{
    public static class DataService
    {
        public static TransactionScope BeginTransactionScope()
        {
            return new TransactionScope(
                TransactionScopeOption.Required,
                new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted });
        }

        public static IDbConnection OpenConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }

        public static void Execute(Action<IDbConnection> action)
        {
            using (var tx = BeginTransactionScope())
            using (var c = OpenConnection())
            {
                action(c);

                tx.Complete();
            }
        }

        public static T Execute<T>(Func<IDbConnection, T> action)
        {
            using (var tx = BeginTransactionScope())
            using (var c = OpenConnection())
            {
                var result = action(c);

                tx.Complete();

                return result;
            }
        }

        public static void CreateInternalUser(ApplicationUser aspNetUser)
        {
            Execute(
                c =>
                {
                    var positionId = c.ExecuteScalar<int>(
                        @"insert into Position default values;
                        select scope_identity();");

                    var userId = c.ExecuteScalar<int>(
                        @"insert into [User] (AspNetUserId, PositionId) values (@aspNetUserId, @positionId);
                        select scope_identity();",
                        new { aspNetUserId = aspNetUser.Id, positionId });

                    c.Execute(
                        @"insert into UserPosition (UserId, PositionId) values (@userId, @positionId);",
                        new { userId, positionId });
                });
        }

        public static int GetAccountId(string accountNumber, string sortCode)
        {
            return Execute(
                c => c.ExecuteScalar<int>(
                    @"select Id 
                        from Account 
                        where UserId = @userId 
                        and AccountNumber = @accountNumber
                        and SortCode = @sortCode;",
                    new { userId = Context.GetUserId(), accountNumber, sortCode }));
        }

        public static IEnumerable<AccountTransactionTypeViewModel> GetAccountTransactionTypes()
        {
            return Execute(
                c => c.Query<AccountTransactionTypeViewModel>(
                    @"select Id, Name, IsIncome from AccountTransactionType order by Name;"));
        }

        public static IEnumerable<AccountViewModel> GetAccounts()
        {
            return Execute(
                c => c.Query<AccountViewModel>(
                    @"select a.* 
                        from Account a
                        inner join Position p on a.PositionId = p.Id
                        inner join UserPosition up on p.Id = up.PositionId
                        inner join [User] u on up.UserId = u.Id
                        where u.Id = @userId;",
                    new { userId = Context.GetUserId() })
                    .ToList());
        }
    }
}