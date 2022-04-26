using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilitiesLibrary
{
    public class LeaveRequestHandler : ILeaveRequestHandler
    {
        private ApprovalPerson approvalPerson;
        private ILeaveRequestHandler nextHandler;
        public LeaveRequestHandler(ApprovalPerson approvalPerson)
        {
            this.approvalPerson = approvalPerson;
        }

        public void NextHandler(ILeaveRequestHandler leaveRequestHandler)
        {
            nextHandler = leaveRequestHandler;
        }

        public LeaveStatus HandleRequest(LeaveRequest leaveRequest)
        {
            var status = approvalPerson.Process(leaveRequest);
            if (status == LeaveStatus.ApprovalRequired && nextHandler != null)
                status = nextHandler.HandleRequest(leaveRequest);
            return status;
        }
       
    }
}
