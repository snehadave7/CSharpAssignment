using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment1 {
    internal class ValidateEmail {
        public bool CheckEmail(string email) {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov|in)$";

            bool check = Regex.IsMatch(email, emailPattern);
            return check;
        }

    }
}
