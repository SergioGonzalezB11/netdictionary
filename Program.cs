using System.Data;
using netdictionary;

internal class Program
{
    private static void Main(string[] args)
    {
        Persona person = new Persona();
        DiccDemo dicc = new DiccDemo();
        Console.Clear();
        Console.WriteLine("Ingrese Documento");
        person.Id = Console.ReadLine();
        Console.WriteLine("Ingrese Nombre");
        person.Name = Console.ReadLine();
        Console.WriteLine("Ingrese Email");
        person.EmailAddress = Console.ReadLine();
        person.DateRegistered = DateTime.UtcNow;
        Console.WriteLine("Ingrese Nombre");
        person.Name = Console.ReadLine();

        dicc.AddItem(person.Id  ??"0", person);
        dicc.ViewData(0);
        dicc.ViewData(1);
        dicc.ViewData(2);



    }
}