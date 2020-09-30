using System;

namespace ejemploTres
{
    class Dog : DomesticAnimal
    {
        private string Tipo_Entrenamiento { get; set; }

        public void mostrarTE(string TA){
            Tipo_Entrenamiento = TA;
            Console.WriteLine($"El tipo es: {Tipo_Entrenamiento}");
        }

        public override string Sound(){
            return "Guaau Guauuuuu Guauuuuu!!!";
        }
       
    }    
}