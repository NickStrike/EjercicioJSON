using System;
using System.Net;
using System.IO;

using Newtonsoft.Json.Linq;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            string ciudad;
            ciudad = Console.ReadLine();
            ciudad.ToLower();

            WebRequest req2 = WebRequest.Create("https://maps.googleapis.com/maps/api/geocode/json?address=" + ciudad);

            WebResponse response = req2.GetResponse();

            Stream stream2 = response.GetResponseStream();

            StreamReader streamReader = new StreamReader(stream2);

            JObject datos = JObject.Parse(streamReader.ReadToEnd());

            string pais = (string)datos["results"][0]["address_components"][2]["long_name"];

            Console.WriteLine(pais);
            Console.ReadLine();


        }
    }
}
