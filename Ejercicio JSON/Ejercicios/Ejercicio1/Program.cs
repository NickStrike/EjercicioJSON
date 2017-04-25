//puedo bajar cualquier tipo de biblioteca de programacion (conjunto de clases), hay que bajar el .dll. (no tocar el codigo fuente), seleccionar la version compatible con mi programa y vincular el .dll y tildar 
//para hacer esto, en explorador de soluciones ir a referencias, agregar referencia, ver version arriba y examinar. de ahi llegas solito. 
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
            string titulo;

            titulo = Console.ReadLine();
            titulo.ToLower();

            WebRequest req = WebRequest.Create("http://www.omdbapi.com/?t=" + titulo);

            WebResponse respuesta = req.GetResponse();

            Stream stream = respuesta.GetResponseStream();

            StreamReader sr = new StreamReader(stream);

            JObject data = JObject.Parse(sr.ReadToEnd());

            string ano = (string)data["Year"];

            Console.WriteLine(ano);
            Console.ReadLine();

        }

    }
}
