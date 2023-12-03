
namespace Person.Clase_principal
{
    public abstract class Persona
    {
        public string? Nombre { get; set; }

        public string? Apellidos { get; set; }

        public string? Telefono { get; set; }

        public string? Direccion { get; set; }

        public string? CorreoElectonico { get; set; }

        public abstract void Guardar();
        public abstract void Actualizar();
        public abstract void Remover();
    }
}
