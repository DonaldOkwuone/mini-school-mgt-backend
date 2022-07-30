using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Noori_Course_Enrollment.Model
{
	public class Noori_Department
	{ 
        public int Noori_DepartmentID { get; set; }
        public string? DepartmentName { get; set; }
        public string? Hod { get; set; }
        public int Noori_SchoolID { get; set; } 
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        //Connections
        [JsonIgnore]
        public Noori_School? Noori_School { get; set; }

        [JsonIgnore]
        public ICollection<Noori_Course>? Noori_Course { get; set; }
    }
}

