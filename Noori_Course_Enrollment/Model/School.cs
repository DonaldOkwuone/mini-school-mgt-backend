using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Noori_Course_Enrollment.Model
{
	public class Noori_School 
	{
        [Key]
        public int Noori_SchoolID { get; set; }
        public string? SchoolName { get; set; } 
        public string? ViceChancellor { get; set; } 
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        [JsonIgnore]
        public ICollection<Noori_Department>? Noori_Departments { get; set; }
    }
}

