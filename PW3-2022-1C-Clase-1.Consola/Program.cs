﻿using PW3_2022_1C_Clase_1.Entidades;
using System;

namespace PW3_2022_1C_Clase_1.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la bola 8!");
            Console.WriteLine("Ingrese su pregunta");
           
            string pregunta = Console.ReadLine();

            Console.WriteLine($"{Respuestas.Respuesta()}");
            Console.ReadKey();
        }
    }
}
