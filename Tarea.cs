// See https://aka.ms/new-console-template for more information
public class Tarea{
    public Tarea(int id, string explicacion, int tiempo)
    {
        tareaId = id;
        descripcion= explicacion;
        duracion= tiempo;
    }

    public int TareaId { get => tareaId; set => tareaId = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }

    private int tareaId;
    private string descripcion;
    private int duracion;
    public bool buscarTarea(string busqueda){
        return descripcion.Contains(busqueda);
    }
}
