using System;

class Notas
{
    static void Main(string[] arg)
    {
        Console.WriteLine("Sistema de  Calculo de Notas");
        Console.WriteLine("Favor ingresa su Nota");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Favor ingrese el el nombre de la Asignatura");
        string Asignatura = Console.ReadLine();
        Console.WriteLine("Ingresa la Primera Nota del Parcial");
        int Nota1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa la segunda Nota del Parcial");
        int Nota2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa la Tercera Nota del Parcial");
        int Nota3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa la Cuarta Nota del Parcial");
        int Nota4 = Convert.ToInt32(Console.ReadLine());
        int Promedio = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

        if (Promedio <= 70)
        {
            Console.WriteLine("Usted esta Reprobado");
            Console.ReadKey();
        }
        if (Promedio > 70 & Promedio <= 80)
        {
            Console.WriteLine("Usted esta en la categoria de Bueno");
            Console.ReadKey();
        }

        if (Promedio > 80 & Promedio <= 90)
        {
            Console.WriteLine("Usted esta en la categoria de Muy Bueno");
            Console.ReadKey();
        }
        if (Promedio > 90 & Promedio <= 100)
        {
            Console.WriteLine("Usted es Sobresaliente");
            Console.ReadKey();
        }

    }

}