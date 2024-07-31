using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Student
{
    public interface IStudent
    {
        void CreateStudent(List<StudentDTO> students);
        List<StudentDTO> GetAllStudents();
        Dictionary<string, double> RemoveStudent();

    }
}
