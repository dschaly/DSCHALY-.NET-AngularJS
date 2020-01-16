using DSCHALY.DTO.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using System.Text.Json

namespace DSCHALY.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Show_Data()
        {
            return View();
        }

        public ActionResult update_data(int id)
        {
            return View();
        }

        public JsonResult Get_Data_By_Id(int id)
        {
            var registers = new List<Register>()
            {
                new Register
                {
                    Sr_no = 1,
                    Name = "Davidson",
                    Email = "davidson.schaly@gmail.com",
                    Address = "Avenida Rio Branco, 80",
                    City = "Rio de Janeiro",
                    Password = "123456"
                },

                new Register
                {
                    Sr_no = 2,
                    Name = "Carlton",
                    Email = "carlton.banks@gmail.com",
                    Address = "Avenida Rio Branco, 80",
                    City = "Rio de Janeiro",
                    Password = "dancingonmyown"
                },

                new Register
                {
                    Sr_no = 3,
                    Name = "Sephirot",
                    Email = "genova_sephirot@gmail.com",
                    Address = "Avenida Rio Branco, 80",
                    City = "Rio de Janeiro",
                    Password = "clouddies"
                },

                new Register
                {
                    Sr_no = 4,
                    Name = "Ezio Auditore",
                    Email = "ezio_firenze@gmail.com",
                    Address = "Avenida Rio Branco, 80",
                    City = "Rio de Janeiro",
                    Password = "requiescateinpace"
                },

                new Register
                {
                    Sr_no = 5,
                    Name = "Samael;",
                    Email = "morningstar_thesun@gmail.com",
                    Address = "Avenida Rio Branco, 80",
                    City = "Rio de Janeiro",
                    Password = "demiurgo"
                }
            };

            foreach (var item in registers)
            {
                if (item.Sr_no == id)
                    return Json(item, JsonRequestBehavior.AllowGet);
            }

            return null;
        }

        public JsonResult Test()
        {
            var result = new Register
            {
                Name = "Davidson",
                Email = "davidson.schaly@gmail.com"
            };

            return Json(result, JsonRequestBehavior.AllowGet);
            
        }

        public JsonResult Get_Data()
        {
            var registers = new List<Register>()
            {
                new Register
                {
                    Sr_no = 1,
                    Name = "Davidson",
                    Email = "davidson.schaly@gmail.com",
                    Address = "Avenida Rio Branco, 80",
                    City = "Rio de Janeiro",
                    Password = "123456"
                },

                new Register
                {
                    Sr_no = 2,
                    Name = "Carlton",
                    Email = "carlton.banks@gmail.com",
                    Address = "Avenida Rio Branco, 80",
                    City = "Rio de Janeiro",
                    Password = "dancingonmyown"
                },

                new Register
                {
                    Sr_no = 3,
                    Name = "Sephirot",
                    Email = "genova_sephirot@gmail.com",
                    Address = "Avenida Rio Branco, 80",
                    City = "Rio de Janeiro",
                    Password = "clouddies"
                },

                new Register
                {
                    Sr_no = 4,
                    Name = "Ezio Auditore",
                    Email = "ezio_firenze@gmail.com",
                    Address = "Avenida Rio Branco, 80",
                    City = "Rio de Janeiro",
                    Password = "requiescateinpace"
                },

                new Register
                {
                    Sr_no = 5,
                    Name = "Samael;",
                    Email = "morningstar_thesun@gmail.com",
                    Address = "Avenida Rio Branco, 80",
                    City = "Rio de Janeiro",
                    Password = "demiurgo"
                }
            };

            return Json(registers, JsonRequestBehavior.AllowGet);
        }
    }
}