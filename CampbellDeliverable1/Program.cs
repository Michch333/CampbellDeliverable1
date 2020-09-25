using System;
using System.Runtime.InteropServices.ComTypes;
using System.Text.RegularExpressions;

namespace CampbellDeliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool HasExclamation(string _password)
            {
                int numberOfExclamation = 0;
                foreach (char e in _password)
                {
                    if (e == '!')
                    {
                        numberOfExclamation++;
                    }
                }
                if (numberOfExclamation > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            bool HasEnoughChar(string _password, int _passMin, int _passMax)
            {
                int passwordLength = 0;
                foreach (char e in _password)
                {
                    passwordLength++;
                }
                if (passwordLength >= _passMin && passwordLength <= _passMax)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


            bool HasCapital(string _password)
            {
                Boolean containsCapital = false;
                foreach (char e in _password)
                {
                    if (Char.IsUpper(e))
                    {
                        containsCapital = true;
                    }
                }
                if (containsCapital == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            bool HasLower(string _password)
            {
                Boolean containsLower = false;
                foreach (char e in _password)
                {
                    if (Char.IsLower(e))
                    {
                        containsLower = true;
                    }
                }
                if (containsLower == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            Console.WriteLine("Please create a password with the following requirements: <br/>7-12 characters, at least one lower case AND upper case letter, and an exclamation point (!).");
            string password = Console.ReadLine();
            Boolean passwordIsValid = false;
            if (HasExclamation(password) == true && HasEnoughChar(password, 7, 12) == true && HasCapital(password) == true && HasLower(password) == true) {
                passwordIsValid = true;
            }
            if (passwordIsValid == false)
            {
                Console.WriteLine("Error");
            }
            else {
                Console.WriteLine("Password valid and accepted");
            }
        }
    }
}
