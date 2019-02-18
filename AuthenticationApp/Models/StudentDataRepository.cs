using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthenticationApp.Models
{
    public class StudentDataRepository : IStudentDataRepository
    {
        public StudentDataEntities DBContext { get; set; }

        public StudentDataRepository()
        {
            this.DBContext = new StudentDataEntities();
        }

        public List<Student> getStudentData()
        {
            return this.DBContext.Students.ToList();
        }
    }
}