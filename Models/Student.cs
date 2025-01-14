﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CodeFirstApproach.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Column("StudentName",TypeName ="varchar(100)")] // we do this so that when we create table using migration it create column in tables as StudentName
        public string Name { get; set; }

        [Column("StudentGender", TypeName = "varchar(20)")]
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Standard { get; set; }
    }
}
