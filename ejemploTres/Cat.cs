using System;

namespace ejemploTres
{
    class Cat : DomesticAnimal
    {
        private string Reflejo { get; set; }

        //Implementar el metodo abstract
        public override string Sound(){
            return "Miau Miauuuuu Miauuuuu!!!";
        }
    }
}