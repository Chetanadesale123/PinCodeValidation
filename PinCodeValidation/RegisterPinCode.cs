using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PinCodeValidation
{
    public class RegisterPinCode
    {
        //public const string PINCODE_REGEX = "^[0-9]{6,}$";
        // public const string PINCODE_REGEX = "^[A-Z]{1}[0-9]{6}$";
        public const string PINCODE_REGEX = "^[0-9]{6}[A-Z]{1}$";
        public void CheckPin(string pincode)
        {
            if (Regex.IsMatch(pincode, PINCODE_REGEX))
            {
                Console.WriteLine("pincode matches");
            }
            else
            {
                Console.WriteLine("verify pincode again");
            }
        }
    }
}


