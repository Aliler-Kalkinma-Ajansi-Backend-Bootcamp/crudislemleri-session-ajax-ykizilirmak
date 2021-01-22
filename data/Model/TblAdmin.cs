using System;
using System.Collections.Generic;

#nullable disable

namespace data.Model
{
    public partial class TblAdmin
    {
        public TblAdmin()
        {
            TblUsers = new HashSet<TblUser>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? ModifyUser { get; set; }

        public virtual ICollection<TblUser> TblUsers { get; set; }
    }
}
