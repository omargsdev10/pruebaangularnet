namespace _3Repository.Interfaces
{
    using _4Users.Entities.Request;
    using _4Users.Entities.Response;
    public interface IUsersRepository
    {
        UserResponse GetUser(UserRequest user);
        UserResponse CreateUser(UserRequest user);
        UserResponse UpdateUser(UserRequest user);
        UserResponse DeleteUser(UserRequest user);
        UsersResponse GetUserList();
    }
}
