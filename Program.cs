using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program : Persona
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Persona persona = new Persona();
            string respuesta;


            Console.WriteLine("¿Como te llamas?");
            persona.getNombre();
            Console.ReadLine();
            Console.WriteLine("¿Que edad tienes?");
            persona.getEdad();
            Console.ReadLine();
            Console.WriteLine("¿Que animal buscas?");
            animal.getTipo();
            Console.ReadLine();
            Console.WriteLine("¿Que raza?");
            animal.getRaza();
            Console.ReadLine();
            Console.WriteLine("¿Deseas hacer el tramite de adopcion, Si/No?");
            respuesta = Console.ReadLine();
            Tramite tramite = new Tramite(animal, persona);
        
    }
    }
}
