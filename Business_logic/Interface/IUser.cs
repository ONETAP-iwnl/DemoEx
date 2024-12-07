using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_logic.Interface
{
    public interface IUser
    {
        int UserId { get; }
        string FIO { get; set; }
        string Phone { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        string Type { get; set; }
    }
}
