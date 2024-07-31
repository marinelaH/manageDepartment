using ConsoleApp6.Department;
using ConsoleApp6.Student;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create Student

            List<StudentDTO> students = new List<StudentDTO>()
            {

                new StudentDTO { Name = "Marinela", DepartmentName = "IT", Grade = 5.1 },
                new StudentDTO { Name = "Marinela", DepartmentName = "IT", Grade = 5.2 },
                new StudentDTO { Name = "Marinela", DepartmentName = "IT", Grade = 5.1 },
                new StudentDTO { Name = "Test", DepartmentName = "IT", Grade = 8.1 },
                new StudentDTO { Name = "Test", DepartmentName = "Biology", Grade = 9.1 },

            };
            // create department object
            List<DepartmentDTO> department = new List<DepartmentDTO>()
            {
                new DepartmentDTO { Name = "IT", FacultyName = "FSHN", NoCurrentStudent = students.Count(), NoMaxStudent = 100 }
            };
            Student.Student addStudent = new Student.Student();
            addStudent.CreateStudent(students); // call method Create Student to create object
            addStudent.RemoveStudent();// after students are created, remove all students that has grade < 5.6
            addStudent.GetAllStudents(); // return all other users wheren grade  > 5.6
        }
    }
}
