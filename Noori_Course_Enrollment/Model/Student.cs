using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Noori_Course_Enrollment.Model
{
	public class Noori_Student
	{
         
        public int Noori_StudentID { get; set; }
        public string? StudentName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Address { get; set; }
    
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int Noori_DepartmentID { get; set; }
        public string?  Email { get; set; }
        [MaxLength(11)]
        public string?  Phone { get; set; }
        public string?  Password { get; set; }
        //Nav
        [JsonIgnore]
        public Noori_Department? Noori_Department { get; set; }
    }
}

