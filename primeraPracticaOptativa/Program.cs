using System;

namespace primeraPracticaOptativa
{
    class Program
    {
        static void Main(string[] args)
        {
            precioConGanancia();
        }

        //1 El precio de los productos no tiene incluido el incremento del 15% que representa la ganancia del negocio, por lo tanto, el algoritmo debe calcular
        //el precio final a abonar por un cliente. Se ingresa el precio del producto y como resultado muestra el precio de venta.
        public static void precioConGanancia() 
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
            Console.WriteLine($"El precio total a pagar es: ${precioBruto + precioBruto * 0.15}";
        }

    }
}
