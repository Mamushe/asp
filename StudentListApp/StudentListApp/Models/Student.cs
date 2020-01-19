using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentListApp.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Column("nvarchar(40")]
        public string StudentName { get; set; }
        [Column("nvarchar(10")]
        [Required]
        public string StudentIdNumber { get; set; }
        [Column("nvarchar(20")]
        public string StudentSection { get; set; }

    }
}
