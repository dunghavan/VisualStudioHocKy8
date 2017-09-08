using DemoWebAPI2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoWebAPI2.Controllers
{

    public class EmptyController : ApiController
    {

        [NonAction]
        [ActionName("TinhTong")]
        public int GetString(int a, int b)
        {
            return function(a, b);
        }

        public int function(int a, int b)
        {
            return a + b;
        }
        // khởi tạo dữ liệu:
        List<Person> listPerson = new List<Person>();
        public EmptyController()
        {
            listPerson.AddRange(new Person[]
                {
                    new Person()
                    {
                        ID = 1,
                        Name = "Tu"
                    },
                    new Person()
                    {
                        ID = 2,
                        Name = "Dung"
                    }

                });
        }

        //Tao 1 phuong thuc Get du lieu Person:
        public IEnumerable<Person> AllPerson()
        {
            return listPerson;
        }

        public Person getPersonByName(string _name)
        {
            return listPerson.First(x => x.Name == _name);
        }

        // PUT
        public string PutPerson(int id, string name)
        {
            Person per = new Person();
            per.ID = id;
            per.Name = name;

            return "Put thanh cong Person co ID la: " + id + ", name: " + name;
        }

        // Delete

        public string DeletePerson(int id)
        {
            // Xoa Person co ID = id...

            return "Xoa thanh cong Person co ID la: " + id;
        }
    }
}
