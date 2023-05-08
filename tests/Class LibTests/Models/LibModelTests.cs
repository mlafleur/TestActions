using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibTests.Models
{
    [TestClass()]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Provides clearer test names")]
    public class LibModelTests
    {
        private const string Description = nameof(Description);
        private const string PartNumber = nameof(PartNumber);
    }
}