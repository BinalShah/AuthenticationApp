using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationApp.Models
{
  public interface IStudentDataRepository
    {
        List<Student> getStudentData();
    }
}
