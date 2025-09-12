namespace Directorio_MVC.Models
{
    public class Persona
    {
        private string NumeroID { get; set; }
        private string Nombres { get; set; }
        private string Apellidos { get; set; }
        private DateTime FechaNacimiento { get; set; }
        private string Telefono { get; set; }
        private string Celular { get; set; }
        private string Pais { get; set; }
        private string Ciudad { get; set; }
        private string Direccion { get; set; }
        private string Profesion { get; set; }

        private List<Grado> HistorialAcademico { get; set; }
        private List<Cargo> HistorialLaboral { get; set; }

        public Persona()
        {

            this.HistorialAcademico = new List<Grado>();
            this.HistorialLaboral = new List<Cargo>();
        }


        public Persona(string numeroID, string nombres, string apellidos, DateTime fechaNacimiento, string telefono, string celular, string pais, string ciudad, string direccion, string profesion)
        {
            this.NumeroID = numeroID;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fechaNacimiento;
            this.Telefono = telefono;
            this.Celular = celular;
            this.Pais = pais;
            this.Ciudad = ciudad;
            this.Direccion = direccion;
            this.Profesion = profesion;

            this.HistorialAcademico = new List<Grado>();
            this.HistorialLaboral = new List<Cargo>();

        }

        public void AgregarGrado(Grado nuevoGrado)
        {
            this.HistorialAcademico.Add(nuevoGrado);
        }

        public void AgregarCargo(Cargo nuevoCargo)
        {
            this.HistorialLaboral.Add(nuevoCargo);
        }

        public void ImprimirFichas()
        {
            Console.WriteLine("*****FICHA DE EMPLEO*****");
            Console.WriteLine("Nombre Completo: " + this.Nombres + this.Apellidos);
            Console.WriteLine("Identidad: " + this.NumeroID);
            Console.WriteLine("Profesion: " + this.Profesion);
            Console.WriteLine("Contacto: " + this.Celular);

            Console.WriteLine("                              ");
            Console.WriteLine("*****HISTORIAL ACADEMICO***** ");
            foreach (var grado in this.HistorialAcademico)
            {
                grado.Imprimir();
            }


            Console.WriteLine("                              ");
            Console.WriteLine("*****HISTORIAl LABORAL***** ");
            foreach (var cargo in this.HistorialLaboral)
            {
                cargo.Imprimir();
            }
}
