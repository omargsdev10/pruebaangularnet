using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Users.Entities.Response
{
    public class UsersResponse : BaseResponse
    {
        public List<UserEntity> UsersList { get; set; }
    }
}
