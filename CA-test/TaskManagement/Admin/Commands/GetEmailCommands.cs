using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TaskManagement.Admin.Commands
{
    internal class EmailCommand
    {
        protected string? _email;

        public virtual void Handle()
        {
            Console.WriteLine("Please enter the email address:");
            _email = Console.ReadLine()!;

            if (IsValid())
            {
                Console.WriteLine($"{GetType().Name} is valid");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} is invalid");
            }
        }

        protected virtual bool IsValid()
        {
            return false;
        }
    }

    internal class RecipientCommand : EmailCommand
    {
        public override void Handle()
        {
            Console.WriteLine("Please enter the recipient:");
            _email = Console.ReadLine()!;

            base.Handle();
        }

        protected override bool IsValid()
        {
            string pattern = @"^[a-zA-Z0-9]{10,30}$";
            return Regex.IsMatch(_email, pattern);
        }
    }

    internal class SeparatorCommand : EmailCommand
    {
        protected override bool IsValid()
        {
            string pattern = @"^.+[\.\-]@.+[\.][a-z]+$";
            return Regex.IsMatch(_email, pattern);
        }
    }

    internal class DomainCommand : EmailCommand
    {
        protected override bool IsValid()
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@code\.edu\.az$";
            return Regex.IsMatch(_email, pattern);
        }
    }

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
