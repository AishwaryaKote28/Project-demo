using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstituteManagementSystem.Model
{
    public class FeesDetails
    {
        [Key]
        public int RecieptId { get; set; }
        public int PaidFees { get; set; }
        public int PendingFees { get; set; }
        public string Status { get; set; }
        /* public int StudentId { get; set; }
        public StudentAdmissionDetails StudentAdmissionDetails { get;set;}*/
    }
}
