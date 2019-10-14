using System;

namespace TypeGen.Core.TypeAnnotations
{
    /// <summary>
    /// Identifies an enum that a TypeScript file should be generated for
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ExportTsClassAsEnumAttribute : ExportAttribute
    {
    }
}
