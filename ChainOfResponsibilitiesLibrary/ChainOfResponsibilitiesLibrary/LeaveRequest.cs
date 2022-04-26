using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilitiesLibrary
{
   public enum LeaveStatus
    {
        Granted,
        Rejected,
        ApprovalRequired
    }
    public class LeaveRequest
    {
        public string Employee { get; set; }
        public int LeaveDays { get; set;  }
    }
}
