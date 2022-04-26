using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilitiesLibrary
{
    public abstract class ApprovalPerson
    {
        public string Name { get; set; }
        public ApprovalPerson(string name)
        {
            this.Name = name;
        }
        public abstract LeaveStatus Process(LeaveRequest leaveRequest);
    }
}
