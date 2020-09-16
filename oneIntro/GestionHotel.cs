using System; // usando una Libreria generica

namespace oneIntro
{
    class GestionHotel
    {
        //propiedades
        public string habitacion { get; set; }
        public int huesped { get; set; }

        int Dias;
        //public int dias { get; set; }
        public int dias { 
            get { return Dias; }
            set
            {
                if (value >= 1)
                {
                    Dias = value;
                } else
                {
                    Console.WriteLine("Cantidad dias deber ser minimo 1");
                }
            }
        }

        
        
        //Metodos
        public int valorEstadia(int huesp, int cantd){
            int TINDIVIDUAL = 2500;
            int TDOBLE = 4600;
            int TFAMILIAR = 5200;

            int cobro = 0;

            if (huesp == 1){
                cobro = cantd * TINDIVIDUAL;
            }
            else {
                if (huesp == 2){
                    cobro = cantd * TDOBLE;
                }
                else {
                    if (huesp >= 3){
                        cobro = cantd * TFAMILIAR;
                    } else{

                    }
                }
            }
            return cobro;
        }

        public void cuentaCobro(){
            int IVA = 19;
            int precioSinIva = 0;
            int precioConIva = 0;
            precioSinIva = valorEstadia(huesped, dias);

            precioConIva = ((precioSinIva * IVA) / 100) + precioSinIva;

            Console.WriteLine(precioConIva);
        }
    }
}