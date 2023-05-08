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

        [TestMethod()]
        public void LocalModel_Full_Ctor()
        {
            var model = new LocalModel("Custom Name", FirstName, LastName);
            model.Should().NotBeNull();
            model.DisplayName.Should().NotBeNull();
            model.GivenName.Should().NotBeNull();
            model.Surname.Should().NotBeNull();
            model.DisplayName.Should().Be("Custom Name");
            model.GivenName.Should().Be(FirstName);
            model.Surname.Should().Be(LastName);
        }

        [TestMethod()]
        [Ignore]
        public void LocalModel_Full_Ctor_Should_Fail()
        {
            var model = new LocalModel("Custom Name", FirstName, LastName);
            model.Should().NotBeNull();
            model.DisplayName.Should().NotBeNull();
            model.GivenName.Should().NotBeNull();
            model.Surname.Should().NotBeNull();
            model.DisplayName.Should().Be($"{model.Surname}, {model.GivenName}");
            model.GivenName.Should().Be(FirstName);
            model.Surname.Should().Be(LastName);
        }

        [TestMethod()]
        public void LocalModel_Partial_Ctor()
        {
            var model = new LocalModel(FirstName, LastName);
            model.Should().NotBeNull();
            model.DisplayName.Should().NotBeNull();
            model.GivenName.Should().NotBeNull();
            model.Surname.Should().NotBeNull();
            model.DisplayName.Should().Be($"{model.Surname}, {model.GivenName}");
            model.GivenName.Should().Be(FirstName);
            model.Surname.Should().Be(LastName);
        }
    }
}