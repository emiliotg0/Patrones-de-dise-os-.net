using System;

namespace Prototype_Shalloq
{
    class Program
    {
        static void Main(string[] args)
        {
            //objeto primario
            Animal animal = new Animal() { nombre = "Perro Firulais", Patas = 4 };
            //objeto clonado
            Animal animalclon = animal.Clone() as Animal;
            animalclon.nombre = "Gato misu";
            animalclon.Patas = 3;

            Console.WriteLine(animal.nombre+" Tiene:"+animal.Patas+" Patas");
            Console.WriteLine(animalclon.nombre + " Tiene:" + animalclon.Patas + " Patas");
        }
    }
}
