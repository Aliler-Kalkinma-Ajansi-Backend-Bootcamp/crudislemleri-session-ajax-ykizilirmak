using data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data.Service
{
    public class UserService
    {
        public List<TblUser> GetAllUsers()
        {
            using (var service = new SocIDContext())
            {
                var data = service.TblUsers.ToList();
                return data;
            }
             
        }

        public TblUser GetById(int id)
        {
            using (var service = new SocIDContext())
            {
                var data = service.TblUsers.FirstOrDefault(balik=>balik.Id==id );
                return data;
            }
             
        }
        public void Insert(TblUser user)
        {
            using (var service = new SocIDContext())
            {
                user.CreateDate = DateTime.Now;
                service.TblUsers.Add(user);
                service.SaveChanges();
            }
        }

        public void Update(TblUser user)
        {
            using (var service = new SocIDContext())
            {
                var _user = service.TblUsers.Find(user.Id);
                _user.ModifyDate = user.ModifyDate;
                _user.Username = user.Username;
                _user.Password = user.Password;
                service.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var service = new SocIDContext())
            {
                var _user = service.TblUsers.Find(id);
                service.TblUsers.Remove(_user);
                service.SaveChanges();
            }
        }

    }
}
