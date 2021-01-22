using data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data.Service
{
    public class LoginControl
    {
        public int Login(string username, string password)    //Logincontrollerdan çekilen user ın girdiği username ve passwordun dbde olup olmadıgını lontrol eder.
        {
            int result = 0;

            using (var service = new SocIDContext())
            {
                var data = service.TblUsers.FirstOrDefault(x => x.Username == username && x.Password == password);
                result = data != null && data.Id > 0 ? data.Id : 0;         
            }

            return result;
        }


    }
}