namespace EspacioCalculadora;

//tratar de no poner cosas como writeLine dentro de la class
public class Calculadora //mayuscula la primera
{
    //atributos
    private double valor; // valor y usar propiedad

    //constructor
    public Calculadora() 
    {
        valor = 0; //x defecto se crean en 0
    }

    //propiedad
    public double Resultado { get => valor;} //saca el valor
    

    //metodos
    public void Sumar(double termino)
    {
        valor += termino;
    }

    public void Restar(double termino)
    {
        valor -= termino;
    }

    public void Multiplicar(double termino)
    {
        valor *= termino;
    }

    public void Dividir(double termino)
    {
        if (termino != 0)
        {
            valor /= termino;
        }
    }

    public void Limpiar()
    {
        valor = 0;
    }

}

