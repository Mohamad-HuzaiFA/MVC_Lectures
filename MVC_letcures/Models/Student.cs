using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;

namespace MVC_letcures.Models

{
    public class Student
    {
        [Required(ErrorMessage ="Please Enter Name")]
        [StringLength(50)] 
        public string? Name { get; set; }
        [Required(ErrorMessage ="Please enter Rollno")]
        public string? Rollno { get; set; }
        [Required(ErrorMessage = "Please enter Age")]
        [Range(1, 100)]
        public int? Age { get; set; }
        [Required(ErrorMessage ="Enter your Semester")]
        public float? CGPA { get; set; }



        public void AddStudent(Student student)
        {
            try
            {
                string connStrig = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BistroManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                SqlConnection con = new SqlConnection(connStrig);

                con.Open();

                string insert = "insert into Students values (@roll,@name,@age,@cgpa)";
                SqlCommand cmd = new SqlCommand(insert, con);

                cmd.Parameters.AddWithValue("@roll", student.Rollno);
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@age", student.Age);
                cmd.Parameters.AddWithValue("@cgpa", student.CGPA);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
               // Console.WriteLine(ex.Message);
            }
        }

        //public Student()
        //{
        //    Name = "Void";
        //    Rollno = "Void";
        //    age = 0;
        //    CGPA = 0;
        //}

        //public Student(string? name, string? rollno, int age,float cgpa)
        //{
        //    Name = name;
        //    Rollno = rollno;
        //    this.age = age;
        //    this.CGPA = cgpa;
        //}
    }
}
