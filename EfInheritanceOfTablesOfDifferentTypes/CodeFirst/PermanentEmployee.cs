using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirst
{
    //[Table("PermanentEmployees")]
    public class PermanentEmployee : Employee
    {
        public int AnnualSalary { get; set; }
    }
}