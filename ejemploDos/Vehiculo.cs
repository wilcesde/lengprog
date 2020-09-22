using System;

namespace ejemploDos
{
    class Vehiculo
    {
        //Propiedades
        public string Marca { get; set; }
        public string Serie { get; set; }

        //Ej concatenar propiedades (Marca y Serie)

        short modelo;
        public short Modelo { 
            get
            {
                return modelo;
            }
            set
            {
                if (value > 2017 && value < 2022)
                {
                    modelo = value;
                }
                else
                {
                    Console.WriteLine("Modelo no valido");
                }                
            }
        }


        string placa;
        public string Placa {
            get
            {
                return placa;
            }
            set
            {
                if (value.Length == 6)
                {
                    placa = value;
                }
                else
                {
                    Console.WriteLine("La placa debe ser de 6 digitos");
                }
            }
        }


        //Metodos
        public void prender()
        {
            Console.WriteLine("El vehiculo esta prendiendo");        }
    }
}