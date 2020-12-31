using ContosoPets.Ui.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPets.Ui.Controllers.Controllers
{
    /// <summary>
    /// This is a controller to expose an admin registration key.
    /// Note that this controller allows anonymous access, and this
    /// mechanism SHOULD NOT be used for production code without
    /// securing this endpoing!!!
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class AdminTokenController : ControllerBase
    {
        private readonly AdminRegistrationTokenServer _adminService;

        public AdminTokenController(AdminRegistrationTokenService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet]
        public ActionResult<ulong> get() =>
            _adminService.CreationKey;
    }
}