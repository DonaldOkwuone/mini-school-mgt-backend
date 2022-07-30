using Noori_Course_Enrollment.Model;

namespace Noori_Course_Enrollment.Data
{
    public interface IStudentRepo{

        public bool SaveChanges();

        public void AddStudent(Noori_Student student);
    }
}