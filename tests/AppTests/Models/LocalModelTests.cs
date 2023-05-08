using App.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppTests.Models
{
    [TestClass()]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Provides clearer test names")]
    public class LocalModelTests
    {
        private const string FirstName = nameof(FirstName);
        private const string LastName = nameof(LastName);

        [TestMethod()]
        public void LocalModel_Default_Ctor()
        {
            var model = new LocalModel();
            model.Should().NotBeNull();
            model.DisplayName.Should().BeNull();
            model.GivenName.Should().BeNull();
            model.Surname.Should().BeNull();
        }
    }
}