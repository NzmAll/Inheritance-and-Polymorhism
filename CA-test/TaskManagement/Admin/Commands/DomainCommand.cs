using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TaskManagement.Admin.Commands
{
    internal class DomainCommand : EmailCommand
    {
        protected override bool IsValid()
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@code\.edu\.az$";
            return Regex.IsMatch(_email, pattern);
        }
    }
}
