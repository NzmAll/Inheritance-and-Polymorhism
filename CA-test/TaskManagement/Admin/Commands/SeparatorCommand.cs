using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TaskManagement.Admin.Commands
{
    internal class SeparatorCommand : EmailCommand
    {
        protected override bool IsValid()
        {
            string pattern = @"^.+[\.\-]@.+[\.][a-z]+$";
            return Regex.IsMatch(_email, pattern);
        }
    }
}
