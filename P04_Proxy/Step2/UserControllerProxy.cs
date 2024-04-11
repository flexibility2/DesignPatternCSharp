using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Proxy.Step2
{
    public class UserControllerProxy : IUserController
    {
        private readonly MetricsCollector _metricsCollector;
        private readonly IUserController _userController;

        public UserControllerProxy(IUserController userController)
        {
            _metricsCollector = new MetricsCollector();
            _userController = userController;
        }

        public UserDto Login(string telephone, string password)
        {
            long startTimestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            var usr = _userController.Login(telephone, password);

            long endTimeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            long responseTime = endTimeStamp - startTimestamp;
            RequestInfo requestInfo = new RequestInfo("login", responseTime, startTimestamp);
            _metricsCollector.RecordRequest(requestInfo);
            return usr;
        }

        public UserDto Register(string telephone, string password)
        {
            long startTimestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            var usr = _userController.Register(telephone, password);
            long endTimeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            long responseTime = endTimeStamp - startTimestamp;
            RequestInfo requestInfo = new RequestInfo("register", responseTime, startTimestamp);
            _metricsCollector.RecordRequest(requestInfo);
            return usr;
        }
    }
}