using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Admin.Commands
{
    internal class TaskManagementAdmin
    {
        internal static class Logger
        {
            public static void Log(string message)
            {
                Console.WriteLine(message);
            }
        }
    }
}
