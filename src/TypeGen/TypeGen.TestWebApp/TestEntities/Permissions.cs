using System.Collections.Generic;
using TypeGen.Core.TypeAnnotations;

namespace TypeGen.TestWebApp.TestEntities
{
    [ExportTsClassAsEnum]
    public static class Permissions
    {
        // TODO: Move to using exactly 8 characters long.

        //Attribute definitions
        public const string ReadAttributeDefinition = "RATTRDEF";
        public const string EditAttributeDefinition = "EATTRDEF";

        //Client
        public const string ReadCustomer = "RCUSTOMER";
        public const string EditCustomer = "ECUSTOMER";

        //Product Custom Pricing
        public const string ReadCustomerProductPricing = "RPRCUSPR";
        public const string EditCustomerProductPricing = "EPRCUSPR";

        //Customer Weekly breakdown rates
        public const string ReadCustomerWeeklyBreakdownRates = "RCWBRATE";
        public const string EditCustomerWeeklyBreakdownRates = "ECWBRATE";

        // Shared Entity Types: image and document are not directly edited, hence only read permission.
        public const string ReadDocument = "RDDOCM";
        public const string ReadImage = "RDIMGE";

        // Enquiries
        public const string ReadEnquiry = "RENQUIRY";
        public const string EditEnquiry = "EENQUIRY";

        //Knowledge Base
        public const string ReadKnowledgeBase = "RKNOWBAS";
        public const string EditKnowledgeBase = "EKNOWBAS";

        //Main Activity
        public const string EditMainActivity = "EMAINACTIVITY";
        public const string ReadMainActivity = "RMAINACTIVITY";

        //Maintenance
        public const string ReadMaintenance = "RMAINTENANCE";
        public const string EditMaintenance = "EMAINTENANCE";

        //Product
        public const string ReadProduct = "RPRODUCT";
        public const string EditProduct = "EPRODUCT";

        //Product Category
        public const string ReadProductCategory = "RPRODCAT";
        public const string EditProductCategory = "EPRODCAT";

        //Product Group
        public const string ReadProductGroup = "RPRODGRP";
        public const string EditProductGroup = "EPRODGRP";

        //Sourcing
        public const string ReadSourcing = "RSOURCIN";
        public const string EditSourcing = "ESOURCIN";

        //Subcategory
        public const string ReadProductSubcategory = "RPSUBCAT";
        public const string EditProductSubcategory = "EPSUBCAT";

        //Search permissions
        public const string RunSearch = "RSEARCH";

        //Sourcing
        public const string QueryForSuppliers = "SRCHSUPP";

        //Supplier
        public const string ReadSupplier = "RSUPPL";
        public const string EditSupplier = "ESUPPL";

        //Supplier Custom Pricing
        public const string ReadSupplierProductPricing = "RPRSUPPR";
        public const string EditSupplierProductPricing = "EPRSUPPR";

        //Supplier Weekly breakdown rates
        public const string ReadSupplierWeeklyBreakdownRates = "RSWBRATE";
        public const string EditSupplierWeeklyBreakdownRates = "ESWBRATE";

        // Unit definitions
        public const string ReadUnitDefinition = "RUNITDEF";
        public const string EditUnitDefinition = "EUNITDEF";

        //User
        public const string ReadUser = "RUSER";
        public const string EditUser = "EUSER";

        //Role
        public const string ReadUserRole = "RROLE";
        public const string EditUserRole = "EROLE";

        [TsIgnore]
        public static IList<string> PermissionsList => new List<string>()
        {
            ReadAttributeDefinition,
            EditAttributeDefinition,
            ReadKnowledgeBase,
            EditKnowledgeBase,
            ReadUnitDefinition,
            EditUnitDefinition,
            ReadProductCategory,
            EditProductCategory,
            ReadProductSubcategory,
            EditProductSubcategory,
            ReadProductGroup,
            EditProductGroup,
            ReadProduct,
            EditProduct,
            ReadCustomer,
            EditCustomer,
            ReadCustomerProductPricing,
            EditCustomerProductPricing,
            ReadCustomerWeeklyBreakdownRates,
            EditCustomerWeeklyBreakdownRates,
            RunSearch,
            QueryForSuppliers,
            ReadSupplier,
            EditSupplier,
            ReadSourcing,
            EditSourcing,
            ReadSupplierProductPricing,
            EditSupplierProductPricing,
            ReadSupplierWeeklyBreakdownRates,
            EditSupplierWeeklyBreakdownRates,
            ReadUser,
            EditUser,
            ReadUserRole,
            EditUserRole,
            ReadImage,
            ReadDocument,
            ReadEnquiry,
            EditEnquiry,
            ReadMaintenance,
            EditMaintenance,
            EditMainActivity
        };
    }
}