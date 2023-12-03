
namespace Person.Clase_principal.clases_hijas
{
    public class Estudiante : MiembroComunidad
    {
        public override void Actualizar()
        {
            System.Console.WriteLine(" Actualizar miembro de la comunidad");
        }

        public override void Remover()
        {
            System.Console.WriteLine(" Guardad miembro de la comunidad");
        }

        public override void Guardar()
        {
            System.Console.WriteLine(" Remover miembro de la comunidad");
        }
    }
}
