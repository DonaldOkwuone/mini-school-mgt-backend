using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Noori_Course_Enrollment.Model
{
    public class Noori_Course 
    {
         
        public int Noori_CourseID { get; set; }
        public string? CourseName { get; set; }
        public string? CourseProfessor { get; set; }
        public string? Score { get; set; }
        //public int Noori_DepartmentId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }


        //Navigations
        //[JsonIgnore]
        //public Noori_Department? Noori_Department { get; set; }
    }
}

