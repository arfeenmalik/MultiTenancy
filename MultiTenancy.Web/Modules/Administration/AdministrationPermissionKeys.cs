
using Serenity.Extensibility;
using System.ComponentModel;

namespace MultiTenancy.Administration
{
    [NestedPermissionKeys]
    [DisplayName("Administration")]
    public class PermissionKeys
    {
            [Description("Read")]
            public const string TenantsRead = "Administration:Tenants:TenantsRead";
            [Description("Insert")]
            public const string TenantsInsert = "Administration:Tenants:TenantsInsert";
            [Description("Update")]
            public const string TenantsUpdate = "Administration:Tenants:TenantsUpdate";
            [Description("Delete")]
            public const string TenantsDelete = "Administration:Tenants:TenantsDelete";

        [Description("User, Role Management and Permissions")]
        public const string Security = "Administration:Security";

        [Description("Languages and Translations")]
        public const string Translation = "Administration:Translation";


        public const string Tenants = "Administration:Tenants";
    }
}