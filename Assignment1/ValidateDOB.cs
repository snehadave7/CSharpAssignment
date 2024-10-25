using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment1 {
    internal class ValidateDOB {

        public bool CheckDOB(String DOB) {
            string datePattern = @"^(0[1-9]|[12][0-9]|3[01])-(0[1-9]|1[0-2])-([0-9]{4})$";
            bool check = Regex.IsMatch(DOB, datePattern);
            return check;   
        }
    }
}
