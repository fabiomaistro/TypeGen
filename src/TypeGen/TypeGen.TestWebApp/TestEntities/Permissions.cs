using System.Collections.Generic;
using TypeGen.Core.TypeAnnotations;

namespace TypeGen.TestWebApp.TestEntities
{
    [ExportTsClassAsEnum]
    public static class Permissions
    {
        //Attribute definitions
        public const string ReadAttributeDefinition = "RATTRDEF";
        public const string EditAttributeDefinition = "EATTRDEF";
}
