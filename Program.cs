// See https://aka.ms/new-console-template for more information
List<Tarea> pendientes = new List<Tarea>();
// List<Tarea> realizadas = new List<Tarea>();

Console.WriteLine("ingrese la cantidad de tareas que cargara");
int cantPendientes= Convert.ToInt32(Console.ReadLine());
int duracion;
Random tiempo= new Random ();
string descripcion;
for (int i = 0; i < cantPendientes; i++)
{
    Console.WriteLine("Ingrese la descripcion de la tarea");
    descripcion= Console.ReadLine();
    duracion= tiempo.Next (10,101);
    Tarea creador=  new Tarea(i+1, descripcion, duracion);
    pendientes.Add(creador);
}
