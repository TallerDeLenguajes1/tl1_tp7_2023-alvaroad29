namespace EspacioEmpleado;

public class Empleado
{
    /*====== Campos de una clase ======*/
    private string nombre;
    private string apellido;
    private DateTime fechaNac;
    private char estadoCivil;
    private char genero;
    private DateTime fechaIngreso;
    private double sueldo;
    Cargos cargo;

    /*====== Propiedades ======*/
    //-Funciones que nos permiten acceder a los campos de la clase
    //-Permiten que una clase exponga una manera publica de obtener(get) y establecer(set) valores, a la vez que oculta
    //el código de implementacion
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public char Genero { get => genero; set => genero = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public double Sueldo { get => sueldo; set => sueldo = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }


    /*====== Metodos ======*/

    //constructor
    public Empleado(string nombre,string apellido,DateTime fechaNac,char estadoCivil,char genero,DateTime fechaIngreso,double sueldo,Cargos cargo)
    {
        this.nombre = nombre; //cont this. me estoy refiriendo al campo de la clase
        this.apellido = apellido;
        this.fechaIngreso = fechaIngreso;
        this.fechaNac = fechaNac;
        this.estadoCivil = estadoCivil;
        this.genero = genero;
        this.sueldo = sueldo;
        this.cargo = cargo;
    }

    //enum
    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    public int antiguedad()
    {
        DateTime fechaActual = DateTime.Now;
        TimeSpan antiguedad = fechaActual - fechaIngreso;
        return (int)antiguedad.TotalDays/365; //TotalDays devuelve cantidad de dias 
        /*
        La diferencia clave entre TimeSpan y DateTime es que TimeSpan representa una duración o intervalo de tiempo, mientras que DateTime representa una fecha y hora específicas en el calendario.
        Cuando necesitas calcular la diferencia entre dos fechas, como la antigüedad de un empleado o la duración entre dos eventos, es apropiado utilizar TimeSpan. El resultado de la resta de dos objetos DateTime es un objeto TimeSpan, que representa la diferencia entre las dos fechas en forma de intervalo de tiempo.
        */
    }

    public int edad()
    {
        TimeSpan edad = DateTime.Now - fechaNac;
        return (DateTime.Now.Subtract(fechaNac).Days) / 365;
    }

    public int tiempoJubilacion()
    {   
        if (genero == 'M')
        {
            return 65 - edad();
        }
        else
        {
            return 60 - edad();
        }
    }

    public double salario()
    {
        double adicional;
        if (antiguedad() <= 20)
        {
            adicional = sueldo * (antiguedad()/100.0);
        }else
        {
            adicional = sueldo * 0.20 + sueldo * ((antiguedad()-20)/100.0); //100.0 o 100d para q sea double, sino lo castea a int
        }

        if (cargo == Cargos.Especialista || cargo == Cargos.Ingeniero )
        {
            adicional *= 1.50;
        }

        if (estadoCivil == 'C')
        {
            adicional += 15000;
        }
        return sueldo + adicional;
    }

    public void mostrarDatos()
    {
        Console.WriteLine($"Apellido y nombre: {apellido}, {nombre}");
        Console.WriteLine($"Genero: {genero}");
        Console.WriteLine($"Fecha de nacimiento: {fechaNac.ToShortDateString()}");
        Console.WriteLine($"Edad: {edad()}");
        Console.WriteLine($"Estado civil: {estadoCivil}");
        Console.WriteLine($"Fecha de ingreso: {fechaIngreso.ToShortDateString()}");
        Console.WriteLine($"Sueldo basico: {sueldo.ToString("N2")}"); //con 2 decimales
        Console.WriteLine($"Cargo: {cargo}");
        Console.WriteLine($"Antiguedad: {antiguedad()}");
        Console.WriteLine($"Años para jubilarse: {tiempoJubilacion()}");
        Console.WriteLine($"Salario: {salario().ToString("N2")}");
    }
}

