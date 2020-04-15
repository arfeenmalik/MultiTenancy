namespace MultiTenancy.Administration {
    export interface TenantsRow {
        Tenantid?: number;
        Tenantname?: string;
    }

    export namespace TenantsRow {
        export const idProperty = 'Tenantid';
        export const nameProperty = 'Tenantname';
        export const localTextPrefix = 'Administration.Tenants';
        export const lookupKey = 'TenantsRow';

        export function getLookup(): Q.Lookup<TenantsRow> {
            return Q.getLookup<TenantsRow>('TenantsRow');
        }
        export const deletePermission = 'Administration:Tenants';
        export const insertPermission = 'Administration:Tenants';
        export const readPermission = 'Administration:Tenants';
        export const updatePermission = 'Administration:Tenants';

        export declare const enum Fields {
            Tenantid = "Tenantid",
            Tenantname = "Tenantname"
        }
    }
}
