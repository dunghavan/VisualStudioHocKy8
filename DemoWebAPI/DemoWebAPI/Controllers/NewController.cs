using DemoWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoWebAPI.Controllers
{
    public class NewController : ApiController
    {
        List<Person> listPerson = new List<Person>();
        public NewController()
        {
            listPerson.AddRange(new Person[]
            {
                new Person()
                {
                    ID=1,
                    Name="Trần Tú",
                    Birthday=1995
                },
                new Person()
                {
                    ID=2,
                    Name="Ha dung",
                    Birthday=1996
                },
                new Person()
                {
                    ID = 3,
                    Name = "Thanh Thuy",
                    Birthday=1997
                },
                new Person
                {
                    ID=4,
                    Name="Nhat Dang",
                    Birthday=1995
                },
                new Person
                {
                    ID=5,
                    Name="Sinh",
                    Birthday=1994
                }
            });
        }
        [HttpGet]
        public int sum(int a, int b)
        {
            return a + b;
        }
        [HttpGet]
        public IEnumerable<Person> AllPerson()
        {
            return listPerson;
        }
        [HttpPost]
        public IEnumerable<Person> AllPersonPost()
        {
            return listPerson;
        }

        [HttpGet]
        public Person ByName(string name)
        {
            return listPerson.First(x => x.Name == name);
        }
    }
}
