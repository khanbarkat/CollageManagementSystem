using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
   public class Patterns
    {
        public static string contactpattern = @"^(0|\+92)(3\d{2}-?\d{7})$";
        public static string cnicpattern = @"^(\d{5}-\d{7}-\d)|(\d{13})$";
    }
}
