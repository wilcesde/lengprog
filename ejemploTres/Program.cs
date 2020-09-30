using System;

namespace ejemploTres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animal Planet!");
            Console.WriteLine("Animal Type:");
            string a_type = Console.ReadLine();
            Console.WriteLine("Animal Breed:");
            string breed = Console.ReadLine();
            Console.WriteLine("Animal Age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Tipo Entrenamiento:");
            string ta = Console.ReadLine();

            Dog dog = new Dog()
            {
                Animal_Type = a_type,
                Breed = breed,
                Age = age
            };

            DomesticAnimal cat = new DomesticAnimal()
            {
                Animal_Type = a_type,
                Breed = breed,
                Age = age
            };

            Console.WriteLine($"{dog.Animal_Type} {dog.Breed}");
            dog.mostrarTE(ta);
            dog.Sound();
            

            Console.WriteLine($"{cat.Animal_Type} {cat.Breed}");
            cat.Sound();
            
        }
    }
}
