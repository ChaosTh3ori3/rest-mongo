using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    /// <summary>
    /// !! TO BE REMOVED !!
    /// </summary>
    public sealed class DummyController : BaseController
    {
        /// <summary>
        /// !! TO BE REMOVED !!
        /// </summary>
        [HttpGet]
        public IActionResult Test() => Ok("Works");
    }
}