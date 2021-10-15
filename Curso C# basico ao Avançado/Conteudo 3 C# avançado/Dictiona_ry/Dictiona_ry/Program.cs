using System;
using System.Collections.Generic;
namespace Dictiona_ry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["user-1"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "999999965";
            cookies["phone"] = "8506340";
            cookies.Add("user-2", "matheus henrique");

            Console.WriteLine(cookies["email"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine("size: " + cookies.Count);

            Console.WriteLine("\nALL COKIES:");

            foreach(KeyValuePair<string, string> item in cookies) // pode tambem utilizar var ao inves de KeyValuePair
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

        }
    }
}
