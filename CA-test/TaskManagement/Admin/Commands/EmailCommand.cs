using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
}
