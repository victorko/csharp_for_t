using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ExampleTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TreeTest()
        {
            // Arrange
            // ...
            var tree = Settings.ReporterTree;

            // Act
            // ...

            // Assert
            // ...
            Assert.IsNotNull(tree);
        }

        [TestMethod]
        public void PermissionsTest()
        {
            // Arrange
            // ...
            var permissions = Settings.SxpPermissions;

            // Act
            // ...

            // Assert
            // ...
            Assert.IsTrue(permissions.Count() > 0);
        }
    }
}
