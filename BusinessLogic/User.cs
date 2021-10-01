using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        public bool Block { get; set; }
        public bool PasswordRestrictions { get; set; }
        public bool FirstLogin { get; set; }

    }
}
