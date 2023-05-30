using _2Users.Services.Interfaces;
using _2Users.Services.Services;
using _4Users.Entities;
using _4Users.Entities.Request;
using _4Users.Entities.Response;
using Microsoft.AspNetCore.Mvc;

namespace _ApiUsers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUsersService _usersService;
        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet("GetUsers")]
        public UsersResponse GetUsers()
        {
            return _usersService.GetUserList();
        }

        [HttpGet("GetUser")]
        public UserResponse GetUser(int Id)
        {
            return _usersService.GetUser(new UserRequest { User = new UserEntity { Id = Id } });
        }

        [HttpPost("UpdateUser")]
        public UserResponse UpdateUser(UserEntity user)
        {
            var request = new UserRequest { User = user };
            return _usersService.UpdateUser(request);
        }

        [HttpPost("CreateUser")]
        public UserResponse CreateUser(UserEntity user)
        {
            var request = new UserRequest { User = user };
            return _usersService.CreateUser(request);
        }

        [HttpPost(Name = "DeleteUser")]
        public UserResponse DeleteUser(int Id)
        {
            return _usersService.DeleteUser(new UserRequest { User = new UserEntity { Id = Id } });
        }
    }
}
