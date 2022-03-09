using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirst
{
    //[Table("Employees")] /*FluentApi kullanıldığı için ihtiyaç kalmadı.[EmployeeDBContext OnModelCreating ToTable metodları.]*/
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
    }
}