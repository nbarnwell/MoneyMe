

// This file was automatically generated.
// Do not make changes directly to this file - edit the template instead.
// 
// The following connection settings were used to generate this file
// 
//     Configuration file:     "MoneyMe.Web\Web.config"
//     Connection String Name: "DefaultConnection"
//     Connection String:      "server=(local);database=Vita;trusted_connection=true;"

// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity.ModelConfiguration;
//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace MoneyMe.Web.Models.Scaffolding
{
    // ************************************************************************
    // Unit of work
    public interface IScaffoldDbContext : IDisposable
    {
        IDbSet<Account> Accounts { get; set; } // Account
        IDbSet<AccountStatement> AccountStatements { get; set; } // AccountStatement
        IDbSet<AccountTransaction> AccountTransactions { get; set; } // AccountTransaction
        IDbSet<AccountTransactionAccountTransactionCategory> AccountTransactionAccountTransactionCategories { get; set; } // AccountTransactionAccountTransactionCategory
        IDbSet<AccountTransactionCategory> AccountTransactionCategories { get; set; } // AccountTransactionCategory
        IDbSet<AccountTransactionCategoryMatchPattern> AccountTransactionCategoryMatchPatterns { get; set; } // AccountTransactionCategoryMatchPattern
        IDbSet<AccountTransactionCategoryMatchPatternMatchMethod> AccountTransactionCategoryMatchPatternMatchMethods { get; set; } // AccountTransactionCategoryMatchPatternMatchMethod
        IDbSet<AccountTransactionStatu> AccountTransactionStatus { get; set; } // AccountTransactionStatus
        IDbSet<AccountTransactionType> AccountTransactionTypes { get; set; } // AccountTransactionType
        IDbSet<AggregateRoot> AggregateRoots { get; set; } // AggregateRoot
        IDbSet<AggregateRootEvent> AggregateRootEvents { get; set; } // AggregateRootEvent
        IDbSet<AspNetRole> AspNetRoles { get; set; } // AspNetRoles
        IDbSet<AspNetUser> AspNetUsers { get; set; } // AspNetUsers
        IDbSet<AspNetUserClaim> AspNetUserClaims { get; set; } // AspNetUserClaims
        IDbSet<AspNetUserLogin> AspNetUserLogins { get; set; } // AspNetUserLogins
        IDbSet<Bank> Banks { get; set; } // Bank
        IDbSet<BankAccount> BankAccounts { get; set; } // BankAccount
        IDbSet<BankSpecificTransactionType> BankSpecificTransactionTypes { get; set; } // BankSpecificTransactionType
        IDbSet<Budget> Budgets { get; set; } // Budget
        IDbSet<Fund> Funds { get; set; } // Fund
        IDbSet<Position> Positions { get; set; } // Position
        IDbSet<User> Users { get; set; } // User
        IDbSet<UserPosition> UserPositions { get; set; } // UserPosition

        int SaveChanges();
        
        // Stored Procedures
    }

    // ************************************************************************
    // Database context
    public class ScaffoldDbContext : DbContext, IScaffoldDbContext
    {
        public IDbSet<Account> Accounts { get; set; } // Account
        public IDbSet<AccountStatement> AccountStatements { get; set; } // AccountStatement
        public IDbSet<AccountTransaction> AccountTransactions { get; set; } // AccountTransaction
        public IDbSet<AccountTransactionAccountTransactionCategory> AccountTransactionAccountTransactionCategories { get; set; } // AccountTransactionAccountTransactionCategory
        public IDbSet<AccountTransactionCategory> AccountTransactionCategories { get; set; } // AccountTransactionCategory
        public IDbSet<AccountTransactionCategoryMatchPattern> AccountTransactionCategoryMatchPatterns { get; set; } // AccountTransactionCategoryMatchPattern
        public IDbSet<AccountTransactionCategoryMatchPatternMatchMethod> AccountTransactionCategoryMatchPatternMatchMethods { get; set; } // AccountTransactionCategoryMatchPatternMatchMethod
        public IDbSet<AccountTransactionStatu> AccountTransactionStatus { get; set; } // AccountTransactionStatus
        public IDbSet<AccountTransactionType> AccountTransactionTypes { get; set; } // AccountTransactionType
        public IDbSet<AggregateRoot> AggregateRoots { get; set; } // AggregateRoot
        public IDbSet<AggregateRootEvent> AggregateRootEvents { get; set; } // AggregateRootEvent
        public IDbSet<AspNetRole> AspNetRoles { get; set; } // AspNetRoles
        public IDbSet<AspNetUser> AspNetUsers { get; set; } // AspNetUsers
        public IDbSet<AspNetUserClaim> AspNetUserClaims { get; set; } // AspNetUserClaims
        public IDbSet<AspNetUserLogin> AspNetUserLogins { get; set; } // AspNetUserLogins
        public IDbSet<Bank> Banks { get; set; } // Bank
        public IDbSet<BankAccount> BankAccounts { get; set; } // BankAccount
        public IDbSet<BankSpecificTransactionType> BankSpecificTransactionTypes { get; set; } // BankSpecificTransactionType
        public IDbSet<Budget> Budgets { get; set; } // Budget
        public IDbSet<Fund> Funds { get; set; } // Fund
        public IDbSet<Position> Positions { get; set; } // Position
        public IDbSet<User> Users { get; set; } // User
        public IDbSet<UserPosition> UserPositions { get; set; } // UserPosition

        static ScaffoldDbContext()
        {
            Database.SetInitializer<ScaffoldDbContext>(null);
        }

        public ScaffoldDbContext()
            : base("Name=DefaultConnection")
        {
        }

        public ScaffoldDbContext(string connectionString) : base(connectionString)
        {
        }

        public ScaffoldDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AccountConfiguration());
            modelBuilder.Configurations.Add(new AccountStatementConfiguration());
            modelBuilder.Configurations.Add(new AccountTransactionConfiguration());
            modelBuilder.Configurations.Add(new AccountTransactionAccountTransactionCategoryConfiguration());
            modelBuilder.Configurations.Add(new AccountTransactionCategoryConfiguration());
            modelBuilder.Configurations.Add(new AccountTransactionCategoryMatchPatternConfiguration());
            modelBuilder.Configurations.Add(new AccountTransactionCategoryMatchPatternMatchMethodConfiguration());
            modelBuilder.Configurations.Add(new AccountTransactionStatuConfiguration());
            modelBuilder.Configurations.Add(new AccountTransactionTypeConfiguration());
            modelBuilder.Configurations.Add(new AggregateRootConfiguration());
            modelBuilder.Configurations.Add(new AggregateRootEventConfiguration());
            modelBuilder.Configurations.Add(new AspNetRoleConfiguration());
            modelBuilder.Configurations.Add(new AspNetUserConfiguration());
            modelBuilder.Configurations.Add(new AspNetUserClaimConfiguration());
            modelBuilder.Configurations.Add(new AspNetUserLoginConfiguration());
            modelBuilder.Configurations.Add(new BankConfiguration());
            modelBuilder.Configurations.Add(new BankAccountConfiguration());
            modelBuilder.Configurations.Add(new BankSpecificTransactionTypeConfiguration());
            modelBuilder.Configurations.Add(new BudgetConfiguration());
            modelBuilder.Configurations.Add(new FundConfiguration());
            modelBuilder.Configurations.Add(new PositionConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new UserPositionConfiguration());
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AccountConfiguration(schema));
            modelBuilder.Configurations.Add(new AccountStatementConfiguration(schema));
            modelBuilder.Configurations.Add(new AccountTransactionConfiguration(schema));
            modelBuilder.Configurations.Add(new AccountTransactionAccountTransactionCategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new AccountTransactionCategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new AccountTransactionCategoryMatchPatternConfiguration(schema));
            modelBuilder.Configurations.Add(new AccountTransactionCategoryMatchPatternMatchMethodConfiguration(schema));
            modelBuilder.Configurations.Add(new AccountTransactionStatuConfiguration(schema));
            modelBuilder.Configurations.Add(new AccountTransactionTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new AggregateRootConfiguration(schema));
            modelBuilder.Configurations.Add(new AggregateRootEventConfiguration(schema));
            modelBuilder.Configurations.Add(new AspNetRoleConfiguration(schema));
            modelBuilder.Configurations.Add(new AspNetUserConfiguration(schema));
            modelBuilder.Configurations.Add(new AspNetUserClaimConfiguration(schema));
            modelBuilder.Configurations.Add(new AspNetUserLoginConfiguration(schema));
            modelBuilder.Configurations.Add(new BankConfiguration(schema));
            modelBuilder.Configurations.Add(new BankAccountConfiguration(schema));
            modelBuilder.Configurations.Add(new BankSpecificTransactionTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new BudgetConfiguration(schema));
            modelBuilder.Configurations.Add(new FundConfiguration(schema));
            modelBuilder.Configurations.Add(new PositionConfiguration(schema));
            modelBuilder.Configurations.Add(new UserConfiguration(schema));
            modelBuilder.Configurations.Add(new UserPositionConfiguration(schema));
            return modelBuilder;
        }
        
        // Stored Procedures
    }

    // ************************************************************************
    // Fake Database context
    public class FakeScaffoldDbContext : IScaffoldDbContext
    {
        public IDbSet<Account> Accounts { get; set; }
        public IDbSet<AccountStatement> AccountStatements { get; set; }
        public IDbSet<AccountTransaction> AccountTransactions { get; set; }
        public IDbSet<AccountTransactionAccountTransactionCategory> AccountTransactionAccountTransactionCategories { get; set; }
        public IDbSet<AccountTransactionCategory> AccountTransactionCategories { get; set; }
        public IDbSet<AccountTransactionCategoryMatchPattern> AccountTransactionCategoryMatchPatterns { get; set; }
        public IDbSet<AccountTransactionCategoryMatchPatternMatchMethod> AccountTransactionCategoryMatchPatternMatchMethods { get; set; }
        public IDbSet<AccountTransactionStatu> AccountTransactionStatus { get; set; }
        public IDbSet<AccountTransactionType> AccountTransactionTypes { get; set; }
        public IDbSet<AggregateRoot> AggregateRoots { get; set; }
        public IDbSet<AggregateRootEvent> AggregateRootEvents { get; set; }
        public IDbSet<AspNetRole> AspNetRoles { get; set; }
        public IDbSet<AspNetUser> AspNetUsers { get; set; }
        public IDbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public IDbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public IDbSet<Bank> Banks { get; set; }
        public IDbSet<BankAccount> BankAccounts { get; set; }
        public IDbSet<BankSpecificTransactionType> BankSpecificTransactionTypes { get; set; }
        public IDbSet<Budget> Budgets { get; set; }
        public IDbSet<Fund> Funds { get; set; }
        public IDbSet<Position> Positions { get; set; }
        public IDbSet<User> Users { get; set; }
        public IDbSet<UserPosition> UserPositions { get; set; }

        public FakeScaffoldDbContext()
        {
            Accounts = new FakeDbSet<Account>();
            AccountStatements = new FakeDbSet<AccountStatement>();
            AccountTransactions = new FakeDbSet<AccountTransaction>();
            AccountTransactionAccountTransactionCategories = new FakeDbSet<AccountTransactionAccountTransactionCategory>();
            AccountTransactionCategories = new FakeDbSet<AccountTransactionCategory>();
            AccountTransactionCategoryMatchPatterns = new FakeDbSet<AccountTransactionCategoryMatchPattern>();
            AccountTransactionCategoryMatchPatternMatchMethods = new FakeDbSet<AccountTransactionCategoryMatchPatternMatchMethod>();
            AccountTransactionStatus = new FakeDbSet<AccountTransactionStatu>();
            AccountTransactionTypes = new FakeDbSet<AccountTransactionType>();
            AggregateRoots = new FakeDbSet<AggregateRoot>();
            AggregateRootEvents = new FakeDbSet<AggregateRootEvent>();
            AspNetRoles = new FakeDbSet<AspNetRole>();
            AspNetUsers = new FakeDbSet<AspNetUser>();
            AspNetUserClaims = new FakeDbSet<AspNetUserClaim>();
            AspNetUserLogins = new FakeDbSet<AspNetUserLogin>();
            Banks = new FakeDbSet<Bank>();
            BankAccounts = new FakeDbSet<BankAccount>();
            BankSpecificTransactionTypes = new FakeDbSet<BankSpecificTransactionType>();
            Budgets = new FakeDbSet<Budget>();
            Funds = new FakeDbSet<Fund>();
            Positions = new FakeDbSet<Position>();
            Users = new FakeDbSet<User>();
            UserPositions = new FakeDbSet<UserPosition>();
        }

        public int SaveChanges()
        {
            return 0;
        }

        public void Dispose()
        {
            throw new NotImplementedException(); 
        }
        
        // Stored Procedures
    }

    // ************************************************************************
    // Fake DbSet
    public class FakeDbSet<T> : IDbSet<T> where T : class
    {
        private readonly HashSet<T> _data;

        public FakeDbSet()
        {
            _data = new HashSet<T>();
        }

        public virtual T Find(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public T Add(T item)
        {
            _data.Add(item);
            return item;
        }

        public T Remove(T item)
        {
            _data.Remove(item);
            return item;
        }

        public T Attach(T item)
        {
            _data.Add(item);
            return item;
        }

        public void Detach(T item)
        {
            _data.Remove(item);
        }

        Type IQueryable.ElementType
        {
            get { return _data.AsQueryable().ElementType; }
        }

        Expression IQueryable.Expression
        {
            get { return _data.AsQueryable().Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return _data.AsQueryable().Provider; }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        public T Create()
        {
            return Activator.CreateInstance<T>();
        }

        public ObservableCollection<T> Local
        {
            get
            {
                return new ObservableCollection<T>(_data);
            }
        }

        public TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, T
        {
            return Activator.CreateInstance<TDerivedEntity>();
        }
    }

    // ************************************************************************
    // POCO classes

    // Account
    public class Account
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public decimal CreditLimit { get; set; } // CreditLimit
        public int PositionId { get; set; } // PositionId

        // Reverse navigation
        public virtual ICollection<AccountStatement> AccountStatements { get; set; } // AccountStatement.FK_AccountStatement__Account
        public virtual ICollection<BankAccount> BankAccounts { get; set; } // BankAccount.FK_BankAccount__Account
        public virtual ICollection<Budget> Budgets { get; set; } // Budget.FK_Budget__Account
        public virtual ICollection<Fund> Funds { get; set; } // Fund.FK_Fund__Account

        // Foreign keys
        public virtual Position Position { get; set; } // FK_Account__Position

        public Account()
        {
            AccountStatements = new List<AccountStatement>();
            BankAccounts = new List<BankAccount>();
            Budgets = new List<Budget>();
            Funds = new List<Fund>();
        }
    }

    // AccountStatement
    public class AccountStatement
    {
        public int Id { get; set; } // Id (Primary key)
        public int AccountId { get; set; } // AccountId
        public DateTimeOffset PeriodStart { get; set; } // PeriodStart
        public DateTimeOffset PeriodEnd { get; set; } // PeriodEnd
        public decimal StartingBalance { get; set; } // StartingBalance

        // Reverse navigation
        public virtual ICollection<AccountTransaction> AccountTransactions { get; set; } // AccountTransaction.FK_AccountTransaction__AccountStatement

        // Foreign keys
        public virtual Account Account { get; set; } // FK_AccountStatement__Account

        public AccountStatement()
        {
            AccountTransactions = new List<AccountTransaction>();
        }
    }

    // AccountTransaction
    public class AccountTransaction
    {
        public int Id { get; set; } // Id (Primary key)
        public int? AccountStatementId { get; set; } // AccountStatementId
        public DateTimeOffset? TransactionDate { get; set; } // TransactionDate
        public DateTimeOffset? ReceiptDate { get; set; } // ReceiptDate
        public DateTimeOffset RecordedDate { get; set; } // RecordedDate
        public int AccountTransactionStatusId { get; set; } // AccountTransactionStatusId
        public decimal Amount { get; set; } // Amount
        public string Payee { get; set; } // Payee
        public string Description { get; set; } // Description
        public int AccountTransactionTypeId { get; set; } // AccountTransactionTypeId

        // Reverse navigation
        public virtual ICollection<AccountTransactionAccountTransactionCategory> AccountTransactionAccountTransactionCategories { get; set; } // Many to many mapping

        // Foreign keys
        public virtual AccountStatement AccountStatement { get; set; } // FK_AccountTransaction__AccountStatement
        public virtual AccountTransactionStatu AccountTransactionStatu { get; set; } // FK_AccountTransaction__AccountTransactionStatus
        public virtual AccountTransactionType AccountTransactionType { get; set; } // FK_AccountTransaction__AccountTransactionType

        public AccountTransaction()
        {
            AccountTransactionAccountTransactionCategories = new List<AccountTransactionAccountTransactionCategory>();
        }
    }

    // AccountTransactionAccountTransactionCategory
    public class AccountTransactionAccountTransactionCategory
    {
        public int AccountTransactionId { get; set; } // AccountTransactionId (Primary key)
        public int AccountTransactionCategoryId { get; set; } // AccountTransactionCategoryId (Primary key)
        public decimal Amount { get; set; } // Amount

        // Foreign keys
        public virtual AccountTransaction AccountTransaction { get; set; } // FK_AccountTransactionAccountTransactionCategory__AccountTransaction
        public virtual AccountTransactionCategory AccountTransactionCategory { get; set; } // FK_AccountTransactionAccountTransactionCategory__AccountTransactionCategory
    }

    // AccountTransactionCategory
    public class AccountTransactionCategory
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name

        // Reverse navigation
        public virtual ICollection<AccountTransactionAccountTransactionCategory> AccountTransactionAccountTransactionCategories { get; set; } // Many to many mapping
        public virtual ICollection<AccountTransactionCategoryMatchPattern> AccountTransactionCategoryMatchPatterns { get; set; } // AccountTransactionCategoryMatchPattern.FK_AccountTransactionCategoryMatchPattern__AccountTransactionCategory

        public AccountTransactionCategory()
        {
            AccountTransactionAccountTransactionCategories = new List<AccountTransactionAccountTransactionCategory>();
            AccountTransactionCategoryMatchPatterns = new List<AccountTransactionCategoryMatchPattern>();
        }
    }

    // AccountTransactionCategoryMatchPattern
    public class AccountTransactionCategoryMatchPattern
    {
        public int Id { get; set; } // Id (Primary key)
        public int AccountTransactionCategoryId { get; set; } // AccountTransactionCategoryId
        public string Pattern { get; set; } // Pattern
        public int MatchMethodId { get; set; } // MatchMethodId

        // Foreign keys
        public virtual AccountTransactionCategory AccountTransactionCategory { get; set; } // FK_AccountTransactionCategoryMatchPattern__AccountTransactionCategory
        public virtual AccountTransactionCategoryMatchPatternMatchMethod AccountTransactionCategoryMatchPatternMatchMethod { get; set; } // FK_AccountTransactionCategoryMatchPattern__AccountTransactionCategoryMatchPatternMatchMethod
    }

    // AccountTransactionCategoryMatchPatternMatchMethod
    public class AccountTransactionCategoryMatchPatternMatchMethod
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name

        // Reverse navigation
        public virtual ICollection<AccountTransactionCategoryMatchPattern> AccountTransactionCategoryMatchPatterns { get; set; } // AccountTransactionCategoryMatchPattern.FK_AccountTransactionCategoryMatchPattern__AccountTransactionCategoryMatchPatternMatchMethod

        public AccountTransactionCategoryMatchPatternMatchMethod()
        {
            AccountTransactionCategoryMatchPatterns = new List<AccountTransactionCategoryMatchPattern>();
        }
    }

    // AccountTransactionStatus
    public class AccountTransactionStatu
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name

        // Reverse navigation
        public virtual ICollection<AccountTransaction> AccountTransactions { get; set; } // AccountTransaction.FK_AccountTransaction__AccountTransactionStatus

        public AccountTransactionStatu()
        {
            AccountTransactions = new List<AccountTransaction>();
        }
    }

    // AccountTransactionType
    public class AccountTransactionType
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public bool IsIncome { get; set; } // IsIncome

        // Reverse navigation
        public virtual ICollection<AccountTransaction> AccountTransactions { get; set; } // AccountTransaction.FK_AccountTransaction__AccountTransactionType
        public virtual ICollection<BankSpecificTransactionType> BankSpecificTransactionTypes { get; set; } // BankSpecificTransactionType.FK_BankSpecificTransactionType__AccountTransactionType

        public AccountTransactionType()
        {
            AccountTransactions = new List<AccountTransaction>();
            BankSpecificTransactionTypes = new List<BankSpecificTransactionType>();
        }
    }

    // AggregateRoot
    public class AggregateRoot
    {
        public Guid Id { get; set; } // Id (Primary key)
        public int Version { get; set; } // Version

        // Reverse navigation
        public virtual ICollection<AggregateRootEvent> AggregateRootEvents { get; set; } // AggregateRootEvent.FK_AggregateRootEvent__AggregateRoot

        public AggregateRoot()
        {
            AggregateRootEvents = new List<AggregateRootEvent>();
        }
    }

    // AggregateRootEvent
    public class AggregateRootEvent
    {
        public Guid Id { get; set; } // Id (Primary key)
        public Guid AggregateId { get; set; } // AggregateId
        public int Version { get; set; } // Version
        public string Data { get; set; } // Data

        // Foreign keys
        public virtual AggregateRoot AggregateRoot { get; set; } // FK_AggregateRootEvent__AggregateRoot
    }

    // AspNetRoles
    public class AspNetRole
    {
        public string Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name

        // Reverse navigation
        public virtual ICollection<AspNetUser> AspNetUsers { get; set; } // Many to many mapping

        public AspNetRole()
        {
            AspNetUsers = new List<AspNetUser>();
        }
    }

    // AspNetUsers
    public class AspNetUser
    {
        public string Id { get; set; } // Id (Primary key)
        public string Email { get; set; } // Email
        public bool EmailConfirmed { get; set; } // EmailConfirmed
        public string PasswordHash { get; set; } // PasswordHash
        public string SecurityStamp { get; set; } // SecurityStamp
        public string PhoneNumber { get; set; } // PhoneNumber
        public bool PhoneNumberConfirmed { get; set; } // PhoneNumberConfirmed
        public bool TwoFactorEnabled { get; set; } // TwoFactorEnabled
        public DateTime? LockoutEndDateUtc { get; set; } // LockoutEndDateUtc
        public bool LockoutEnabled { get; set; } // LockoutEnabled
        public int AccessFailedCount { get; set; } // AccessFailedCount
        public string UserName { get; set; } // UserName

        // Reverse navigation
        public virtual ICollection<AspNetRole> AspNetRoles { get; set; } // Many to many mapping
        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; } // AspNetUserClaims.FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; } // Many to many mapping

        public AspNetUser()
        {
            AspNetUserClaims = new List<AspNetUserClaim>();
            AspNetUserLogins = new List<AspNetUserLogin>();
            AspNetRoles = new List<AspNetRole>();
        }
    }

    // AspNetUserClaims
    public class AspNetUserClaim
    {
        public int Id { get; set; } // Id (Primary key)
        public string UserId { get; set; } // UserId
        public string ClaimType { get; set; } // ClaimType
        public string ClaimValue { get; set; } // ClaimValue

        // Foreign keys
        public virtual AspNetUser AspNetUser { get; set; } // FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId
    }

    // AspNetUserLogins
    public class AspNetUserLogin
    {
        public string LoginProvider { get; set; } // LoginProvider (Primary key)
        public string ProviderKey { get; set; } // ProviderKey (Primary key)
        public string UserId { get; set; } // UserId (Primary key)

        // Foreign keys
        public virtual AspNetUser AspNetUser { get; set; } // FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId
    }

    // Bank
    public class Bank
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public int PositionId { get; set; } // PositionId

        // Reverse navigation
        public virtual ICollection<BankSpecificTransactionType> BankSpecificTransactionTypes { get; set; } // BankSpecificTransactionType.FK_BankSpecificTransactionType__Bank

        public Bank()
        {
            BankSpecificTransactionTypes = new List<BankSpecificTransactionType>();
        }
    }

    // BankAccount
    public class BankAccount
    {
        public int Id { get; set; } // Id (Primary key)
        public int AccountId { get; set; } // AccountId
        public string BankName { get; set; } // BankName
        public string AccountNumber { get; set; } // AccountNumber
        public string SortCode { get; set; } // SortCode

        // Foreign keys
        public virtual Account Account { get; set; } // FK_BankAccount__Account
    }

    // BankSpecificTransactionType
    public class BankSpecificTransactionType
    {
        public int Id { get; set; } // Id (Primary key)
        public int BankId { get; set; } // BankId
        public string Name { get; set; } // Name
        public string Description { get; set; } // Description
        public int AccountTransactionTypeId { get; set; } // AccountTransactionTypeId

        // Foreign keys
        public virtual AccountTransactionType AccountTransactionType { get; set; } // FK_BankSpecificTransactionType__AccountTransactionType
        public virtual Bank Bank { get; set; } // FK_BankSpecificTransactionType__Bank
    }

    // Budget
    public class Budget
    {
        public int Id { get; set; } // Id (Primary key)
        public int AccountId { get; set; } // AccountId
        public string Name { get; set; } // Name

        // Foreign keys
        public virtual Account Account { get; set; } // FK_Budget__Account
    }

    // Fund
    public class Fund
    {
        public int Id { get; set; } // Id (Primary key)
        public int AccountId { get; set; } // AccountId
        public string Name { get; set; } // Name

        // Foreign keys
        public virtual Account Account { get; set; } // FK_Fund__Account
    }

    // Position
    public class Position
    {
        public int Id { get; set; } // Id (Primary key)

        // Reverse navigation
        public virtual ICollection<Account> Accounts { get; set; } // Account.FK_Account__Position
        public virtual ICollection<User> Users { get; set; } // User.FK_User__Position
        public virtual ICollection<UserPosition> UserPositions { get; set; } // UserPosition.FK_UserPosition__Position

        public Position()
        {
            Accounts = new List<Account>();
            Users = new List<User>();
            UserPositions = new List<UserPosition>();
        }
    }

    // User
    public class User
    {
        public int Id { get; set; } // Id (Primary key)
        public Guid AspNetUserId { get; set; } // AspNetUserId
        public int PositionId { get; set; } // PositionId

        // Reverse navigation
        public virtual ICollection<UserPosition> UserPositions { get; set; } // UserPosition.FK_UserPosition__User

        // Foreign keys
        public virtual Position Position { get; set; } // FK_User__Position

        public User()
        {
            UserPositions = new List<UserPosition>();
        }
    }

    // UserPosition
    public class UserPosition
    {
        public int Id { get; set; } // Id (Primary key)
        public int UserId { get; set; } // UserId
        public int PositionId { get; set; } // PositionId

        // Foreign keys
        public virtual Position Position { get; set; } // FK_UserPosition__Position
        public virtual User User { get; set; } // FK_UserPosition__User
    }


    // ************************************************************************
    // POCO Configuration

    // Account
    internal class AccountConfiguration : EntityTypeConfiguration<Account>
    {
        public AccountConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Account");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(256);
            Property(x => x.CreditLimit).HasColumnName("CreditLimit").IsRequired().HasPrecision(19,4);
            Property(x => x.PositionId).HasColumnName("PositionId").IsRequired();

            // Foreign keys
            HasRequired(a => a.Position).WithMany(b => b.Accounts).HasForeignKey(c => c.PositionId); // FK_Account__Position
        }
    }

    // AccountStatement
    internal class AccountStatementConfiguration : EntityTypeConfiguration<AccountStatement>
    {
        public AccountStatementConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".AccountStatement");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.AccountId).HasColumnName("AccountId").IsRequired();
            Property(x => x.PeriodStart).HasColumnName("PeriodStart").IsRequired();
            Property(x => x.PeriodEnd).HasColumnName("PeriodEnd").IsRequired();
            Property(x => x.StartingBalance).HasColumnName("StartingBalance").IsRequired().HasPrecision(19,4);

            // Foreign keys
            HasRequired(a => a.Account).WithMany(b => b.AccountStatements).HasForeignKey(c => c.AccountId); // FK_AccountStatement__Account
        }
    }

    // AccountTransaction
    internal class AccountTransactionConfiguration : EntityTypeConfiguration<AccountTransaction>
    {
        public AccountTransactionConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".AccountTransaction");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.AccountStatementId).HasColumnName("AccountStatementId").IsOptional();
            Property(x => x.TransactionDate).HasColumnName("TransactionDate").IsOptional();
            Property(x => x.ReceiptDate).HasColumnName("ReceiptDate").IsOptional();
            Property(x => x.RecordedDate).HasColumnName("RecordedDate").IsRequired();
            Property(x => x.AccountTransactionStatusId).HasColumnName("AccountTransactionStatusId").IsRequired();
            Property(x => x.Amount).HasColumnName("Amount").IsRequired().HasPrecision(19,4);
            Property(x => x.Payee).HasColumnName("Payee").IsOptional().HasMaxLength(256);
            Property(x => x.Description).HasColumnName("Description").IsOptional().HasMaxLength(256);
            Property(x => x.AccountTransactionTypeId).HasColumnName("AccountTransactionTypeId").IsRequired();

            // Foreign keys
            HasOptional(a => a.AccountStatement).WithMany(b => b.AccountTransactions).HasForeignKey(c => c.AccountStatementId); // FK_AccountTransaction__AccountStatement
            HasRequired(a => a.AccountTransactionStatu).WithMany(b => b.AccountTransactions).HasForeignKey(c => c.AccountTransactionStatusId); // FK_AccountTransaction__AccountTransactionStatus
            HasRequired(a => a.AccountTransactionType).WithMany(b => b.AccountTransactions).HasForeignKey(c => c.AccountTransactionTypeId); // FK_AccountTransaction__AccountTransactionType
        }
    }

    // AccountTransactionAccountTransactionCategory
    internal class AccountTransactionAccountTransactionCategoryConfiguration : EntityTypeConfiguration<AccountTransactionAccountTransactionCategory>
    {
        public AccountTransactionAccountTransactionCategoryConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".AccountTransactionAccountTransactionCategory");
            HasKey(x => new { x.AccountTransactionId, x.AccountTransactionCategoryId });

            Property(x => x.AccountTransactionId).HasColumnName("AccountTransactionId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AccountTransactionCategoryId).HasColumnName("AccountTransactionCategoryId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Amount).HasColumnName("Amount").IsRequired().HasPrecision(19,4);

            // Foreign keys
            HasRequired(a => a.AccountTransaction).WithMany(b => b.AccountTransactionAccountTransactionCategories).HasForeignKey(c => c.AccountTransactionId); // FK_AccountTransactionAccountTransactionCategory__AccountTransaction
            HasRequired(a => a.AccountTransactionCategory).WithMany(b => b.AccountTransactionAccountTransactionCategories).HasForeignKey(c => c.AccountTransactionCategoryId); // FK_AccountTransactionAccountTransactionCategory__AccountTransactionCategory
        }
    }

    // AccountTransactionCategory
    internal class AccountTransactionCategoryConfiguration : EntityTypeConfiguration<AccountTransactionCategory>
    {
        public AccountTransactionCategoryConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".AccountTransactionCategory");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(256);
        }
    }

    // AccountTransactionCategoryMatchPattern
    internal class AccountTransactionCategoryMatchPatternConfiguration : EntityTypeConfiguration<AccountTransactionCategoryMatchPattern>
    {
        public AccountTransactionCategoryMatchPatternConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".AccountTransactionCategoryMatchPattern");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AccountTransactionCategoryId).HasColumnName("AccountTransactionCategoryId").IsRequired();
            Property(x => x.Pattern).HasColumnName("Pattern").IsRequired().HasMaxLength(256);
            Property(x => x.MatchMethodId).HasColumnName("MatchMethodId").IsRequired();

            // Foreign keys
            HasRequired(a => a.AccountTransactionCategory).WithMany(b => b.AccountTransactionCategoryMatchPatterns).HasForeignKey(c => c.AccountTransactionCategoryId); // FK_AccountTransactionCategoryMatchPattern__AccountTransactionCategory
            HasRequired(a => a.AccountTransactionCategoryMatchPatternMatchMethod).WithMany(b => b.AccountTransactionCategoryMatchPatterns).HasForeignKey(c => c.MatchMethodId); // FK_AccountTransactionCategoryMatchPattern__AccountTransactionCategoryMatchPatternMatchMethod
        }
    }

    // AccountTransactionCategoryMatchPatternMatchMethod
    internal class AccountTransactionCategoryMatchPatternMatchMethodConfiguration : EntityTypeConfiguration<AccountTransactionCategoryMatchPatternMatchMethod>
    {
        public AccountTransactionCategoryMatchPatternMatchMethodConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".AccountTransactionCategoryMatchPatternMatchMethod");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(256);
        }
    }

    // AccountTransactionStatus
    internal class AccountTransactionStatuConfiguration : EntityTypeConfiguration<AccountTransactionStatu>
    {
        public AccountTransactionStatuConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".AccountTransactionStatus");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(256);
        }
    }

    // AccountTransactionType
    internal class AccountTransactionTypeConfiguration : EntityTypeConfiguration<AccountTransactionType>
    {
        public AccountTransactionTypeConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".AccountTransactionType");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(256);
            Property(x => x.IsIncome).HasColumnName("IsIncome").IsRequired();
        }
    }

    // AggregateRoot
    internal class AggregateRootConfiguration : EntityTypeConfiguration<AggregateRoot>
    {
        public AggregateRootConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".AggregateRoot");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired();
            Property(x => x.Version).HasColumnName("Version").IsRequired();
        }
    }

    // AggregateRootEvent
    internal class AggregateRootEventConfiguration : EntityTypeConfiguration<AggregateRootEvent>
    {
        public AggregateRootEventConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".AggregateRootEvent");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired();
            Property(x => x.AggregateId).HasColumnName("AggregateId").IsRequired();
            Property(x => x.Version).HasColumnName("Version").IsRequired();
            Property(x => x.Data).HasColumnName("Data").IsRequired();

            // Foreign keys
            HasRequired(a => a.AggregateRoot).WithMany(b => b.AggregateRootEvents).HasForeignKey(c => c.AggregateId); // FK_AggregateRootEvent__AggregateRoot
        }
    }

    // AspNetRoles
    internal class AspNetRoleConfiguration : EntityTypeConfiguration<AspNetRole>
    {
        public AspNetRoleConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".AspNetRoles");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(256);
            HasMany(t => t.AspNetUsers).WithMany(t => t.AspNetRoles).Map(m => 
            {
                m.ToTable("AspNetUserRoles", schema);
                m.MapLeftKey("RoleId");
                m.MapRightKey("UserId");
            });
        }
    }

    // AspNetUsers
    internal class AspNetUserConfiguration : EntityTypeConfiguration<AspNetUser>
    {
        public AspNetUserConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".AspNetUsers");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Email).HasColumnName("Email").IsOptional().HasMaxLength(256);
            Property(x => x.EmailConfirmed).HasColumnName("EmailConfirmed").IsRequired();
            Property(x => x.PasswordHash).HasColumnName("PasswordHash").IsOptional();
            Property(x => x.SecurityStamp).HasColumnName("SecurityStamp").IsOptional();
            Property(x => x.PhoneNumber).HasColumnName("PhoneNumber").IsOptional();
            Property(x => x.PhoneNumberConfirmed).HasColumnName("PhoneNumberConfirmed").IsRequired();
            Property(x => x.TwoFactorEnabled).HasColumnName("TwoFactorEnabled").IsRequired();
            Property(x => x.LockoutEndDateUtc).HasColumnName("LockoutEndDateUtc").IsOptional();
            Property(x => x.LockoutEnabled).HasColumnName("LockoutEnabled").IsRequired();
            Property(x => x.AccessFailedCount).HasColumnName("AccessFailedCount").IsRequired();
            Property(x => x.UserName).HasColumnName("UserName").IsRequired().HasMaxLength(256);
        }
    }

    // AspNetUserClaims
    internal class AspNetUserClaimConfiguration : EntityTypeConfiguration<AspNetUserClaim>
    {
        public AspNetUserClaimConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".AspNetUserClaims");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.UserId).HasColumnName("UserId").IsRequired().HasMaxLength(128);
            Property(x => x.ClaimType).HasColumnName("ClaimType").IsOptional();
            Property(x => x.ClaimValue).HasColumnName("ClaimValue").IsOptional();

            // Foreign keys
            HasRequired(a => a.AspNetUser).WithMany(b => b.AspNetUserClaims).HasForeignKey(c => c.UserId); // FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId
        }
    }

    // AspNetUserLogins
    internal class AspNetUserLoginConfiguration : EntityTypeConfiguration<AspNetUserLogin>
    {
        public AspNetUserLoginConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".AspNetUserLogins");
            HasKey(x => new { x.LoginProvider, x.ProviderKey, x.UserId });

            Property(x => x.LoginProvider).HasColumnName("LoginProvider").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProviderKey).HasColumnName("ProviderKey").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.UserId).HasColumnName("UserId").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.AspNetUser).WithMany(b => b.AspNetUserLogins).HasForeignKey(c => c.UserId); // FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId
        }
    }

    // Bank
    internal class BankConfiguration : EntityTypeConfiguration<Bank>
    {
        public BankConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Bank");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(256);
            Property(x => x.PositionId).HasColumnName("PositionId").IsRequired();
        }
    }

    // BankAccount
    internal class BankAccountConfiguration : EntityTypeConfiguration<BankAccount>
    {
        public BankAccountConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".BankAccount");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.AccountId).HasColumnName("AccountId").IsRequired();
            Property(x => x.BankName).HasColumnName("BankName").IsRequired().HasMaxLength(256);
            Property(x => x.AccountNumber).HasColumnName("AccountNumber").IsRequired().HasMaxLength(50);
            Property(x => x.SortCode).HasColumnName("SortCode").IsRequired().HasMaxLength(50);

            // Foreign keys
            HasRequired(a => a.Account).WithMany(b => b.BankAccounts).HasForeignKey(c => c.AccountId); // FK_BankAccount__Account
        }
    }

    // BankSpecificTransactionType
    internal class BankSpecificTransactionTypeConfiguration : EntityTypeConfiguration<BankSpecificTransactionType>
    {
        public BankSpecificTransactionTypeConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".BankSpecificTransactionType");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.BankId).HasColumnName("BankId").IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(256);
            Property(x => x.Description).HasColumnName("Description").IsRequired().HasMaxLength(256);
            Property(x => x.AccountTransactionTypeId).HasColumnName("AccountTransactionTypeId").IsRequired();

            // Foreign keys
            HasRequired(a => a.Bank).WithMany(b => b.BankSpecificTransactionTypes).HasForeignKey(c => c.BankId); // FK_BankSpecificTransactionType__Bank
            HasRequired(a => a.AccountTransactionType).WithMany(b => b.BankSpecificTransactionTypes).HasForeignKey(c => c.AccountTransactionTypeId); // FK_BankSpecificTransactionType__AccountTransactionType
        }
    }

    // Budget
    internal class BudgetConfiguration : EntityTypeConfiguration<Budget>
    {
        public BudgetConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Budget");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.AccountId).HasColumnName("AccountId").IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(256);

            // Foreign keys
            HasRequired(a => a.Account).WithMany(b => b.Budgets).HasForeignKey(c => c.AccountId); // FK_Budget__Account
        }
    }

    // Fund
    internal class FundConfiguration : EntityTypeConfiguration<Fund>
    {
        public FundConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Fund");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.AccountId).HasColumnName("AccountId").IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(256);

            // Foreign keys
            HasRequired(a => a.Account).WithMany(b => b.Funds).HasForeignKey(c => c.AccountId); // FK_Fund__Account
        }
    }

    // Position
    internal class PositionConfiguration : EntityTypeConfiguration<Position>
    {
        public PositionConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Position");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }

    // User
    internal class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".User");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.AspNetUserId).HasColumnName("AspNetUserId").IsRequired();
            Property(x => x.PositionId).HasColumnName("PositionId").IsRequired();

            // Foreign keys
            HasRequired(a => a.Position).WithMany(b => b.Users).HasForeignKey(c => c.PositionId); // FK_User__Position
        }
    }

    // UserPosition
    internal class UserPositionConfiguration : EntityTypeConfiguration<UserPosition>
    {
        public UserPositionConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".UserPosition");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.UserId).HasColumnName("UserId").IsRequired();
            Property(x => x.PositionId).HasColumnName("PositionId").IsRequired();

            // Foreign keys
            HasRequired(a => a.User).WithMany(b => b.UserPositions).HasForeignKey(c => c.UserId); // FK_UserPosition__User
            HasRequired(a => a.Position).WithMany(b => b.UserPositions).HasForeignKey(c => c.PositionId); // FK_UserPosition__Position
        }
    }


    // ************************************************************************
    // Stored procedure return models

}
