namespace _2Users.Services.Services
{
    using _2Users.Services.Interfaces;
    using _3Repository.Interfaces;
    using _3Repository.Repositories;
    using _4Users.Entities.Request;
    using _4Users.Entities.Response;
    public class UsersService : IUsersService
    {
        private IUsersRepository _usersRepository;
        public UsersService(IUsersRepository usersRepository) 
        {
            _usersRepository = usersRepository;
        }
        public UserResponse GetUser(UserRequest user)
        {
            var response = _usersRepository.GetUser(user);
            return response;
        }
        public UserResponse CreateUser(UserRequest user)
        {
            var response = _usersRepository.CreateUser(user);
            return response;
        }
        public UserResponse UpdateUser(UserRequest user)
        {
            var response = _usersRepository.UpdateUser(user); 
            return response;
        }
        public UserResponse DeleteUser(UserRequest user)
        {
            var response = _usersRepository.DeleteUser(user); 
            return response;
        }
        public UsersResponse GetUserList()
        {
            var response = _usersRepository.GetUserList();
            return response;
        }
    }
}
