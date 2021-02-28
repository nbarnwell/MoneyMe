

// This file was automatically generated.
// Do not make changes directly to this file - edit the template instead.
// 
// The following connection settings were used to generate this file
// 
//     Configuration file:     "MoneyMe.Web\Web.config"
//     Connection String Name: "DefaultConnection"
//     Connection String:      "server=(local);database=MoneyMe;trusted_connection=true;MultipleActiveResultSets=True;"

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
        IDbSet<Bank> Banks { get; set; } // Bank
        IDbSet<BankAccount> BankAccounts { get; set; } // BankAccount
        IDbSet<BankSpecificTransactionType> BankSpecificTransactionTypes { get; set; } // BankSpecificTransactionType
        IDbSet<Fund> Funds { get; set; } // Fund
        IDbSet<Household> Households { get; set; } // Household
        IDbSet<User> Users { get; set; } // User

        int SaveChanges();
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
        public IDbSet<Bank> Banks { get; set; } // Bank
        public IDbSet<BankAccount> BankAccounts { get; set; } // BankAccount
        public IDbSet<BankSpecificTransactionType> BankSpecificTransactionTypes { get; set; } // BankSpecificTransactionType
        public IDbSet<Fund> Funds { get; set; } // Fund
        public IDbSet<Household> Households { get; set; } // Household
        public IDbSet<User> Users { get; set; } // User

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
            modelBuilder.Configurations.Add(new BankConfiguration());
            modelBuilder.Configurations.Add(new BankAccountConfiguration());
            modelBuilder.Configurations.Add(new BankSpecificTransactionTypeConfiguration());
            modelBuilder.Configurations.Add(new FundConfiguration());
            modelBuilder.Configurations.Add(new HouseholdConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
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
            modelBuilder.Configurations.Add(new BankConfiguration(schema));
            modelBuilder.Configurations.Add(new BankAccountConfiguration(schema));
            modelBuilder.Configurations.Add(new BankSpecificTransactionTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new FundConfiguration(schema));
            modelBuilder.Configurations.Add(new HouseholdConfiguration(schema));
            modelBuilder.Configurations.Add(new UserConfiguration(schema));
            return modelBuilder;
        }
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
        public IDbSet<Bank> Banks { get; set; }
        public IDbSet<BankAccount> BankAccounts { get; set; }
        public IDbSet<BankSpecificTransactionType> BankSpecificTransactionTypes { get; set; }
        public IDbSet<Fund> Funds { get; set; }
        public IDbSet<Household> Households { get; set; }
        public IDbSet<User> Users { get; set; }

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
            Banks = new FakeDbSet<Bank>();
            BankAccounts = new FakeDbSet<BankAccount>();
            BankSpecificTransactionTypes = new FakeDbSet<BankSpecificTransactionType>();
            Funds = new FakeDbSet<Fund>();
            Households = new FakeDbSet<Household>();
            Users = new FakeDbSet<User>();
        }

        public int SaveChanges()
        {
            return 0;
        }

        public void Dispose()
        {
            throw new NotImplementedException(); 
        }
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
        public int UserId { get; set; } // UserId

        // Reverse navigation
        public virtual ICollection<AccountStatement> AccountStatements { get; set; } // AccountStatement.FK_AccountStatement__Account
        public virtual ICollection<BankAccount> BankAccounts { get; set; } // BankAccount.FK_BankAccount__Account
        public virtual ICollection<Fund> Funds { get; set; } // Fund.FK_Fund__Account

        public Account()
        {
            AccountStatements = new List<AccountStatement>();
            BankAccounts = new List<BankAccount>();
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
        public DateTimeOffset? TransactionTime { get; set; } // TransactionTime
        public DateTime RecordedDate { get; set; } // RecordedDate
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
        public int HouseholdId { get; set; } // HouseholdId

        // Reverse navigation
        public virtual ICollection<AccountTransactionAccountTransactionCategory> AccountTransactionAccountTransactionCategories { get; set; } // Many to many mapping
        public virtual ICollection<AccountTransactionCategoryMatchPattern> AccountTransactionCategoryMatchPatterns { get; set; } // AccountTransactionCategoryMatchPattern.FK_AccountTransactionCategoryMatchPattern__AccountTransactionCategory

        // Foreign keys
        public virtual Household Household { get; set; } // FK_AccountTransactionCategory__Household

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
        public int AccountTransactionCategoryMatchPatternMatchMethodId { get; set; } // AccountTransactionCategoryMatchPatternMatchMethodId

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

    // Bank
    public class Bank
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name

        // Reverse navigation
        public virtual ICollection<BankAccount> BankAccounts { get; set; } // BankAccount.FK_BankAccount__Bank
        public virtual ICollection<BankSpecificTransactionType> BankSpecificTransactionTypes { get; set; } // BankSpecificTransactionType.FK_BankSpecificTransactionType__Bank

        public Bank()
        {
            BankAccounts = new List<BankAccount>();
            BankSpecificTransactionTypes = new List<BankSpecificTransactionType>();
        }
    }

    // BankAccount
    public class BankAccount
    {
        public int Id { get; set; } // Id (Primary key)
        public int BankId { get; set; } // BankId
        public int UserId { get; set; } // UserId
        public int AccountId { get; set; } // AccountId
        public decimal CreditLimit { get; set; } // CreditLimit
        public string BankName { get; set; } // BankName
        public string AccountNumber { get; set; } // AccountNumber
        public string SortCode { get; set; } // SortCode

        // Foreign keys
        public virtual Account Account { get; set; } // FK_BankAccount__Account
        public virtual Bank Bank { get; set; } // FK_BankAccount__Bank
        public virtual User User { get; set; } // FK_Account__User
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

    // Fund
    public class Fund
    {
        public int Id { get; set; } // Id (Primary key)
        public int AccountId { get; set; } // AccountId
        public string Name { get; set; } // Name

        // Foreign keys
        public virtual Account Account { get; set; } // FK_Fund__Account
    }

    // Household
    public class Household
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name

        // Reverse navigation
        public virtual ICollection<AccountTransactionCategory> AccountTransactionCategories { get; set; } // AccountTransactionCategory.FK_AccountTransactionCategory__Household
        public virtual ICollection<User> Users { get; set; } // User.FK_User__Household

        public Household()
        {
            AccountTransactionCategories = new List<AccountTransactionCategory>();
            Users = new List<User>();
        }
    }

    // User
    [System.ComponentModel.DataAnnotations.DisplayColumn("Username")]
    public class User
    {
        public int Id { get; set; } // Id (Primary key)
        public string AuthenticationIdentity { get; set; } // AuthenticationIdentity
        public string Username { get; set; } // Username
        public int? HouseholdId { get; set; } // HouseholdId

        // Reverse navigation
        public virtual ICollection<BankAccount> BankAccounts { get; set; } // BankAccount.FK_Account__User

        // Foreign keys
        public virtual Household Household { get; set; } // FK_User__Household

        public User()
        {
            BankAccounts = new List<BankAccount>();
        }
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
            Property(x => x.UserId).HasColumnName("UserId").IsRequired();
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
            Property(x => x.TransactionTime).HasColumnName("TransactionTime").IsOptional();
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
            Property(x => x.HouseholdId).HasColumnName("HouseholdId").IsRequired();

            // Foreign keys
            HasRequired(a => a.Household).WithMany(b => b.AccountTransactionCategories).HasForeignKey(c => c.HouseholdId); // FK_AccountTransactionCategory__Household
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
            Property(x => x.AccountTransactionCategoryMatchPatternMatchMethodId).HasColumnName("AccountTransactionCategoryMatchPatternMatchMethodId").IsRequired();

            // Foreign keys
            HasRequired(a => a.AccountTransactionCategory).WithMany(b => b.AccountTransactionCategoryMatchPatterns).HasForeignKey(c => c.AccountTransactionCategoryId); // FK_AccountTransactionCategoryMatchPattern__AccountTransactionCategory
            HasRequired(a => a.AccountTransactionCategoryMatchPatternMatchMethod).WithMany(b => b.AccountTransactionCategoryMatchPatterns).HasForeignKey(c => c.AccountTransactionCategoryMatchPatternMatchMethodId); // FK_AccountTransactionCategoryMatchPattern__AccountTransactionCategoryMatchPatternMatchMethod
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

    // Bank
    internal class BankConfiguration : EntityTypeConfiguration<Bank>
    {
        public BankConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Bank");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(256);
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
            Property(x => x.BankId).HasColumnName("BankId").IsRequired();
            Property(x => x.UserId).HasColumnName("UserId").IsRequired();
            Property(x => x.AccountId).HasColumnName("AccountId").IsRequired();
            Property(x => x.CreditLimit).HasColumnName("CreditLimit").IsRequired().HasPrecision(19,4);
            Property(x => x.BankName).HasColumnName("BankName").IsRequired().HasMaxLength(256);
            Property(x => x.AccountNumber).HasColumnName("AccountNumber").IsRequired().HasMaxLength(50);
            Property(x => x.SortCode).HasColumnName("SortCode").IsRequired().HasMaxLength(50);

            // Foreign keys
            HasRequired(a => a.Bank).WithMany(b => b.BankAccounts).HasForeignKey(c => c.BankId); // FK_BankAccount__Bank
            HasRequired(a => a.User).WithMany(b => b.BankAccounts).HasForeignKey(c => c.UserId); // FK_Account__User
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

    // Household
    internal class HouseholdConfiguration : EntityTypeConfiguration<Household>
    {
        public HouseholdConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Household");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().IsUnicode(false).HasMaxLength(50);
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
            Property(x => x.AuthenticationIdentity).HasColumnName("AuthenticationIdentity").IsRequired().HasMaxLength(256);
            Property(x => x.Username).HasColumnName("Username").IsRequired().HasMaxLength(256);
            Property(x => x.HouseholdId).HasColumnName("HouseholdId").IsOptional();

            // Foreign keys
            HasOptional(a => a.Household).WithMany(b => b.Users).HasForeignKey(c => c.HouseholdId); // FK_User__Household
        }
    }

}
