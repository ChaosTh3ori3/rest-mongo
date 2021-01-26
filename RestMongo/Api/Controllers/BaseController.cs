using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    /// <summary>
    /// Base controller
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public abstract class BaseController : ControllerBase { }
}