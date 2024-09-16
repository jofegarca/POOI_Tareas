using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare, cree e inicialice un objeto de tipo Video (con datos fijos)
            Video video = new Video(123, "Video de prueba", 30.0, 50.0, 3.5);

            // Invoque a un método listado que reciba la referencia a un objeto de tipo Video y visualice sus datos completos
            MostrarDatosVideo(video);

            // Aumente en 5.50 el precio del video
            video.PrecioSoles += 5.50;

            // Invoque nuevamente al método listado
            MostrarDatosVideo(video);

            Console.ReadLine();
        }

        static void MostrarDatosVideo(Video video)
        {
            Console.WriteLine("Código: " + video.Codigo);
            Console.WriteLine("Nombre del video: " + video.NombreVideo);
            Console.WriteLine("Duración: " + video.Duracion);
            Console.WriteLine("Precio en soles: " + video.PrecioSoles);
            Console.WriteLine("Tipo de cambio: " + video.TipoCambio);
            Console.WriteLine("Precio en dólares: " + video.PrecioDolares()+"\n");
            Console.WriteLine("--------------------------------------------------- \n");
        }
    }
}
