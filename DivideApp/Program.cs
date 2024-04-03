using System;

class ClassDivide
{
    static void Main(string[] args)
    {
        //Ejemplo de uso del metodo DivideNum.
        int Num1 = 15;
        int Num2 = 3;
        double ResultadoDiv = DivideNum(Num1, Num2);

        //Condicional indicando el mensaje a mostrar en consola.
        if(ResultadoDiv == 0) 
        {
            Console.WriteLine("No es posible dividir por 0");
        }
        else
        {
            Console.WriteLine("El resultado de la división es: " + ResultadoDiv);
        }
        
    }
    
    static double DivideNum(int Num1, int Num2)
    {
        //Condicional para evitar la divisón por 0.
        if (Num2 == 0)
        {            
            return 0;
        }
        //Se realiza la operación y se retorna el resultado.
        return (double)Num1 / Num2;
    }
}
