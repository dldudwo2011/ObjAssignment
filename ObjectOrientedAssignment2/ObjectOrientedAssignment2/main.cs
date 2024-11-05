using Microsoft.Data.SqlClient;
using ObjectOrientedAssignment2.Domain;
using System.Collections.Generic;

namespace ObjectOrientedAssignment2
{

    class Program
    {

        static void Main(string[] args)
        {
            BCS RequestDirector = new();

            //bool Confirmation = RequestDirector.CreateProgram("", "CS123 course");
            //Console.WriteLine(Confirmation);


            //Student EnrolledStudent = RequestDirector.FindStudent("ylee39");
            //Console.WriteLine("found student email: " + EnrolledStudent.Email);
            //Console.WriteLine("found student FirstName: " + EnrolledStudent.FirstName);
            //Console.WriteLine("found student LastName: " + EnrolledStudent.LastName);

            //Student AcceptedStudent = new("newstudent12343w", "James", "lee", "skske1432@gmail.com");
            //bool Confirmation = RequestDirector.EnrollStudent(AcceptedStudent, "CS123");
            //Console.WriteLine(Confirmation);

            //Student EnrolledStudent = RequestDirector.FindStudent("ylee39");
            //Console.WriteLine("found student email: " + EnrolledStudent.Email);
            //Console.WriteLine("found student FirstName: " + EnrolledStudent.FirstName);
            //Console.WriteLine("found student LastName: " + EnrolledStudent.LastName);

            //EnrolledStudent.Email = "skske1432@gmail.com";

            //bool Confirmation = RequestDirector.ModifyStudent(EnrolledStudent);
            //Console.WriteLine(Confirmation);

            //Student EnrolledStudent = RequestDirector.FindStudent("ylee39");
            //Console.WriteLine("found student email: " + EnrolledStudent.Email);
            //Console.WriteLine("found student FirstName: " + EnrolledStudent.FirstName);
            //Console.WriteLine("found student LastName: " + EnrolledStudent.LastName);



            //bool Confirmation = RequestDirector.RemoveStudent(EnrolledStudent.StudentID);
            //Console.WriteLine(Confirmation);

            Domain.Program ActiveProgram = RequestDirector.FindProgram("CS101");
            Console.WriteLine(ActiveProgram.ProgramCode);
            Console.WriteLine("foundprogram description" + ActiveProgram.Description);

            foreach (Student EnrolledStudent in ActiveProgram.EnrolledStudents)
            {
                Console.WriteLine("foundstudent-ID " + EnrolledStudent.StudentID);
                Console.WriteLine("foundstudent-FirstName " + EnrolledStudent.FirstName);
                Console.WriteLine("foundstudent-LastName " + EnrolledStudent.LastName);
                Console.WriteLine("foundstudent-Email " + EnrolledStudent.Email);// Prints each item in the list
            }
        }
    }
}