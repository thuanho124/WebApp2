using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementWithAuthen.Models
{
    public class Student
    {
        public int StudentID { get; set; } // primary key

        [Required]
        [StringLength(30)]
        public string StudentFirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string StudentLastName { get; set; }

        [Required]
        [StringLength(30)]
        public string StudentEmail { get; set; }


        // navigation property
        public ICollection<RentedBook> RentedBooks { get; set; }
    }
}
