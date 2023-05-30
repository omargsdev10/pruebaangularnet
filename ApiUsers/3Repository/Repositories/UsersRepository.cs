namespace _3Repository.Repositories
{
    using _3Repository.Interfaces;
    using _4Users.Entities.Request;
    using _4Users.Entities.Response;
    public class UsersRepository : IUsersRepository
    {
        public UserResponse GetUser(UserRequest user)
        {
            var response = new UserResponse();
            response.User = user.User;
            return response;
        }
        public UserResponse CreateUser(UserRequest user)
        {
            var response = new UserResponse();
            response.User = user.User;
            return response;
        }

        public UserResponse UpdateUser(UserRequest user)
        {
            var response = new UserResponse();
            response.User = user.User;
            return response;
        }
        public UserResponse DeleteUser(UserRequest user)
        {
            var response = new UserResponse();
            response.User = user.User;
            return response;
        }
        public UsersResponse GetUserList()
        {
            var response = new UsersResponse();
            response.UsersList = new List<_4Users.Entities.UserEntity> {
                new _4Users.Entities.UserEntity{ 
                    Id = 1,
                    Name = "Juan",
                    LastName = "Marino",
                    MothersLastName = "Contreras",
                    Email = "Marino",
                    Address = "Vicente Guerro 103",
                    PhoneNumber = "1234567890"
                },
                new _4Users.Entities.UserEntity{
                    Id = 2,
                    Name = "Leonel",
                    LastName = "Martinez",
                    MothersLastName = "Vela",
                    Email = "Marino",
                    Address = "Río Amazonas 12",
                    PhoneNumber = "1234567890"
                }
            };
            return response;
        }
    }
}
