
namespace Ejercicio1.ContactForms.Class
{
    /// <summary>
    /// Clase para manejar los datos de los contactos.
    /// </summary>
    public class Contacts
    {

        #region "Atributos o Campos de nuestra clase"
        private string _PrimerNombre;
        private string _SegundoNombre;
        private string _Apellidos;
        private string _Email;
        private DateTime _FechaNacimiento;
        private string _Telefono;
        private string _Puesto;
        private string _PaginaWeb;
        private string _Notas;
        private string _Pais;

        public Contacts(string codigo)
        {
            Codigo = codigo;
        }
        #endregion


        #region "Propiedades"


        /// <summary>
        /// Nombres del contacto
        /// </summary>
        public string PrimerNombre
        {
            get { return _PrimerNombre; }
            set { _PrimerNombre = value;}
        }

        public string SegundoNombre
        {
            get { return _SegundoNombre; }
            set { _PrimerNombre = value; }
        }

        /// <summary>
        /// Codigo de contactos.
        /// </summary>
        public string Codigo { get; set; }

        /// <summary>
        /// Esta propiedad es para almacenar el apellido del contacto.
        /// </summary>
        public string Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }

        /// <summary>
        /// Esta propiedad es para almacenar el correo electonico del contacto.
        /// </summary>
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        /// <summary>
        /// Esta propiedad es para almacenar el telefono del contacto.
        /// </summary>
        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        /// <summary>
        /// Esta propiedad es para almacenar la fecha de nacimiento del contacto
        /// </summary>
        public DateTime FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }

        /// <summary>
        /// Esta propiedad es para almacenar el puesto del contacto.
        /// </summary>
        public string Puesto
        {
            get { return _Puesto; }
            set { _Puesto = value; }
        }

        /// <summary>
        /// Esta propiedad es para almacenar la pagina web del contacto.
        /// </summary>
        public string PaginaWeb
        {
            get { return _PaginaWeb; }
            set { _PaginaWeb = value; }
        }

        /// <summary>
        /// Esta propiedad es para alamcenar las notas del contacto.
        /// </summary>
        public string Notas
        {
            get { return _Notas; }
            set { _Notas = value; }
        }

        /// <summary>
        /// Pais al que pertenece el contacto.
        /// </summary>
        public string? Pais { get; set; }

        public string NombreCompleto => string.Concat(this.PrimerNombre, " ", this.SegundoNombre);



        #endregion

    }

}
