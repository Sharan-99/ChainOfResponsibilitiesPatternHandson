using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilitiesLibrary
{
    public class ProjectManager:ApprovalPerson
    {
        public ProjectManager(string name) : base(name) { }
        public override LeaveStatus Process(LeaveRequest leaveRequest)
        {
            if (leaveRequest.LeaveDays >= 3 && leaveRequest.LeaveDays < 5)
            {
                Console.WriteLine("Leave Request granted by project manager:{0} for employee:{1}", Name, leaveRequest.Employee);
                return LeaveStatus.Granted;
            }
            Console.WriteLine("Leave Request Sent for Approval from the Project Manager to HR....");
            return LeaveStatus.ApprovalRequired;
        }
    }
}
