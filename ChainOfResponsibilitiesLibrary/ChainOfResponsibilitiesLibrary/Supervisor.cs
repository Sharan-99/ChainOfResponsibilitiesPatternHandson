using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilitiesLibrary
{
    public class Supervisor : ApprovalPerson
    {
        public Supervisor(string name):base(name) {  }
        public override LeaveStatus Process(LeaveRequest leaveRequest)
        {
            if (leaveRequest.LeaveDays >= 1 && leaveRequest.LeaveDays < 3)
            {
                Console.WriteLine("Leave Request granted by supervisor:{0} for employee:{1}", Name,leaveRequest.Employee);
                return LeaveStatus.Granted;
            }
            Console.WriteLine("Leave Request Sent for Approval from the Supervisor to Project Manager...");
            return LeaveStatus.ApprovalRequired;
        }
    }
}
