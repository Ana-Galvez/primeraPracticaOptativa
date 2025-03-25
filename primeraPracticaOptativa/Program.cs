using System;

namespace primeraPracticaOptativa
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrecioConGanancia();
            //CampeonatoEstudiantil();
            //SumaDeLaCifra();
            PorcentajeAportado();
        }

        //1 El precio de los productos no tiene incluido el incremento del 15% que representa la ganancia del negocio, por lo tanto, el algoritmo debe calcular
        //el precio final a abonar por un cliente. Se ingresa el precio del producto y como resultado muestra el precio de venta.
        static void PrecioConGanancia() 
        { 
            Console.WriteLine("Ingrese el precio bruto");// ver menor a 0
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
        //3 Modifica la salida de la resolución del punto 2. Se pide mostrar un mensaje que indique si cada participante llegó a la última etapa o no.
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
        //4 Se trata de implementar un programa que sume los dígitos de un número entero no negativo de 4 dígitos.Por ejemplo, la suma de los dígitos del 3433 es 13.
        //Para darle un poco más de emoción, el programa no se limitará a escribir el resultado de la suma,
        //sino que también escribirá todos los sumandos utilizados: 3 + 4 + 3 + 3 = 13.
        //5 Resolver la consiga del punto 4 con la particularidad que el número puede tener cualquier cantidad de dígitos, es decir, puede ser un número de dos dígitos
        //como un número de 6 dígitos. Tomá la codificación anterior e introducí los cambios que sean necesarios.
        static void SumaDeLaCifra()
        {
            Console.WriteLine("Ingrese el número para sumar sus cifras");
            string numeroString=Console.ReadLine();
            uint suma=0;
            string numero="";
            foreach (char item in numeroString)
            {
                suma += uint.Parse(item.ToString());
                numero += item.ToString() + " + ";
            }
            numero = numero.TrimEnd(' ','+');
            Console.WriteLine();
            Console.WriteLine($"{numero} = {suma}");
        }
        //6 Tres personas aportan diferente capital a una sociedad y desean saber el valor total aportado y qué porcentaje aportó cada una (indicando nombre y porcentaje).
        // Para ello, solicitar la carga por teclado del nombre de cada socio, su capital aportado y a partir de esto calcular e informar lo requerido previamente 
        static void PorcentajeAportado()
        {
            string[] socio= new string[3];
            double[] capitalAportado= new double[3];
            int aportantes = 3;
            double capitalTotal=0;
            for (int i = 0; i < aportantes; i++)
            {
                Console.WriteLine("Ingresa el nombre del socio");
                socio[i] = Console.ReadLine();
                Console.WriteLine("Ingresa el capital aportado por este socio");
                capitalAportado[i] = double.Parse(Console.ReadLine());
                capitalTotal += capitalAportado[i];
            }
            Console.WriteLine($"Capital total aportado: ${capitalTotal}");
            for (int i = 0; i < aportantes; i++)
            {
                double porcentaje = (capitalAportado[i]*100)/capitalTotal;
                Console.WriteLine($"El socio {socio[i]} aportó el {porcentaje}%");
            }
        }
    }
}
