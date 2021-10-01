using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class UserBindingModel
    {
        public int? Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
        public string NewPassword { get; set; }
        public bool Admin { get; set; }
        public bool Block { get; set; }
        public bool PasswordRestrictions { get; set; }
    }
}
