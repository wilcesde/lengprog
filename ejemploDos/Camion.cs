using System;

namespace ejemploDos
{
    class Camion : Vehiculo
    {
        //Propiedades especificas de camion
        string tipoR;
        public string Remolque {
            get { return tipoR; }
            set {
                //string tipoRemolque = value;
                switch (value.ToLower())
                {
                    case "camabaja":
                        tipoR = value;
                        break;
                    case "Estacas":
                        tipoR = value;
                        break;
                    case "Contenedor":
                        tipoR = value;
                        break;
                    case "Sisterna":
                        tipoR = value;
                        break;
                    case "Planchon":
                        tipoR = value;
                        break;
                    case "Ninera":
                        tipoR = value;
                        break;
                    default:
                        Console.WriteLine($"Remolque no existe, por favor verificar");
                        break;
                }
            }
        }

        //Metodos
        public void mostrarDatos()
        {
            Console.WriteLine(Serie);
        }

        public string listarRuta()
        {
            return Ruta.ToString();
        }
    }
}