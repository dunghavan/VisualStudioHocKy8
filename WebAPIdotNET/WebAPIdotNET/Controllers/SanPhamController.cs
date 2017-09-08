using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIdotNET.Models;

namespace WebAPIdotNET.Controllers
{
    public class SanPhamController : ApiController
    {
        myLinqClassDataContext _myLinqClass = new myLinqClassDataContext();

        public IEnumerable<SanPham> getAllSanPham()
        {
            List<SanPham> listSanPham = new List<SanPham>();
            var results = from sanpham in _myLinqClass.SanPhams select sanpham;

            foreach (var item in results)
            {
                listSanPham.Add(item);
            }
            return listSanPham;
        }
        [HttpGet]
        [ActionName("getAllSanPhamCustom")]
        public IEnumerable<SanPhamCustom> getAllSanPhamCustom()
        {
            List<SanPhamCustom> listSanPham = new List<SanPhamCustom>();
            var results = from sanpham in _myLinqClass.SanPhamCustoms select sanpham;
            foreach (var item in results)
            {
                listSanPham.Add(item);
            }
            return listSanPham;
        }
    }
}
