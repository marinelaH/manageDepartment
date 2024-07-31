using System.Text.RegularExpressions;

namespace ConsoleApp6.Student
{
    public class Student : IStudent
    {
        List<StudentDTO> listOfStudents = new List<StudentDTO>();
        public void CreateStudent(List<StudentDTO> students)
        {
            listOfStudents.AddRange(students);
        }


        public List<StudentDTO> GetAllStudents()
        {
            return listOfStudents;
        }

        public Dictionary<string, double> RemoveStudent()
        {
            // filterData
            try
            {
                Dictionary<string, double> result = new Dictionary<string, double>();
                // filter all students that has Grade < 5.6
                var filterData = listOfStudents.Where(x => x.Grade <= 5.6).ToList();

                // filter all students that whose elements that are not also in second list
                var  finalList = listOfStudents.Except(filterData);
                listOfStudents = finalList.ToList();
               
                // add all students that has Grad < 5.6 in a dictionary
                foreach (var item in filterData)
                {
                    if (!result.ContainsKey(item.Name))
                    {
                        result.Add(item.Name, item.Grade);
                    }
                    else
                    {
                        // increment by one if a value exist in a dictionary
                        int number = ExtractNumericSuffixes(item.Name);
                        if(number == 0)
                        {
                            number = 1;
                        }
                        string newName2 = item.Name + number;
                        string newName = item.Name.Substring(0, item.Name.Length - 1) + number.ToString();
                        result.Add(newName, item.Grade);

                    }
                }

                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        private int ExtractNumericSuffixes(string name)
        {
            Regex regex = new Regex(@"\d+$");
            int finalNumber = 0;
            Match match = regex.Match(name);
            if (match.Success)
            {
                if (int.TryParse(match.Value, out int number))
                {
                    finalNumber = number;
                }
            }


            return finalNumber;
        }



    }
}
