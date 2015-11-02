

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
        IDbSet<AspnetApplications> AspnetApplications { get; set; } // aspnet_Applications
        IDbSet<AspnetMembership> AspnetMemberships { get; set; } // aspnet_Membership
        IDbSet<AspnetPaths> AspnetPaths { get; set; } // aspnet_Paths
        IDbSet<AspnetPersonalizationAllUsers> AspnetPersonalizationAllUsers { get; set; } // aspnet_PersonalizationAllUsers
        IDbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; } // aspnet_PersonalizationPerUser
        IDbSet<AspnetProfile> AspnetProfiles { get; set; } // aspnet_Profile
        IDbSet<AspnetRoles> AspnetRoles { get; set; } // aspnet_Roles
        IDbSet<AspnetSchemaVersions> AspnetSchemaVersions { get; set; } // aspnet_SchemaVersions
        IDbSet<AspnetUsers> AspnetUsers { get; set; } // aspnet_Users
        IDbSet<AspnetWebEventEvents> AspnetWebEventEvents { get; set; } // aspnet_WebEvent_Events
        IDbSet<Bank> Banks { get; set; } // Bank
        IDbSet<BankAccount> BankAccounts { get; set; } // BankAccount
        IDbSet<BankSpecificTransactionType> BankSpecificTransactionTypes { get; set; } // BankSpecificTransactionType
        IDbSet<Budget> Budgets { get; set; } // Budget
        IDbSet<Fund> Funds { get; set; } // Fund
        IDbSet<Position> Positions { get; set; } // Position
        IDbSet<User> Users { get; set; } // User
        IDbSet<UserPosition> UserPositions { get; set; } // UserPosition
        IDbSet<VwAspnetApplications> VwAspnetApplications { get; set; } // vw_aspnet_Applications
        IDbSet<VwAspnetMembershipUsers> VwAspnetMembershipUsers { get; set; } // vw_aspnet_MembershipUsers
        IDbSet<VwAspnetProfiles> VwAspnetProfiles { get; set; } // vw_aspnet_Profiles
        IDbSet<VwAspnetRoles> VwAspnetRoles { get; set; } // vw_aspnet_Roles
        IDbSet<VwAspnetUsers> VwAspnetUsers { get; set; } // vw_aspnet_Users
        IDbSet<VwAspnetUsersInRoles> VwAspnetUsersInRoles { get; set; } // vw_aspnet_UsersInRoles
        IDbSet<VwAspnetWebPartStatePaths> VwAspnetWebPartStatePaths { get; set; } // vw_aspnet_WebPartState_Paths
        IDbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShareds { get; set; } // vw_aspnet_WebPartState_Shared
        IDbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUsers { get; set; } // vw_aspnet_WebPartState_User

        int SaveChanges();
        
        // Stored Procedures
        List<AspnetAnyDataInTablesReturnModel> AspnetAnyDataInTables(int tablesToCheck, out int procResult);
        int AspnetApplicationsCreateApplication(string applicationName, out Guid applicationId);
        int AspnetCheckSchemaVersion(string feature, string compatibleSchemaVersion);
        int AspnetMembershipChangePasswordQuestionAndAnswer(string applicationName, string userName, string newPasswordQuestion, string newPasswordAnswer);
        int AspnetMembershipCreateUser(string applicationName, string userName, string password, string passwordSalt, string email, string passwordQuestion, string passwordAnswer, bool isApproved, DateTime currentTimeUtc, DateTime createDate, int uniqueEmail, int passwordFormat, out Guid userId);
        int AspnetMembershipFindUsersByEmail(string applicationName, string emailToMatch, int pageIndex, int pageSize);
        int AspnetMembershipFindUsersByName(string applicationName, string userNameToMatch, int pageIndex, int pageSize);
        int AspnetMembershipGetAllUsers(string applicationName, int pageIndex, int pageSize);
        int AspnetMembershipGetNumberOfUsersOnline(string applicationName, int minutesSinceLastInActive, DateTime currentTimeUtc);
        List<AspnetMembershipGetPasswordReturnModel> AspnetMembershipGetPassword(string applicationName, string userName, int maxInvalidPasswordAttempts, int passwordAttemptWindow, DateTime currentTimeUtc, string passwordAnswer, out int procResult);
        List<AspnetMembershipGetPasswordWithFormatReturnModel> AspnetMembershipGetPasswordWithFormat(string applicationName, string userName, bool updateLastLoginActivityDate, DateTime currentTimeUtc, out int procResult);
        List<AspnetMembershipGetUserByEmailReturnModel> AspnetMembershipGetUserByEmail(string applicationName, string email, out int procResult);
        List<AspnetMembershipGetUserByNameReturnModel> AspnetMembershipGetUserByName(string applicationName, string userName, DateTime currentTimeUtc, bool updateLastActivity, out int procResult);
        List<AspnetMembershipGetUserByUserIdReturnModel> AspnetMembershipGetUserByUserId(Guid userId, DateTime currentTimeUtc, bool updateLastActivity, out int procResult);
        int AspnetMembershipResetPassword(string applicationName, string userName, string newPassword, int maxInvalidPasswordAttempts, int passwordAttemptWindow, string passwordSalt, DateTime currentTimeUtc, int passwordFormat, string passwordAnswer);
        int AspnetMembershipSetPassword(string applicationName, string userName, string newPassword, string passwordSalt, DateTime currentTimeUtc, int passwordFormat);
        int AspnetMembershipUnlockUser(string applicationName, string userName);
        int AspnetMembershipUpdateUser(string applicationName, string userName, string email, string comment, bool isApproved, DateTime lastLoginDate, DateTime lastActivityDate, int uniqueEmail, DateTime currentTimeUtc);
        int AspnetMembershipUpdateUserInfo(string applicationName, string userName, bool isPasswordCorrect, bool updateLastLoginActivityDate, int maxInvalidPasswordAttempts, int passwordAttemptWindow, DateTime currentTimeUtc, DateTime lastLoginDate, DateTime lastActivityDate);
        int AspnetPathsCreatePath(Guid applicationId, string path, out Guid pathId);
        int AspnetPersonalizationGetApplicationId(string applicationName, out Guid applicationId);
        int AspnetPersonalizationAdministrationDeleteAllState(bool allUsersScope, string applicationName, out int count);
        int AspnetPersonalizationAdministrationFindState(bool allUsersScope, string applicationName, int pageIndex, int pageSize, string path, string userName, DateTime inactiveSinceDate);
        int AspnetPersonalizationAdministrationGetCountOfState(out int count, bool allUsersScope, string applicationName, string path, string userName, DateTime inactiveSinceDate);
        int AspnetPersonalizationAdministrationResetSharedState(out int count, string applicationName, string path);
        int AspnetPersonalizationAdministrationResetUserState(out int count, string applicationName, DateTime inactiveSinceDate, string userName, string path);
        List<AspnetPersonalizationAllUsersGetPageSettingsReturnModel> AspnetPersonalizationAllUsersGetPageSettings(string applicationName, string path, out int procResult);
        int AspnetPersonalizationAllUsersResetPageSettings(string applicationName, string path);
        int AspnetPersonalizationAllUsersSetPageSettings(string applicationName, string path, byte[] pageSettings, DateTime currentTimeUtc);
        List<AspnetPersonalizationPerUserGetPageSettingsReturnModel> AspnetPersonalizationPerUserGetPageSettings(string applicationName, string userName, string path, DateTime currentTimeUtc, out int procResult);
        int AspnetPersonalizationPerUserResetPageSettings(string applicationName, string userName, string path, DateTime currentTimeUtc);
        int AspnetPersonalizationPerUserSetPageSettings(string applicationName, string userName, string path, byte[] pageSettings, DateTime currentTimeUtc);
        List<AspnetProfileDeleteInactiveProfilesReturnModel> AspnetProfileDeleteInactiveProfiles(string applicationName, int profileAuthOptions, DateTime inactiveSinceDate, out int procResult);
        List<AspnetProfileDeleteProfilesReturnModel> AspnetProfileDeleteProfiles(string applicationName, string userNames, out int procResult);
        List<AspnetProfileGetNumberOfInactiveProfilesReturnModel> AspnetProfileGetNumberOfInactiveProfiles(string applicationName, int profileAuthOptions, DateTime inactiveSinceDate, out int procResult);
        int AspnetProfileGetProfiles(string applicationName, int profileAuthOptions, int pageIndex, int pageSize, string userNameToMatch, DateTime inactiveSinceDate);
        List<AspnetProfileGetPropertiesReturnModel> AspnetProfileGetProperties(string applicationName, string userName, DateTime currentTimeUtc, out int procResult);
        int AspnetProfileSetProperties(string applicationName, string propertyNames, string propertyValuesString, byte[] propertyValuesBinary, string userName, bool isUserAnonymous, DateTime currentTimeUtc);
        int AspnetRegisterSchemaVersion(string feature, string compatibleSchemaVersion, bool isCurrentVersion, bool removeIncompatibleSchema);
        int AspnetRolesCreateRole(string applicationName, string roleName);
        int AspnetRolesDeleteRole(string applicationName, string roleName, bool deleteOnlyIfRoleIsEmpty);
        List<AspnetRolesGetAllRolesReturnModel> AspnetRolesGetAllRoles(string applicationName, out int procResult);
        int AspnetRolesRoleExists(string applicationName, string roleName);
        int AspnetSetupRemoveAllRoleMembers(string name);
        int AspnetSetupRestorePermissions(string name);
        int AspnetUnRegisterSchemaVersion(string feature, string compatibleSchemaVersion);
        int AspnetUsersCreateUser(Guid applicationId, string userName, bool isUserAnonymous, DateTime lastActivityDate, out Guid userId);
        int AspnetUsersDeleteUser(string applicationName, string userName, int tablesToDeleteFrom, out int numTablesDeletedFrom);
        List<AspnetUsersInRolesAddUsersToRolesReturnModel> AspnetUsersInRolesAddUsersToRoles(string applicationName, string userNames, string roleNames, DateTime currentTimeUtc, out int procResult);
        List<AspnetUsersInRolesFindUsersInRoleReturnModel> AspnetUsersInRolesFindUsersInRole(string applicationName, string roleName, string userNameToMatch, out int procResult);
        List<AspnetUsersInRolesGetRolesForUserReturnModel> AspnetUsersInRolesGetRolesForUser(string applicationName, string userName, out int procResult);
        List<AspnetUsersInRolesGetUsersInRolesReturnModel> AspnetUsersInRolesGetUsersInRoles(string applicationName, string roleName, out int procResult);
        int AspnetUsersInRolesIsUserInRole(string applicationName, string userName, string roleName);
        List<AspnetUsersInRolesRemoveUsersFromRolesReturnModel> AspnetUsersInRolesRemoveUsersFromRoles(string applicationName, string userNames, string roleNames, out int procResult);
        int AspnetWebEventLogEvent(string eventId, DateTime eventTimeUtc, DateTime eventTime, string eventType, decimal eventSequence, decimal eventOccurrence, int eventCode, int eventDetailCode, string message, string applicationPath, string applicationVirtualPath, string machineName, string requestUrl, string exceptionType, string details);
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
        public IDbSet<AspnetApplications> AspnetApplications { get; set; } // aspnet_Applications
        public IDbSet<AspnetMembership> AspnetMemberships { get; set; } // aspnet_Membership
        public IDbSet<AspnetPaths> AspnetPaths { get; set; } // aspnet_Paths
        public IDbSet<AspnetPersonalizationAllUsers> AspnetPersonalizationAllUsers { get; set; } // aspnet_PersonalizationAllUsers
        public IDbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; } // aspnet_PersonalizationPerUser
        public IDbSet<AspnetProfile> AspnetProfiles { get; set; } // aspnet_Profile
        public IDbSet<AspnetRoles> AspnetRoles { get; set; } // aspnet_Roles
        public IDbSet<AspnetSchemaVersions> AspnetSchemaVersions { get; set; } // aspnet_SchemaVersions
        public IDbSet<AspnetUsers> AspnetUsers { get; set; } // aspnet_Users
        public IDbSet<AspnetWebEventEvents> AspnetWebEventEvents { get; set; } // aspnet_WebEvent_Events
        public IDbSet<Bank> Banks { get; set; } // Bank
        public IDbSet<BankAccount> BankAccounts { get; set; } // BankAccount
        public IDbSet<BankSpecificTransactionType> BankSpecificTransactionTypes { get; set; } // BankSpecificTransactionType
        public IDbSet<Budget> Budgets { get; set; } // Budget
        public IDbSet<Fund> Funds { get; set; } // Fund
        public IDbSet<Position> Positions { get; set; } // Position
        public IDbSet<User> Users { get; set; } // User
        public IDbSet<UserPosition> UserPositions { get; set; } // UserPosition
        public IDbSet<VwAspnetApplications> VwAspnetApplications { get; set; } // vw_aspnet_Applications
        public IDbSet<VwAspnetMembershipUsers> VwAspnetMembershipUsers { get; set; } // vw_aspnet_MembershipUsers
        public IDbSet<VwAspnetProfiles> VwAspnetProfiles { get; set; } // vw_aspnet_Profiles
        public IDbSet<VwAspnetRoles> VwAspnetRoles { get; set; } // vw_aspnet_Roles
        public IDbSet<VwAspnetUsers> VwAspnetUsers { get; set; } // vw_aspnet_Users
        public IDbSet<VwAspnetUsersInRoles> VwAspnetUsersInRoles { get; set; } // vw_aspnet_UsersInRoles
        public IDbSet<VwAspnetWebPartStatePaths> VwAspnetWebPartStatePaths { get; set; } // vw_aspnet_WebPartState_Paths
        public IDbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShareds { get; set; } // vw_aspnet_WebPartState_Shared
        public IDbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUsers { get; set; } // vw_aspnet_WebPartState_User

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
            modelBuilder.Configurations.Add(new AspnetApplicationsConfiguration());
            modelBuilder.Configurations.Add(new AspnetMembershipConfiguration());
            modelBuilder.Configurations.Add(new AspnetPathsConfiguration());
            modelBuilder.Configurations.Add(new AspnetPersonalizationAllUsersConfiguration());
            modelBuilder.Configurations.Add(new AspnetPersonalizationPerUserConfiguration());
            modelBuilder.Configurations.Add(new AspnetProfileConfiguration());
            modelBuilder.Configurations.Add(new AspnetRolesConfiguration());
            modelBuilder.Configurations.Add(new AspnetSchemaVersionsConfiguration());
            modelBuilder.Configurations.Add(new AspnetUsersConfiguration());
            modelBuilder.Configurations.Add(new AspnetWebEventEventsConfiguration());
            modelBuilder.Configurations.Add(new BankConfiguration());
            modelBuilder.Configurations.Add(new BankAccountConfiguration());
            modelBuilder.Configurations.Add(new BankSpecificTransactionTypeConfiguration());
            modelBuilder.Configurations.Add(new BudgetConfiguration());
            modelBuilder.Configurations.Add(new FundConfiguration());
            modelBuilder.Configurations.Add(new PositionConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new UserPositionConfiguration());
            modelBuilder.Configurations.Add(new VwAspnetApplicationsConfiguration());
            modelBuilder.Configurations.Add(new VwAspnetMembershipUsersConfiguration());
            modelBuilder.Configurations.Add(new VwAspnetProfilesConfiguration());
            modelBuilder.Configurations.Add(new VwAspnetRolesConfiguration());
            modelBuilder.Configurations.Add(new VwAspnetUsersConfiguration());
            modelBuilder.Configurations.Add(new VwAspnetUsersInRolesConfiguration());
            modelBuilder.Configurations.Add(new VwAspnetWebPartStatePathsConfiguration());
            modelBuilder.Configurations.Add(new VwAspnetWebPartStateSharedConfiguration());
            modelBuilder.Configurations.Add(new VwAspnetWebPartStateUserConfiguration());
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
            modelBuilder.Configurations.Add(new AspnetApplicationsConfiguration(schema));
            modelBuilder.Configurations.Add(new AspnetMembershipConfiguration(schema));
            modelBuilder.Configurations.Add(new AspnetPathsConfiguration(schema));
            modelBuilder.Configurations.Add(new AspnetPersonalizationAllUsersConfiguration(schema));
            modelBuilder.Configurations.Add(new AspnetPersonalizationPerUserConfiguration(schema));
            modelBuilder.Configurations.Add(new AspnetProfileConfiguration(schema));
            modelBuilder.Configurations.Add(new AspnetRolesConfiguration(schema));
            modelBuilder.Configurations.Add(new AspnetSchemaVersionsConfiguration(schema));
            modelBuilder.Configurations.Add(new AspnetUsersConfiguration(schema));
            modelBuilder.Configurations.Add(new AspnetWebEventEventsConfiguration(schema));
            modelBuilder.Configurations.Add(new BankConfiguration(schema));
            modelBuilder.Configurations.Add(new BankAccountConfiguration(schema));
            modelBuilder.Configurations.Add(new BankSpecificTransactionTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new BudgetConfiguration(schema));
            modelBuilder.Configurations.Add(new FundConfiguration(schema));
            modelBuilder.Configurations.Add(new PositionConfiguration(schema));
            modelBuilder.Configurations.Add(new UserConfiguration(schema));
            modelBuilder.Configurations.Add(new UserPositionConfiguration(schema));
            modelBuilder.Configurations.Add(new VwAspnetApplicationsConfiguration(schema));
            modelBuilder.Configurations.Add(new VwAspnetMembershipUsersConfiguration(schema));
            modelBuilder.Configurations.Add(new VwAspnetProfilesConfiguration(schema));
            modelBuilder.Configurations.Add(new VwAspnetRolesConfiguration(schema));
            modelBuilder.Configurations.Add(new VwAspnetUsersConfiguration(schema));
            modelBuilder.Configurations.Add(new VwAspnetUsersInRolesConfiguration(schema));
            modelBuilder.Configurations.Add(new VwAspnetWebPartStatePathsConfiguration(schema));
            modelBuilder.Configurations.Add(new VwAspnetWebPartStateSharedConfiguration(schema));
            modelBuilder.Configurations.Add(new VwAspnetWebPartStateUserConfiguration(schema));
            return modelBuilder;
        }
        
        // Stored Procedures
        public List<AspnetAnyDataInTablesReturnModel> AspnetAnyDataInTables(int tablesToCheck, out int procResult)
        {
            var tablesToCheckParam = new SqlParameter { ParameterName = "@TablesToCheck", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = tablesToCheck };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<AspnetAnyDataInTablesReturnModel>("EXEC @procResult = aspnet_AnyDataInTables @TablesToCheck", new object[]
            {
                tablesToCheckParam,
                procResultParam

            }).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public int AspnetApplicationsCreateApplication(string applicationName, out Guid applicationId)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var applicationIdParam = new SqlParameter { ParameterName = "@ApplicationId", SqlDbType = SqlDbType.UniqueIdentifier, Direction = ParameterDirection.Output };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Applications_CreateApplication @ApplicationName, @ApplicationId OUTPUT", new object[]
            {
                applicationNameParam,
                applicationIdParam,
                procResultParam
 
            });
            applicationId = (Guid) applicationIdParam.Value;
 
            return (int) procResultParam.Value;
        }

        public int AspnetCheckSchemaVersion(string feature, string compatibleSchemaVersion)
        {
            var featureParam = new SqlParameter { ParameterName = "@Feature", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = feature, Size = 128 };
            var compatibleSchemaVersionParam = new SqlParameter { ParameterName = "@CompatibleSchemaVersion", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = compatibleSchemaVersion, Size = 128 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_CheckSchemaVersion @Feature, @CompatibleSchemaVersion", new object[]
            {
                featureParam,
                compatibleSchemaVersionParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public int AspnetMembershipChangePasswordQuestionAndAnswer(string applicationName, string userName, string newPasswordQuestion, string newPasswordAnswer)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var userNameParam = new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userName, Size = 256 };
            var newPasswordQuestionParam = new SqlParameter { ParameterName = "@NewPasswordQuestion", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = newPasswordQuestion, Size = 256 };
            var newPasswordAnswerParam = new SqlParameter { ParameterName = "@NewPasswordAnswer", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = newPasswordAnswer, Size = 128 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Membership_ChangePasswordQuestionAndAnswer @ApplicationName, @UserName, @NewPasswordQuestion, @NewPasswordAnswer", new object[]
            {
                applicationNameParam,
                userNameParam,
                newPasswordQuestionParam,
                newPasswordAnswerParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public int AspnetMembershipCreateUser(string applicationName, string userName, string password, string passwordSalt, string email, string passwordQuestion, string passwordAnswer, bool isApproved, DateTime currentTimeUtc, DateTime createDate, int uniqueEmail, int passwordFormat, out Guid userId)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var userNameParam = new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userName, Size = 256 };
            var passwordParam = new SqlParameter { ParameterName = "@Password", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = password, Size = 128 };
            var passwordSaltParam = new SqlParameter { ParameterName = "@PasswordSalt", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = passwordSalt, Size = 128 };
            var emailParam = new SqlParameter { ParameterName = "@Email", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = email, Size = 256 };
            var passwordQuestionParam = new SqlParameter { ParameterName = "@PasswordQuestion", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = passwordQuestion, Size = 256 };
            var passwordAnswerParam = new SqlParameter { ParameterName = "@PasswordAnswer", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = passwordAnswer, Size = 128 };
            var isApprovedParam = new SqlParameter { ParameterName = "@IsApproved", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = isApproved };
            var currentTimeUtcParam = new SqlParameter { ParameterName = "@CurrentTimeUtc", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = currentTimeUtc };
            var createDateParam = new SqlParameter { ParameterName = "@CreateDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = createDate };
            var uniqueEmailParam = new SqlParameter { ParameterName = "@UniqueEmail", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = uniqueEmail };
            var passwordFormatParam = new SqlParameter { ParameterName = "@PasswordFormat", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = passwordFormat };
            var userIdParam = new SqlParameter { ParameterName = "@UserId", SqlDbType = SqlDbType.UniqueIdentifier, Direction = ParameterDirection.Output };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Membership_CreateUser @ApplicationName, @UserName, @Password, @PasswordSalt, @Email, @PasswordQuestion, @PasswordAnswer, @IsApproved, @CurrentTimeUtc, @CreateDate, @UniqueEmail, @PasswordFormat, @UserId OUTPUT", new object[]
            {
                applicationNameParam,
                userNameParam,
                passwordParam,
                passwordSaltParam,
                emailParam,
                passwordQuestionParam,
                passwordAnswerParam,
                isApprovedParam,
                currentTimeUtcParam,
                createDateParam,
                uniqueEmailParam,
                passwordFormatParam,
                userIdParam,
                procResultParam
 
            });
            userId = (Guid) userIdParam.Value;
 
            return (int) procResultParam.Value;
        }

        public int AspnetMembershipFindUsersByEmail(string applicationName, string emailToMatch, int pageIndex, int pageSize)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var emailToMatchParam = new SqlParameter { ParameterName = "@EmailToMatch", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = emailToMatch, Size = 256 };
            var pageIndexParam = new SqlParameter { ParameterName = "@PageIndex", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = pageIndex };
            var pageSizeParam = new SqlParameter { ParameterName = "@PageSize", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = pageSize };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Membership_FindUsersByEmail @ApplicationName, @EmailToMatch, @PageIndex, @PageSize", new object[]
            {
                applicationNameParam,
                emailToMatchParam,
                pageIndexParam,
                pageSizeParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public int AspnetMembershipFindUsersByName(string applicationName, string userNameToMatch, int pageIndex, int pageSize)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var userNameToMatchParam = new SqlParameter { ParameterName = "@UserNameToMatch", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userNameToMatch, Size = 256 };
            var pageIndexParam = new SqlParameter { ParameterName = "@PageIndex", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = pageIndex };
            var pageSizeParam = new SqlParameter { ParameterName = "@PageSize", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = pageSize };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Membership_FindUsersByName @ApplicationName, @UserNameToMatch, @PageIndex, @PageSize", new object[]
            {
                applicationNameParam,
                userNameToMatchParam,
                pageIndexParam,
                pageSizeParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public int AspnetMembershipGetAllUsers(string applicationName, int pageIndex, int pageSize)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var pageIndexParam = new SqlParameter { ParameterName = "@PageIndex", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = pageIndex };
            var pageSizeParam = new SqlParameter { ParameterName = "@PageSize", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = pageSize };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Membership_GetAllUsers @ApplicationName, @PageIndex, @PageSize", new object[]
            {
                applicationNameParam,
                pageIndexParam,
                pageSizeParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public int AspnetMembershipGetNumberOfUsersOnline(string applicationName, int minutesSinceLastInActive, DateTime currentTimeUtc)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var minutesSinceLastInActiveParam = new SqlParameter { ParameterName = "@MinutesSinceLastInActive", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = minutesSinceLastInActive };
            var currentTimeUtcParam = new SqlParameter { ParameterName = "@CurrentTimeUtc", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = currentTimeUtc };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Membership_GetNumberOfUsersOnline @ApplicationName, @MinutesSinceLastInActive, @CurrentTimeUtc", new object[]
            {
                applicationNameParam,
                minutesSinceLastInActiveParam,
                currentTimeUtcParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public List<AspnetMembershipGetPasswordReturnModel> AspnetMembershipGetPassword(string applicationName, string userName, int maxInvalidPasswordAttempts, int passwordAttemptWindow, DateTime currentTimeUtc, string passwordAnswer, out int procResult)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var userNameParam = new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userName, Size = 256 };
            var maxInvalidPasswordAttemptsParam = new SqlParameter { ParameterName = "@MaxInvalidPasswordAttempts", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = maxInvalidPasswordAttempts };
            var passwordAttemptWindowParam = new SqlParameter { ParameterName = "@PasswordAttemptWindow", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = passwordAttemptWindow };
            var currentTimeUtcParam = new SqlParameter { ParameterName = "@CurrentTimeUtc", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = currentTimeUtc };
            var passwordAnswerParam = new SqlParameter { ParameterName = "@PasswordAnswer", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = passwordAnswer, Size = 128 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<AspnetMembershipGetPasswordReturnModel>("EXEC @procResult = aspnet_Membership_GetPassword @ApplicationName, @UserName, @MaxInvalidPasswordAttempts, @PasswordAttemptWindow, @CurrentTimeUtc, @PasswordAnswer", new object[]
            {
                applicationNameParam,
                userNameParam,
                maxInvalidPasswordAttemptsParam,
                passwordAttemptWindowParam,
                currentTimeUtcParam,
                passwordAnswerParam,
                procResultParam

            }).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public List<AspnetMembershipGetPasswordWithFormatReturnModel> AspnetMembershipGetPasswordWithFormat(string applicationName, string userName, bool updateLastLoginActivityDate, DateTime currentTimeUtc, out int procResult)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var userNameParam = new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userName, Size = 256 };
            var updateLastLoginActivityDateParam = new SqlParameter { ParameterName = "@UpdateLastLoginActivityDate", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = updateLastLoginActivityDate };
            var currentTimeUtcParam = new SqlParameter { ParameterName = "@CurrentTimeUtc", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = currentTimeUtc };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<AspnetMembershipGetPasswordWithFormatReturnModel>("EXEC @procResult = aspnet_Membership_GetPasswordWithFormat @ApplicationName, @UserName, @UpdateLastLoginActivityDate, @CurrentTimeUtc", new object[]
            {
                applicationNameParam,
                userNameParam,
                updateLastLoginActivityDateParam,
                currentTimeUtcParam,
                procResultParam

            }).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public List<AspnetMembershipGetUserByEmailReturnModel> AspnetMembershipGetUserByEmail(string applicationName, string email, out int procResult)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var emailParam = new SqlParameter { ParameterName = "@Email", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = email, Size = 256 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<AspnetMembershipGetUserByEmailReturnModel>("EXEC @procResult = aspnet_Membership_GetUserByEmail @ApplicationName, @Email", new object[]
            {
                applicationNameParam,
                emailParam,
                procResultParam

            }).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public List<AspnetMembershipGetUserByNameReturnModel> AspnetMembershipGetUserByName(string applicationName, string userName, DateTime currentTimeUtc, bool updateLastActivity, out int procResult)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var userNameParam = new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userName, Size = 256 };
            var currentTimeUtcParam = new SqlParameter { ParameterName = "@CurrentTimeUtc", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = currentTimeUtc };
            var updateLastActivityParam = new SqlParameter { ParameterName = "@UpdateLastActivity", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = updateLastActivity };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<AspnetMembershipGetUserByNameReturnModel>("EXEC @procResult = aspnet_Membership_GetUserByName @ApplicationName, @UserName, @CurrentTimeUtc, @UpdateLastActivity", new object[]
            {
                applicationNameParam,
                userNameParam,
                currentTimeUtcParam,
                updateLastActivityParam,
                procResultParam

            }).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public List<AspnetMembershipGetUserByUserIdReturnModel> AspnetMembershipGetUserByUserId(Guid userId, DateTime currentTimeUtc, bool updateLastActivity, out int procResult)
        {
            var userIdParam = new SqlParameter { ParameterName = "@UserId", SqlDbType = SqlDbType.UniqueIdentifier, Direction = ParameterDirection.Input, Value = userId };
            var currentTimeUtcParam = new SqlParameter { ParameterName = "@CurrentTimeUtc", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = currentTimeUtc };
            var updateLastActivityParam = new SqlParameter { ParameterName = "@UpdateLastActivity", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = updateLastActivity };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<AspnetMembershipGetUserByUserIdReturnModel>("EXEC @procResult = aspnet_Membership_GetUserByUserId @UserId, @CurrentTimeUtc, @UpdateLastActivity", new object[]
            {
                userIdParam,
                currentTimeUtcParam,
                updateLastActivityParam,
                procResultParam

            }).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public int AspnetMembershipResetPassword(string applicationName, string userName, string newPassword, int maxInvalidPasswordAttempts, int passwordAttemptWindow, string passwordSalt, DateTime currentTimeUtc, int passwordFormat, string passwordAnswer)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var userNameParam = new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userName, Size = 256 };
            var newPasswordParam = new SqlParameter { ParameterName = "@NewPassword", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = newPassword, Size = 128 };
            var maxInvalidPasswordAttemptsParam = new SqlParameter { ParameterName = "@MaxInvalidPasswordAttempts", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = maxInvalidPasswordAttempts };
            var passwordAttemptWindowParam = new SqlParameter { ParameterName = "@PasswordAttemptWindow", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = passwordAttemptWindow };
            var passwordSaltParam = new SqlParameter { ParameterName = "@PasswordSalt", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = passwordSalt, Size = 128 };
            var currentTimeUtcParam = new SqlParameter { ParameterName = "@CurrentTimeUtc", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = currentTimeUtc };
            var passwordFormatParam = new SqlParameter { ParameterName = "@PasswordFormat", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = passwordFormat };
            var passwordAnswerParam = new SqlParameter { ParameterName = "@PasswordAnswer", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = passwordAnswer, Size = 128 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Membership_ResetPassword @ApplicationName, @UserName, @NewPassword, @MaxInvalidPasswordAttempts, @PasswordAttemptWindow, @PasswordSalt, @CurrentTimeUtc, @PasswordFormat, @PasswordAnswer", new object[]
            {
                applicationNameParam,
                userNameParam,
                newPasswordParam,
                maxInvalidPasswordAttemptsParam,
                passwordAttemptWindowParam,
                passwordSaltParam,
                currentTimeUtcParam,
                passwordFormatParam,
                passwordAnswerParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public int AspnetMembershipSetPassword(string applicationName, string userName, string newPassword, string passwordSalt, DateTime currentTimeUtc, int passwordFormat)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var userNameParam = new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userName, Size = 256 };
            var newPasswordParam = new SqlParameter { ParameterName = "@NewPassword", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = newPassword, Size = 128 };
            var passwordSaltParam = new SqlParameter { ParameterName = "@PasswordSalt", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = passwordSalt, Size = 128 };
            var currentTimeUtcParam = new SqlParameter { ParameterName = "@CurrentTimeUtc", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = currentTimeUtc };
            var passwordFormatParam = new SqlParameter { ParameterName = "@PasswordFormat", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = passwordFormat };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Membership_SetPassword @ApplicationName, @UserName, @NewPassword, @PasswordSalt, @CurrentTimeUtc, @PasswordFormat", new object[]
            {
                applicationNameParam,
                userNameParam,
                newPasswordParam,
                passwordSaltParam,
                currentTimeUtcParam,
                passwordFormatParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public int AspnetMembershipUnlockUser(string applicationName, string userName)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var userNameParam = new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userName, Size = 256 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Membership_UnlockUser @ApplicationName, @UserName", new object[]
            {
                applicationNameParam,
                userNameParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public int AspnetMembershipUpdateUser(string applicationName, string userName, string email, string comment, bool isApproved, DateTime lastLoginDate, DateTime lastActivityDate, int uniqueEmail, DateTime currentTimeUtc)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var userNameParam = new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userName, Size = 256 };
            var emailParam = new SqlParameter { ParameterName = "@Email", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = email, Size = 256 };
            var commentParam = new SqlParameter { ParameterName = "@Comment", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = comment, Size = 1073741823 };
            var isApprovedParam = new SqlParameter { ParameterName = "@IsApproved", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = isApproved };
            var lastLoginDateParam = new SqlParameter { ParameterName = "@LastLoginDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = lastLoginDate };
            var lastActivityDateParam = new SqlParameter { ParameterName = "@LastActivityDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = lastActivityDate };
            var uniqueEmailParam = new SqlParameter { ParameterName = "@UniqueEmail", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = uniqueEmail };
            var currentTimeUtcParam = new SqlParameter { ParameterName = "@CurrentTimeUtc", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = currentTimeUtc };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Membership_UpdateUser @ApplicationName, @UserName, @Email, @Comment, @IsApproved, @LastLoginDate, @LastActivityDate, @UniqueEmail, @CurrentTimeUtc", new object[]
            {
                applicationNameParam,
                userNameParam,
                emailParam,
                commentParam,
                isApprovedParam,
                lastLoginDateParam,
                lastActivityDateParam,
                uniqueEmailParam,
                currentTimeUtcParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public int AspnetMembershipUpdateUserInfo(string applicationName, string userName, bool isPasswordCorrect, bool updateLastLoginActivityDate, int maxInvalidPasswordAttempts, int passwordAttemptWindow, DateTime currentTimeUtc, DateTime lastLoginDate, DateTime lastActivityDate)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var userNameParam = new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userName, Size = 256 };
            var isPasswordCorrectParam = new SqlParameter { ParameterName = "@IsPasswordCorrect", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = isPasswordCorrect };
            var updateLastLoginActivityDateParam = new SqlParameter { ParameterName = "@UpdateLastLoginActivityDate", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = updateLastLoginActivityDate };
            var maxInvalidPasswordAttemptsParam = new SqlParameter { ParameterName = "@MaxInvalidPasswordAttempts", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = maxInvalidPasswordAttempts };
            var passwordAttemptWindowParam = new SqlParameter { ParameterName = "@PasswordAttemptWindow", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = passwordAttemptWindow };
            var currentTimeUtcParam = new SqlParameter { ParameterName = "@CurrentTimeUtc", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = currentTimeUtc };
            var lastLoginDateParam = new SqlParameter { ParameterName = "@LastLoginDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = lastLoginDate };
            var lastActivityDateParam = new SqlParameter { ParameterName = "@LastActivityDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = lastActivityDate };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Membership_UpdateUserInfo @ApplicationName, @UserName, @IsPasswordCorrect, @UpdateLastLoginActivityDate, @MaxInvalidPasswordAttempts, @PasswordAttemptWindow, @CurrentTimeUtc, @LastLoginDate, @LastActivityDate", new object[]
            {
                applicationNameParam,
                userNameParam,
                isPasswordCorrectParam,
                updateLastLoginActivityDateParam,
                maxInvalidPasswordAttemptsParam,
                passwordAttemptWindowParam,
                currentTimeUtcParam,
                lastLoginDateParam,
                lastActivityDateParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public int AspnetPathsCreatePath(Guid applicationId, string path, out Guid pathId)
        {
            var applicationIdParam = new SqlParameter { ParameterName = "@ApplicationId", SqlDbType = SqlDbType.UniqueIdentifier, Direction = ParameterDirection.Input, Value = applicationId };
            var pathParam = new SqlParameter { ParameterName = "@Path", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = path, Size = 256 };
            var pathIdParam = new SqlParameter { ParameterName = "@PathId", SqlDbType = SqlDbType.UniqueIdentifier, Direction = ParameterDirection.Output };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Paths_CreatePath @ApplicationId, @Path, @PathId OUTPUT", new object[]
            {
                applicationIdParam,
                pathParam,
                pathIdParam,
                procResultParam
 
            });
            pathId = (Guid) pathIdParam.Value;
 
            return (int) procResultParam.Value;
        }

        public int AspnetPersonalizationGetApplicationId(string applicationName, out Guid applicationId)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var applicationIdParam = new SqlParameter { ParameterName = "@ApplicationId", SqlDbType = SqlDbType.UniqueIdentifier, Direction = ParameterDirection.Output };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Personalization_GetApplicationId @ApplicationName, @ApplicationId OUTPUT", new object[]
            {
                applicationNameParam,
                applicationIdParam,
                procResultParam
 
            });
            applicationId = (Guid) applicationIdParam.Value;
 
            return (int) procResultParam.Value;
        }

        public int AspnetPersonalizationAdministrationDeleteAllState(bool allUsersScope, string applicationName, out int count)
        {
            var allUsersScopeParam = new SqlParameter { ParameterName = "@AllUsersScope", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = allUsersScope };
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var countParam = new SqlParameter { ParameterName = "@Count", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_PersonalizationAdministration_DeleteAllState @AllUsersScope, @ApplicationName, @Count OUTPUT", new object[]
            {
                allUsersScopeParam,
                applicationNameParam,
                countParam,
                procResultParam
 
            });
            count = (int) countParam.Value;
 
            return (int) procResultParam.Value;
        }

        public int AspnetPersonalizationAdministrationFindState(bool allUsersScope, string applicationName, int pageIndex, int pageSize, string path, string userName, DateTime inactiveSinceDate)
        {
            var allUsersScopeParam = new SqlParameter { ParameterName = "@AllUsersScope", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = allUsersScope };
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var pageIndexParam = new SqlParameter { ParameterName = "@PageIndex", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = pageIndex };
            var pageSizeParam = new SqlParameter { ParameterName = "@PageSize", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = pageSize };
            var pathParam = new SqlParameter { ParameterName = "@Path", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = path, Size = 256 };
            var userNameParam = new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userName, Size = 256 };
            var inactiveSinceDateParam = new SqlParameter { ParameterName = "@InactiveSinceDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = inactiveSinceDate };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_PersonalizationAdministration_FindState @AllUsersScope, @ApplicationName, @PageIndex, @PageSize, @Path, @UserName, @InactiveSinceDate", new object[]
            {
                allUsersScopeParam,
                applicationNameParam,
                pageIndexParam,
                pageSizeParam,
                pathParam,
                userNameParam,
                inactiveSinceDateParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public int AspnetPersonalizationAdministrationGetCountOfState(out int count, bool allUsersScope, string applicationName, string path, string userName, DateTime inactiveSinceDate)
        {
            var countParam = new SqlParameter { ParameterName = "@Count", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
            var allUsersScopeParam = new SqlParameter { ParameterName = "@AllUsersScope", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = allUsersScope };
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var pathParam = new SqlParameter { ParameterName = "@Path", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = path, Size = 256 };
            var userNameParam = new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userName, Size = 256 };
            var inactiveSinceDateParam = new SqlParameter { ParameterName = "@InactiveSinceDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = inactiveSinceDate };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_PersonalizationAdministration_GetCountOfState @Count OUTPUT, @AllUsersScope, @ApplicationName, @Path, @UserName, @InactiveSinceDate", new object[]
            {
                countParam,
                allUsersScopeParam,
                applicationNameParam,
                pathParam,
                userNameParam,
                inactiveSinceDateParam,
                procResultParam
 
            });
            count = (int) countParam.Value;
 
            return (int) procResultParam.Value;
        }

        public int AspnetPersonalizationAdministrationResetSharedState(out int count, string applicationName, string path)
        {
            var countParam = new SqlParameter { ParameterName = "@Count", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var pathParam = new SqlParameter { ParameterName = "@Path", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = path, Size = 256 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_PersonalizationAdministration_ResetSharedState @Count OUTPUT, @ApplicationName, @Path", new object[]
            {
                countParam,
                applicationNameParam,
                pathParam,
                procResultParam
 
            });
            count = (int) countParam.Value;
 
            return (int) procResultParam.Value;
        }

        public int AspnetPersonalizationAdministrationResetUserState(out int count, string applicationName, DateTime inactiveSinceDate, string userName, string path)
        {
            var countParam = new SqlParameter { ParameterName = "@Count", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var inactiveSinceDateParam = new SqlParameter { ParameterName = "@InactiveSinceDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = inactiveSinceDate };
            var userNameParam = new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userName, Size = 256 };
            var pathParam = new SqlParameter { ParameterName = "@Path", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = path, Size = 256 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_PersonalizationAdministration_ResetUserState @Count OUTPUT, @ApplicationName, @InactiveSinceDate, @UserName, @Path", new object[]
            {
                countParam,
                applicationNameParam,
                inactiveSinceDateParam,
                userNameParam,
                pathParam,
                procResultParam
 
            });
            count = (int) countParam.Value;
 
            return (int) procResultParam.Value;
        }

        public List<AspnetPersonalizationAllUsersGetPageSettingsReturnModel> AspnetPersonalizationAllUsersGetPageSettings(string applicationName, string path, out int procResult)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var pathParam = new SqlParameter { ParameterName = "@Path", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = path, Size = 256 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<AspnetPersonalizationAllUsersGetPageSettingsReturnModel>("EXEC @procResult = aspnet_PersonalizationAllUsers_GetPageSettings @ApplicationName, @Path", new object[]
            {
                applicationNameParam,
                pathParam,
                procResultParam

            }).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public int AspnetPersonalizationAllUsersResetPageSettings(string applicationName, string path)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var pathParam = new SqlParameter { ParameterName = "@Path", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = path, Size = 256 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_PersonalizationAllUsers_ResetPageSettings @ApplicationName, @Path", new object[]
            {
                applicationNameParam,
                pathParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public int AspnetPersonalizationAllUsersSetPageSettings(string applicationName, string path, byte[] pageSettings, DateTime currentTimeUtc)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var pathParam = new SqlParameter { ParameterName = "@Path", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = path, Size = 256 };
            var pageSettingsParam = new SqlParameter { ParameterName = "@PageSettings", SqlDbType = SqlDbType.Image, Direction = ParameterDirection.Input, Value = pageSettings, Size = 2147483647 };
            var currentTimeUtcParam = new SqlParameter { ParameterName = "@CurrentTimeUtc", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = currentTimeUtc };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_PersonalizationAllUsers_SetPageSettings @ApplicationName, @Path, @PageSettings, @CurrentTimeUtc", new object[]
            {
                applicationNameParam,
                pathParam,
                pageSettingsParam,
                currentTimeUtcParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public List<AspnetPersonalizationPerUserGetPageSettingsReturnModel> AspnetPersonalizationPerUserGetPageSettings(string applicationName, string userName, string path, DateTime currentTimeUtc, out int procResult)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var userNameParam = new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userName, Size = 256 };
            var pathParam = new SqlParameter { ParameterName = "@Path", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = path, Size = 256 };
            var currentTimeUtcParam = new SqlParameter { ParameterName = "@CurrentTimeUtc", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = currentTimeUtc };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<AspnetPersonalizationPerUserGetPageSettingsReturnModel>("EXEC @procResult = aspnet_PersonalizationPerUser_GetPageSettings @ApplicationName, @UserName, @Path, @CurrentTimeUtc", new object[]
            {
                applicationNameParam,
                userNameParam,
                pathParam,
                currentTimeUtcParam,
                procResultParam

            }).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public int AspnetPersonalizationPerUserResetPageSettings(string applicationName, string userName, string path, DateTime currentTimeUtc)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var userNameParam = new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userName, Size = 256 };
            var pathParam = new SqlParameter { ParameterName = "@Path", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = path, Size = 256 };
            var currentTimeUtcParam = new SqlParameter { ParameterName = "@CurrentTimeUtc", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = currentTimeUtc };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_PersonalizationPerUser_ResetPageSettings @ApplicationName, @UserName, @Path, @CurrentTimeUtc", new object[]
            {
                applicationNameParam,
                userNameParam,
                pathParam,
                currentTimeUtcParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public int AspnetPersonalizationPerUserSetPageSettings(string applicationName, string userName, string path, byte[] pageSettings, DateTime currentTimeUtc)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var userNameParam = new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userName, Size = 256 };
            var pathParam = new SqlParameter { ParameterName = "@Path", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = path, Size = 256 };
            var pageSettingsParam = new SqlParameter { ParameterName = "@PageSettings", SqlDbType = SqlDbType.Image, Direction = ParameterDirection.Input, Value = pageSettings, Size = 2147483647 };
            var currentTimeUtcParam = new SqlParameter { ParameterName = "@CurrentTimeUtc", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = currentTimeUtc };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_PersonalizationPerUser_SetPageSettings @ApplicationName, @UserName, @Path, @PageSettings, @CurrentTimeUtc", new object[]
            {
                applicationNameParam,
                userNameParam,
                pathParam,
                pageSettingsParam,
                currentTimeUtcParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public List<AspnetProfileDeleteInactiveProfilesReturnModel> AspnetProfileDeleteInactiveProfiles(string applicationName, int profileAuthOptions, DateTime inactiveSinceDate, out int procResult)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var profileAuthOptionsParam = new SqlParameter { ParameterName = "@ProfileAuthOptions", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = profileAuthOptions };
            var inactiveSinceDateParam = new SqlParameter { ParameterName = "@InactiveSinceDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = inactiveSinceDate };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<AspnetProfileDeleteInactiveProfilesReturnModel>("EXEC @procResult = aspnet_Profile_DeleteInactiveProfiles @ApplicationName, @ProfileAuthOptions, @InactiveSinceDate", new object[]
            {
                applicationNameParam,
                profileAuthOptionsParam,
                inactiveSinceDateParam,
                procResultParam

            }).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public List<AspnetProfileDeleteProfilesReturnModel> AspnetProfileDeleteProfiles(string applicationName, string userNames, out int procResult)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var userNamesParam = new SqlParameter { ParameterName = "@UserNames", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userNames, Size = 4000 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<AspnetProfileDeleteProfilesReturnModel>("EXEC @procResult = aspnet_Profile_DeleteProfiles @ApplicationName, @UserNames", new object[]
            {
                applicationNameParam,
                userNamesParam,
                procResultParam

            }).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public List<AspnetProfileGetNumberOfInactiveProfilesReturnModel> AspnetProfileGetNumberOfInactiveProfiles(string applicationName, int profileAuthOptions, DateTime inactiveSinceDate, out int procResult)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var profileAuthOptionsParam = new SqlParameter { ParameterName = "@ProfileAuthOptions", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = profileAuthOptions };
            var inactiveSinceDateParam = new SqlParameter { ParameterName = "@InactiveSinceDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = inactiveSinceDate };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<AspnetProfileGetNumberOfInactiveProfilesReturnModel>("EXEC @procResult = aspnet_Profile_GetNumberOfInactiveProfiles @ApplicationName, @ProfileAuthOptions, @InactiveSinceDate", new object[]
            {
                applicationNameParam,
                profileAuthOptionsParam,
                inactiveSinceDateParam,
                procResultParam

            }).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public int AspnetProfileGetProfiles(string applicationName, int profileAuthOptions, int pageIndex, int pageSize, string userNameToMatch, DateTime inactiveSinceDate)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var profileAuthOptionsParam = new SqlParameter { ParameterName = "@ProfileAuthOptions", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = profileAuthOptions };
            var pageIndexParam = new SqlParameter { ParameterName = "@PageIndex", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = pageIndex };
            var pageSizeParam = new SqlParameter { ParameterName = "@PageSize", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = pageSize };
            var userNameToMatchParam = new SqlParameter { ParameterName = "@UserNameToMatch", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userNameToMatch, Size = 256 };
            var inactiveSinceDateParam = new SqlParameter { ParameterName = "@InactiveSinceDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = inactiveSinceDate };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Profile_GetProfiles @ApplicationName, @ProfileAuthOptions, @PageIndex, @PageSize, @UserNameToMatch, @InactiveSinceDate", new object[]
            {
                applicationNameParam,
                profileAuthOptionsParam,
                pageIndexParam,
                pageSizeParam,
                userNameToMatchParam,
                inactiveSinceDateParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public List<AspnetProfileGetPropertiesReturnModel> AspnetProfileGetProperties(string applicationName, string userName, DateTime currentTimeUtc, out int procResult)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var userNameParam = new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userName, Size = 256 };
            var currentTimeUtcParam = new SqlParameter { ParameterName = "@CurrentTimeUtc", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = currentTimeUtc };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<AspnetProfileGetPropertiesReturnModel>("EXEC @procResult = aspnet_Profile_GetProperties @ApplicationName, @UserName, @CurrentTimeUtc", new object[]
            {
                applicationNameParam,
                userNameParam,
                currentTimeUtcParam,
                procResultParam

            }).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public int AspnetProfileSetProperties(string applicationName, string propertyNames, string propertyValuesString, byte[] propertyValuesBinary, string userName, bool isUserAnonymous, DateTime currentTimeUtc)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var propertyNamesParam = new SqlParameter { ParameterName = "@PropertyNames", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = propertyNames, Size = 1073741823 };
            var propertyValuesStringParam = new SqlParameter { ParameterName = "@PropertyValuesString", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = propertyValuesString, Size = 1073741823 };
            var propertyValuesBinaryParam = new SqlParameter { ParameterName = "@PropertyValuesBinary", SqlDbType = SqlDbType.Image, Direction = ParameterDirection.Input, Value = propertyValuesBinary, Size = 2147483647 };
            var userNameParam = new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userName, Size = 256 };
            var isUserAnonymousParam = new SqlParameter { ParameterName = "@IsUserAnonymous", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = isUserAnonymous };
            var currentTimeUtcParam = new SqlParameter { ParameterName = "@CurrentTimeUtc", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = currentTimeUtc };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Profile_SetProperties @ApplicationName, @PropertyNames, @PropertyValuesString, @PropertyValuesBinary, @UserName, @IsUserAnonymous, @CurrentTimeUtc", new object[]
            {
                applicationNameParam,
                propertyNamesParam,
                propertyValuesStringParam,
                propertyValuesBinaryParam,
                userNameParam,
                isUserAnonymousParam,
                currentTimeUtcParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public int AspnetRegisterSchemaVersion(string feature, string compatibleSchemaVersion, bool isCurrentVersion, bool removeIncompatibleSchema)
        {
            var featureParam = new SqlParameter { ParameterName = "@Feature", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = feature, Size = 128 };
            var compatibleSchemaVersionParam = new SqlParameter { ParameterName = "@CompatibleSchemaVersion", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = compatibleSchemaVersion, Size = 128 };
            var isCurrentVersionParam = new SqlParameter { ParameterName = "@IsCurrentVersion", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = isCurrentVersion };
            var removeIncompatibleSchemaParam = new SqlParameter { ParameterName = "@RemoveIncompatibleSchema", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = removeIncompatibleSchema };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_RegisterSchemaVersion @Feature, @CompatibleSchemaVersion, @IsCurrentVersion, @RemoveIncompatibleSchema", new object[]
            {
                featureParam,
                compatibleSchemaVersionParam,
                isCurrentVersionParam,
                removeIncompatibleSchemaParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public int AspnetRolesCreateRole(string applicationName, string roleName)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var roleNameParam = new SqlParameter { ParameterName = "@RoleName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = roleName, Size = 256 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Roles_CreateRole @ApplicationName, @RoleName", new object[]
            {
                applicationNameParam,
                roleNameParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public int AspnetRolesDeleteRole(string applicationName, string roleName, bool deleteOnlyIfRoleIsEmpty)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var roleNameParam = new SqlParameter { ParameterName = "@RoleName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = roleName, Size = 256 };
            var deleteOnlyIfRoleIsEmptyParam = new SqlParameter { ParameterName = "@DeleteOnlyIfRoleIsEmpty", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = deleteOnlyIfRoleIsEmpty };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Roles_DeleteRole @ApplicationName, @RoleName, @DeleteOnlyIfRoleIsEmpty", new object[]
            {
                applicationNameParam,
                roleNameParam,
                deleteOnlyIfRoleIsEmptyParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public List<AspnetRolesGetAllRolesReturnModel> AspnetRolesGetAllRoles(string applicationName, out int procResult)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<AspnetRolesGetAllRolesReturnModel>("EXEC @procResult = aspnet_Roles_GetAllRoles @ApplicationName", new object[]
            {
                applicationNameParam,
                procResultParam

            }).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public int AspnetRolesRoleExists(string applicationName, string roleName)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var roleNameParam = new SqlParameter { ParameterName = "@RoleName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = roleName, Size = 256 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Roles_RoleExists @ApplicationName, @RoleName", new object[]
            {
                applicationNameParam,
                roleNameParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public int AspnetSetupRemoveAllRoleMembers(string name)
        {
            var nameParam = new SqlParameter { ParameterName = "@name", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = name, Size = 128 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Setup_RemoveAllRoleMembers @name", new object[]
            {
                nameParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public int AspnetSetupRestorePermissions(string name)
        {
            var nameParam = new SqlParameter { ParameterName = "@name", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = name, Size = 128 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Setup_RestorePermissions @name", new object[]
            {
                nameParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public int AspnetUnRegisterSchemaVersion(string feature, string compatibleSchemaVersion)
        {
            var featureParam = new SqlParameter { ParameterName = "@Feature", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = feature, Size = 128 };
            var compatibleSchemaVersionParam = new SqlParameter { ParameterName = "@CompatibleSchemaVersion", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = compatibleSchemaVersion, Size = 128 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_UnRegisterSchemaVersion @Feature, @CompatibleSchemaVersion", new object[]
            {
                featureParam,
                compatibleSchemaVersionParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public int AspnetUsersCreateUser(Guid applicationId, string userName, bool isUserAnonymous, DateTime lastActivityDate, out Guid userId)
        {
            var applicationIdParam = new SqlParameter { ParameterName = "@ApplicationId", SqlDbType = SqlDbType.UniqueIdentifier, Direction = ParameterDirection.Input, Value = applicationId };
            var userNameParam = new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userName, Size = 256 };
            var isUserAnonymousParam = new SqlParameter { ParameterName = "@IsUserAnonymous", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = isUserAnonymous };
            var lastActivityDateParam = new SqlParameter { ParameterName = "@LastActivityDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = lastActivityDate };
            var userIdParam = new SqlParameter { ParameterName = "@UserId", SqlDbType = SqlDbType.UniqueIdentifier, Direction = ParameterDirection.Output };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Users_CreateUser @ApplicationId, @UserName, @IsUserAnonymous, @LastActivityDate, @UserId OUTPUT", new object[]
            {
                applicationIdParam,
                userNameParam,
                isUserAnonymousParam,
                lastActivityDateParam,
                userIdParam,
                procResultParam
 
            });
            userId = (Guid) userIdParam.Value;
 
            return (int) procResultParam.Value;
        }

        public int AspnetUsersDeleteUser(string applicationName, string userName, int tablesToDeleteFrom, out int numTablesDeletedFrom)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var userNameParam = new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userName, Size = 256 };
            var tablesToDeleteFromParam = new SqlParameter { ParameterName = "@TablesToDeleteFrom", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = tablesToDeleteFrom };
            var numTablesDeletedFromParam = new SqlParameter { ParameterName = "@NumTablesDeletedFrom", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_Users_DeleteUser @ApplicationName, @UserName, @TablesToDeleteFrom, @NumTablesDeletedFrom OUTPUT", new object[]
            {
                applicationNameParam,
                userNameParam,
                tablesToDeleteFromParam,
                numTablesDeletedFromParam,
                procResultParam
 
            });
            numTablesDeletedFrom = (int) numTablesDeletedFromParam.Value;
 
            return (int) procResultParam.Value;
        }

        public List<AspnetUsersInRolesAddUsersToRolesReturnModel> AspnetUsersInRolesAddUsersToRoles(string applicationName, string userNames, string roleNames, DateTime currentTimeUtc, out int procResult)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var userNamesParam = new SqlParameter { ParameterName = "@UserNames", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userNames, Size = 4000 };
            var roleNamesParam = new SqlParameter { ParameterName = "@RoleNames", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = roleNames, Size = 4000 };
            var currentTimeUtcParam = new SqlParameter { ParameterName = "@CurrentTimeUtc", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = currentTimeUtc };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<AspnetUsersInRolesAddUsersToRolesReturnModel>("EXEC @procResult = aspnet_UsersInRoles_AddUsersToRoles @ApplicationName, @UserNames, @RoleNames, @CurrentTimeUtc", new object[]
            {
                applicationNameParam,
                userNamesParam,
                roleNamesParam,
                currentTimeUtcParam,
                procResultParam

            }).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public List<AspnetUsersInRolesFindUsersInRoleReturnModel> AspnetUsersInRolesFindUsersInRole(string applicationName, string roleName, string userNameToMatch, out int procResult)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var roleNameParam = new SqlParameter { ParameterName = "@RoleName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = roleName, Size = 256 };
            var userNameToMatchParam = new SqlParameter { ParameterName = "@UserNameToMatch", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userNameToMatch, Size = 256 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<AspnetUsersInRolesFindUsersInRoleReturnModel>("EXEC @procResult = aspnet_UsersInRoles_FindUsersInRole @ApplicationName, @RoleName, @UserNameToMatch", new object[]
            {
                applicationNameParam,
                roleNameParam,
                userNameToMatchParam,
                procResultParam

            }).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public List<AspnetUsersInRolesGetRolesForUserReturnModel> AspnetUsersInRolesGetRolesForUser(string applicationName, string userName, out int procResult)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var userNameParam = new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userName, Size = 256 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<AspnetUsersInRolesGetRolesForUserReturnModel>("EXEC @procResult = aspnet_UsersInRoles_GetRolesForUser @ApplicationName, @UserName", new object[]
            {
                applicationNameParam,
                userNameParam,
                procResultParam

            }).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public List<AspnetUsersInRolesGetUsersInRolesReturnModel> AspnetUsersInRolesGetUsersInRoles(string applicationName, string roleName, out int procResult)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var roleNameParam = new SqlParameter { ParameterName = "@RoleName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = roleName, Size = 256 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<AspnetUsersInRolesGetUsersInRolesReturnModel>("EXEC @procResult = aspnet_UsersInRoles_GetUsersInRoles @ApplicationName, @RoleName", new object[]
            {
                applicationNameParam,
                roleNameParam,
                procResultParam

            }).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public int AspnetUsersInRolesIsUserInRole(string applicationName, string userName, string roleName)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var userNameParam = new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userName, Size = 256 };
            var roleNameParam = new SqlParameter { ParameterName = "@RoleName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = roleName, Size = 256 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_UsersInRoles_IsUserInRole @ApplicationName, @UserName, @RoleName", new object[]
            {
                applicationNameParam,
                userNameParam,
                roleNameParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
        }

        public List<AspnetUsersInRolesRemoveUsersFromRolesReturnModel> AspnetUsersInRolesRemoveUsersFromRoles(string applicationName, string userNames, string roleNames, out int procResult)
        {
            var applicationNameParam = new SqlParameter { ParameterName = "@ApplicationName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationName, Size = 256 };
            var userNamesParam = new SqlParameter { ParameterName = "@UserNames", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = userNames, Size = 4000 };
            var roleNamesParam = new SqlParameter { ParameterName = "@RoleNames", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = roleNames, Size = 4000 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            var procResultData = Database.SqlQuery<AspnetUsersInRolesRemoveUsersFromRolesReturnModel>("EXEC @procResult = aspnet_UsersInRoles_RemoveUsersFromRoles @ApplicationName, @UserNames, @RoleNames", new object[]
            {
                applicationNameParam,
                userNamesParam,
                roleNamesParam,
                procResultParam

            }).ToList();
 
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public int AspnetWebEventLogEvent(string eventId, DateTime eventTimeUtc, DateTime eventTime, string eventType, decimal eventSequence, decimal eventOccurrence, int eventCode, int eventDetailCode, string message, string applicationPath, string applicationVirtualPath, string machineName, string requestUrl, string exceptionType, string details)
        {
            var eventIdParam = new SqlParameter { ParameterName = "@EventId", SqlDbType = SqlDbType.Char, Direction = ParameterDirection.Input, Value = eventId, Size = 32 };
            var eventTimeUtcParam = new SqlParameter { ParameterName = "@EventTimeUtc", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = eventTimeUtc };
            var eventTimeParam = new SqlParameter { ParameterName = "@EventTime", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = eventTime };
            var eventTypeParam = new SqlParameter { ParameterName = "@EventType", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = eventType, Size = 256 };
            var eventSequenceParam = new SqlParameter { ParameterName = "@EventSequence", SqlDbType = SqlDbType.Decimal, Direction = ParameterDirection.Input, Value = eventSequence };
            var eventOccurrenceParam = new SqlParameter { ParameterName = "@EventOccurrence", SqlDbType = SqlDbType.Decimal, Direction = ParameterDirection.Input, Value = eventOccurrence };
            var eventCodeParam = new SqlParameter { ParameterName = "@EventCode", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = eventCode };
            var eventDetailCodeParam = new SqlParameter { ParameterName = "@EventDetailCode", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = eventDetailCode };
            var messageParam = new SqlParameter { ParameterName = "@Message", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = message, Size = 1024 };
            var applicationPathParam = new SqlParameter { ParameterName = "@ApplicationPath", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationPath, Size = 256 };
            var applicationVirtualPathParam = new SqlParameter { ParameterName = "@ApplicationVirtualPath", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = applicationVirtualPath, Size = 256 };
            var machineNameParam = new SqlParameter { ParameterName = "@MachineName", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = machineName, Size = 256 };
            var requestUrlParam = new SqlParameter { ParameterName = "@RequestUrl", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = requestUrl, Size = 1024 };
            var exceptionTypeParam = new SqlParameter { ParameterName = "@ExceptionType", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = exceptionType, Size = 256 };
            var detailsParam = new SqlParameter { ParameterName = "@Details", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = details, Size = 1073741823 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = aspnet_WebEvent_LogEvent @EventId, @EventTimeUtc, @EventTime, @EventType, @EventSequence, @EventOccurrence, @EventCode, @EventDetailCode, @Message, @ApplicationPath, @ApplicationVirtualPath, @MachineName, @RequestUrl, @ExceptionType, @Details", new object[]
            {
                eventIdParam,
                eventTimeUtcParam,
                eventTimeParam,
                eventTypeParam,
                eventSequenceParam,
                eventOccurrenceParam,
                eventCodeParam,
                eventDetailCodeParam,
                messageParam,
                applicationPathParam,
                applicationVirtualPathParam,
                machineNameParam,
                requestUrlParam,
                exceptionTypeParam,
                detailsParam,
                procResultParam
 
            });
 
            return (int) procResultParam.Value;
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
        public IDbSet<AggregateRoot> AggregateRoots { get; set; }
        public IDbSet<AggregateRootEvent> AggregateRootEvents { get; set; }
        public IDbSet<AspnetApplications> AspnetApplications { get; set; }
        public IDbSet<AspnetMembership> AspnetMemberships { get; set; }
        public IDbSet<AspnetPaths> AspnetPaths { get; set; }
        public IDbSet<AspnetPersonalizationAllUsers> AspnetPersonalizationAllUsers { get; set; }
        public IDbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; }
        public IDbSet<AspnetProfile> AspnetProfiles { get; set; }
        public IDbSet<AspnetRoles> AspnetRoles { get; set; }
        public IDbSet<AspnetSchemaVersions> AspnetSchemaVersions { get; set; }
        public IDbSet<AspnetUsers> AspnetUsers { get; set; }
        public IDbSet<AspnetWebEventEvents> AspnetWebEventEvents { get; set; }
        public IDbSet<Bank> Banks { get; set; }
        public IDbSet<BankAccount> BankAccounts { get; set; }
        public IDbSet<BankSpecificTransactionType> BankSpecificTransactionTypes { get; set; }
        public IDbSet<Budget> Budgets { get; set; }
        public IDbSet<Fund> Funds { get; set; }
        public IDbSet<Position> Positions { get; set; }
        public IDbSet<User> Users { get; set; }
        public IDbSet<UserPosition> UserPositions { get; set; }
        public IDbSet<VwAspnetApplications> VwAspnetApplications { get; set; }
        public IDbSet<VwAspnetMembershipUsers> VwAspnetMembershipUsers { get; set; }
        public IDbSet<VwAspnetProfiles> VwAspnetProfiles { get; set; }
        public IDbSet<VwAspnetRoles> VwAspnetRoles { get; set; }
        public IDbSet<VwAspnetUsers> VwAspnetUsers { get; set; }
        public IDbSet<VwAspnetUsersInRoles> VwAspnetUsersInRoles { get; set; }
        public IDbSet<VwAspnetWebPartStatePaths> VwAspnetWebPartStatePaths { get; set; }
        public IDbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShareds { get; set; }
        public IDbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUsers { get; set; }

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
            AspnetApplications = new FakeDbSet<AspnetApplications>();
            AspnetMemberships = new FakeDbSet<AspnetMembership>();
            AspnetPaths = new FakeDbSet<AspnetPaths>();
            AspnetPersonalizationAllUsers = new FakeDbSet<AspnetPersonalizationAllUsers>();
            AspnetPersonalizationPerUsers = new FakeDbSet<AspnetPersonalizationPerUser>();
            AspnetProfiles = new FakeDbSet<AspnetProfile>();
            AspnetRoles = new FakeDbSet<AspnetRoles>();
            AspnetSchemaVersions = new FakeDbSet<AspnetSchemaVersions>();
            AspnetUsers = new FakeDbSet<AspnetUsers>();
            AspnetWebEventEvents = new FakeDbSet<AspnetWebEventEvents>();
            Banks = new FakeDbSet<Bank>();
            BankAccounts = new FakeDbSet<BankAccount>();
            BankSpecificTransactionTypes = new FakeDbSet<BankSpecificTransactionType>();
            Budgets = new FakeDbSet<Budget>();
            Funds = new FakeDbSet<Fund>();
            Positions = new FakeDbSet<Position>();
            Users = new FakeDbSet<User>();
            UserPositions = new FakeDbSet<UserPosition>();
            VwAspnetApplications = new FakeDbSet<VwAspnetApplications>();
            VwAspnetMembershipUsers = new FakeDbSet<VwAspnetMembershipUsers>();
            VwAspnetProfiles = new FakeDbSet<VwAspnetProfiles>();
            VwAspnetRoles = new FakeDbSet<VwAspnetRoles>();
            VwAspnetUsers = new FakeDbSet<VwAspnetUsers>();
            VwAspnetUsersInRoles = new FakeDbSet<VwAspnetUsersInRoles>();
            VwAspnetWebPartStatePaths = new FakeDbSet<VwAspnetWebPartStatePaths>();
            VwAspnetWebPartStateShareds = new FakeDbSet<VwAspnetWebPartStateShared>();
            VwAspnetWebPartStateUsers = new FakeDbSet<VwAspnetWebPartStateUser>();
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
        public List<AspnetAnyDataInTablesReturnModel> AspnetAnyDataInTables(int tablesToCheck, out int procResult)
        {
 
            procResult = 0;
            return new List<AspnetAnyDataInTablesReturnModel>();
        }

        public int AspnetApplicationsCreateApplication(string applicationName, out Guid applicationId)
        {
            applicationId = default(Guid);
 
            return 0;
        }

        public int AspnetCheckSchemaVersion(string feature, string compatibleSchemaVersion)
        {
 
            return 0;
        }

        public int AspnetMembershipChangePasswordQuestionAndAnswer(string applicationName, string userName, string newPasswordQuestion, string newPasswordAnswer)
        {
 
            return 0;
        }

        public int AspnetMembershipCreateUser(string applicationName, string userName, string password, string passwordSalt, string email, string passwordQuestion, string passwordAnswer, bool isApproved, DateTime currentTimeUtc, DateTime createDate, int uniqueEmail, int passwordFormat, out Guid userId)
        {
            userId = default(Guid);
 
            return 0;
        }

        public int AspnetMembershipFindUsersByEmail(string applicationName, string emailToMatch, int pageIndex, int pageSize)
        {
 
            return 0;
        }

        public int AspnetMembershipFindUsersByName(string applicationName, string userNameToMatch, int pageIndex, int pageSize)
        {
 
            return 0;
        }

        public int AspnetMembershipGetAllUsers(string applicationName, int pageIndex, int pageSize)
        {
 
            return 0;
        }

        public int AspnetMembershipGetNumberOfUsersOnline(string applicationName, int minutesSinceLastInActive, DateTime currentTimeUtc)
        {
 
            return 0;
        }

        public List<AspnetMembershipGetPasswordReturnModel> AspnetMembershipGetPassword(string applicationName, string userName, int maxInvalidPasswordAttempts, int passwordAttemptWindow, DateTime currentTimeUtc, string passwordAnswer, out int procResult)
        {
 
            procResult = 0;
            return new List<AspnetMembershipGetPasswordReturnModel>();
        }

        public List<AspnetMembershipGetPasswordWithFormatReturnModel> AspnetMembershipGetPasswordWithFormat(string applicationName, string userName, bool updateLastLoginActivityDate, DateTime currentTimeUtc, out int procResult)
        {
 
            procResult = 0;
            return new List<AspnetMembershipGetPasswordWithFormatReturnModel>();
        }

        public List<AspnetMembershipGetUserByEmailReturnModel> AspnetMembershipGetUserByEmail(string applicationName, string email, out int procResult)
        {
 
            procResult = 0;
            return new List<AspnetMembershipGetUserByEmailReturnModel>();
        }

        public List<AspnetMembershipGetUserByNameReturnModel> AspnetMembershipGetUserByName(string applicationName, string userName, DateTime currentTimeUtc, bool updateLastActivity, out int procResult)
        {
 
            procResult = 0;
            return new List<AspnetMembershipGetUserByNameReturnModel>();
        }

        public List<AspnetMembershipGetUserByUserIdReturnModel> AspnetMembershipGetUserByUserId(Guid userId, DateTime currentTimeUtc, bool updateLastActivity, out int procResult)
        {
 
            procResult = 0;
            return new List<AspnetMembershipGetUserByUserIdReturnModel>();
        }

        public int AspnetMembershipResetPassword(string applicationName, string userName, string newPassword, int maxInvalidPasswordAttempts, int passwordAttemptWindow, string passwordSalt, DateTime currentTimeUtc, int passwordFormat, string passwordAnswer)
        {
 
            return 0;
        }

        public int AspnetMembershipSetPassword(string applicationName, string userName, string newPassword, string passwordSalt, DateTime currentTimeUtc, int passwordFormat)
        {
 
            return 0;
        }

        public int AspnetMembershipUnlockUser(string applicationName, string userName)
        {
 
            return 0;
        }

        public int AspnetMembershipUpdateUser(string applicationName, string userName, string email, string comment, bool isApproved, DateTime lastLoginDate, DateTime lastActivityDate, int uniqueEmail, DateTime currentTimeUtc)
        {
 
            return 0;
        }

        public int AspnetMembershipUpdateUserInfo(string applicationName, string userName, bool isPasswordCorrect, bool updateLastLoginActivityDate, int maxInvalidPasswordAttempts, int passwordAttemptWindow, DateTime currentTimeUtc, DateTime lastLoginDate, DateTime lastActivityDate)
        {
 
            return 0;
        }

        public int AspnetPathsCreatePath(Guid applicationId, string path, out Guid pathId)
        {
            pathId = default(Guid);
 
            return 0;
        }

        public int AspnetPersonalizationGetApplicationId(string applicationName, out Guid applicationId)
        {
            applicationId = default(Guid);
 
            return 0;
        }

        public int AspnetPersonalizationAdministrationDeleteAllState(bool allUsersScope, string applicationName, out int count)
        {
            count = default(int);
 
            return 0;
        }

        public int AspnetPersonalizationAdministrationFindState(bool allUsersScope, string applicationName, int pageIndex, int pageSize, string path, string userName, DateTime inactiveSinceDate)
        {
 
            return 0;
        }

        public int AspnetPersonalizationAdministrationGetCountOfState(out int count, bool allUsersScope, string applicationName, string path, string userName, DateTime inactiveSinceDate)
        {
            count = default(int);
 
            return 0;
        }

        public int AspnetPersonalizationAdministrationResetSharedState(out int count, string applicationName, string path)
        {
            count = default(int);
 
            return 0;
        }

        public int AspnetPersonalizationAdministrationResetUserState(out int count, string applicationName, DateTime inactiveSinceDate, string userName, string path)
        {
            count = default(int);
 
            return 0;
        }

        public List<AspnetPersonalizationAllUsersGetPageSettingsReturnModel> AspnetPersonalizationAllUsersGetPageSettings(string applicationName, string path, out int procResult)
        {
 
            procResult = 0;
            return new List<AspnetPersonalizationAllUsersGetPageSettingsReturnModel>();
        }

        public int AspnetPersonalizationAllUsersResetPageSettings(string applicationName, string path)
        {
 
            return 0;
        }

        public int AspnetPersonalizationAllUsersSetPageSettings(string applicationName, string path, byte[] pageSettings, DateTime currentTimeUtc)
        {
 
            return 0;
        }

        public List<AspnetPersonalizationPerUserGetPageSettingsReturnModel> AspnetPersonalizationPerUserGetPageSettings(string applicationName, string userName, string path, DateTime currentTimeUtc, out int procResult)
        {
 
            procResult = 0;
            return new List<AspnetPersonalizationPerUserGetPageSettingsReturnModel>();
        }

        public int AspnetPersonalizationPerUserResetPageSettings(string applicationName, string userName, string path, DateTime currentTimeUtc)
        {
 
            return 0;
        }

        public int AspnetPersonalizationPerUserSetPageSettings(string applicationName, string userName, string path, byte[] pageSettings, DateTime currentTimeUtc)
        {
 
            return 0;
        }

        public List<AspnetProfileDeleteInactiveProfilesReturnModel> AspnetProfileDeleteInactiveProfiles(string applicationName, int profileAuthOptions, DateTime inactiveSinceDate, out int procResult)
        {
 
            procResult = 0;
            return new List<AspnetProfileDeleteInactiveProfilesReturnModel>();
        }

        public List<AspnetProfileDeleteProfilesReturnModel> AspnetProfileDeleteProfiles(string applicationName, string userNames, out int procResult)
        {
 
            procResult = 0;
            return new List<AspnetProfileDeleteProfilesReturnModel>();
        }

        public List<AspnetProfileGetNumberOfInactiveProfilesReturnModel> AspnetProfileGetNumberOfInactiveProfiles(string applicationName, int profileAuthOptions, DateTime inactiveSinceDate, out int procResult)
        {
 
            procResult = 0;
            return new List<AspnetProfileGetNumberOfInactiveProfilesReturnModel>();
        }

        public int AspnetProfileGetProfiles(string applicationName, int profileAuthOptions, int pageIndex, int pageSize, string userNameToMatch, DateTime inactiveSinceDate)
        {
 
            return 0;
        }

        public List<AspnetProfileGetPropertiesReturnModel> AspnetProfileGetProperties(string applicationName, string userName, DateTime currentTimeUtc, out int procResult)
        {
 
            procResult = 0;
            return new List<AspnetProfileGetPropertiesReturnModel>();
        }

        public int AspnetProfileSetProperties(string applicationName, string propertyNames, string propertyValuesString, byte[] propertyValuesBinary, string userName, bool isUserAnonymous, DateTime currentTimeUtc)
        {
 
            return 0;
        }

        public int AspnetRegisterSchemaVersion(string feature, string compatibleSchemaVersion, bool isCurrentVersion, bool removeIncompatibleSchema)
        {
 
            return 0;
        }

        public int AspnetRolesCreateRole(string applicationName, string roleName)
        {
 
            return 0;
        }

        public int AspnetRolesDeleteRole(string applicationName, string roleName, bool deleteOnlyIfRoleIsEmpty)
        {
 
            return 0;
        }

        public List<AspnetRolesGetAllRolesReturnModel> AspnetRolesGetAllRoles(string applicationName, out int procResult)
        {
 
            procResult = 0;
            return new List<AspnetRolesGetAllRolesReturnModel>();
        }

        public int AspnetRolesRoleExists(string applicationName, string roleName)
        {
 
            return 0;
        }

        public int AspnetSetupRemoveAllRoleMembers(string name)
        {
 
            return 0;
        }

        public int AspnetSetupRestorePermissions(string name)
        {
 
            return 0;
        }

        public int AspnetUnRegisterSchemaVersion(string feature, string compatibleSchemaVersion)
        {
 
            return 0;
        }

        public int AspnetUsersCreateUser(Guid applicationId, string userName, bool isUserAnonymous, DateTime lastActivityDate, out Guid userId)
        {
            userId = default(Guid);
 
            return 0;
        }

        public int AspnetUsersDeleteUser(string applicationName, string userName, int tablesToDeleteFrom, out int numTablesDeletedFrom)
        {
            numTablesDeletedFrom = default(int);
 
            return 0;
        }

        public List<AspnetUsersInRolesAddUsersToRolesReturnModel> AspnetUsersInRolesAddUsersToRoles(string applicationName, string userNames, string roleNames, DateTime currentTimeUtc, out int procResult)
        {
 
            procResult = 0;
            return new List<AspnetUsersInRolesAddUsersToRolesReturnModel>();
        }

        public List<AspnetUsersInRolesFindUsersInRoleReturnModel> AspnetUsersInRolesFindUsersInRole(string applicationName, string roleName, string userNameToMatch, out int procResult)
        {
 
            procResult = 0;
            return new List<AspnetUsersInRolesFindUsersInRoleReturnModel>();
        }

        public List<AspnetUsersInRolesGetRolesForUserReturnModel> AspnetUsersInRolesGetRolesForUser(string applicationName, string userName, out int procResult)
        {
 
            procResult = 0;
            return new List<AspnetUsersInRolesGetRolesForUserReturnModel>();
        }

        public List<AspnetUsersInRolesGetUsersInRolesReturnModel> AspnetUsersInRolesGetUsersInRoles(string applicationName, string roleName, out int procResult)
        {
 
            procResult = 0;
            return new List<AspnetUsersInRolesGetUsersInRolesReturnModel>();
        }

        public int AspnetUsersInRolesIsUserInRole(string applicationName, string userName, string roleName)
        {
 
            return 0;
        }

        public List<AspnetUsersInRolesRemoveUsersFromRolesReturnModel> AspnetUsersInRolesRemoveUsersFromRoles(string applicationName, string userNames, string roleNames, out int procResult)
        {
 
            procResult = 0;
            return new List<AspnetUsersInRolesRemoveUsersFromRolesReturnModel>();
        }

        public int AspnetWebEventLogEvent(string eventId, DateTime eventTimeUtc, DateTime eventTime, string eventType, decimal eventSequence, decimal eventOccurrence, int eventCode, int eventDetailCode, string message, string applicationPath, string applicationVirtualPath, string machineName, string requestUrl, string exceptionType, string details)
        {
 
            return 0;
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

    // aspnet_Applications
    public class AspnetApplications
    {
        public string ApplicationName { get; set; } // ApplicationName
        public string LoweredApplicationName { get; set; } // LoweredApplicationName
        public Guid ApplicationId { get; set; } // ApplicationId (Primary key)
        public string Description { get; set; } // Description

        // Reverse navigation
        public virtual ICollection<AspnetMembership> AspnetMemberships { get; set; } // aspnet_Membership.FK__aspnet_Me__Appli__60A75C0F
        public virtual ICollection<AspnetPaths> AspnetPaths { get; set; } // aspnet_Paths.FK__aspnet_Pa__Appli__123EB7A3
        public virtual ICollection<AspnetRoles> AspnetRoles { get; set; } // aspnet_Roles.FK__aspnet_Ro__Appli__7F2BE32F
        public virtual ICollection<AspnetUsers> AspnetUsers { get; set; } // aspnet_Users.FK__aspnet_Us__Appli__5070F446

        public AspnetApplications()
        {
            ApplicationId = System.Guid.NewGuid();
            AspnetMemberships = new List<AspnetMembership>();
            AspnetPaths = new List<AspnetPaths>();
            AspnetRoles = new List<AspnetRoles>();
            AspnetUsers = new List<AspnetUsers>();
        }
    }

    // aspnet_Membership
    public class AspnetMembership
    {
        public Guid ApplicationId { get; set; } // ApplicationId
        public Guid UserId { get; set; } // UserId (Primary key)
        public string Password { get; set; } // Password
        public int PasswordFormat { get; set; } // PasswordFormat
        public string PasswordSalt { get; set; } // PasswordSalt
        public string MobilePin { get; set; } // MobilePIN
        public string Email { get; set; } // Email
        public string LoweredEmail { get; set; } // LoweredEmail
        public string PasswordQuestion { get; set; } // PasswordQuestion
        public string PasswordAnswer { get; set; } // PasswordAnswer
        public bool IsApproved { get; set; } // IsApproved
        public bool IsLockedOut { get; set; } // IsLockedOut
        public DateTime CreateDate { get; set; } // CreateDate
        public DateTime LastLoginDate { get; set; } // LastLoginDate
        public DateTime LastPasswordChangedDate { get; set; } // LastPasswordChangedDate
        public DateTime LastLockoutDate { get; set; } // LastLockoutDate
        public int FailedPasswordAttemptCount { get; set; } // FailedPasswordAttemptCount
        public DateTime FailedPasswordAttemptWindowStart { get; set; } // FailedPasswordAttemptWindowStart
        public int FailedPasswordAnswerAttemptCount { get; set; } // FailedPasswordAnswerAttemptCount
        public DateTime FailedPasswordAnswerAttemptWindowStart { get; set; } // FailedPasswordAnswerAttemptWindowStart
        public string Comment { get; set; } // Comment

        // Foreign keys
        public virtual AspnetApplications AspnetApplications { get; set; } // FK__aspnet_Me__Appli__60A75C0F
        public virtual AspnetUsers AspnetUsers { get; set; } // FK__aspnet_Me__UserI__619B8048

        public AspnetMembership()
        {
            PasswordFormat = 0;
        }
    }

    // aspnet_Paths
    public class AspnetPaths
    {
        public Guid ApplicationId { get; set; } // ApplicationId
        public Guid PathId { get; set; } // PathId (Primary key)
        public string Path { get; set; } // Path
        public string LoweredPath { get; set; } // LoweredPath

        // Reverse navigation
        public virtual AspnetPersonalizationAllUsers AspnetPersonalizationAllUsers { get; set; } // aspnet_PersonalizationAllUsers.FK__aspnet_Pe__PathI__17F790F9
        public virtual ICollection<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; } // aspnet_PersonalizationPerUser.FK__aspnet_Pe__PathI__1BC821DD

        // Foreign keys
        public virtual AspnetApplications AspnetApplications { get; set; } // FK__aspnet_Pa__Appli__123EB7A3

        public AspnetPaths()
        {
            PathId = System.Guid.NewGuid();
            AspnetPersonalizationPerUsers = new List<AspnetPersonalizationPerUser>();
        }
    }

    // aspnet_PersonalizationAllUsers
    public class AspnetPersonalizationAllUsers
    {
        public Guid PathId { get; set; } // PathId (Primary key)
        public byte[] PageSettings { get; set; } // PageSettings
        public DateTime LastUpdatedDate { get; set; } // LastUpdatedDate

        // Foreign keys
        public virtual AspnetPaths AspnetPaths { get; set; } // FK__aspnet_Pe__PathI__17F790F9
    }

    // aspnet_PersonalizationPerUser
    public class AspnetPersonalizationPerUser
    {
        public Guid Id { get; set; } // Id (Primary key)
        public Guid? PathId { get; set; } // PathId
        public Guid? UserId { get; set; } // UserId
        public byte[] PageSettings { get; set; } // PageSettings
        public DateTime LastUpdatedDate { get; set; } // LastUpdatedDate

        // Foreign keys
        public virtual AspnetPaths AspnetPaths { get; set; } // FK__aspnet_Pe__PathI__1BC821DD
        public virtual AspnetUsers AspnetUsers { get; set; } // FK__aspnet_Pe__UserI__1CBC4616

        public AspnetPersonalizationPerUser()
        {
            Id = System.Guid.NewGuid();
        }
    }

    // aspnet_Profile
    public class AspnetProfile
    {
        public Guid UserId { get; set; } // UserId (Primary key)
        public string PropertyNames { get; set; } // PropertyNames
        public string PropertyValuesString { get; set; } // PropertyValuesString
        public byte[] PropertyValuesBinary { get; set; } // PropertyValuesBinary
        public DateTime LastUpdatedDate { get; set; } // LastUpdatedDate

        // Foreign keys
        public virtual AspnetUsers AspnetUsers { get; set; } // FK__aspnet_Pr__UserI__75A278F5
    }

    // aspnet_Roles
    public class AspnetRoles
    {
        public Guid ApplicationId { get; set; } // ApplicationId
        public Guid RoleId { get; set; } // RoleId (Primary key)
        public string RoleName { get; set; } // RoleName
        public string LoweredRoleName { get; set; } // LoweredRoleName
        public string Description { get; set; } // Description

        // Reverse navigation
        public virtual ICollection<AspnetUsers> AspnetUsers { get; set; } // Many to many mapping

        // Foreign keys
        public virtual AspnetApplications AspnetApplications { get; set; } // FK__aspnet_Ro__Appli__7F2BE32F

        public AspnetRoles()
        {
            RoleId = System.Guid.NewGuid();
            AspnetUsers = new List<AspnetUsers>();
        }
    }

    // aspnet_SchemaVersions
    public class AspnetSchemaVersions
    {
        public string Feature { get; set; } // Feature (Primary key)
        public string CompatibleSchemaVersion { get; set; } // CompatibleSchemaVersion (Primary key)
        public bool IsCurrentVersion { get; set; } // IsCurrentVersion
    }

    // aspnet_Users
    public class AspnetUsers
    {
        public Guid ApplicationId { get; set; } // ApplicationId
        public Guid UserId { get; set; } // UserId (Primary key)
        public string UserName { get; set; } // UserName
        public string LoweredUserName { get; set; } // LoweredUserName
        public string MobileAlias { get; set; } // MobileAlias
        public bool IsAnonymous { get; set; } // IsAnonymous
        public DateTime LastActivityDate { get; set; } // LastActivityDate

        // Reverse navigation
        public virtual AspnetMembership AspnetMembership { get; set; } // aspnet_Membership.FK__aspnet_Me__UserI__619B8048
        public virtual AspnetProfile AspnetProfile { get; set; } // aspnet_Profile.FK__aspnet_Pr__UserI__75A278F5
        public virtual ICollection<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; } // aspnet_PersonalizationPerUser.FK__aspnet_Pe__UserI__1CBC4616
        public virtual ICollection<AspnetRoles> AspnetRoles { get; set; } // Many to many mapping

        // Foreign keys
        public virtual AspnetApplications AspnetApplications { get; set; } // FK__aspnet_Us__Appli__5070F446

        public AspnetUsers()
        {
            UserId = System.Guid.NewGuid();
            MobileAlias = "NULL";
            IsAnonymous = false;
            AspnetPersonalizationPerUsers = new List<AspnetPersonalizationPerUser>();
            AspnetRoles = new List<AspnetRoles>();
        }
    }

    // aspnet_WebEvent_Events
    public class AspnetWebEventEvents
    {
        public string EventId { get; set; } // EventId (Primary key)
        public DateTime EventTimeUtc { get; set; } // EventTimeUtc
        public DateTime EventTime { get; set; } // EventTime
        public string EventType { get; set; } // EventType
        public decimal EventSequence { get; set; } // EventSequence
        public decimal EventOccurrence { get; set; } // EventOccurrence
        public int EventCode { get; set; } // EventCode
        public int EventDetailCode { get; set; } // EventDetailCode
        public string Message { get; set; } // Message
        public string ApplicationPath { get; set; } // ApplicationPath
        public string ApplicationVirtualPath { get; set; } // ApplicationVirtualPath
        public string MachineName { get; set; } // MachineName
        public string RequestUrl { get; set; } // RequestUrl
        public string ExceptionType { get; set; } // ExceptionType
        public string Details { get; set; } // Details
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
        public string Name { get; set; } // Name

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

    // vw_aspnet_Applications
    public class VwAspnetApplications
    {
        public string ApplicationName { get; set; } // ApplicationName
        public string LoweredApplicationName { get; set; } // LoweredApplicationName
        public Guid ApplicationId { get; set; } // ApplicationId
        public string Description { get; set; } // Description
    }

    // vw_aspnet_MembershipUsers
    public class VwAspnetMembershipUsers
    {
        public Guid UserId { get; set; } // UserId
        public int PasswordFormat { get; set; } // PasswordFormat
        public string MobilePin { get; set; } // MobilePIN
        public string Email { get; set; } // Email
        public string LoweredEmail { get; set; } // LoweredEmail
        public string PasswordQuestion { get; set; } // PasswordQuestion
        public string PasswordAnswer { get; set; } // PasswordAnswer
        public bool IsApproved { get; set; } // IsApproved
        public bool IsLockedOut { get; set; } // IsLockedOut
        public DateTime CreateDate { get; set; } // CreateDate
        public DateTime LastLoginDate { get; set; } // LastLoginDate
        public DateTime LastPasswordChangedDate { get; set; } // LastPasswordChangedDate
        public DateTime LastLockoutDate { get; set; } // LastLockoutDate
        public int FailedPasswordAttemptCount { get; set; } // FailedPasswordAttemptCount
        public DateTime FailedPasswordAttemptWindowStart { get; set; } // FailedPasswordAttemptWindowStart
        public int FailedPasswordAnswerAttemptCount { get; set; } // FailedPasswordAnswerAttemptCount
        public DateTime FailedPasswordAnswerAttemptWindowStart { get; set; } // FailedPasswordAnswerAttemptWindowStart
        public string Comment { get; set; } // Comment
        public Guid ApplicationId { get; set; } // ApplicationId
        public string UserName { get; set; } // UserName
        public string MobileAlias { get; set; } // MobileAlias
        public bool IsAnonymous { get; set; } // IsAnonymous
        public DateTime LastActivityDate { get; set; } // LastActivityDate
    }

    // vw_aspnet_Profiles
    public class VwAspnetProfiles
    {
        public Guid UserId { get; set; } // UserId
        public DateTime LastUpdatedDate { get; set; } // LastUpdatedDate
        public int? DataSize { get; set; } // DataSize
    }

    // vw_aspnet_Roles
    public class VwAspnetRoles
    {
        public Guid ApplicationId { get; set; } // ApplicationId
        public Guid RoleId { get; set; } // RoleId
        public string RoleName { get; set; } // RoleName
        public string LoweredRoleName { get; set; } // LoweredRoleName
        public string Description { get; set; } // Description
    }

    // vw_aspnet_Users
    public class VwAspnetUsers
    {
        public Guid ApplicationId { get; set; } // ApplicationId
        public Guid UserId { get; set; } // UserId
        public string UserName { get; set; } // UserName
        public string LoweredUserName { get; set; } // LoweredUserName
        public string MobileAlias { get; set; } // MobileAlias
        public bool IsAnonymous { get; set; } // IsAnonymous
        public DateTime LastActivityDate { get; set; } // LastActivityDate
    }

    // vw_aspnet_UsersInRoles
    public class VwAspnetUsersInRoles
    {
        public Guid UserId { get; set; } // UserId
        public Guid RoleId { get; set; } // RoleId
    }

    // vw_aspnet_WebPartState_Paths
    public class VwAspnetWebPartStatePaths
    {
        public Guid ApplicationId { get; set; } // ApplicationId
        public Guid PathId { get; set; } // PathId
        public string Path { get; set; } // Path
        public string LoweredPath { get; set; } // LoweredPath
    }

    // vw_aspnet_WebPartState_Shared
    public class VwAspnetWebPartStateShared
    {
        public Guid PathId { get; set; } // PathId
        public int? DataSize { get; set; } // DataSize
        public DateTime LastUpdatedDate { get; set; } // LastUpdatedDate
    }

    // vw_aspnet_WebPartState_User
    public class VwAspnetWebPartStateUser
    {
        public Guid? PathId { get; set; } // PathId
        public Guid? UserId { get; set; } // UserId
        public int? DataSize { get; set; } // DataSize
        public DateTime LastUpdatedDate { get; set; } // LastUpdatedDate
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

    // aspnet_Applications
    internal class AspnetApplicationsConfiguration : EntityTypeConfiguration<AspnetApplications>
    {
        public AspnetApplicationsConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".aspnet_Applications");
            HasKey(x => x.ApplicationId);

            Property(x => x.ApplicationName).HasColumnName("ApplicationName").IsRequired().HasMaxLength(256);
            Property(x => x.LoweredApplicationName).HasColumnName("LoweredApplicationName").IsRequired().HasMaxLength(256);
            Property(x => x.ApplicationId).HasColumnName("ApplicationId").IsRequired();
            Property(x => x.Description).HasColumnName("Description").IsOptional().HasMaxLength(256);
        }
    }

    // aspnet_Membership
    internal class AspnetMembershipConfiguration : EntityTypeConfiguration<AspnetMembership>
    {
        public AspnetMembershipConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".aspnet_Membership");
            HasKey(x => x.UserId);

            Property(x => x.ApplicationId).HasColumnName("ApplicationId").IsRequired();
            Property(x => x.UserId).HasColumnName("UserId").IsRequired();
            Property(x => x.Password).HasColumnName("Password").IsRequired().HasMaxLength(128);
            Property(x => x.PasswordFormat).HasColumnName("PasswordFormat").IsRequired();
            Property(x => x.PasswordSalt).HasColumnName("PasswordSalt").IsRequired().HasMaxLength(128);
            Property(x => x.MobilePin).HasColumnName("MobilePIN").IsOptional().HasMaxLength(16);
            Property(x => x.Email).HasColumnName("Email").IsOptional().HasMaxLength(256);
            Property(x => x.LoweredEmail).HasColumnName("LoweredEmail").IsOptional().HasMaxLength(256);
            Property(x => x.PasswordQuestion).HasColumnName("PasswordQuestion").IsOptional().HasMaxLength(256);
            Property(x => x.PasswordAnswer).HasColumnName("PasswordAnswer").IsOptional().HasMaxLength(128);
            Property(x => x.IsApproved).HasColumnName("IsApproved").IsRequired();
            Property(x => x.IsLockedOut).HasColumnName("IsLockedOut").IsRequired();
            Property(x => x.CreateDate).HasColumnName("CreateDate").IsRequired();
            Property(x => x.LastLoginDate).HasColumnName("LastLoginDate").IsRequired();
            Property(x => x.LastPasswordChangedDate).HasColumnName("LastPasswordChangedDate").IsRequired();
            Property(x => x.LastLockoutDate).HasColumnName("LastLockoutDate").IsRequired();
            Property(x => x.FailedPasswordAttemptCount).HasColumnName("FailedPasswordAttemptCount").IsRequired();
            Property(x => x.FailedPasswordAttemptWindowStart).HasColumnName("FailedPasswordAttemptWindowStart").IsRequired();
            Property(x => x.FailedPasswordAnswerAttemptCount).HasColumnName("FailedPasswordAnswerAttemptCount").IsRequired();
            Property(x => x.FailedPasswordAnswerAttemptWindowStart).HasColumnName("FailedPasswordAnswerAttemptWindowStart").IsRequired();
            Property(x => x.Comment).HasColumnName("Comment").IsOptional().HasMaxLength(1073741823);

            // Foreign keys
            HasRequired(a => a.AspnetApplications).WithMany(b => b.AspnetMemberships).HasForeignKey(c => c.ApplicationId); // FK__aspnet_Me__Appli__60A75C0F
            HasRequired(a => a.AspnetUsers).WithOptional(b => b.AspnetMembership); // FK__aspnet_Me__UserI__619B8048
        }
    }

    // aspnet_Paths
    internal class AspnetPathsConfiguration : EntityTypeConfiguration<AspnetPaths>
    {
        public AspnetPathsConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".aspnet_Paths");
            HasKey(x => x.PathId);

            Property(x => x.ApplicationId).HasColumnName("ApplicationId").IsRequired();
            Property(x => x.PathId).HasColumnName("PathId").IsRequired();
            Property(x => x.Path).HasColumnName("Path").IsRequired().HasMaxLength(256);
            Property(x => x.LoweredPath).HasColumnName("LoweredPath").IsRequired().HasMaxLength(256);

            // Foreign keys
            HasRequired(a => a.AspnetApplications).WithMany(b => b.AspnetPaths).HasForeignKey(c => c.ApplicationId); // FK__aspnet_Pa__Appli__123EB7A3
        }
    }

    // aspnet_PersonalizationAllUsers
    internal class AspnetPersonalizationAllUsersConfiguration : EntityTypeConfiguration<AspnetPersonalizationAllUsers>
    {
        public AspnetPersonalizationAllUsersConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".aspnet_PersonalizationAllUsers");
            HasKey(x => x.PathId);

            Property(x => x.PathId).HasColumnName("PathId").IsRequired();
            Property(x => x.PageSettings).HasColumnName("PageSettings").IsRequired().HasMaxLength(2147483647);
            Property(x => x.LastUpdatedDate).HasColumnName("LastUpdatedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.AspnetPaths).WithOptional(b => b.AspnetPersonalizationAllUsers); // FK__aspnet_Pe__PathI__17F790F9
        }
    }

    // aspnet_PersonalizationPerUser
    internal class AspnetPersonalizationPerUserConfiguration : EntityTypeConfiguration<AspnetPersonalizationPerUser>
    {
        public AspnetPersonalizationPerUserConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".aspnet_PersonalizationPerUser");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired();
            Property(x => x.PathId).HasColumnName("PathId").IsOptional();
            Property(x => x.UserId).HasColumnName("UserId").IsOptional();
            Property(x => x.PageSettings).HasColumnName("PageSettings").IsRequired().HasMaxLength(2147483647);
            Property(x => x.LastUpdatedDate).HasColumnName("LastUpdatedDate").IsRequired();

            // Foreign keys
            HasOptional(a => a.AspnetPaths).WithMany(b => b.AspnetPersonalizationPerUsers).HasForeignKey(c => c.PathId); // FK__aspnet_Pe__PathI__1BC821DD
            HasOptional(a => a.AspnetUsers).WithMany(b => b.AspnetPersonalizationPerUsers).HasForeignKey(c => c.UserId); // FK__aspnet_Pe__UserI__1CBC4616
        }
    }

    // aspnet_Profile
    internal class AspnetProfileConfiguration : EntityTypeConfiguration<AspnetProfile>
    {
        public AspnetProfileConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".aspnet_Profile");
            HasKey(x => x.UserId);

            Property(x => x.UserId).HasColumnName("UserId").IsRequired();
            Property(x => x.PropertyNames).HasColumnName("PropertyNames").IsRequired().HasMaxLength(1073741823);
            Property(x => x.PropertyValuesString).HasColumnName("PropertyValuesString").IsRequired().HasMaxLength(1073741823);
            Property(x => x.PropertyValuesBinary).HasColumnName("PropertyValuesBinary").IsRequired().HasMaxLength(2147483647);
            Property(x => x.LastUpdatedDate).HasColumnName("LastUpdatedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.AspnetUsers).WithOptional(b => b.AspnetProfile); // FK__aspnet_Pr__UserI__75A278F5
        }
    }

    // aspnet_Roles
    internal class AspnetRolesConfiguration : EntityTypeConfiguration<AspnetRoles>
    {
        public AspnetRolesConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".aspnet_Roles");
            HasKey(x => x.RoleId);

            Property(x => x.ApplicationId).HasColumnName("ApplicationId").IsRequired();
            Property(x => x.RoleId).HasColumnName("RoleId").IsRequired();
            Property(x => x.RoleName).HasColumnName("RoleName").IsRequired().HasMaxLength(256);
            Property(x => x.LoweredRoleName).HasColumnName("LoweredRoleName").IsRequired().HasMaxLength(256);
            Property(x => x.Description).HasColumnName("Description").IsOptional().HasMaxLength(256);

            // Foreign keys
            HasRequired(a => a.AspnetApplications).WithMany(b => b.AspnetRoles).HasForeignKey(c => c.ApplicationId); // FK__aspnet_Ro__Appli__7F2BE32F
            HasMany(t => t.AspnetUsers).WithMany(t => t.AspnetRoles).Map(m => 
            {
                m.ToTable("aspnet_UsersInRoles", schema);
                m.MapLeftKey("RoleId");
                m.MapRightKey("UserId");
            });
        }
    }

    // aspnet_SchemaVersions
    internal class AspnetSchemaVersionsConfiguration : EntityTypeConfiguration<AspnetSchemaVersions>
    {
        public AspnetSchemaVersionsConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".aspnet_SchemaVersions");
            HasKey(x => new { x.Feature, x.CompatibleSchemaVersion });

            Property(x => x.Feature).HasColumnName("Feature").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CompatibleSchemaVersion).HasColumnName("CompatibleSchemaVersion").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.IsCurrentVersion).HasColumnName("IsCurrentVersion").IsRequired();
        }
    }

    // aspnet_Users
    internal class AspnetUsersConfiguration : EntityTypeConfiguration<AspnetUsers>
    {
        public AspnetUsersConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".aspnet_Users");
            HasKey(x => x.UserId);

            Property(x => x.ApplicationId).HasColumnName("ApplicationId").IsRequired();
            Property(x => x.UserId).HasColumnName("UserId").IsRequired();
            Property(x => x.UserName).HasColumnName("UserName").IsRequired().HasMaxLength(256);
            Property(x => x.LoweredUserName).HasColumnName("LoweredUserName").IsRequired().HasMaxLength(256);
            Property(x => x.MobileAlias).HasColumnName("MobileAlias").IsOptional().HasMaxLength(16);
            Property(x => x.IsAnonymous).HasColumnName("IsAnonymous").IsRequired();
            Property(x => x.LastActivityDate).HasColumnName("LastActivityDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.AspnetApplications).WithMany(b => b.AspnetUsers).HasForeignKey(c => c.ApplicationId); // FK__aspnet_Us__Appli__5070F446
        }
    }

    // aspnet_WebEvent_Events
    internal class AspnetWebEventEventsConfiguration : EntityTypeConfiguration<AspnetWebEventEvents>
    {
        public AspnetWebEventEventsConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".aspnet_WebEvent_Events");
            HasKey(x => x.EventId);

            Property(x => x.EventId).HasColumnName("EventId").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(32).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.EventTimeUtc).HasColumnName("EventTimeUtc").IsRequired();
            Property(x => x.EventTime).HasColumnName("EventTime").IsRequired();
            Property(x => x.EventType).HasColumnName("EventType").IsRequired().HasMaxLength(256);
            Property(x => x.EventSequence).HasColumnName("EventSequence").IsRequired();
            Property(x => x.EventOccurrence).HasColumnName("EventOccurrence").IsRequired();
            Property(x => x.EventCode).HasColumnName("EventCode").IsRequired();
            Property(x => x.EventDetailCode).HasColumnName("EventDetailCode").IsRequired();
            Property(x => x.Message).HasColumnName("Message").IsOptional().HasMaxLength(1024);
            Property(x => x.ApplicationPath).HasColumnName("ApplicationPath").IsOptional().HasMaxLength(256);
            Property(x => x.ApplicationVirtualPath).HasColumnName("ApplicationVirtualPath").IsOptional().HasMaxLength(256);
            Property(x => x.MachineName).HasColumnName("MachineName").IsRequired().HasMaxLength(256);
            Property(x => x.RequestUrl).HasColumnName("RequestUrl").IsOptional().HasMaxLength(1024);
            Property(x => x.ExceptionType).HasColumnName("ExceptionType").IsOptional().HasMaxLength(256);
            Property(x => x.Details).HasColumnName("Details").IsOptional().HasMaxLength(1073741823);
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

    // vw_aspnet_Applications
    internal class VwAspnetApplicationsConfiguration : EntityTypeConfiguration<VwAspnetApplications>
    {
        public VwAspnetApplicationsConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".vw_aspnet_Applications");
            HasKey(x => new { x.ApplicationName, x.LoweredApplicationName, x.ApplicationId });

            Property(x => x.ApplicationName).HasColumnName("ApplicationName").IsRequired().HasMaxLength(256);
            Property(x => x.LoweredApplicationName).HasColumnName("LoweredApplicationName").IsRequired().HasMaxLength(256);
            Property(x => x.ApplicationId).HasColumnName("ApplicationId").IsRequired();
            Property(x => x.Description).HasColumnName("Description").IsOptional().HasMaxLength(256);
        }
    }

    // vw_aspnet_MembershipUsers
    internal class VwAspnetMembershipUsersConfiguration : EntityTypeConfiguration<VwAspnetMembershipUsers>
    {
        public VwAspnetMembershipUsersConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".vw_aspnet_MembershipUsers");
            HasKey(x => new { x.UserId, x.PasswordFormat, x.IsApproved, x.IsLockedOut, x.CreateDate, x.LastLoginDate, x.LastPasswordChangedDate, x.LastLockoutDate, x.FailedPasswordAttemptCount, x.FailedPasswordAttemptWindowStart, x.FailedPasswordAnswerAttemptCount, x.FailedPasswordAnswerAttemptWindowStart, x.ApplicationId, x.UserName, x.IsAnonymous, x.LastActivityDate });

            Property(x => x.UserId).HasColumnName("UserId").IsRequired();
            Property(x => x.PasswordFormat).HasColumnName("PasswordFormat").IsRequired();
            Property(x => x.MobilePin).HasColumnName("MobilePIN").IsOptional().HasMaxLength(16);
            Property(x => x.Email).HasColumnName("Email").IsOptional().HasMaxLength(256);
            Property(x => x.LoweredEmail).HasColumnName("LoweredEmail").IsOptional().HasMaxLength(256);
            Property(x => x.PasswordQuestion).HasColumnName("PasswordQuestion").IsOptional().HasMaxLength(256);
            Property(x => x.PasswordAnswer).HasColumnName("PasswordAnswer").IsOptional().HasMaxLength(128);
            Property(x => x.IsApproved).HasColumnName("IsApproved").IsRequired();
            Property(x => x.IsLockedOut).HasColumnName("IsLockedOut").IsRequired();
            Property(x => x.CreateDate).HasColumnName("CreateDate").IsRequired();
            Property(x => x.LastLoginDate).HasColumnName("LastLoginDate").IsRequired();
            Property(x => x.LastPasswordChangedDate).HasColumnName("LastPasswordChangedDate").IsRequired();
            Property(x => x.LastLockoutDate).HasColumnName("LastLockoutDate").IsRequired();
            Property(x => x.FailedPasswordAttemptCount).HasColumnName("FailedPasswordAttemptCount").IsRequired();
            Property(x => x.FailedPasswordAttemptWindowStart).HasColumnName("FailedPasswordAttemptWindowStart").IsRequired();
            Property(x => x.FailedPasswordAnswerAttemptCount).HasColumnName("FailedPasswordAnswerAttemptCount").IsRequired();
            Property(x => x.FailedPasswordAnswerAttemptWindowStart).HasColumnName("FailedPasswordAnswerAttemptWindowStart").IsRequired();
            Property(x => x.Comment).HasColumnName("Comment").IsOptional().HasMaxLength(1073741823);
            Property(x => x.ApplicationId).HasColumnName("ApplicationId").IsRequired();
            Property(x => x.UserName).HasColumnName("UserName").IsRequired().HasMaxLength(256);
            Property(x => x.MobileAlias).HasColumnName("MobileAlias").IsOptional().HasMaxLength(16);
            Property(x => x.IsAnonymous).HasColumnName("IsAnonymous").IsRequired();
            Property(x => x.LastActivityDate).HasColumnName("LastActivityDate").IsRequired();
        }
    }

    // vw_aspnet_Profiles
    internal class VwAspnetProfilesConfiguration : EntityTypeConfiguration<VwAspnetProfiles>
    {
        public VwAspnetProfilesConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".vw_aspnet_Profiles");
            HasKey(x => new { x.UserId, x.LastUpdatedDate });

            Property(x => x.UserId).HasColumnName("UserId").IsRequired();
            Property(x => x.LastUpdatedDate).HasColumnName("LastUpdatedDate").IsRequired();
            Property(x => x.DataSize).HasColumnName("DataSize").IsOptional();
        }
    }

    // vw_aspnet_Roles
    internal class VwAspnetRolesConfiguration : EntityTypeConfiguration<VwAspnetRoles>
    {
        public VwAspnetRolesConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".vw_aspnet_Roles");
            HasKey(x => new { x.ApplicationId, x.RoleId, x.RoleName, x.LoweredRoleName });

            Property(x => x.ApplicationId).HasColumnName("ApplicationId").IsRequired();
            Property(x => x.RoleId).HasColumnName("RoleId").IsRequired();
            Property(x => x.RoleName).HasColumnName("RoleName").IsRequired().HasMaxLength(256);
            Property(x => x.LoweredRoleName).HasColumnName("LoweredRoleName").IsRequired().HasMaxLength(256);
            Property(x => x.Description).HasColumnName("Description").IsOptional().HasMaxLength(256);
        }
    }

    // vw_aspnet_Users
    internal class VwAspnetUsersConfiguration : EntityTypeConfiguration<VwAspnetUsers>
    {
        public VwAspnetUsersConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".vw_aspnet_Users");
            HasKey(x => new { x.ApplicationId, x.UserId, x.UserName, x.LoweredUserName, x.IsAnonymous, x.LastActivityDate });

            Property(x => x.ApplicationId).HasColumnName("ApplicationId").IsRequired();
            Property(x => x.UserId).HasColumnName("UserId").IsRequired();
            Property(x => x.UserName).HasColumnName("UserName").IsRequired().HasMaxLength(256);
            Property(x => x.LoweredUserName).HasColumnName("LoweredUserName").IsRequired().HasMaxLength(256);
            Property(x => x.MobileAlias).HasColumnName("MobileAlias").IsOptional().HasMaxLength(16);
            Property(x => x.IsAnonymous).HasColumnName("IsAnonymous").IsRequired();
            Property(x => x.LastActivityDate).HasColumnName("LastActivityDate").IsRequired();
        }
    }

    // vw_aspnet_UsersInRoles
    internal class VwAspnetUsersInRolesConfiguration : EntityTypeConfiguration<VwAspnetUsersInRoles>
    {
        public VwAspnetUsersInRolesConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".vw_aspnet_UsersInRoles");
            HasKey(x => new { x.UserId, x.RoleId });

            Property(x => x.UserId).HasColumnName("UserId").IsRequired();
            Property(x => x.RoleId).HasColumnName("RoleId").IsRequired();
        }
    }

    // vw_aspnet_WebPartState_Paths
    internal class VwAspnetWebPartStatePathsConfiguration : EntityTypeConfiguration<VwAspnetWebPartStatePaths>
    {
        public VwAspnetWebPartStatePathsConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".vw_aspnet_WebPartState_Paths");
            HasKey(x => new { x.ApplicationId, x.PathId, x.Path, x.LoweredPath });

            Property(x => x.ApplicationId).HasColumnName("ApplicationId").IsRequired();
            Property(x => x.PathId).HasColumnName("PathId").IsRequired();
            Property(x => x.Path).HasColumnName("Path").IsRequired().HasMaxLength(256);
            Property(x => x.LoweredPath).HasColumnName("LoweredPath").IsRequired().HasMaxLength(256);
        }
    }

    // vw_aspnet_WebPartState_Shared
    internal class VwAspnetWebPartStateSharedConfiguration : EntityTypeConfiguration<VwAspnetWebPartStateShared>
    {
        public VwAspnetWebPartStateSharedConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".vw_aspnet_WebPartState_Shared");
            HasKey(x => new { x.PathId, x.LastUpdatedDate });

            Property(x => x.PathId).HasColumnName("PathId").IsRequired();
            Property(x => x.DataSize).HasColumnName("DataSize").IsOptional();
            Property(x => x.LastUpdatedDate).HasColumnName("LastUpdatedDate").IsRequired();
        }
    }

    // vw_aspnet_WebPartState_User
    internal class VwAspnetWebPartStateUserConfiguration : EntityTypeConfiguration<VwAspnetWebPartStateUser>
    {
        public VwAspnetWebPartStateUserConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".vw_aspnet_WebPartState_User");
            HasKey(x => x.LastUpdatedDate);

            Property(x => x.PathId).HasColumnName("PathId").IsOptional();
            Property(x => x.UserId).HasColumnName("UserId").IsOptional();
            Property(x => x.DataSize).HasColumnName("DataSize").IsOptional();
            Property(x => x.LastUpdatedDate).HasColumnName("LastUpdatedDate").IsRequired();
        }
    }


    // ************************************************************************
    // Stored procedure return models

    public class AspnetAnyDataInTablesReturnModel
    {
        public String Column1 { get; set; }
    }

    public class AspnetMembershipGetPasswordReturnModel
    {
        public String Column1 { get; set; }
        public Int32? Column2 { get; set; }
    }

    public class AspnetMembershipGetPasswordWithFormatReturnModel
    {
        public String Column1 { get; set; }
        public Int32? Column2 { get; set; }
        public String Column3 { get; set; }
        public Int32? Column4 { get; set; }
        public Int32? Column5 { get; set; }
        public Boolean? Column6 { get; set; }
        public DateTime? Column7 { get; set; }
        public DateTime? Column8 { get; set; }
    }

    public class AspnetMembershipGetUserByEmailReturnModel
    {
        public String UserName { get; set; }
    }

    public class AspnetMembershipGetUserByNameReturnModel
    {
        public String Email { get; set; }
        public String PasswordQuestion { get; set; }
        public String Comment { get; set; }
        public Boolean IsApproved { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime LastActivityDate { get; set; }
        public DateTime LastPasswordChangedDate { get; set; }
        public Guid UserId { get; set; }
        public Boolean IsLockedOut { get; set; }
        public DateTime LastLockoutDate { get; set; }
    }

    public class AspnetMembershipGetUserByUserIdReturnModel
    {
        public String Email { get; set; }
        public String PasswordQuestion { get; set; }
        public String Comment { get; set; }
        public Boolean IsApproved { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime LastActivityDate { get; set; }
        public DateTime LastPasswordChangedDate { get; set; }
        public String UserName { get; set; }
        public Boolean IsLockedOut { get; set; }
        public DateTime LastLockoutDate { get; set; }
    }

    public class AspnetPersonalizationAllUsersGetPageSettingsReturnModel
    {
        public Byte[] PageSettings { get; set; }
    }

    public class AspnetPersonalizationPerUserGetPageSettingsReturnModel
    {
        public Byte[] PageSettings { get; set; }
    }

    public class AspnetProfileDeleteInactiveProfilesReturnModel
    {
        public Int32? Column1 { get; set; }
    }

    public class AspnetProfileDeleteProfilesReturnModel
    {
        public Int32? Column1 { get; set; }
    }

    public class AspnetProfileGetNumberOfInactiveProfilesReturnModel
    {
        public Int32? Column1 { get; set; }
    }

    public class AspnetProfileGetPropertiesReturnModel
    {
        public String PropertyNames { get; set; }
        public String PropertyValuesString { get; set; }
        public Byte[] PropertyValuesBinary { get; set; }
    }

    public class AspnetRolesGetAllRolesReturnModel
    {
        public String RoleName { get; set; }
    }

    public class AspnetUsersInRolesAddUsersToRolesReturnModel
    {
        public String Name { get; set; }
    }

    public class AspnetUsersInRolesFindUsersInRoleReturnModel
    {
        public String UserName { get; set; }
    }

    public class AspnetUsersInRolesGetRolesForUserReturnModel
    {
        public String RoleName { get; set; }
    }

    public class AspnetUsersInRolesGetUsersInRolesReturnModel
    {
        public String UserName { get; set; }
    }

    public class AspnetUsersInRolesRemoveUsersFromRolesReturnModel
    {
        public String Column1 { get; set; }
        public String Name { get; set; }
    }

}
