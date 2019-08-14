using System;
using System.Collections.Generic;
using System.Text;

namespace SENOVA
{
    public class Proyecto
    {
        #region Atributos
        public List<Proyecto> proyectos = new List<Proyecto>();

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
        public Proyecto(string area, int duracion)
        {

            Area = area;
            Duration = duracion;
        }
        #endregion

        #region Metodos
        public void OrdenarDuracion(int o)
        {
            List<Proyecto> orden = new List<Proyecto>();
            foreach (var item in proyectos)
            {

            }
        }
        public void ObtenerMayores()
        {
            List<Proyecto> pro20 = new List<Proyecto>();
            foreach (var item in proyectos)
            {
                if (item.Code > 20 && item.Code % 2 == 0)
                {
                    pro20.Add(item);
                }
            }
            ImprimirProyecto(pro20);
        }
        public void IngresarProyecto()
        {
            var res = "si";
            while (res == "si")
            {
                Proyecto myproyect = new Proyecto();
                Console.WriteLine("¿Insgrese el nombre del proyecto?");
                myproyect.Name = Console.ReadLine();
                Console.WriteLine("¿Ingrese el codigo?");
                myproyect.Code = double.Parse(Console.ReadLine());
                Console.WriteLine("¿Ingrese el Area del proyecto?");
                myproyect.Area = Console.ReadLine();
                Console.WriteLine("¿Ingrese la duracion del proyecto?");
                var Dura = Console.ReadLine();
                myproyect.Duration = int.Parse(Dura);
                proyectos.Add(myproyect);
                Console.WriteLine("¿Desea agregar otro proyecto?");
                res = Console.ReadLine();
            }
        }
        public void ImprimirProyecto(List<Proyecto> proyecto1)
        {
            foreach (var item in proyecto1)
            {
                Console.WriteLine($"Name of proyect {item.Name}\n Code of proyect {item.Code}\n Area of proyect {item.Area}\n Duration of proyect {item.Duration}");
            }
        }
        #endregion
    }
}