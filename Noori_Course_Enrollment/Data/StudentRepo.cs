using Noori_Course_Enrollment.Model;

namespace Noori_Course_Enrollment.Data
{
    public class StudentRepo : IStudentRepo
    {
        private readonly ApplicationDbContext _context;
        public StudentRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        void IStudentRepo.AddStudent(Noori_Student student)
        {
            _context.Add(student);
             
        }

        bool IStudentRepo.SaveChanges()
        {
           return _context.SaveChanges()>0;
        }
    }
}