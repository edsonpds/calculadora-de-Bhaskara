using System;

class Program

{
    static void Main()
    {
        
        Console.Write ("Informar o valor de A: ");
        double valorA= Convert.ToDouble(Console.ReadLine());
        Console.Write ("Informar o valor de B: ");
        double valorB= Convert.ToDouble(Console.ReadLine());
        Console.Write ("Informar o valor de C: ");
        double valorC= Convert.ToDouble(Console.ReadLine());
        

        double delta = (valorB * valorB) -(4 * valorA *valorC); 


        Console.WriteLine("valor de delta =>"+ delta +"!!!");

        if (delta < 0){
            Console.WriteLine("Se delta negativo,não existe raizes reais. ");
          
        }else{
            Console.WriteLine("se delta positivo,raizes diferente:");

            double coeficiente1 = (-valorB + Math.Sqrt(delta)) /(2 * valorA);
            double coeficiente2 = (-valorB - Math.Sqrt(delta)) / (2 * valorA );

            Console.WriteLine($"x'={coeficiente1}");
            Console.WriteLine($"x'={coeficiente2}");
        }

    }
}

