using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            String strPassword;
            strPassword = "";
            getPasswordInput();
            
        }
        public static void getPasswordInput()
        {
            Console.WriteLine("Enter the password");
            string Password = Console.ReadLine();
            validatepasswordlength(Password);
        }
        public static void validatepasswordlength(String strPassword)
        {
            if (strPassword.Length < 8 || strPassword.Length > 12)
            {
                Console.WriteLine("Please provide a Password within 8 to 12 characters");
                strPassword = "";
                getPasswordInput();
            }
            else
            {
                Console.WriteLine("You have entered a valid Password");
            }
        }

    }
}
