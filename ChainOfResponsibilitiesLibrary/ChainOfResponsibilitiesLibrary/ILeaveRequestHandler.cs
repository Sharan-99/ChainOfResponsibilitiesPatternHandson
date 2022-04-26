using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilitiesLibrary
{
    public interface ILeaveRequestHandler
    {
        LeaveStatus HandleRequest(LeaveRequest leaveRequest);
        void NextHandler(ILeaveRequestHandler leaveRequestHandler);
    }
}
