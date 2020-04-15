
namespace MultiTenancy.Administration.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using MultiTenancy.Administration;

    [ConnectionKey("Default"), Module("Administration"), TableName("[MULTITENANT].[TENANTS]")]
    [DisplayName("Tenants"), InstanceName("Tenants")]
    [ReadPermission(PermissionKeys.Tenants)]
    [ModifyPermission(PermissionKeys.Tenants)]
    //[ReadPermission(PermissionKeys.TenantsRead)]
    //[InsertPermission(PermissionKeys.TenantsInsert)]
    //[UpdatePermission(PermissionKeys.TenantsUpdate)]
    //[DeletePermission(PermissionKeys.TenantsDelete)]
	[LookupScript(nameof(TenantsRow))]
    public sealed class TenantsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Tenantid"), Column("TENANTID"), Size(10), Identity]
        public Int32? Tenantid
        {
            get { return Fields.Tenantid[this]; }
            set { Fields.Tenantid[this] = value; }
        }

        [DisplayName("Tenantname"), Column("TENANTNAME"), Size(100), NotNull, QuickSearch]
        public String Tenantname
        {
            get { return Fields.Tenantname[this]; }
            set { Fields.Tenantname[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Tenantid; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Tenantname; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TenantsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Tenantid;
            public StringField Tenantname;
        }
    }
}
