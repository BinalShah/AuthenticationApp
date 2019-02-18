using AuthenticationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthenticationApp.Controllers
{
    public class HomeController : Controller
    {
        protected IStudentDataRepository StudentDataRepository { get; set; }

        public HomeController() : base()
        {
            this.StudentDataRepository = new StudentDataRepository();
        }

        [Authorize]
        public ActionResult Index()
        {
            List<Student> studentList = new List<Student>();
            studentList = StudentDataRepository.getStudentData();
            return View("Index", studentList);
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
    }
}