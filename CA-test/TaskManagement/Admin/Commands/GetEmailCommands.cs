using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TaskManagement.Admin.Commands
{
    internal class GetEmailCommands
    {
        public static void Handle()
        {
            Console.WriteLine("Available email commands:");
            Console.WriteLine("1. GetRecipient");
            Console.WriteLine("2. GetSeparator");
            Console.WriteLine("3. GetDomain");

            Console.WriteLine("Please enter the command number:");
            int commandNumber;
            bool isCommandNumberValid = int.TryParse(Console.ReadLine(), out commandNumber);

            if (!isCommandNumberValid || commandNumber < 1 || commandNumber > 3)
            {
                Console.WriteLine("Invalid command number");
                return;
            }

            EmailCommand command;

            switch (commandNumber)
            {
                case 1:
                    command = new RecipientCommand();
                    break;
                case 2:
                    command = new SeparatorCommand();
                    break;
                case 3:
                    command = new DomainCommand();
                    break;
                default:
                    Console.WriteLine("Invalid command number");
                    return;
            }

            command.Handle();
        }
    }
}
