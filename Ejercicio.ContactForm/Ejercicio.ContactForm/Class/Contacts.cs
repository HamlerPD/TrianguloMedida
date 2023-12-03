

namespace Ejercicio.ContactForm.Class
{

    /// <summary>
    /// Clase para manejar los datos de los contactos.
    /// </summary>
    public class Contacts
    {

        #region"Atributos o Campos de nuestra clase"
        private string _nombres;
        private string _apellidos;
        private string _email;
        private string _puesto;
        private DateTime _fechaNacimiento;
        private string _telefono;
        private string _paginaWeb;
        private string _notas;
        #endregion

        #region"Propiedades"

        public string Nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }

        public string Apellido
        {
            get { return _apellidos}
            set { _apellidos = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Puesto
        {
            get { return _puesto; }
            set { _puesto = value; }

        }





        #endregion

      

        #region"Metodos"
        #endregion


    }
}
