using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apicrc.Helpers
{
    public class Authorization
    {
        public enum Roles
        {
            Administrator,
            Manager,
            Employee
        }
        public const Roles rol_default = Roles.Employee;
    }
}