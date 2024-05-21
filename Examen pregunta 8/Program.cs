using System;

namespace worlddd
{
    class Program
    {
        interface Pais
        {
            //métodos abstractos
            void colorbandera();
            void size();
            void idioma();


        }
        //implementacion de clases
        class Ecuador : Pais
        {
            public void colorbandera()
            {
                Console.WriteLine("TRICOLOR,amarillo,azul,rojo");
            }
            public void size()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("283.561 km²");
            }
            public void idioma()
            {
                Console.WriteLine("Españolo");
            }

        }
        class Brasil : Pais
        {
            public void colorbandera()
            {
                Console.WriteLine("amarillo,verde, azul");
            }
            public void size()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("8,51 millones km²");
            }
            public void idioma()
            {
                Console.WriteLine("Portuguez");
            }

        }
        class Andorra : Pais
        {
            public void colorbandera()
            {
                Console.WriteLine("azul,amarillo,rojo");
            }
            public void size()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("468 km²");
            }
            public void idioma()
            {
                Console.WriteLine("Catalán");
            }

        }



        static void Main(string[] args)
        {
            //aplicacion de crear cualquier animal en base de las clases heredadas con sus metodos de "ANIMAL" y propios
            Console.WriteLine("Color de la bandera de Ecuador:");
            Ecuador Ecu = new Ecuador();
            Ecu.colorbandera();
            Console.WriteLine("Tamaño de Andorra:");
            Andorra andoria = new Andorra();
            andoria.size();
            Console.WriteLine("Idioma de Brasil:");
            Brasil Brasilia = new Brasil();
            Brasilia.idioma();


        }


    }
}
