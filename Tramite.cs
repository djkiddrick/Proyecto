using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tramite :Persona
    {
        public Tramite(Animal animal, Persona persona) 
        {
            persona.setNombre("Ricardo");
            animal.setRaza("Perro");

            Console.WriteLine("Señor(a): " + persona.getNombre() + "\nHaz adoptado a un: " + animal.getTipo());
            Console.WriteLine("Gracias.");
            Console.ReadKey();
        }
    }
}
