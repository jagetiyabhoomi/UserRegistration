using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegxDemo
{
    public class Patterns
    {
        public String REGX_FNAME = "^[A-Z]{1}[A-Z a-z]{3,}$";
        public String REGX_LNAME = "^[A-Z]{1}[A-Z a-z]{3,}$";
        public String REGX_PHONE = "^91( )+[7-9]{1}?[0-9]{9}?$";
        public String REGX_PASS = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[@$!%*#?&])[a-zA-Z0-9@$!%*#?&]{8,}$";
        public String REGX_EMAIL = "^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$";
        public bool boolvalidateEmail(string email)
        {
            return Regex.IsMatch(email, REGX_EMAIL);
        }
        public bool boolvalidateFname(string Fname)
        {
            return Regex.IsMatch(Fname, REGX_FNAME);
        }
        public bool boolvalidateLname(string Lname)
        {
            return Regex.IsMatch(Lname, REGX_LNAME);
        }
        public bool boolvalidatePhone(string phone)
        {
            return Regex.IsMatch(phone, REGX_PHONE);
        }
        public bool boolvalidatePassword(string pass)
        {
            return Regex.IsMatch(pass, REGX_PASS);
        }
    }
}
