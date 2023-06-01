using EspacioCalculadora;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Calculadora cal = new Calculadora(); //creo un objeto del tipo Calculadora con el nombre cal

        //--------interfaz-------
        int op = 1;
        double num1;

        do
        {
            do
            {
                Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><>");
                Console.WriteLine("<>   Ingrese la operacion a realizar:       <>");
                Console.WriteLine("<>   0-Salir                                <>");
                Console.WriteLine("<>   1-Suma                                 <>");
                Console.WriteLine("<>   2-Resta                                <>");
                Console.WriteLine("<>   3-Multiplicacion                       <>");
                Console.WriteLine("<>   4-Division                             <>");
                Console.WriteLine("<>   5-Limpiar                              <>");
                Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><>");
            } while (!int.TryParse(Console.ReadLine(),out op) || op < 0 || op > 5); //si ingreso un texto o un valor que no este en el rango seguir iterando

            if (op != 0)
            {
                do
                {
                    Console.WriteLine("<<<< Ingrese un numero >>>>");  
                } while (!double.TryParse(Console.ReadLine(),out num1));

                switch (op)
                {
                    case 1:
                        cal.Sumar(num1);
                        Console.WriteLine("\nSuma : " + cal.Resultado + "\n");
                        break;

                    case 2:
                        cal.Restar(num1);
                        Console.WriteLine($"\nResta: {cal.Resultado}");
                        break;

                    case 3:
                        Console.WriteLine($"\nProducto:{cal.Resultado}\n");
                        break;

                    case 4:
                        Console.WriteLine($"\nDivision: {cal.Resultado}\n");
                        break;
                    case 5:
                        cal.Limpiar();
                        Console.WriteLine($"\nDivision: {cal.Resultado}\n");
                        break;
                }

                do
                {
                    Console.WriteLine("<<<< Desea continuar? SI[1] / NO[0] >>>>");
                } while (!int.TryParse(Console.ReadLine(),out op) || op < 0 || op > 1);
            }
        } while (op != 0);
    }
}