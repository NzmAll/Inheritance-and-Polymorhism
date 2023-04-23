using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TaskManagement.Admin.Commands.TaskManagementAdmin;

namespace TaskManagement.Admin.Commands
{
    internal class GetDateTimeCommands
    {
        public static void Handle()
        {
            DateTime currentDateTime = DateTime.Now;

            Console.WriteLine("Current date and time is: " + currentDateTime.ToString());

            string logMessage = "GetCurrentDateTimeCommand executed on " + currentDateTime.ToString();
            Logger.Log(logMessage);
        }
    }
}
