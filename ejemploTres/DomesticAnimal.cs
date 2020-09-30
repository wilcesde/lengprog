using System;

namespace ejemploTres
{
    abstract class DomesticAnimal
    {
        //prop
        public string Animal_Type { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }

        //func
        public void Eat()
        {
            Console.WriteLine("Is eating");
        }

        //Metodos abstractos. Solo se le define su estructura
        //La class debe ser abstracta
        //Este metodo debe ser implementado (usado) en las class hijas
        public abstract string Sound();
    }
}