using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Department
{
    internal interface IDepartment
    {
        void CreateDepartments(List<DepartmentDTO> departments);
        List<DepartmentDTO> GetAllDepartments();
        void RemoveDepartments();

    }
}
