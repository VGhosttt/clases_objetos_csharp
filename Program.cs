//
public class  Estudiante
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
public void Information()
    {
    Console.WriteLine($"Bienvenido: {Nombre} {Apellido}");
    }
}
//clase prinsis
public class Program
{
    public static void Main()
    {
        Estudiante estudiante1 = new Estudiante();

        estudiante1.Nombre = "vicente";
        estudiante1.Apellido = "hinojosa";
        estudiante1.Information();

        Estudiante estudiante2 = new Estudiante();

        estudiante2.Nombre = "pablo";
        estudiante2.Apellido = "mendez";
        estudiante2.Information();
    }
}