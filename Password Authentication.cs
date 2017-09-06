using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Authentication
{
    class Program
    {
        static void Main(string[] args)
        {
            String username = "", password = "";
            int attempts = 0;

            while (attempts < 3 && (username != "root" && password != "letmein"))
            {
                Console.WriteLine("Enter a username: ");
                username = Console.ReadLine();
                Console.WriteLine("Enter a password: ");
                password = Console.ReadLine();
                attempts++;
            }
            if (username == "root" && password == "letmein")
            {
                Console.WriteLine("Login successful!");
            }
            else Console.WriteLine("Too many incorrect login attempts! Try again later.");
        }
    }
}
