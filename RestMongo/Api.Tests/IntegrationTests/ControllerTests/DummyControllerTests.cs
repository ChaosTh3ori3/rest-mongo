using Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Api.Tests.IntegrationTests.ControllerTests
{
    /// <summary>
    /// !! TO BE REMOVED !!
    /// </summary>
    public sealed class DummyControllerTests
    {
        /// <summary>
        /// !! TO BE REMOVED !!
        /// </summary>
        private readonly DummyController _dummyController;
        
        /// <summary>
        /// !! TO BE REMOVED !!
        /// </summary>
        public DummyControllerTests()
        {
            _dummyController = new DummyController();
        }

        /// <summary>
        /// !! TO BE REMOVED !!
        /// </summary>
        [Fact]
        public void ReturnsOk()
        {
            IActionResult actionResult = _dummyController.Test();

            Assert.IsType<OkObjectResult>(actionResult);
        }
    }
}