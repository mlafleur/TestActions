using App.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppTests.Models
{
    [TestClass()]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Provides clearer test names")]
    public class LocalModelTests
    {
        private const string DisplayName = nameof(DisplayName);
        private const string FirstName = nameof(FirstName);
        private const string LastName = nameof(LastName);

        [TestMethod()]
        public void LocalModel_Ctor_Should_Thow_On_Null_Params()
        {
            Action action = () => { _ = new LocalModel(null!, FirstName, LastName); };
            action.Should().Throw<ArgumentNullException>();

            action = () => { _ = new LocalModel(DisplayName, null!, LastName); };
            action.Should().Throw<ArgumentNullException>();

            action = () => { _ = new LocalModel(DisplayName, FirstName, null!); };
            action.Should().Throw<ArgumentNullException>();

            action = () => { _ = new LocalModel(null!, LastName); };
            action.Should().Throw<ArgumentNullException>();

            action = () => { _ = new LocalModel(FirstName, null!); };
            action.Should().Throw<ArgumentNullException>();
        }

        [TestMethod()]
        public void LocalModel_Default_Ctor()
        {
            var model = new LocalModel();
            model.Should().NotBeNull();
            model.DisplayName.Should().BeNull();
            model.GivenName.Should().BeNull();
            model.Surname.Should().BeNull();
            model.Id.Should().NotBeEmpty();
        }

        [TestMethod()]
        public void LocalModel_Full_Ctor()
        {
            var model = new LocalModel(DisplayName, FirstName, LastName);
            model.Should().NotBeNull();
            model.DisplayName.Should().NotBeNull();
            model.GivenName.Should().NotBeNull();
            model.Surname.Should().NotBeNull();
            model.DisplayName.Should().Be(DisplayName);
            model.GivenName.Should().Be(FirstName);
            model.Surname.Should().Be(LastName);
            model.Id.Should().NotBeEmpty();
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
            model.Id.Should().NotBeEmpty();
        }
    }
}