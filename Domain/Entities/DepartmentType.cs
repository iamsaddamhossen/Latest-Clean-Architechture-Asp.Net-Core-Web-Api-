using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    public class DepartmentType : AuditableBaseEntity
    {
        [Key]
        public int DepartmentTypeId { get; set; }

        [Required]
        [StringLength(250)]
        public string DepartmentName { get; set; }
    }
}
