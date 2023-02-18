using GizmoAPI.Models;
using GizmoAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GizmoAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUsersRepository _usersRepository;
    public UsersController(IUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

    [HttpGet]
    public ActionResult GetUsers([FromQuery]User user = null)
    {
        if (!_usersRepository.IsEmpty())
        {
            return NoContent();
        } else if (!String.IsNullOrEmpty(user.FirstName)) 
            {
           var foundUserList = _usersRepository.GetUsersByFirstName(user.FirstName);
            if (foundUserList != null)
            {
                return Ok(foundUserList);
            } else return Ok(_usersRepository.GetAll());
        } else return NoContent();
    }
}
