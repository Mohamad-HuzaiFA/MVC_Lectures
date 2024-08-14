namespace MVC_letcures.Models
{
    public class StudentRepository
    {
        public static List<Student> listOfStu = new List<Student>();

        public static void AddStudentsInMemory(Student newSt)
        {
            listOfStu.Add(newSt);
        }
    }
}
