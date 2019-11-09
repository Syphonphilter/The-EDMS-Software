using System;
using System.Collections.Generic;

namespace The_EDMS_Software.Models
{
    public partial class TblUser
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public Guid SessionId { get; set; }
        public Guid TokenId { get; set; }
    }
}
