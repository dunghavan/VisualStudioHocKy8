using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DemoREST.Models;

namespace DemoREST.Controllers
{
    public class StudentController : ApiController
    {
        DBMemberDataContext myContext = new DBMemberDataContext();
        
        public IEnumerable<Student> getAllStudent()
        {
            var students = (from items in myContext.Students select items).ToList();
            List<Student> studentList = new List<Student>();
            foreach (var student in students)
            {
                studentList.Add(new Student
                {
                    ID = student.ID,
                    Name = student.Name
                });
            }
            return studentList;
        }
        
        public IEnumerable<Student> getStudentByID(int id)
        {
            var students = from item in myContext.Students where item.ID == id select item;
            List<Student> myList = new List<Student>();
            foreach (var s in students)
            {
                myList.Add(s);
            }
            return myList;
        }
        [HttpPost]
        public void addStudent()
        {
            Student student = new Student
            {
                ID = 13520872,
                Name = "Le Thanh Thuy"
            };
            myContext.Students.InsertOnSubmit(student);
            myContext.SubmitChanges();
        }

        [HttpPost]
        public void addListStudent()
        {
            List<Student> studentList = new List<Student>()
            {
                 new Student
                {
                    ID = 13520872,
                    Name = "Le Thanh Thuy"
                },
                new Student
                {
                    ID = 13520969,
                    Name = "Tran Ngoc Tu"
                },

                new Student
                {
                    ID = 13520137,
                    Name = "Ha Van Dung"
                },
        };
            foreach(var student in studentList)
            {
                myContext.Students.InsertOnSubmit(student);
                myContext.SubmitChanges();
            }
               
        }

        [HttpPut]
        public void updateStudent()
        {
            var students = from items in myContext.Students where items.ID == 13520137 select items;
            foreach (var student in students)
            {
                student.Name = "Ha Van Dung";
            }

            myContext.SubmitChanges();
        }

        [HttpDelete]
        public void deleteStudent()
        {
            var students = from items in myContext.Students where items.ID == 13520002 select items;
            foreach(var student in students)
            {
                myContext.Students.DeleteOnSubmit(student);
            }
            myContext.SubmitChanges();
        }
    }
}
