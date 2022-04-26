using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibilitiesLibrary;

namespace ChainOfResponsibilitiesClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var leaveRequest = new LeaveRequest { Employee = "Sharan", LeaveDays = 9 };
            var supervisor = new Supervisor("Sam");
            var projectManager = new ProjectManager("Aravindh");
            var hr = new HR("Gokul");

            ILeaveRequestHandler handler1 = new LeaveRequestHandler(supervisor);
            ILeaveRequestHandler handler2 = new LeaveRequestHandler(projectManager);
            ILeaveRequestHandler handler3 = new LeaveRequestHandler(hr);

            handler1.NextHandler(handler2);
            handler2.NextHandler(handler3);

            var permission = handler1.HandleRequest(leaveRequest);
            Console.WriteLine(permission);
            Console.ReadLine();

        }
    }
}
