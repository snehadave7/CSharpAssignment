using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment1 {
    internal class ValidatePhoneNum {

        public bool ValidatePhone(string num) {
            string mobilePattern = @"\d{3}-\d{3}-\d{4}";

            bool check=Regex.IsMatch(num, mobilePattern);
            return check;
        }
    }
}
