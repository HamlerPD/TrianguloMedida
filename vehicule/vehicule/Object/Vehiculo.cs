
namespace vehicule.Object
{
    public abstract class Vehiculo
    {
        public string? Marca { get; set; }

        public string? Modelo { get; set; }

        public string? Año { get; set; }

        public string? Color { get; set; }

        public string? CantidadPuertas { get; set; }


        public abstract void Endender();
        public abstract void Apagar();
    }

}
