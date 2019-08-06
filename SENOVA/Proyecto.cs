using System;
using System.Collections.Generic;
using System.Text;

namespace SENOVA
{
    public class Proyecto
    {
        #region Atributos
        #endregion
        #region Propiedades
        public string Name { get; set; }
        public double Code { get; set; }
        public string Area { get; set; }
        public int Duration { get; set; }
        #endregion
        #region Contructores
        public Proyecto(string nombre, double codigo, string area, int duracion)
        {
            Name = nombre;
            Code = codigo;
            Area = area;
            Duration = duracion;
        }
        public Proyecto()
        {

        }
        public Proyecto( string area, int duracion)
        {
       
            Area = area;
            Duration = duracion;
        }
        #endregion
        #region Metodos
        public void IngresarProyecto()
        {
            Console.WriteLine("Ins¿grese el nombre delproyecto");
            Name = Console.ReadLine();
            Console.WriteLine("Ingrese el codigo");
            Code = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Area del proyecto");
            Area = Console.ReadLine();
            Console.WriteLine("Ingrese la duracion del proyecto");
            var Dura = Console.ReadLine();
            Duration = int.Parse(Dura);
        }

        public void ImprimirProyecto()
        {
            Console.WriteLine($"Name {Name}\n Code {Code}\n Area IP {Area}\n Duration {Duration}");
        }
        #endregion
    }
}