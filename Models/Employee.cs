using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    /// <summary>
    /// represents an employee
    /// </summary>
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "First Name is a required field.")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is a required field.")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public decimal Salary { get; set; }

        // dependent ids
        [DisplayName("Dependents")]
        public List<int> Dependents { get; set; }

        public decimal BenefitCost { get; set; }

        public Employee()
        {
            EmployeeId = -1;
            FirstName = string.Empty;
            LastName = string.Empty;
            Dependents = new List<int>();
        }
    }
}
