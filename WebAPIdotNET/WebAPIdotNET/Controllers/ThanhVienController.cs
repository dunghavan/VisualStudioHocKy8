using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIdotNET.Models;

namespace WebAPIdotNET.Controllers
{
    public class ThanhVienController : ApiController
    {
        myLinqClassDataContext _myLinqClass = new myLinqClassDataContext();

        public IEnumerable<ThanhVien> getAllThanhVien()
        {
            var result = from thanhvien in _myLinqClass.ThanhViens select thanhvien;
            List<ThanhVien> listThanhVien = new List<ThanhVien>();
            foreach (var item in result)
            {
                listThanhVien.Add(item);
            }
            return listThanhVien;

        }
    }
}
