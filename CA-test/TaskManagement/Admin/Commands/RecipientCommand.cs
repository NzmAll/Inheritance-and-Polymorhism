using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TaskManagement.Admin.Commands
{
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
}
