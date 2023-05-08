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
        private const string PartNumber = nameof(PartNumber);

        [TestMethod()]
        public void LibModel_Default_Ctor()
        {
            var model = new LibModel();
            model.Should().NotBeNull();
            model.DisplayName.Should().BeNull();
            model.Description.Should().BeNull();
            model.PartNumber.Should().BeNull();
        }

        [TestMethod()]
        public void LibModel_Full_Ctor()
        {
            var model = new LibModel("Custom Name", PartNumber, Description);
            model.Should().NotBeNull();
            model.DisplayName.Should().NotBeNull();
            model.Description.Should().NotBeNull();
            model.PartNumber.Should().NotBeNull();
            model.DisplayName.Should().Be("Custom Name");
            model.Description.Should().Be(Description);
            model.PartNumber.Should().Be(PartNumber);
        }

        [TestMethod()]
        [Ignore]
        public void LibModel_Full_Ctor_Should_Fail()
        {
            var model = new LibModel("Custom Name", PartNumber, Description);
            model.Should().NotBeNull();
            model.DisplayName.Should().NotBeNull();
            model.Description.Should().NotBeNull();
            model.PartNumber.Should().NotBeNull();
            model.DisplayName.Should().Be($"{model.PartNumber} - {model.Description}");
            model.Description.Should().Be(Description);
            model.PartNumber.Should().Be(PartNumber);
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
        }
    }
}