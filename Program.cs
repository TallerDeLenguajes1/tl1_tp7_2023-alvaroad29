using EspacioEmpleado;
internal class Program
{
    private static void Main(string[] args)
    {
        Empleado[] empleados= new Empleado[3];

        empleados[0] = new Empleado("nombre1","apellido1",DateTime.Parse("01/01/1980"),'S','M',DateTime.Parse("01/01/2005"),312930.12,Empleado.Cargos.Administrativo);
        empleados[1] = new Empleado("nombre2","apellido2",new DateTime(1981,5,23),'C','M',new DateTime (2008,3,2),65000,Empleado.Cargos.Especialista);
        empleados[2] = new Empleado("nombre3","apellido3",new DateTime(1999,8,1),'S','M',new DateTime (2021,7,2),80123.123,Empleado.Cargos.Auxiliar);

        System.Console.WriteLine("<<<<<<<<<<< DATOS DE TODOS LOS EMPLEADOS >>>>>>>>>>>");
        foreach (var item in empleados)
        {
            item.mostrarDatos();
            System.Console.WriteLine("----------------------------");
        }

        // monto total (suma de los salario de todos los empleados)
        double montoTotal = 0;
        foreach (var item in empleados)
        {
            montoTotal += item.salario();
        }
        System.Console.WriteLine("<<<<<<<<<<<<<<<< Monto total >>>>>>>>>>>");
        System.Console.WriteLine(montoTotal);

        /*-------- Mas proximo a jubilarse -------  */
        System.Console.WriteLine("<<<<<<<<<<< Empleado mas proximo a jubilarse >>>>>>>>>>>>");
        Empleado masProximo = empleados[0];
        foreach (var item in empleados)
        {
            if (item.tiempoJubilacion() <  masProximo.tiempoJubilacion())
            {
                masProximo = item;
            }
        }

        masProximo.mostrarDatos();
    }
}