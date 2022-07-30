using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Noori_Course_Enrollment.Model
{
	public class Noori_Student_Registration
	{
        [Key]
        public int Noori_Student_RegistrationID { get; set; }

        public int Noori_CourseID { get; set; }
        //public int Noori_SchoolID { get; set; }
        //public int Noori_DepartmentID { get; set; }
        public int Noori_StudentID { get; set; }

        public string? Noori_Level { get; set; }

        //Navigation
        [JsonIgnore]
        public Noori_Course? Noori_Course { get; set; }
        [JsonIgnore]
        public Noori_Student? Noori_Student { get; set; }
        //public Noori_Department? Noori_Department { get; set; }
        //public Noori_School? Noori_School { get; set; }
    }
}

