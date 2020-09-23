using System;

namespace ejemploDos
{
    class Taxi : Vehiculo
    {
        //Propiedad
        private short Banderazo { get; set; }

        //metodo

        public string listarRuta()
        {
            return Ruta.ToString();
        }

        public short valorPagar(short valorRecorrido)
        {
            short totalPagar = Banderazo;

            totalPagar += valorRecorrido;

            return totalPagar;
        }
    }
}