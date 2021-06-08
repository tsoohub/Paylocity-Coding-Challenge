using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Models;

namespace PaylocityWeb.ViewModels
{
    public class EmpDetailsViewModel
    {
        public Employee employee { get; set; }

        [Display(Name = "Add dependent")]
        public List<Dependent> dependents { get; set; }

        public decimal PayrollDeduction { get; set; }

        public decimal PayAfterBenefitDeduction { get; set; }
    }
}