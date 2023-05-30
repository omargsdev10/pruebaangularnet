using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Users.Entities.Request
{
    public class UserRequest : BaseRequest
    {
        public UserEntity User { get; set; }
    }
}
