using ClassLib.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibTests.Models
{
    [TestClass()]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Provides clearer test names")]
    public class LibModelTests
    {
        private const string Description = nameof(Description);
        private const string DisplayName = nameof(DisplayName);
        private const string PartNumber = nameof(PartNumber);

        [TestMethod()]
        public void LibModel_Ctor_Should_Thow_On_Null_Params()
        {
            Action action = () => { _ = new LibModel(null!, PartNumber, Description); };
            action.Should().Throw<ArgumentNullException>();

            action = () => { _ = new LibModel(DisplayName, null!, Description); };
            action.Should().Throw<ArgumentNullException>();

            action = () => { _ = new LibModel(DisplayName, PartNumber, null!); };
            action.Should().Throw<ArgumentNullException>();

            action = () => { _ = new LibModel(null!, Description); };
            action.Should().Throw<ArgumentNullException>();

            action = () => { _ = new LibModel(PartNumber, null!); };
            action.Should().Throw<ArgumentNullException>();
        }

        [TestMethod()]
        public void LibModel_Default_Ctor()
        {
            var model = new LibModel();
            model.Should().NotBeNull();
            model.DisplayName.Should().BeNull();
            model.Description.Should().BeNull();
            model.PartNumber.Should().BeNull();
            model.Id.Should().NotBeEmpty();
        }

        [TestMethod()]
        public void LibModel_Full_Ctor()
        {
            var model = new LibModel(DisplayName, PartNumber, Description);
            model.Should().NotBeNull();
            model.DisplayName.Should().NotBeNull();
            model.Description.Should().NotBeNull();
            model.PartNumber.Should().NotBeNull();
            model.DisplayName.Should().Be(DisplayName);
            model.Description.Should().Be(Description);
            model.PartNumber.Should().Be(PartNumber);
            model.Id.Should().NotBeEmpty();
        }

        [TestMethod()]
        public void LibModel_Partial_Ctor()
        {
            var model = new LibModel(PartNumber, Description);
            model.Should().NotBeNull();
            model.DisplayName.Should().NotBeNull();
            model.Description.Should().NotBeNull();
            model.PartNumber.Should().NotBeNull();
            model.DisplayName.Should().Be($"{model.PartNumber} - {model.Description}");
            model.Description.Should().Be(Description);
            model.PartNumber.Should().Be(PartNumber);
            model.Id.Should().NotBeEmpty();
        }
    }
}