using CloudCustomers.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CloudCustomers.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly ILogger<UsersController> _logger;
    private readonly IUsersService _userService;

    public UsersController(/*ILogger<UsersController> logger*/ IUsersService usersService)
    {
        /*_logger = logger;*/
        this._userService = usersService;
    }

    [HttpGet(Name = "GetUsers")]
    public async Task<ActionResult> Get(){
        //return null;
        var users = await _userService.GetAllUsers();
        if(users.Any()){
            return Ok(users);
        }
        return NotFound();
    }
}
