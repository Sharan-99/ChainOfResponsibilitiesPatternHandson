using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilitiesLibrary
{
    public class HR:ApprovalPerson
    {
        public HR(string name) : base(name) { }
        public override LeaveStatus Process(LeaveRequest leaveRequest)
        {
            if (leaveRequest.LeaveDays >= 5 && leaveRequest.LeaveDays < 10)
            {
                Console.WriteLine("Leave Request granted by HR:{0} for employee:{1}", Name, leaveRequest.Employee);
                return LeaveStatus.Granted;
            }
            Console.WriteLine("***Leave Request has been rejected by HR since the numner of days is above the minimum limit ***");
            return LeaveStatus.Rejected;
        }
    }
}
