
using app;
using System;

public
    
    class HelloWorld
{

    public static void Main(string[] args)
    {
        Persona persona1 = new Persona("",15);
        persona1.Nombre = "Brayan";
        persona1.Edad = 17;
        persona1.Peso = 60.5d;
        persona1.Altura = 1.72d;
        Console.Write("la persona:{0} ", persona1.Nombre);
        if (persona1.Esmayor())
            Console.WriteLine("es mayor de edad");
        else
            Console.WriteLine("es menor de edad");
        int respuesta = persona1.CalcularImc();
        if (respuesta == 0)
            Console.WriteLine("la persona esta baja de peso");
        else if (respuesta == 1)
            Console.WriteLine("La persona tiene peso normal");
        else
            Console.WriteLine("la persona tiene sobrepeso");


        
         Console.WriteLine("hola");

        Persona car = new Persona("brayan", "ospina", 60, 17, 1.72);
        Console.WriteLine(car.);
       
    }
}
