using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_logic.Interface
{
    public interface IComment
    {
        int CommentId { get; }
        string Message { get; set; }
        int MasterId { get; set; }
        int RequestId { get; set; }
    }
}
