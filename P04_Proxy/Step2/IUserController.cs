using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Proxy.Step2
{
    public interface IUserController
    {
        public UserDto Login(string telephone, string password);

        public UserDto Register(string telephone, string password);
    }
}