using System;

namespace SENOVA
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int puntaje = 0;

            Proyecto miproyecto = new Proyecto();
            Proyecto miproyecto2 = new Proyecto();
            Proyecto miproyecto3 = new Proyecto();
            Proyecto miproyecto4 = new Proyecto("Realidad Aumentada",15664,"Sistemas",15);
            Proyecto miproyecto5 = new Proyecto("Talento Humano", 10);

            //miproyecto3.IngresarProyecto();
            //miproyecto3.ImprimirProyecto();
            //miproyecto4.ImprimirProyecto();
            miproyecto5.ImprimirProyecto();

            //miproyecto.Area = "Sistemas";
            //miproyecto.Code = 12000;
            //miproyecto.Duration = 13;
            //miproyecto.Name = "Developing of Internet of things IOT";
            //miproyecto2.Area = "System";
            //miproyecto2.Code = 1804643;
            //miproyecto2.Name = "ADSI";
            //miproyecto2.Duration = 24;
            //Console.WriteLine("Area" + miproyecto.Area);
            //Console.WriteLine("Code" + miproyecto.Code);
            //Console.WriteLine("Duration" + miproyecto.Duration);
            //Console.WriteLine("Name" + miproyecto.Name);
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine($" Area {miproyecto.Area}\n Code {miproyecto.Code}\n Duration {miproyecto.Duration}\n Name{miproyecto.Name}");
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine($" Area 2: {miproyecto2.Area}\n Code 2: {miproyecto2.Code}\n Duration 2: {miproyecto2.Duration}\n Name 2: {miproyecto2.Name}");
            Console.ReadLine();
        }
    }
}
