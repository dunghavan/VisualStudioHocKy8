using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIdotNET.Models;
using System.Web.Mvc;

namespace WebAPIdotNET.Controllers
{
    public class NhanVienController : ApiController
    {
        myLinqClassDataContext _myLinqClass = new myLinqClassDataContext();
        public IEnumerable<NhanVien> getAllNhanVien()
        {
            var results = from nhanvien in _myLinqClass.NhanViens select nhanvien;
            List<NhanVien> listNhanVien = new List<NhanVien>();
            listNhanVien.AddRange(results);
            //foreach(var item in results)
            //{
            //    NhanVien nv = new NhanVien();
            //    nv.MaNV = item.MaNV;
            //    nv.MatKhau = item.MatKhau;
            //    nv.DiaChi = item.DiaChi;
            //    nv.Email = item.Email;
            //    nv.TaiKhoan = item.TaiKhoan;
            //    nv.Ten = item.Ten;

            //    listNhanVien.Add(nv);
            //}

            return listNhanVien;
        }

    }
}
