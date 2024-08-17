using Microsoft.AspNetCore.Mvc;
using MVC_letcures.Models;
using System.ComponentModel.DataAnnotations;

namespace MVC_letcures.Controllers
{
    public class StudentController : Controller
    {
        //Student s1 = new Student[3];  
        Student s = new Student { Name = "HUZAIFA", Rollno = "BCSF21M010", Age = 22 };
        List<Student> listOfStu = new List<Student>();
        //listOfStu.Add(new Student{Name = "HUZAIFA", Rollno = "BCSF21M010", age = 22});

        public IActionResult Index()
        {
            listOfStu.Add(new Student { Name = "Ali", Rollno = "m101", Age = 22, CGPA = 3.4F });
            listOfStu.Add(new Student { Name = "Jimmi", Rollno = "m103", Age = 23, CGPA = 3.5F });
            listOfStu.Add(new Student { Name = "Junaid", Rollno = "m105", Age = 24, CGPA = 3.4F });
            //     string data = "This is dummy data passed to index";
            return View(listOfStu);
        }

        [HttpGet] // when get request from client end
        public ViewResult StudentForm()
        {
            return View();
        }
        [HttpPost] //When post request from client end
        //public ViewResult StudentForm(string Name, string Rollno, int age, float cgpa)
        //{
        //    if(ModelState.IsValid)
        //    {
        //    Student temp = new Student();
        //    temp.Name = Name;
        //    temp.Rollno = Rollno;
        //    temp.Age = age;
        //    temp.CGPA = cgpa;

        //    temp.AddStudent(temp);
        //    //string msg = "Student Added";
        //    return View();
        //    //Console.WriteLine($"name = {Name},Rollno = {Rollno},Age = {age}, CGPA = {cgpa}");
        //}
        //else 
            //return View();
        //}
        public ViewResult StudentForm(Student s)
        {
            if (ModelState.IsValid)
            {
                StudentRepository.AddStudentsInMemory(s);

                return View("Thanks", s);
                //Console.WriteLine($"name = {Name},Rollno = {Rollno},Age = {age}, CGPA = {cgpa}");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Please Enter Correct Data"); //For generic Msg 
                return View();
            }
        }

        public ViewResult ListStudents()
        {
            return View("ListStudents",StudentRepository.listOfStu);
        }

        

    }
}
