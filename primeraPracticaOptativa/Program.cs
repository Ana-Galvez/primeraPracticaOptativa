﻿using System;

namespace primeraPracticaOptativa
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrecioConGanancia();
            CampeonatoEstudiantil();
        }

        //1 El precio de los productos no tiene incluido el incremento del 15% que representa la ganancia del negocio, por lo tanto, el algoritmo debe calcular
        //el precio final a abonar por un cliente. Se ingresa el precio del producto y como resultado muestra el precio de venta.
        static void PrecioConGanancia() 
        { 
            Console.WriteLine("Ingrese el precio bruto");
            string precioString=Console.ReadLine();
            double precioBruto;
            while(!double.TryParse(precioString, out precioBruto))
            {
                Console.WriteLine("Verifique haber ingresado correctamente una cifra");
                Console.WriteLine("Ingrese el precio bruto");
                precioString = Console.ReadLine();
            }
            Console.WriteLine($"El precio total a pagar es: ${precioBruto + precioBruto * 0.15}");
        }

        //2 En el campeonato estudiantil llegan a la última etapa los participantes que superen los 80 puntos.El algoritmo pide el nombre de cada participante y la puntuación
        //de los 3 jurados.Debe mostrar el nombre y el puntaje total de cada participante.Nota: cuando se ingrese "FIN" en el nombre del participante finaliza nuestro programa.
        static void CampeonatoEstudiantil()
        {
            Console.WriteLine("Ingrese el nombre del estudiante");
            string nombre = Console.ReadLine();

                while (nombre != "FIN")
                {
                    if(nombre != "") 
                    { 
                        Console.WriteLine("Ingrese el puntaje del primer jurado");
                        string puntajePrimerJurado = Console.ReadLine();
                        int puntaje1;
                        Console.WriteLine("Ingrese el puntaje del segundo jurado");
                        string puntajeSegundoJurado = Console.ReadLine();
                        int puntaje2;
                        Console.WriteLine("Ingrese el puntaje del tercer jurado");
                        string puntajeTercerJurado = Console.ReadLine();
                        int puntaje3;
                        int resultado;
                        while (!int.TryParse(puntajePrimerJurado, out puntaje1))
                        {
                            Console.WriteLine("Verifique haber ingresado correctamente los puntajes");
                            Console.WriteLine("Ingrese el puntaje del primer jurado");
                            puntajePrimerJurado = Console.ReadLine();
                        }
                        while (!int.TryParse(puntajeSegundoJurado, out puntaje2))
                        {
                            Console.WriteLine("Verifique haber ingresado correctamente los puntajes");
                            Console.WriteLine("Ingrese el puntaje del segundo jurado");
                            puntajeSegundoJurado = Console.ReadLine();
                        }
                        while (!int.TryParse(puntajeTercerJurado, out puntaje3))
                        {
                            Console.WriteLine("Verifique haber ingresado correctamente los puntajes");
                            Console.WriteLine("Ingrese el puntaje del tercer jurado");
                            puntajeTercerJurado = Console.ReadLine();
                        }
                        resultado = puntaje1 + puntaje2 + puntaje3;
                        Console.WriteLine($"El nombre del estudiante es: {nombre}");
                        Console.WriteLine($"Su puntuación total fue de {resultado}");
                        if (resultado > 80) Console.WriteLine("Felicidades pasaste a la última etapa");
                        else Console.WriteLine("Lamentablemente no superaste esta etapa");
                        Console.WriteLine();
                        Console.WriteLine("Ingrese el nombre del estudiante");
                        nombre = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Nombre vacío, escriba de nuevo");
                        nombre = Console.ReadLine();
                    }
                }
        }
    }
}
