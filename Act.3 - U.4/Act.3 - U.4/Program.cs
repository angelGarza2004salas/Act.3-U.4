public abstract class Animal
{
    public string nombre;
    public int edad;

    public Animal(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

    public void hacerSonido()
    {
        Console.WriteLine("El animal está haciendo un sonido.");
    }

    // Método abstracto que debe ser implementado en las clases derivadas
    public abstract void moverse();
}
public class Perro : Animal
{
    public string raza;

    public Perro(string nombre, int edad, string raza) : base(nombre, edad)
    {
        this.raza = raza;
    }

    public void ladrar()
    {
        Console.WriteLine("El perro está ladrando.");
    }

    // Implementación del método abstracto en la clase derivada
    public override void moverse()
    {
        Console.WriteLine("El perro está corriendo.");
    }
}

// Uso de la clase derivada
public class Program
{
    public static void Main()
    {
        Perro miPerro = new Perro("Fido", 5, "Labrador");
        Console.WriteLine("Nombre: " + miPerro.nombre);
        Console.WriteLine("Edad: " + miPerro.edad);
        Console.WriteLine("Raza: " + miPerro.raza);
        miPerro.hacerSonido();
        miPerro.ladrar();
        miPerro.moverse();
    }
}