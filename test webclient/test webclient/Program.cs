using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Collections.Specialized;

namespace test_webclient
{
    public class CookieExample
    {

        public string uriString = "https://www.newyorkpizza.nl/inloggen?ReturnUrl=%2F";

        public static void Main(string[] args)
        {
            WebClient newyork = new WebClient();
            newyork.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

            string postData = "";
            newyork.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

            // Display the headers in the request
            Console.Write("Resulting Request Headers: ");
            Console.WriteLine(newyork.Headers.ToString());

            // Apply ASCII Encoding to obtain the string as a byte array.

            byte[] byteArray = Encoding.ASCII.GetBytes(postData);
            Console.WriteLine("Uploading to {0} ...", uriString);
            // Upload the input string using the HTTP 1.0 POST method.
            byte[] responseArray = newyork.UploadData(uriString, "POST", byteArray);

            // Decode and display the response.
            Console.WriteLine("\nResponse received was {0}",
                  Encoding.ASCII.GetString(responseArray));
        }
    }
}
